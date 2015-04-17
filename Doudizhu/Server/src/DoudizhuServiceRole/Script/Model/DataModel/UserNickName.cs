using System;
using ProtoBuf;
using ZyGames.Framework.Model;

namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 玩家昵称缓存
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Entity, DbConfig.Data, StorageType = StorageType.ReadWriteRedis, IsExpired = false)]
    public class UserNickName : ShareEntity
    {
        public UserNickName()
            : base(false)
        {
        }

        public UserNickName(int userId)
            : this()
        {
            UserId = userId;
        }

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField(true)]
        public int UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField]
        public string NickName { get; set; }

    }
}
