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
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config, OrderColumn = "PlotID,NpcSeqNo asc")]

    public class PlotNPCInfo : ShareEntity
    {

        public const string Index_PlotID = "Index_PlotID";
        
        public PlotNPCInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _PlotNpcID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotNpcID", IsKey = true)]
        public Int32 PlotNpcID
        {
            get
            {
                return _PlotNpcID;
            }
            private set
            {
                SetChange("PlotNpcID", value);
            }
        }
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotID")]
        public Int32 PlotID
        {
            get
            {
                return _PlotID;
            }
            private set
            {
                SetChange("PlotID", value);
            }
        }
        private String _NpcName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("NpcName")]
        public String NpcName
        {
            get
            {
                return _NpcName;
            }
            private set
            {
                SetChange("NpcName", value);
            }
        }
        private String _HeadID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HeadID")]
        public String HeadID
        {
            get
            {
                return _HeadID;
            }
            private set
            {
                SetChange("HeadID", value);
            }
        }
        private short _NpcSeqNo;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("NpcSeqNo")]
        public short NpcSeqNo
        {
            get
            {
                return _NpcSeqNo;
            }
            private set
            {
                SetChange("NpcSeqNo", value);
            }
        }
        private Int32 _PointX;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PointX")]
        public Int32 PointX
        {
            get
            {
                return _PointX;
            }
            private set
            {
                SetChange("PointX", value);
            }
        }
        private Int32 _PointY;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PointY")]
        public Int32 PointY
        {
            get
            {
                return _PointY;
            }
            private set
            {
                SetChange("PointY", value);
            }
        }
        private String _NpcTip;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("NpcTip")]
        public String NpcTip
        {
            get
            {
                return _NpcTip;
            }
            private set
            {
                SetChange("NpcTip", value);
            }
        }
        private String _PreStoryCode;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PreStoryCode")]
        public String PreStoryCode
        {
            get
            {
                return _PreStoryCode;
            }
            private set
            {
                SetChange("PreStoryCode", value);
            }
        }
        private String _AftStoryCode;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AftStoryCode")]
        public String AftStoryCode
        {
            get
            {
                return _AftStoryCode;
            }
            private set
            {
                SetChange("AftStoryCode", value);
            }
        }
        private Boolean _IsBoss;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsBoss")]
        public Boolean IsBoss
        {
            get
            {
                return _IsBoss;
            }
            private set
            {
                SetChange("IsBoss", value);
            }
        }
        private Int32 _GameCoin;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GameCoin")]
        public Int32 GameCoin
        {
            get
            {
                return _GameCoin;
            }
            private set
            {
                SetChange("GameCoin", value);
            }
        }
        private Int32 _Gold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Gold")]
        public Int32 Gold
        {
            get
            {
                return _Gold;
            }
            private set
            {
                SetChange("Gold", value);
            }
        }
        private Decimal _GoldProbability;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GoldProbability")]
        public Decimal GoldProbability
        {
            get
            {
                return _GoldProbability;
            }
            private set
            {
                SetChange("GoldProbability", value);
            }
        }
        private Int32 _ObtainNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ObtainNum")]
        public Int32 ObtainNum
        {
            get
            {
                return _ObtainNum;
            }
            private set
            {
                SetChange("ObtainNum", value);
            }
        }
        private Int32 _ExpNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ExpNum")]
        public Int32 ExpNum
        {
            get
            {
                return _ExpNum;
            }
            private set
            {
                SetChange("ExpNum", value);
            }
        }
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Experience")]
        public Int32 Experience
        {
            get
            {
                return _Experience;
            }
            private set
            {
                SetChange("Experience", value);
            }
        }
        private Int32 _SparePartID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SparePartID")]
        public Int32 SparePartID
        {
            get
            {
                return _SparePartID;
            }
            private set
            {
                SetChange("SparePartID", value);
            }
        }
        private Decimal _SparePartProbability;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SparePartProbability")]
        public Decimal SparePartProbability
        {
            get
            {
                return _SparePartProbability;
            }
            private set
            {
                SetChange("SparePartProbability", value);
            }
        }
        private Int32 _BehindNpcID;
        /// <summary>
        /// ���ź���BOSSID
        /// </summary>
        [EntityField("BehindNpcID")]
        public Int32 BehindNpcID
        {
            get
            {
                return _BehindNpcID;
            }
            private set
            {
                SetChange("BehindNpcID", value);
            }
        }
        private Int32 _AgentNum;
        /// <summary>
        /// ��������ҩ������
        /// </summary>
        [EntityField("AgentNum")]
        public Int32 AgentNum
        {
            get
            {
                return _AgentNum;
            }
            private set
            {
                SetChange("AgentNum", value);
            }
        }
        private CacheList<PrizeInfo> _BoxReward;
        /// <summary>
        /// ����9������ƷID
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeInfo> BoxReward
        {
            get
            {
                return _BoxReward;
            }
            private set
            {
                SetChange("BoxReward", value);
            }
        }
        private Int32 _HonourNum;
        /// <summary>
        /// ���Ž�������ֵ
        /// </summary>
        [EntityField("HonourNum")]
        public Int32 HonourNum
        {
            get
            {
                return _HonourNum;
            }
            private set
            {
                SetChange("HonourNum", value);
            }
        }
        private Int32 _MonsterNum;
        /// <summary>
        /// ���Ź�������
        /// </summary>
        [EntityField("MonsterNum")]
        public Int32 MonsterNum
        {
            get
            {
                return _MonsterNum;
            }
            private set
            {
                SetChange("MonsterNum", value);
            }
        }
        private Int32 _ChallengeNum;
        /// <summary>
        /// ����BOSS��ս����
        /// </summary>
        [EntityField("ChallengeNum")]
        public Int32 ChallengeNum
        {
            get
            {
                return _ChallengeNum;
            }
            private set
            {
                SetChange("ChallengeNum", value);
            }
        }
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "PlotNpcID": return PlotNpcID;
                    case "PlotID": return PlotID;
                    case "NpcName": return NpcName;
                    case "HeadID": return HeadID;
                    case "NpcSeqNo": return NpcSeqNo;
                    case "PointX": return PointX;
                    case "PointY": return PointY;
                    case "NpcTip": return NpcTip;
                    case "PreStoryCode": return PreStoryCode;
                    case "AftStoryCode": return AftStoryCode;
                    case "IsBoss": return IsBoss;
                    case "GameCoin": return GameCoin;
                    case "Gold": return Gold;
                    case "GoldProbability": return GoldProbability;
                    case "ObtainNum": return ObtainNum;
                    case "ExpNum": return ExpNum;
                    case "Experience": return Experience;
                    case "SparePartID": return SparePartID;
                    case "SparePartProbability": return SparePartProbability;
                    case "BehindNpcID": return BehindNpcID;
                    case "AgentNum": return AgentNum;
                    case "BoxReward": return BoxReward;
                    case "BossNum": return HonourNum;
                    case "MonsterNum": return MonsterNum;
                    case "ChallengeNum": return ChallengeNum;
					default: throw new ArgumentException(string.Format("PlotNPCInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "PlotNpcID": 
                        _PlotNpcID = value.ToInt(); 
                        break; 
                    case "PlotID": 
                        _PlotID = value.ToInt(); 
                        break; 
                    case "NpcName": 
                        _NpcName = value.ToNotNullString(); 
                        break; 
                    case "HeadID": 
                        _HeadID = value.ToNotNullString(); 
                        break; 
                    case "NpcSeqNo": 
                        _NpcSeqNo = value.ToShort(); 
                        break; 
                    case "PointX": 
                        _PointX = value.ToInt(); 
                        break; 
                    case "PointY": 
                        _PointY = value.ToInt(); 
                        break; 
                    case "NpcTip": 
                        _NpcTip = value.ToNotNullString(); 
                        break; 
                    case "PreStoryCode": 
                        _PreStoryCode = value.ToNotNullString(); 
                        break; 
                    case "AftStoryCode": 
                        _AftStoryCode = value.ToNotNullString(); 
                        break; 
                    case "IsBoss": 
                        _IsBoss = value.ToBool(); 
                        break; 
                    case "GameCoin": 
                        _GameCoin = value.ToInt(); 
                        break; 
                    case "Gold": 
                        _Gold = value.ToInt(); 
                        break; 
                    case "GoldProbability": 
                        _GoldProbability = value.ToDecimal(); 
                        break; 
                    case "ObtainNum": 
                        _ObtainNum = value.ToInt(); 
                        break; 
                    case "ExpNum": 
                        _ExpNum = value.ToInt(); 
                        break; 
                    case "Experience": 
                        _Experience = value.ToInt(); 
                        break; 
                    case "SparePartID": 
                        _SparePartID = value.ToInt(); 
                        break; 
                    case "SparePartProbability": 
                        _SparePartProbability = value.ToDecimal(); 
                        break;
                    case "BehindNpcID":
                        _BehindNpcID = value.ToInt();
                        break;
                    case "AgentNum":
                        _AgentNum = value.ToInt();
                        break;
                    case "BoxReward":
                        _BoxReward = ConvertCustomField<CacheList<PrizeInfo>>(value, index); 
                        break;
                    case "HonourNum":
                        _HonourNum = value.ToInt();
                        break;
                    case "MonsterNum":
                        _MonsterNum = value.ToInt();
                        break;
                    case "ChallengeNum":
                        _ChallengeNum = value.ToInt();
                        break; 
					default: throw new ArgumentException(string.Format("PlotNPCInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
                
        protected override int GetIdentityId()
        {
            //allow modify return value
            return DefIdentityId;
        }
        public int GetRandomGold()
        {
            return RandomUtils.IsHit(this.GoldProbability) ? this.Gold : 0;
        }
	}
}