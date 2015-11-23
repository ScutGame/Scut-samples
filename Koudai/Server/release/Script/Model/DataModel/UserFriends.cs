﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// ��Һ��ѱ�
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data, OrderColumn = "ChatTime desc")]
    public class UserFriends : ShareEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_UserID_FriendType = "Index_UserID_FriendType";

        public UserFriends()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public String UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                SetChange("UserID", value);
            }
        }
        private String _FriendID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("FriendID", IsKey = true)]
        public String FriendID
        {
            get
            {
                return _FriendID;
            }
            set
            {
                SetChange("FriendID", value);
            }
        }
        private FriendType _FriendType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("FriendType")]
        public FriendType FriendType
        {
            get
            {
                return _FriendType;
            }
            set
            {
                SetChange("FriendType", value);
            }
        }
        private DateTime _ChatTime;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("ChatTime")]
        public DateTime ChatTime
        {
            get
            {
                return _ChatTime;
            }
            set
            {
                SetChange("ChatTime", value);
            }
        }

        private DateTime _FightTime;
        /// <summary>
        /// �����������ҵ�ʱ��
        /// </summary>
        [ProtoMember(5)]
        [EntityField("FightTime")]
        public DateTime FightTime
        {
            get
            {
                return _FightTime;
            }
            set
            {
                SetChange("FightTime", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "UserID": return UserID;
                    case "FriendID": return FriendID;
                    case "FriendType": return FriendType;
                    case "ChatTime": return ChatTime;
                    case "FightTime": return FightTime;
                    default: throw new ArgumentException(string.Format("UserFriends index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "FriendID":
                        _FriendID = value.ToNotNullString();
                        break;
                    case "FriendType":
                        _FriendType = value.ToEnum<FriendType>();
                        break;
                    case "ChatTime":
                        _ChatTime = value.ToDateTime();
                        break;
                    case "FightTime":
                        _FightTime = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserFriends index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //allow modify return value
            return DefIdentityId;
        }

    }
}