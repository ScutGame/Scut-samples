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
    /// ���ɨ����
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data, OrderColumn = "UserID,TurnsNum,BattleNum")]

    public class UserSweepPool : BaseEntity
    {

        public const string Index_UserID = "UserID";

        public UserSweepPool()
            : base(AccessLevel.ReadWrite)
        {
            PrizeItems = new CacheList<PrizeItemInfo>();
        }
        //protected override void BindChangeEvent()
        //{
        //    PrizeItems.BindParentChangeEvent(this);
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
        private Int32 _TurnsNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("TurnsNum", IsKey = true)]
        public Int32 TurnsNum
        {
            get
            {
                return _TurnsNum;
            }
            set
            {
                SetChange("TurnsNum", value);
            }
        }
        private Int32 _BattleNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("BattleNum", IsKey = true)]
        public Int32 BattleNum
        {
            get
            {
                return _BattleNum;
            }
            set
            {
                SetChange("BattleNum", value);
            }
        }
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("PlotID")]
        public Int32 PlotID
        {
            get
            {
                return _PlotID;
            }
            set
            {
                SetChange("PlotID", value);
            }
        }
        private Boolean _IsSend;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("IsSend")]
        public Boolean IsSend
        {
            get
            {
                return _IsSend;
            }
            set
            {
                SetChange("IsSend", value);
            }
        }
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("Experience")]
        public Int32 Experience
        {
            get
            {
                return _Experience;
            }
            set
            {
                SetChange("Experience", value);
            }
        }
        private Int32 _GameCoin;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("GameCoin")]
        public Int32 GameCoin
        {
            get
            {
                return _GameCoin;
            }
            set
            {
                SetChange("GameCoin", value);
            }
        }
        private Int32 _Gold;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("Gold")]
        public Int32 Gold
        {
            get
            {
                return _Gold;
            }
            set
            {
                SetChange("Gold", value);
            }
        }
        private Int32 _ExpNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("ExpNum")]
        public Int32 ExpNum
        {
            get
            {
                return _ExpNum;
            }
            set
            {
                SetChange("ExpNum", value);
            }
        }
        private CacheList<PrizeItemInfo> _PrizeItems;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeItemInfo> PrizeItems
        {
            get
            {
                return _PrizeItems;
            }
            set
            {
                SetChange("PrizeItems", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                SetChange("CreateDate", value);
            }
        }
        private Int32 _BlessExperience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField("BlessExperience")]
        public Int32 BlessExperience
        {
            get
            {
                return _BlessExperience;
            }
            set
            {
                SetChange("BlessExperience", value);
            }
        }
        private Int32 _BlessPennyNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        [EntityField("BlessPennyNum")]
        public Int32 BlessPennyNum
        {
            get
            {
                return _BlessPennyNum;
            }
            set
            {
                SetChange("BlessPennyNum", value);
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
                    case "TurnsNum": return TurnsNum;
                    case "BattleNum": return BattleNum;
                    case "PlotID": return PlotID;
                    case "IsSend": return IsSend;
                    case "Experience": return Experience;
                    case "GameCoin": return GameCoin;
                    case "Gold": return Gold;
                    case "ExpNum": return ExpNum;
                    case "PrizeItems": return PrizeItems;
                    case "CreateDate": return CreateDate;
                    case "BlessExperience": return BlessExperience;
                    case "BlessPennyNum": return BlessPennyNum;
                    default: throw new ArgumentException(string.Format("UserSweepPool index[{0}] isn't exist.", index));
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
                    case "TurnsNum":
                        _TurnsNum = value.ToInt();
                        break;
                    case "BattleNum":
                        _BattleNum = value.ToInt();
                        break;
                    case "PlotID":
                        _PlotID = value.ToInt();
                        break;
                    case "IsSend":
                        _IsSend = value.ToBool();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    case "GameCoin":
                        _GameCoin = value.ToInt();
                        break;
                    case "Gold":
                        _Gold = value.ToInt();
                        break;
                    case "ExpNum":
                        _ExpNum = value.ToInt();
                        break;
                    case "PrizeItems":
                        _PrizeItems =ConvertCustomField<CacheList<PrizeItemInfo>>(value, index); 
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    case "BlessExperience":
                        _BlessExperience = value.ToInt();
                        break;
                    case "BlessPennyNum":
                        _BlessPennyNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserSweepPool index[{0}] isn't exist.", index));
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

        public override int CompareTo(BaseEntity item)
        {
            UserSweepPool other = item as UserSweepPool;
            int result = 0;
            if (this == null && other == null) return 0;
            else if (this != null && other == null) return 1;
            else if (this == null && other != null) return -1;

            result = this.UserID.CompareTo(other.UserID);
            if (result == 0)
            {
                if (this.TurnsNum < other.TurnsNum)
                {
                    return -1;
                }
                else if (this.TurnsNum > other.TurnsNum)
                {
                    return 1;
                }
                else
                {
                    if (this.BattleNum < other.BattleNum)
                    {
                        return -1;
                    }
                    else if (this.BattleNum > other.BattleNum)
                    {
                        return 1;
                    }
                }
            }
            return result;
        }

    }
}