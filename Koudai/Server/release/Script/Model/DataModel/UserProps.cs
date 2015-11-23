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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Model;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// ��������̵�ˢ�±�
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]

    public class UserProps : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;

        public UserProps()
            : base(AccessLevel.ReadWrite)
        {
        }

        public UserProps(string userID, int itemID)
            : this()
        {
            this.UserID = userID;
            this.ItemID = itemID;
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
            private set
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
            private set
            {
                SetChange("ItemID", value);
            }
        }
        private Int32 _SurplusNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("SurplusNum")]
        public Int32 SurplusNum
        {
            get
            {
                return _SurplusNum;
            }
            set
            {
                SetChange("SurplusNum", value);
            }
        }
        private DateTime _ChangeTime;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("ChangeTime")]
        public DateTime ChangeTime
        {
            get
            {
                return _ChangeTime;
            }
            set
            {
                SetChange("ChangeTime", value);
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
                    case "SurplusNum": return SurplusNum;
                    case "ChangeTime": return ChangeTime;
                    default: throw new ArgumentException(string.Format("UserProps index[{0}] isn't exist.", index));
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
                    case "SurplusNum":
                        _SurplusNum = value.ToInt();
                        break;
                    case "ChangeTime":
                        _ChangeTime = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserProps index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public short PropType
        {
            get
            {
                var cache = new ShareCacheStruct<ItemBaseInfo>();
                if (cache.FindKey(ItemID) != null)
                {
                    return cache.FindKey(ItemID).PropType;
                }
                return 0;
            }
        }
        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID.ToInt();
        }
        /// <summary>
        /// ˢ����ȴʱ��
        /// </summary>
        /// <returns>����ʣ����ȴʱ��</returns>
        public int DoRefresh()
        {
            int coldTime = 0;
            var cache = new ShareCacheStruct<ItemBaseInfo>();
            ItemBaseInfo itemInfo = cache.FindKey(ItemID);
            if (itemInfo != null && (itemInfo.PropType == 3 || itemInfo.PropType == 9))
            {
                TimeSpan ts = DateTime.Now - ChangeTime;

                coldTime = MathUtils.Subtraction(itemInfo.EffectNum, (int)Math.Floor(ts.TotalSeconds), 0);
                coldTime = MathUtils.Addition(coldTime, 0, itemInfo.EffectNum);
            }
            return coldTime;
        }
    }
}