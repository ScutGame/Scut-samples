﻿using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Model;


namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.WriteOnly, DbConfig.Log)]
    public class UserLoginLog : LogEntity
    {
        /// <summary>
        /// </summary>
        public UserLoginLog()
        {
            
        }        
        /// <summary>
        /// </summary>
        public UserLoginLog(int iD)
            : this()
        {
            ID = iD;
        }

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField(true, IsIdentity = true)]
        public int ID{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField]
        public string SessionID{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField]
        public short MobileType{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField]
        public short ScreenX{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField]
        public short ScreenY{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField]
        public string RetailId{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField]
        public string Model{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField]
        public short NetWork{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField]
        public string UserId{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField]
        public DateTime AddTime{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
        [EntityField]
        public int State{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(12)]
        [EntityField]
        public string DeviceID{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(13)]
        [EntityField]
        public string Ip{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(14)]
        [EntityField]
        public string Pid{ get; set; }
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(15)]
        [EntityField]
        public short UserLv { get; set; }
        

	}
}