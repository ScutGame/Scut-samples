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
    public class UserCrystalPackage : BaseEntity
    {

        public static UserCrystalPackage Get(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException("UserID为空");
            }
            var cacheSet = new PersonalCacheStruct<UserCrystalPackage>();
            var data = cacheSet.FindKey(userId);
            if (data != null)
            {
                return data;
            }
            BaseLog log = new BaseLog();
            log.SaveLog(new NullReferenceException(string.Format("User:{0} crystal package is null.", userId)));
            return null;
        }


        public UserCrystalPackage()
            : base(AccessLevel.ReadWrite)
        {
            CrystalPackage = new CacheList<UserCrystalInfo>();
        }
        //protected override void BindChangeEvent()
        //{
        //    CrystalPackage.BindParentChangeEvent(this);
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
        private CacheList<UserCrystalInfo> _CrystalPackage;
        /// <summary>
        /// 
        /// </summary>

        [ProtoMember(2)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<UserCrystalInfo> CrystalPackage
        {
            get
            {
                return _CrystalPackage;
            }
            set
            {
                SetChange("CrystalPackage", value);
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
                    case "CrystalPackage": return CrystalPackage;
                    default: throw new ArgumentException(string.Format("UserCrystalPackage index[{0}] isn't exist.", index));
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
                    case "CrystalPackage":
                        _CrystalPackage = ConvertCustomField<CacheList<UserCrystalInfo>>(value, index);
                        break;
                    default: throw new ArgumentException(string.Format("UserCrystalPackage index[{0}] isn't exist.", index));
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

        public void SaveCrystal(UserCrystalInfo crystal)
        {
            var tempItem = CrystalPackage.Find(m => m.UserCrystalID.Equals(crystal.UserCrystalID));
            if (tempItem == null)
            {
                CrystalPackage.Add(crystal);
            }
            else
            {
                tempItem.UpdateNotify(m =>
                {
                    UserCrystalInfo obj = m as UserCrystalInfo;
                    if (obj == null)
                    {
                        return false;
                    }
                    obj.UserCrystalID = crystal.UserCrystalID;
                    obj.GeneralID = crystal.GeneralID;
                    obj.CrystalID = crystal.CrystalID;
                    obj.CrystalLv = crystal.CrystalLv;
                    obj.Position = crystal.Position;
                    obj.CurrExprience = crystal.CurrExprience;
                    obj.CreateDate = crystal.CreateDate;
                    return true;
                });
            }
        }

        public void RemoveCrystal(UserCrystalInfo crystalInfo)
        {
            if (crystalInfo != null)
            {
                CrystalPackage.Remove(crystalInfo);
                TraceLog.Write(string.Format("UserId:{0} remove Crystal:'{1}' {2},lv:{3}",
                    UserID,
                    crystalInfo.UserCrystalID,
                    crystalInfo.CrystalID,
                    crystalInfo.CrystalLv));
            }
        }
    }
}