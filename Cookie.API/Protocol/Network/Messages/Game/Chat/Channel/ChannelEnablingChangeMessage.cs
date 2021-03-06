//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Chat.Channel
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ChannelEnablingChangeMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 891;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_channel;
        
        public virtual byte Channel
        {
            get
            {
                return m_channel;
            }
            set
            {
                m_channel = value;
            }
        }
        
        private bool m_enable;
        
        public virtual bool Enable
        {
            get
            {
                return m_enable;
            }
            set
            {
                m_enable = value;
            }
        }
        
        public ChannelEnablingChangeMessage(byte channel, bool enable)
        {
            m_channel = channel;
            m_enable = enable;
        }
        
        public ChannelEnablingChangeMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_channel);
            writer.WriteBoolean(m_enable);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_channel = reader.ReadByte();
            m_enable = reader.ReadBoolean();
        }
    }
}
