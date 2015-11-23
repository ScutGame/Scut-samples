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
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserItemPackage : BaseEntity
    {

        public static UserItemPackage Get(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException("UserIDΪ��");
            }
            var cacheSet = new PersonalCacheStruct<UserItemPackage>();
            var data = cacheSet.FindKey(userId);
            if (data != null)
            {
                return data;
            }
            BaseLog log = new BaseLog();
            log.SaveLog(new NullReferenceException(string.Format("User:{0} item package is null.", userId)));
            return null;
        }

        public UserItemPackage()
            : base(AccessLevel.ReadWrite)
        {
            ItemPackage = new CacheList<UserItemInfo>();
        }

        //protected override void BindChangeEvent()
        //{
        //    ItemPackage.BindParentChangeEvent(this);
        //}

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
        private CacheList<UserItemInfo> _ItemPackage;
        /// <summary>
        /// 
        /// </summary>

        [ProtoMember(2)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<UserItemInfo> ItemPackage
        {
            get
            {
                return _ItemPackage;
            }
            set
            {
                SetChange("ItemPackage", value);
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
                    case "ItemPackage": return ItemPackage;
                    default: throw new ArgumentException(string.Format("UserItemPackage index[{0}] isn't exist.", index));
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
                    case "ItemPackage":
                        _ItemPackage =ConvertCustomField<CacheList<UserItemInfo>>(value, index); 
                        break;
                    default: throw new ArgumentException(string.Format("UserItemPackage index[{0}] isn't exist.", index));
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

        public void SaveItem(UserItemInfo item)
        {
            if (item == null || string.IsNullOrEmpty(item.UserItemID)) return;
            var tempItem = ItemPackage.Find(m => !string.IsNullOrEmpty(item.UserItemID) && string.Equals(m.UserItemID, item.UserItemID));
            if (tempItem == null)
            {
                ItemPackage.Add(item);
            }
            else
            {
                tempItem.UpdateNotify(obj =>
                {
                    tempItem.UserItemID = item.UserItemID;
                    tempItem.GeneralID = item.GeneralID;
                    tempItem.IsRemove = item.IsRemove;
                    tempItem.ItemID = item.ItemID;
                    tempItem.ItemLv = item.ItemLv;
                    tempItem.ItemStatus = item.ItemStatus;
                    tempItem.ItemType = item.ItemType;
                    tempItem.Num = item.Num;
                    tempItem.SoldDate = item.SoldDate;
                    return true;
                });
            }
        }

        public void RemoveItem(UserItemInfo userItem)
        {
            if (userItem != null)
            {
                userItem.IsRemove = true;
                ItemPackage.Remove(userItem);

                TraceLog.Write(string.Format("UserId:{0} remove item:'{1}' {2}*{3},state:{4},lv:{5}",
                    UserID,
                    userItem.UserItemID,
                    userItem.ItemID,
                    userItem.Num,
                    userItem.ItemStatus,
                    userItem.ItemLv));
            }
        }
    }
}