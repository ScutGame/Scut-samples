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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data, OrderColumn = " PlotID desc")]

    public class UserPlot : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;

        public UserPlot()
            : base(AccessLevel.ReadWrite)
        {
            ItemList = new CacheList<UniversalInfo>();
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
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("PlotID", IsKey = true)]
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
        private PlotStatus _PlotStatus;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("PlotStatus")]
        public PlotStatus PlotStatus
        {
            get
            {
                return _PlotStatus;
            }
            set
            {
                SetChange("PlotStatus", value);
            }
        }
        private short _ScoreNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("ScoreNum")]
        public short ScoreNum
        {
            get
            {
                return _ScoreNum;
            }
            set
            {
                SetChange("ScoreNum", value);
            }
        }
        private short _AttackScore;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("AttackScore")]
        public short AttackScore
        {
            get
            {
                return _AttackScore;
            }
            set
            {
                SetChange("AttackScore", value);
            }
        }
        private short _DefenseScore;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("DefenseScore")]
        public short DefenseScore
        {
            get
            {
                return _DefenseScore;
            }
            set
            {
                SetChange("DefenseScore", value);
            }
        }
        private Int16 _StarScore;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("StarScore")]
        public Int16 StarScore
        {
            get
            {
                return _StarScore;
            }
            set
            {
                SetChange("StarScore", value);
            }
        }
        private Int32 _ExpNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
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
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
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
        private Int32 _PennyNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField("PennyNum")]
        public Int32 PennyNum
        {
            get
            {
                return _PennyNum;
            }
            set
            {
                SetChange("PennyNum", value);
            }
        }
        private Int32 _GoldNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField("GoldNum")]
        public Int32 GoldNum
        {
            get
            {
                return _GoldNum;
            }
            set
            {
                SetChange("GoldNum", value);
            }
        }
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField("ItemID")]
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
        private DateTime _CompleteDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        [EntityField("CompleteDate")]
        public DateTime CompleteDate
        {
            get
            {
                return _CompleteDate;
            }
            set
            {
                SetChange("CompleteDate", value);
            }
        }
        private DateTime _RefleshDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        [EntityField("RefleshDate")]
        public DateTime RefleshDate
        {
            get
            {
                return _RefleshDate;
            }
            set
            {
                SetChange("RefleshDate", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(15)]
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
        private Int32 _BlessPennyNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(16)]
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
        private Int32 _BlessExperience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(17)]
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

        private Int32 _EnchantID;

        /// <summary>
        /// ��ħ��id
        /// </summary>
        [ProtoMember(18)]
        [EntityField("EnchantID")]
        public Int32 EnchantID
        {
            get
            {
                return _EnchantID;
            }
            set
            {
                SetChange("EnchantID", value);
            }
        }

        private PlotSuccessType _PlotSuccessType;

        /// <summary>
        /// ����ʤ������
        /// </summary>
        [ProtoMember(19)]
        [EntityField("PlotSuccessType")]
        public PlotSuccessType PlotSuccessType
        {
            get
            {
                return _PlotSuccessType;
            }
            set
            {
                SetChange("PlotSuccessType", value);
            }
        }
        private PlotFailureType _PlotFailureType;
        /// <summary>
        /// ����ʧ������
        /// </summary>
        [ProtoMember(20)]
        [EntityField("PlotFailureType")]
        public PlotFailureType PlotFailureType
        {
            get
            {
                return _PlotFailureType;
            }
            set
            {
                SetChange("PlotFailureType", value);
            }
        }
        private Int32 _HonourNum;
        /// <summary>
        /// ����ֵ
        /// </summary>
        [ProtoMember(21)]
        [EntityField("HonourNum")]
        public Int32 HonourNum
        {
            get
            {
                return _HonourNum;
            }
            set
            {
                 BaseLog baseLog = new BaseLog("");
                baseLog.SaveDebugLog(string.Format("HonourNum{0}", value.ToString()));
                SetChange("HonourNum", value);
            }
        }
        private CacheList<UniversalInfo> _ItemList;
        /// <summary>
        /// ����ֵ
        /// </summary>
        [ProtoMember(22)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<UniversalInfo> ItemList
        {
            get
            {
                return _ItemList;
            }
            set
            {
                SetChange("ItemList", value);
            }
        }
        private Int32 _PlotNum;
        /// <summary>
        /// ��������
        /// </summary>
        [ProtoMember(23)]
        [EntityField("PlotNum")]
        public Int32 PlotNum
        {
            get
            {
                return _PlotNum;
            }
            set
            {
                SetChange("PlotNum", value);
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
                    case "PlotID": return PlotID;
                    case "PlotStatus": return PlotStatus;
                    case "ScoreNum": return ScoreNum;
                    case "AttackScore": return AttackScore;
                    case "DefenseScore": return DefenseScore;
                    case "StarScore": return StarScore;
                    case "ExpNum": return ExpNum;
                    case "Experience": return Experience;
                    case "PennyNum": return PennyNum;
                    case "GoldNum": return GoldNum;
                    case "ItemID": return ItemID;
                    case "CompleteDate": return CompleteDate;
                    case "RefleshDate": return RefleshDate;
                    case "CreateDate": return CreateDate;
                    case "BlessPennyNum": return BlessPennyNum;
                    case "BlessExperience": return BlessExperience;
                    case "EnchantID": return EnchantID;
                    case "PlotSuccessType": return EnchantID;
                    case "PlotFailureType": return EnchantID;
                    case "HonourNum": return HonourNum;
                    case "ItemList": return ItemList;
                    case "PlotNum": return PlotNum;
                    default: throw new ArgumentException(string.Format("UserPlot index[{0}] isn't exist.", index));
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
                    case "PlotID":
                        _PlotID = value.ToInt();
                        break;
                    case "PlotStatus":
                        _PlotStatus = value.ToEnum<PlotStatus>();
                        break;
                    case "ScoreNum":
                        _ScoreNum = value.ToShort();
                        break;
                    case "AttackScore":
                        _AttackScore = value.ToShort();
                        break;
                    case "DefenseScore":
                        _DefenseScore = value.ToShort();
                        break;
                    case "StarScore":
                        _StarScore = value.ToShort();
                        break;
                    case "ExpNum":
                        _ExpNum = value.ToInt();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    case "PennyNum":
                        _PennyNum = value.ToInt();
                        break;
                    case "GoldNum":
                        _GoldNum = value.ToInt();
                        break;
                    case "ItemID":
                        _ItemID = value.ToInt();
                        break;
                    case "CompleteDate":
                        _CompleteDate = value.ToDateTime();
                        break;
                    case "RefleshDate":
                        _RefleshDate = value.ToDateTime();
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    case "BlessPennyNum":
                        _BlessPennyNum = value.ToInt();
                        break;
                    case "BlessExperience":
                        _BlessExperience = value.ToInt();
                        break;
                    case "EnchantID":
                        _EnchantID = value.ToInt();
                        break;
                    case "PlotSuccessType":
                        _PlotSuccessType = value.ToEnum<PlotSuccessType>();
                        break;
                    case "PlotFailureType":
                        _PlotFailureType = value.ToEnum<PlotFailureType>();
                        break;
                    case "HonourNum":
                        _HonourNum = value.ToInt();
                        break;
                    case "ItemList":
                        _ItemList = ConvertCustomField<CacheList<UniversalInfo>>(value, index); 
                        break;
                    case "PlotNum":
                        _PlotNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserPlot index[{0}] isn't exist.", index));
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
        public PlotType PlotType
        {
            get
            {
                var cacheSet = new ShareCacheStruct<PlotInfo>();
                return cacheSet.FindKey(PlotID) == null ? 0 : cacheSet.FindKey(PlotID).PlotType;
            }
        }
    }
}