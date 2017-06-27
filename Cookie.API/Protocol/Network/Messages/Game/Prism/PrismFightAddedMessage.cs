//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Prism
{
    using Cookie.API.Protocol.Network.Types.Game.Prism;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class PrismFightAddedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6452;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PrismFightersInformation m_fight;
        
        public virtual PrismFightersInformation Fight
        {
            get
            {
                return m_fight;
            }
            set
            {
                m_fight = value;
            }
        }
        
        public PrismFightAddedMessage(PrismFightersInformation fight)
        {
            m_fight = fight;
        }
        
        public PrismFightAddedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_fight.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_fight = new PrismFightersInformation();
            m_fight.Deserialize(reader);
        }
    }
}