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
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config, OrderColumn = "CityID,PlotType,PlotSeqNo asc")]
    public class PlotInfo : ShareEntity
    {

        public const string Index_CityID_PlotType = "Index_CityID_PlotType";
        public const string Index_PlotType = "Index_PlotType";
        public const string Index_LayerNum_PlotType = "Index_LayerNum_PlotType";

        public PlotInfo()
            : base(AccessLevel.ReadOnly)
        {
            FestivalReward = new CacheList<FestivalReward>(0, true);
        }

        /// <summary>
        /// ����ɨ����ȴʱ��Ƶ��
        /// </summary>
        public static int BattleSpeedNum = ConfigEnvSet.GetInt("Plot.BattleSpeedNum");

        /// <summary>
        /// ����ɨ��1Ԫ���۳�������ȴʱ��
        /// </summary>
        public static int BattleGold = ConfigEnvSet.GetInt("Plot.BattleGold");

        /// <summary>
        /// ÿ��ͨ��ɨ��ʹ�þ���
        /// </summary>
        public static short BattleEnergyNum = (short)ConfigEnvSet.GetInt("Plot.BattleEnergyNum");


        #region auto-generated Property
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotID", IsKey = true)]
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
        private Int32 _CityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CityID")]
        public Int32 CityID
        {
            get
            {
                return _CityID;
            }
            private set
            {
                SetChange("CityID", value);
            }
        }
        private PlotType _PlotType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotType")]
        public PlotType PlotType
        {
            get
            {
                return _PlotType;
            }
            private set
            {
                SetChange("PlotType", value);
            }
        }
        private short _PlotSeqNo;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotSeqNo")]
        public short PlotSeqNo
        {
            get
            {
                return _PlotSeqNo;
            }
            private set
            {
                SetChange("PlotSeqNo", value);
            }
        }
        private String _PlotName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotName")]
        public String PlotName
        {
            get
            {
                return _PlotName;
            }
            private set
            {
                SetChange("PlotName", value);
            }
        }
        private String _BossHeadID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BossHeadID")]
        public String BossHeadID
        {
            get
            {
                return _BossHeadID;
            }
            private set
            {
                SetChange("BossHeadID", value);
            }
        }
        private String _BgScene;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BgScene")]
        public String BgScene
        {
            get
            {
                return _BgScene;
            }
            private set
            {
                SetChange("BgScene", value);
            }
        }
        private String _FgScene;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("FgScene")]
        public String FgScene
        {
            get
            {
                return _FgScene;
            }
            private set
            {
                SetChange("FgScene", value);
            }
        }
        private Int32 _PrePlotID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PrePlotID")]
        public Int32 PrePlotID
        {
            get
            {
                return _PrePlotID;
            }
            private set
            {
                SetChange("PrePlotID", value);
            }
        }
        private Int32 _AftPlotID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AftPlotID")]
        public Int32 AftPlotID
        {
            get
            {
                return _AftPlotID;
            }
            private set
            {
                SetChange("AftPlotID", value);
            }
        }
        private Int16 _DemandLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("DemandLv")]
        public Int16 DemandLv
        {
            get
            {
                return _DemandLv;
            }
            private set
            {
                SetChange("DemandLv", value);
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
        private Int32 _ScoreNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ScoreNum")]
        public Int32 ScoreNum
        {
            get
            {
                return _ScoreNum;
            }
            private set
            {
                SetChange("ScoreNum", value);
            }
        }
        private String _ItemRank;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemRank")]
        public String ItemRank
        {
            get
            {
                return _ItemRank;
            }
            private set
            {
                SetChange("ItemRank", value);
            }
        }
        private Decimal _ItemProbability;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemProbability")]
        public Decimal ItemProbability
        {
            get
            {
                return _ItemProbability;
            }
            private set
            {
                SetChange("ItemProbability", value);
            }
        }
        private Int32 _SceneY1;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SceneY1")]
        public Int32 SceneY1
        {
            get
            {
                return _SceneY1;
            }
            private set
            {
                SetChange("SceneY1", value);
            }
        }
        private Int32 _SceneY2;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SceneY2")]
        public Int32 SceneY2
        {
            get
            {
                return _SceneY2;
            }
            private set
            {
                SetChange("SceneY2", value);
            }
        }
        private Int32 _Version;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Version")]
        public Int32 Version
        {
            get
            {
                return _Version;
            }
            private set
            {
                SetChange("Version", value);
            }
        }
        private Decimal _FestivalProbability;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("FestivalProbability")]
        public Decimal FestivalProbability
        {
            get
            {
                return _FestivalProbability;
            }
            private set
            {
                SetChange("FestivalProbability", value);
            }
        }
        private CacheList<FestivalReward> _FestivalReward;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<FestivalReward> FestivalReward
        {
            get
            {
                return _FestivalReward;
            }
            private set
            {
                SetChange("FestivalReward", value);
            }
        }
        private Int32 _LayerNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LayerNum")]
        public Int32 LayerNum
        {
            get
            {
                return _LayerNum;
            }
            private set
            {
                SetChange("LayerNum", value);
            }
        }
        private Int32 _EnableSparePart;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EnableSparePart")]
        public Int32 EnableSparePart
        {
            get
            {
                return _EnableSparePart;
            }
            private set
            {
                SetChange("EnableSparePart", value);
            }
        }

        private String _EnchantID;
        /// <summary>
        /// ��ħ��ID
        /// </summary>
        [EntityField("EnchantID")]
        public String EnchantID
        {
            get
            {
                return _EnchantID;
            }
            private set
            {
                SetChange("EnchantID", value);
            }
        }

        private Decimal _EnchantProbability;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EnchantProbability")]
        public Decimal EnchantProbability
        {
            get
            {
                return _EnchantProbability;
            }
            private set
            {
                SetChange("EnchantProbability", value);
            }
        }


        private String _PlotDesc;
        /// <summary>
        /// ˵��
        /// </summary>
        [EntityField("PlotDesc")]
        public String PlotDesc
        {
            get
            {
                return _PlotDesc;
            }
            private set
            {
                SetChange("PlotDesc", value);
            }
        }


        private Int32 _ChallengeNum;
        /// <summary>
        /// ��ս����
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

        private Int32 _PlotLv;
        /// <summary>
        /// �ȼ�
        /// </summary>
        [EntityField("PlotLv")]
        public Int32 PlotLv
        {
            get
            {
                return _PlotLv;
            }
            private set
            {
                SetChange("PlotLv", value);
            }
        }

        private Int32 _HonourNum;
        /// <summary>
        /// ����ֵ
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
        private Int32 _FragmentNum;
        /// <summary>
        /// ������Ƭ����
        /// </summary>
        [EntityField("FragmentNum")]
        public Int32 FragmentNum
        {
            get
            {
                return _FragmentNum;
            }
            private set
            {
                SetChange("FragmentNum", value);
            }
        }
        private Int32 _JYPrePlotID;
        /// <summary>
        /// ��Ӣ����ǰ��ID(�Ǿ�ӢΪ0)
        /// </summary>
        [EntityField("JYPrePlotID")]
        public Int32 JYPrePlotID
        {
            get
            {
                return _JYPrePlotID;
            }
            private set
            {
                SetChange("JYPrePlotID", value);
            }
        }
        private string _KgScene;
        /// <summary>
        /// ���ű���ͼƬ
        /// </summary>
        [EntityField("KgScene")]
        public string KgScene
        {
            get
            {
                return _KgScene;
            }
            private set
            {
                SetChange("KgScene", value);
            }
        }
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "PlotID": return PlotID;
                    case "CityID": return CityID;
                    case "PlotType": return PlotType;
                    case "PlotSeqNo": return PlotSeqNo;
                    case "PlotName": return PlotName;
                    case "BossHeadID": return BossHeadID;
                    case "BgScene": return BgScene;
                    case "FgScene": return FgScene;
                    case "PrePlotID": return PrePlotID;
                    case "AftPlotID": return AftPlotID;
                    case "DemandLv": return DemandLv;
                    case "GameCoin": return GameCoin;
                    case "Gold": return Gold;
                    case "GoldProbability": return GoldProbability;
                    case "ObtainNum": return ObtainNum;
                    case "ExpNum": return ExpNum;
                    case "Experience": return Experience;
                    case "ScoreNum": return ScoreNum;
                    case "ItemRank": return ItemRank;
                    case "ItemProbability": return ItemProbability;
                    case "SceneY1": return SceneY1;
                    case "SceneY2": return SceneY2;
                    case "Version": return Version;
                    case "FestivalProbability": return FestivalProbability;
                    case "FestivalReward": return FestivalReward;
                    case "LayerNum": return LayerNum;
                    case "EnableSparePart": return EnableSparePart;
                    case "EnchantID": return EnchantID;
                    case "EnchantProbability": return EnchantProbability;
                    case "PlotDesc": return PlotDesc;
                    case "ChallengeNum": return ChallengeNum;
                    case "PlotLv": return PlotLv;
                    case "HonourNum": return HonourNum;
                    case "FragmentNum": return FragmentNum;
                    case "JYPrePlotID": return JYPrePlotID;
                    case "KgScene": return KgScene;
                    default: throw new ArgumentException(string.Format("PlotInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "PlotID":
                        _PlotID = value.ToInt();
                        break;
                    case "CityID":
                        _CityID = value.ToInt();
                        break;
                    case "PlotType":
                        _PlotType = value.ToEnum<PlotType>();
                        break;
                    case "PlotSeqNo":
                        _PlotSeqNo = value.ToShort();
                        break;
                    case "PlotName":
                        _PlotName = value.ToNotNullString();
                        break;
                    case "BossHeadID":
                        _BossHeadID = value.ToNotNullString();
                        break;
                    case "BgScene":
                        _BgScene = value.ToNotNullString();
                        break;
                    case "FgScene":
                        _FgScene = value.ToNotNullString();
                        break;
                    case "PrePlotID":
                        _PrePlotID = value.ToInt();
                        break;
                    case "AftPlotID":
                        _AftPlotID = value.ToInt();
                        break;
                    case "DemandLv":
                        _DemandLv = value.ToShort();
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
                    case "ScoreNum":
                        _ScoreNum = value.ToInt();
                        break;
                    case "ItemRank":
                        _ItemRank = value.ToNotNullString();
                        break;
                    case "ItemProbability":
                        _ItemProbability = value.ToDecimal();
                        break;
                    case "SceneY1":
                        _SceneY1 = value.ToInt();
                        break;
                    case "SceneY2":
                        _SceneY2 = value.ToInt();
                        break;
                    case "Version":
                        _Version = value.ToInt();
                        break;
                    case "FestivalProbability":
                        _FestivalProbability = value.ToDecimal();
                        break;
                    case "FestivalReward":
                        _FestivalReward = ConvertCustomField<CacheList<FestivalReward>>(value, index);
                        break;
                    case "LayerNum":
                        _LayerNum = value.ToInt();
                        break;
                    case "EnableSparePart":
                        _EnableSparePart = value.ToInt();
                        break;
                    case "EnchantID":
                        _EnchantID = value.ToNotNullString();
                        break;
                    case "EnchantProbability":
                        _EnchantProbability = value.ToDecimal();
                        break;
                    case "PlotDesc":
                        _PlotDesc = value.ToNotNullString();
                        break;
                    case "ChallengeNum":
                        _ChallengeNum = value.ToInt();
                        break;
                    case "PlotLv":
                        _PlotLv = value.ToInt();
                        break;
                    case "HonourNum":
                        _HonourNum = value.ToInt();
                        break;
                    case "FragmentNum":
                        _FragmentNum = value.ToInt();
                        break;
                    case "JYPrePlotID":
                        _JYPrePlotID = value.ToInt();
                        break;
                    case "KgScene":
                        _KgScene = value.ToNotNullString();
                        break;
                    default: throw new ArgumentException(string.Format("PlotInfo index[{0}] isn't exist.", index));
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