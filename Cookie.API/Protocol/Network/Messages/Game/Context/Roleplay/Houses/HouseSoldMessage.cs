//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Houses
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class HouseSoldMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5737;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_houseId;
        
        public virtual uint HouseId
        {
            get
            {
                return m_houseId;
            }
            set
            {
                m_houseId = value;
            }
        }
        
        private uint m_realPrice;
        
        public virtual uint RealPrice
        {
            get
            {
                return m_realPrice;
            }
            set
            {
                m_realPrice = value;
            }
        }
        
        private string m_buyerName;
        
        public virtual string BuyerName
        {
            get
            {
                return m_buyerName;
            }
            set
            {
                m_buyerName = value;
            }
        }
        
        public HouseSoldMessage(uint houseId, uint realPrice, string buyerName)
        {
            m_houseId = houseId;
            m_realPrice = realPrice;
            m_buyerName = buyerName;
        }
        
        public HouseSoldMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_houseId);
            writer.WriteVarUhInt(m_realPrice);
            writer.WriteUTF(m_buyerName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_houseId = reader.ReadVarUhInt();
            m_realPrice = reader.ReadVarUhInt();
            m_buyerName = reader.ReadUTF();
        }
    }
}