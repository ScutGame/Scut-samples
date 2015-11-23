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
    [Obsolete("", true)]
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserShops : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;

        public UserShops()
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
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("ItemID", IsKey = true)]
        public Int32 ItemID
        {
            get
            {
                return _ItemID;
            }
            set
            {
                SetChange("ItemID", value);
            }
        }
        private Int32 _ItemNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("ItemNum")]
        public Int32 ItemNum
        {
            get
            {
                return _ItemNum;
            }
            set
            {
                SetChange("ItemNum", value);
            }
        }
        private Int32 _BuyNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("BuyNum")]
        public Int32 BuyNum
        {
            get
            {
                return _BuyNum;
            }
            set
            {
                SetChange("BuyNum", value);
            }
        }
        private DateTime _NextDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("NextDate")]
        public DateTime NextDate
        {
            get
            {
                return _NextDate;
            }
            set
            {
                SetChange("NextDate", value);
            }
        }
        private DateTime _SparDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("SparDate")]
        public DateTime SparDate
        {
            get
            {
                return _SparDate;
            }
            set
            {
                SetChange("SparDate", value);
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
                    case "ItemID": return ItemID;
                    case "ItemNum": return ItemNum;
                    case "BuyNum": return BuyNum;
                    case "NextDate": return NextDate;
                    case "SparDate": return SparDate;
                    default: throw new ArgumentException(string.Format("UserShops index[{0}] isn't exist.", index));
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
                    case "ItemID":
                        _ItemID = value.ToInt();
                        break;
                    case "ItemNum":
                        _ItemNum = value.ToInt();
                        break;
                    case "BuyNum":
                        _BuyNum = value.ToInt();
                        break;
                    case "NextDate":
                        _NextDate = value.ToDateTime();
                        break;
                    case "SparDate":
                        _SparDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserShops index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID.ToInt();
        }
    }
}