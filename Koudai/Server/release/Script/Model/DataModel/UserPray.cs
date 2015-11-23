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
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ProtoBuf;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 玩家祈祷表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserPray : BaseEntity
    {


        public UserPray()
            : base(AccessLevel.ReadWrite)
        {
        }

        public UserPray(Int32 UserID)
            : this()
        {
            this.UserID = UserID;
        }

        #region 自动生成属性

        private Int32 _UserID;
        /// <summary>
        /// 玩家ID
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public Int32 UserID
        {
            get
            {
                return _UserID;
            }
            private set
            {
                SetChange("UserID", value);
            }
        }

        private DateTime _PrayDate;
        /// <summary>
        /// 祈祷时间
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("PrayDate")]
        public DateTime PrayDate
        {
            get
            {
                return _PrayDate;
            }
            set
            {
                SetChange("PrayDate", value);
            }
        }

        private PrayType _PrayType;
        /// <summary>
        /// 祈祷类型
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("PrayType")]
        public PrayType PrayType
        {
            get
            {
                return _PrayType;
            }
            set
            {
                SetChange("PrayType", value);
            }
        }

        private Int32 _PrayNum;
        /// <summary>
        /// 祈祷次数
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("PrayNum")]
        public Int32 PrayNum
        {
            get
            {
                return _PrayNum;
            }
            set
            {
                SetChange("PrayNum", value);
            }
        }
        private Boolean _IsPray;
        /// <summary>
        /// 当天是否祈祷完成
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("IsPray")]
        public Boolean IsPray
        {
            get
            {
                return _IsPray;
            }
            set
            {
                SetChange("IsPray", value);
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
                    case "PrayDate": return PrayDate;
                    case "PrayType": return PrayType;
                    case "PrayNum": return PrayNum;
                    case "IsPray": return IsPray;
                    default: throw new ArgumentException(string.Format("UserPray index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "UserID":
                        _UserID = value.ToInt();
                        break;
                    case "PrayDate":
                        _PrayDate = value.ToDateTime();
                        break;
                    case "PrayType":
                        _PrayType = value.ToEnum<PrayType>();
                        break;
                    case "PrayNum":
                        _PrayNum = value.ToInt();
                        break;
                    case "IsPray":
                        _IsPray = value.ToBool();
                        break;
                    default: throw new ArgumentException(string.Format("UserPray index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion
        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID;
        }
    }
}