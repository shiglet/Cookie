﻿using Cookie.API.Utils.IO;

namespace Cookie.API.Protocol.Network.Messages.Game.Context
{
    public class GameContextCreateRequestMessage : NetworkMessage
    {
        public const uint ProtocolId = 250;

        public override uint MessageID => ProtocolId;

        public override void Serialize(IDataWriter writer)
        {
            //
        }

        public override void Deserialize(IDataReader reader)
        {
            //
        }
    }
}