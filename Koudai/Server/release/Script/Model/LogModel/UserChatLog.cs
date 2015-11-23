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
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.None,DbConfig.Log, "UserChatLog")]
    public class UserChatLog : BaseEntity
    {
        #region auto-generated static method
        static UserChatLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserChatLog));
        }
        #endregion

        public UserChatLog()
            : base(AccessLevel.WriteOnly)
        {
        }

        #region auto-generated Property
        private String _ChatID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ChatID", IsKey = true)]
        public String ChatID
        {
            private get
            {
                return _ChatID;
            }
            set
            {
                SetChange("ChatID", value);
            }
        }
        private String _FromUserID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("FromUserID")]
        public String FromUserID
        {
            private get
            {
                return _FromUserID;
            }
            set
            {
                SetChange("FromUserID", value);
            }
        }
        private String _FromUserName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("FromUserName")]
        public String FromUserName
        {
            private get
            {
                return _FromUserName;
            }
            set
            {
                SetChange("FromUserName", value);
            }
        }
        private String _ToUserID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ToUserID")]
        public String ToUserID
        {
            private get
            {
                return _ToUserID;
            }
            set
            {
                SetChange("ToUserID", value);
            }
        }
        private String _ToUserName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ToUserName")]
        public String ToUserName
        {
            private get
            {
                return _ToUserName;
            }
            set
            {
                SetChange("ToUserName", value);
            }
        }
        private String _Content;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Content")]
        public String Content
        {
            private get
            {
                return _Content;
            }
            set
            {
                SetChange("Content", value);
            }
        }
        private ChatType _ChatType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ChatType")]
        public ChatType ChatType
        {
            private get
            {
                return _ChatType;
            }
            set
            {
                SetChange("ChatType", value);
            }
        }
        private DateTime _SendDate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SendDate")]
        public DateTime SendDate
        {
            private get
            {
                return _SendDate;
            }
            set
            {
                SetChange("SendDate", value);
            }
        }
        private String _GuildID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GuildID")]
        public String GuildID
        {
            private get
            {
                return _GuildID;
            }
            set
            {
                SetChange("GuildID", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ChatID": return ChatID;
                    case "FromUserID": return FromUserID;
                    case "FromUserName": return FromUserName;
                    case "ToUserID": return ToUserID;
                    case "ToUserName": return ToUserName;
                    case "Content": return Content;
                    case "ChatType": return ChatType;
                    case "SendDate": return SendDate;
                    case "GuildID": return GuildID;
                    default: throw new ArgumentException(string.Format("UserChatLog index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ChatID":
                        _ChatID = value.ToNotNullString();
                        break;
                    case "FromUserID":
                        _FromUserID = value.ToNotNullString();
                        break;
                    case "FromUserName":
                        _FromUserName = value.ToNotNullString();
                        break;
                    case "ToUserID":
                        _ToUserID = value.ToNotNullString();
                        break;
                    case "ToUserName":
                        _ToUserName = value.ToNotNullString();
                        break;
                    case "Content":
                        _Content = value.ToNotNullString();
                        break;
                    case "ChatType":
                        _ChatType = value.ToEnum<ChatType>();
                        break;
                    case "SendDate":
                        _SendDate = value.ToDateTime();
                        break;
                    case "GuildID":
                        _GuildID = value.ToNotNullString();
                        break;
                    default: throw new ArgumentException(string.Format("UserChatLog index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //allow modify return value
            return FromUserID.ToInt();
        }
    }
}