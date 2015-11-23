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
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.WriteOnly, DbConfig.Log, "UserCombatLog")]
    public class UserCombatLog : BaseEntity
    {
        #region auto-generated static method
        static UserCombatLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserCombatLog));
        }
        #endregion

        public UserCombatLog()
            : base(AccessLevel.WriteOnly)
        {
        }

        #region auto-generated Property
        private String _CombatLogID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CombatLogID", IsKey = true)]
        public String CombatLogID
        {
            private get
            {
                return _CombatLogID;
            }
            set
            {
                SetChange("CombatLogID", value);
            }
        }
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UserID")]
        public String UserID
        {
            private get
            {
                return _UserID;
            }
            set
            {
                SetChange("UserID", value);
            }
        }
        private CombatType _CombatType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CombatType")]
        public CombatType CombatType
        {
            private get
            {
                return _CombatType;
            }
            set
            {
                SetChange("CombatType", value);
            }
        }
        private Int32 _CityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CityID")]
        public Int32 CityID
        {
            private get
            {
                return _CityID;
            }
            set
            {
                SetChange("CityID", value);
            }
        }
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotID")]
        public Int32 PlotID
        {
            private get
            {
                return _PlotID;
            }
            set
            {
                SetChange("PlotID", value);
            }
        }
        private Int32 _NpcID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("NpcID")]
        public Int32 NpcID
        {
            private get
            {
                return _NpcID;
            }
            set
            {
                SetChange("NpcID", value);
            }
        }
        private String _HostileUser;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HostileUser")]
        public String HostileUser
        {
            private get
            {
                return _HostileUser;
            }
            set
            {
                SetChange("HostileUser", value);
            }
        }
        private String _CombatProcess;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CombatProcess",DbType = ColumnDbType.Text)]
        public String CombatProcess
        {
            private get
            {
                return _CombatProcess;
            }
            set
            {
                SetChange("CombatProcess", value);
            }
        }
        private CacheList<PrizeItemInfo> _PrizeItem;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeItemInfo> PrizeItem
        {
            private get
            {
                return _PrizeItem;
            }
            set
            {
                SetChange("PrizeItem", value);
            }
        }
        private Boolean _IsWin;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsWin")]
        public Boolean IsWin
        {
            private get
            {
                return _IsWin;
            }
            set
            {
                SetChange("IsWin", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            private get
            {
                return _CreateDate;
            }
            set
            {
                SetChange("CreateDate", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "CombatLogID": return CombatLogID;
                    case "UserID": return UserID;
                    case "CombatType": return CombatType;
                    case "CityID": return CityID;
                    case "PlotID": return PlotID;
                    case "NpcID": return NpcID;
                    case "HostileUser": return HostileUser;
                    case "CombatProcess": return CombatProcess;
                    case "PrizeItem": return PrizeItem;
                    case "IsWin": return IsWin;
                    case "CreateDate": return CreateDate;
                    default: throw new ArgumentException(string.Format("UserCombatLog index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "CombatLogID":
                        _CombatLogID = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "CombatType":
                        _CombatType = value.ToEnum<CombatType>();
                        break;
                    case "CityID":
                        _CityID = value.ToInt();
                        break;
                    case "PlotID":
                        _PlotID = value.ToInt();
                        break;
                    case "NpcID":
                        _NpcID = value.ToInt();
                        break;
                    case "HostileUser":
                        _HostileUser = value.ToNotNullString();
                        break;
                    case "CombatProcess":
                        _CombatProcess = value.ToNotNullString();
                        break;
                    case "PrizeItem":
                        _PrizeItem =ConvertCustomField<CacheList<PrizeItemInfo>>(value, index); 
                        break;
                    case "IsWin":
                        _IsWin = value.ToBool();
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserCombatLog index[{0}] isn't exist.", index));
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