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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ProtoBuf;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Dictionary, DbConfig.Data)]

    public class UserShengJiTa : BaseEntity
    {

        /// <summary>
        /// </summary>
        public UserShengJiTa()
            : base(AccessLevel.ReadWrite)
        {
            RewardStatusList=new CacheList<RewardStatus>();
            FiveTierRewardList=new CacheList<FiveTierReward>();
        }        
        /// <summary>
        /// </summary>
        public UserShengJiTa(int userID)
            : this()
        {
            _userID = userID;
        }

        #region 自动生成属性
        private int _userID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                SetChange("UserID", value);
            }
            
        }
        private int _battleRount;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("BattleRount")]
        public int BattleRount
        {
            get
            {
                return _battleRount;
            } 
            set
            {
                SetChange("BattleRount", value);
            }
        }
        private int _maxTierNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("MaxTierNum")]
        public int MaxTierNum
        {
            get
            {
                return _maxTierNum;
            } 
            set
            {
                SetChange("MaxTierNum", value);
            }
        }
        private int _haveRankNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("HaveRankNum")]
        public int HaveRankNum
        {
            get
            {
                return _haveRankNum;
            } 
            set
            {
                SetChange("HaveRankNum", value);
            }
        }
        private int _scoreStar;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("ScoreStar")]
        public int ScoreStar
        {
            get
            {
                return _scoreStar;
            } 
            set
            {
                SetChange("ScoreStar", value);
            }
        }
        private int _lastScoreStar;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("LastScoreStar")]
        public int LastScoreStar
        {
            get
            {
                return _lastScoreStar;
            } 
            set
            {
                SetChange("LastScoreStar", value);
            }
        }
        private DateTime _endTime;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("EndTime")]
        public DateTime EndTime
        {
            get
            {
                return _endTime;
            } 
            set
            {
                SetChange("EndTime", value);
            }
        }
        private DateTime _rankTime;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("RankTime")]
        public DateTime RankTime
        {
            get
            {
                return _rankTime;
            } 
            set
            {
                SetChange("RankTime", value);
            }
        }
        private int _IsTierNum;
        /// <summary>
        /// 当前层数
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("IsTierNum")]
        public int IsTierNum
        {
            get
            {
                return _IsTierNum;
            }
            set
            {
                SetChange("IsTierNum", value);
            }
        }
        private int _IsTierStar;
        /// <summary>
        /// 当前每五层分数
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("IsTierStar")]
        public int IsTierStar
        {
            get
            {
                return _IsTierStar;
            }
            set
            {
                SetChange("IsTierStar", value);
            }
        }
        private int _IsRountStar;
        /// <summary>
        /// 当前每轮分数
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("IsRountStar")]
        public int IsRountStar
        {
            get
            {
                return _IsRountStar;
            }
            set
            {
                SetChange("IsRountStar", value);
            }
        }
        private CacheList<RewardStatus> _rewardStatusList;
        /// <summary>
        /// [CacheList<RewardStatus>]
        /// </summary>        
        [ProtoMember(12)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<RewardStatus> RewardStatusList
        {
            get
            {
                return _rewardStatusList;
            } 
            set
            {
                SetChange("RewardStatusList", value);
            }
        }
        private decimal _LifeNum;
        /// <summary>
        /// 生命加成
        /// </summary>        
        [ProtoMember(13)]
        [EntityField("LifeNum")]
        public decimal LifeNum
        {
            get
            {
                return _LifeNum;
            }
            set
            {
                SetChange("LifeNum", value);
            }
        }
        private decimal _WuLiNum;
        /// <summary>
        /// 物理加成
        /// </summary>        
        [ProtoMember(14)]
        [EntityField("WuLiNum")]
        public decimal WuLiNum
        {
            get
            {
                return _WuLiNum;
            }
            set
            {
                SetChange("WuLiNum", value);
            }
        }
        private decimal _FunJiNum;
        /// <summary>
        /// 魂技加成
        /// </summary>        
        [ProtoMember(15)]
        [EntityField("FunJiNum")]
        public decimal FunJiNum
        {
            get
            {
                return _FunJiNum;
            }
            set
            {
                SetChange("FunJiNum", value);
            }
        }
        private decimal _MofaNum;
        /// <summary>
        /// 魔法加成
        /// </summary>        
        [ProtoMember(16)]
        [EntityField("MofaNum")]
        public decimal MofaNum
        {
            get
            {
                return _MofaNum;
            }
            set
            {
                SetChange("MofaNum", value);
            }
        }

        private short _SJTStatus;
        /// <summary>
        /// 当前状态
        /// </summary>        
        [ProtoMember(17)]
        [EntityField("SJTStatus")]
        public short SJTStatus
        {
            get
            {
                return _SJTStatus;
            }
            set
            {
                SetChange("SJTStatus", value);
            }
        }
        private int _RoundPoor;
        /// <summary>
        /// 当前轮总积分与前一轮总积分差值
        /// </summary>        
        [ProtoMember(18)]
        [EntityField("RoundPoor")]
        public int RoundPoor
        {
            get
            {
                return _RoundPoor;
            }
            set
            {
                SetChange("RoundPoor", value);
            }
        }

        private CacheList<FiveTierReward> _fiveTierRewardList;
        /// <summary>
        /// [CacheList<FiveTierRewardList>]
        /// </summary>        
        [ProtoMember(19)]
        [EntityField(true, ColumnDbType.LongText)]

        public CacheList<FiveTierReward> FiveTierRewardList
        {
            get
            {
                return _fiveTierRewardList;
            } 
            set
            {
                SetChange("FiveTierRewardList", value);
            }
        }
        private int _IsYesterday;
        /// <summary>
        /// 昨天是否进榜0：否1：是
        /// </summary>        
        [ProtoMember(20)]
        [EntityField("IsYesterday")]
        public int IsYesterday
        {
            get
            {
                return _IsYesterday;
            }
            set
            {
                SetChange("IsYesterday", value);
            }
        }
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "UserID": return _userID;
                    case "BattleRount": return _battleRount;
                    case "MaxTierNum": return _maxTierNum;
                    case "HaveRankNum": return _haveRankNum;
                    case "ScoreStar": return _scoreStar;
                    case "LastScoreStar": return _lastScoreStar;
                    case "EndTime": return _endTime;
                    case "RankTime": return _rankTime;
                    case "IsTierNum": return _IsTierNum;
                    case "IsTierStar": return _IsTierStar;
                    case "IsRountStar": return _IsRountStar;
                    case "RewardStatusList": return _rewardStatusList;
                    case "LifeNum": return _LifeNum;
                    case "WuLiNum": return _WuLiNum;
                    case "FunJiNum": return _FunJiNum;
                    case "MofaNum": return _MofaNum;
                    case "SJTStatus": return _SJTStatus;
                    case "RoundPoor": return _RoundPoor;
                    case "FiveTierRewardList": return _fiveTierRewardList;
                    case "IsYesterday": return _IsYesterday;
					default: throw new ArgumentException(string.Format("UserShengJiTa index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "UserID": 
                        _userID = value.ToInt();
                        break; 
                    case "BattleRount": 
                        _battleRount = value.ToInt();
                        break; 
                    case "MaxTierNum": 
                        _maxTierNum = value.ToInt();
                        break; 
                    case "HaveRankNum": 
                        _haveRankNum = value.ToInt();
                        break; 
                    case "ScoreStar": 
                        _scoreStar = value.ToInt();
                        break; 
                    case "LastScoreStar": 
                        _lastScoreStar = value.ToInt();
                        break; 
                    case "EndTime": 
                        _endTime = value.ToDateTime();
                        break; 
                    case "RankTime": 
                        _rankTime = value.ToDateTime();
                        break;
                    case "IsTierNum":
                        _IsTierNum = value.ToInt();
                        break;
                    case "IsTierStar":
                        _IsTierStar = value.ToInt();
                        break;
                    case "IsRountStar":
                        _IsRountStar = value.ToInt();
                        break;

                    case "RewardStatusList": 
                        _rewardStatusList = ConvertCustomField<CacheList<RewardStatus>>(value, index);
                        break;
                    case "LifeNum":
                        _LifeNum = value.ToDecimal();
                        break;
                    case "WuLiNum":
                        _WuLiNum = value.ToDecimal();
                        break;
                    case "FunJiNum":
                        _FunJiNum = value.ToDecimal();
                        break;
                    case "MofaNum":
                        _MofaNum = value.ToDecimal();
                        break;
                    case "SJTStatus":
                        _SJTStatus = value.ToShort();
                        break;
                    case "RoundPoor":
                        _RoundPoor = value.ToInt();
                        break;
                    case "FiveTierRewardList":
                        _fiveTierRewardList = ConvertCustomField<CacheList<FiveTierReward>>(value, index);
                        break;
                    case "IsYesterday":
                        _IsYesterday = value.ToInt();
                        break;
					default: throw new ArgumentException(string.Format("UserShengJiTa index[{0}] isn't exist.", index));
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

        /// <summary>
        /// 临时缓存字段：第一个为层数，其余为位置
        /// </summary>
        [ProtoMember(21)]
        public string RandomPosition { get; set; }
        
	}
}