//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Fight
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class FightExternalInformations : NetworkType
    {
        
        public const short ProtocolId = 117;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_fightId;
        
        public virtual int FightId
        {
            get
            {
                return m_fightId;
            }
            set
            {
                m_fightId = value;
            }
        }
        
        private byte m_fightType;
        
        public virtual byte FightType
        {
            get
            {
                return m_fightType;
            }
            set
            {
                m_fightType = value;
            }
        }
        
        private int m_fightStart;
        
        public virtual int FightStart
        {
            get
            {
                return m_fightStart;
            }
            set
            {
                m_fightStart = value;
            }
        }
        
        private bool m_fightSpectatorLocked;
        
        public virtual bool FightSpectatorLocked
        {
            get
            {
                return m_fightSpectatorLocked;
            }
            set
            {
                m_fightSpectatorLocked = value;
            }
        }
        
        public FightExternalInformations(int fightId, byte fightType, int fightStart, bool fightSpectatorLocked)
        {
            m_fightId = fightId;
            m_fightType = fightType;
            m_fightStart = fightStart;
            m_fightSpectatorLocked = fightSpectatorLocked;
        }
        
        public FightExternalInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_fightId);
            writer.WriteByte(m_fightType);
            writer.WriteInt(m_fightStart);
            writer.WriteBoolean(m_fightSpectatorLocked);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_fightId = reader.ReadInt();
            m_fightType = reader.ReadByte();
            m_fightStart = reader.ReadInt();
            m_fightSpectatorLocked = reader.ReadBoolean();
        }
    }
}