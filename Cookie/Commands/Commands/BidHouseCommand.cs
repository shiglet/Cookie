﻿using System;
using System.Linq;

using Cookie.API.Commands;
using Cookie.API.Core;
using Cookie.API.Utils;
using Cookie.Game.BidHouse;
using Cookie.API.Utils.Enums;

namespace Cookie.Commands.Commands
{
    public class BidHouseCommand : ICommand
    {
        public string CommandName => "hdv";
        public string CommandSufix => "[HDV]";

        public async void OnCommand(IAccount account, string[] args)
        {
            try
            {
                if (args.Length < 1)
                {
                    Logger.Default.Log("Vous devez spécifier l'id de l'item à chercher", LogMessageType.Error);
                }
                else if (args[0] == "list")
                {
                    account.Character.Inventory.Objects.ForEach(item => Logger.Default.Log($"{item.Quantity}x{API.Gamedata.D2OParsing.GetItemName(item.ObjectGID)} ({item.ObjectGID}, {item.ObjectUID})"));
                }
                else if (args[0] == "exit")
                {
                    account.Character.BidHouse.ExitBidHouseDialog();
                }
                else if (args[0] == "price")
                {
                    var itemid = Convert.ToUInt32(args[1]);

                    if (!await account.Character.BidHouse.StartBidHouseDialog(NpcActionId.BID_HOUSE_BUY)) return;
                    if (!await account.Character.BidHouse.LoadItemData(itemid)) return;

                    var prices = account.Character.BidHouse.ItemPricesList.FirstOrDefault();
                    Logger.Default.Log($" Prix de {API.Gamedata.D2OParsing.GetItemName(itemid)} => 1:{prices[0]}-  10:{prices[1]} - 100:{prices[2]} - Mean:{account.Character.BidHouse.MeanPrice}");
                }
                else if (args[0] == "sell")
                {
                    var itemid = Convert.ToUInt32(args[1]);

                    if (!await account.Character.BidHouse.StartBidHouseDialog(NpcActionId.BID_HOUSE_SELL)) return;

                    if(! await account.Character.BidHouse.SellItem(itemid, 10, 42)) return;

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Logger.Default.Log($"{CommandSufix} Error : {ex.Message}", LogMessageType.Error);
                Logger.Default.Log($"{CommandSufix} StackTrace : {ex.StackTrace}", LogMessageType.Error);
            }

        }
    }
}
