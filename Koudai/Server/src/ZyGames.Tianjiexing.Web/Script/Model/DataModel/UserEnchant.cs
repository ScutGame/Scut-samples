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
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Model;
using ProtoBuf;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 玩家附魔符表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserEnchant : BaseEntity
    {
        public static UserEnchant Get(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException("UserID为空");
            }
            var cacheSet = new PersonalCacheStruct<UserEnchant>();
            var data = cacheSet.FindKey(userId);
            if (data != null)
            {
                return data;
            }
            BaseLog log = new BaseLog();
            log.SaveLog(new NullReferenceException(string.Format("User:{0} Enchant package is null.", userId)));
            return null;
        }

        public UserEnchant()
            : base(AccessLevel.ReadWrite)
        {
            EnchantPackage = new CacheList<UserEnchantInfo>();
        }

        //protected override void BindChangeEvent()
        //{
        //    EnchantPackage.BindParentChangeEvent(this);
        //}

        public UserEnchant(String UserID)
            : this()
        {
            this.UserID = UserID;
        }

        #region 自动生成属性

        private String _UserID;
        /// <summary>
        /// 用户ID主键
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

        private CacheList<UserEnchantInfo> _EnchantPackage;
        /// <summary>
        /// 附魔符
        /// </summary>        
        [ProtoMember(2)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<UserEnchantInfo> EnchantPackage
        {
            get
            {
                return _EnchantPackage;
            }
            set
            {
                SetChange("EnchantPackage", value);
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
                    case "EnchantPackage": return EnchantPackage;
                    default: throw new ArgumentException(string.Format("UserEnchant index[{0}] isn't exist.", index));
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
                    case "EnchantPackage":
                        _EnchantPackage = ConvertCustomField<CacheList<UserEnchantInfo>>(value, index);
                        break;
                    default: throw new ArgumentException(string.Format("UserEnchant index[{0}] isn't exist.", index));
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

        public void SaveEnchant(UserEnchantInfo enchant)
        {
            if (enchant == null || string.IsNullOrEmpty(enchant.UserEnchantID)) return;
            var tempEnchant = EnchantPackage.Find(m => !string.IsNullOrEmpty(enchant.UserEnchantID) && string.Equals(m.UserEnchantID, enchant.UserEnchantID));
            if (tempEnchant == null)
            {
                EnchantPackage.Add(enchant);
            }
            else
            {
                tempEnchant.UpdateNotify(obj =>
                {
                    tempEnchant.UserEnchantID = enchant.UserEnchantID;
                    tempEnchant.EnchantID = enchant.EnchantID;
                    tempEnchant.EnchantLv = enchant.EnchantLv;
                    tempEnchant.CurrExprience = enchant.CurrExprience;
                    tempEnchant.MaxMature = enchant.MaxMature;
                    tempEnchant.Position = enchant.Position;
                    tempEnchant.UserItemID = enchant.UserItemID;
                    return true;
                });
            }
        }

        public void RemoveEnchant(UserEnchantInfo userEnchantInfo)
        {
            if (userEnchantInfo != null)
            {
                EnchantPackage.Remove(userEnchantInfo);

                TraceLog.Write(string.Format("UserId:{0} remove enchant:'{1}' {2},lv:{3}",
                    UserID,
                    userEnchantInfo.UserItemID,
                    userEnchantInfo.EnchantID,
                    userEnchantInfo.EnchantLv));
            }
        }
    }
}