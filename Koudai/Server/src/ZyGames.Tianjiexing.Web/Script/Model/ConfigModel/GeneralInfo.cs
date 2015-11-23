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
using ZyGames.Tianjiexing.Model.Enum;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class GeneralInfo : ShareEntity
    {

        public const string Index_IsRecruit = "Index_IsRecruit";
        public const string Index_RecruitType = "Index_RecruitType";

        public GeneralInfo()
            : base(AccessLevel.ReadOnly)
        {
            ShowFilter = new CacheList<ShowFilterInfo>(0, true);
            RecruitFilter = new CacheList<RecruitFilter>(0, true);
            Mature = new CacheList<GeneralProperty>(0, true);
        }

        #region auto-generated Property
        private Int32 _GeneralID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GeneralID", IsKey = true)]
        public Int32 GeneralID
        {
            get
            {
                return _GeneralID;
            }
            private set
            {
                SetChange("GeneralID", value);
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
        private String _PicturesID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PicturesID")]
        public String PicturesID
        {
            get
            {
                return _PicturesID;
            }
            private set
            {
                SetChange("PicturesID", value);
            }
        }
        private String _GeneralName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GeneralName")]
        public String GeneralName
        {
            get
            {
                return _GeneralName;
            }
            private set
            {
                SetChange("GeneralName", value);
            }
        }
        private Int16 _GeneralLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GeneralLv")]
        public Int16 GeneralLv
        {
            get
            {
                return _GeneralLv;
            }
            private set
            {
                SetChange("GeneralLv", value);
            }
        }
        private Int32 _LifeNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LifeNum")]
        public Int32 LifeNum
        {
            get
            {
                return _LifeNum;
            }
            private set
            {
                SetChange("LifeNum", value);
            }
        }
        private Int16 _CareerID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CareerID")]
        public Int16 CareerID
        {
            get
            {
                return _CareerID;
            }
            private set
            {
                SetChange("CareerID", value);
            }
        }
        private Int16 _PowerNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PowerNum")]
        public Int16 PowerNum
        {
            get
            {
                return _PowerNum;
            }
            private set
            {
                SetChange("PowerNum", value);
            }
        }
        private Int16 _SoulNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SoulNum")]
        public Int16 SoulNum
        {
            get
            {
                return _SoulNum;
            }
            private set
            {
                SetChange("SoulNum", value);
            }
        }
        private Int16 _IntellectNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IntellectNum")]
        public Int16 IntellectNum
        {
            get
            {
                return _IntellectNum;
            }
            private set
            {
                SetChange("IntellectNum", value);
            }
        }
        private Decimal _HitProbability;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HitProbability")]
        public Decimal HitProbability
        {
            get
            {
                return _HitProbability;
            }
            private set
            {
                SetChange("HitProbability", value);
            }
        }
        private Int32 _AbilityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityID")]
        public Int32 AbilityID
        {
            get
            {
                return _AbilityID;
            }
            private set
            {
                SetChange("AbilityID", value);
            }
        }
        private Boolean _IsRecruit;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsRecruit")]
        public Boolean IsRecruit
        {
            get
            {
                return _IsRecruit;
            }
            private set
            {
                SetChange("IsRecruit", value);
            }
        }
        private CacheList<ShowFilterInfo> _ShowFilter;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<ShowFilterInfo> ShowFilter
        {
            get
            {
                return _ShowFilter;
            }
            private set
            {
                SetChange("ShowFilter", value);
            }
        }
        private CacheList<RecruitFilter> _RecruitFilter;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<RecruitFilter> RecruitFilter
        {
            get
            {
                return _RecruitFilter;
            }
            private set
            {
                SetChange("RecruitFilter", value);
            }
        }
        private String _Description;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Description")]
        public String Description
        {
            get
            {
                return _Description;
            }
            private set
            {
                SetChange("Description", value);
            }
        }

        private GiftType _GiftType;
        /// <summary>
        /// Ӷ��ϲ���������� ����GiftType����
        /// </summary>
        [EntityField("GiftType")]
        public GiftType GiftType
        {
            get
            {
                return _GiftType;
            }
            private set
            {
                SetChange("GiftType", value);
            }
        }

        private SkillInfo _ReplaceSkills;
        /// <summary>
        /// Ӷ���滻����
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public SkillInfo ReplaceSkills
        {
            get
            {
                return _ReplaceSkills;
            }
            private set
            {
                SetChange("ReplaceSkills", value);
            }
        }

        private GeneralType _GeneralType;

        /// <summary>
        /// ����GeneralTypeö��
        /// </summary>
        [EntityField("GeneralType")]
        public GeneralType GeneralType
        {
            get
            {
                return _GeneralType;
            }
            private set
            {
                SetChange("GeneralType", value);
            }
        }

        private Int32 _SoulID;

        /// <summary>
        /// ���ID
        /// </summary>
        [EntityField("SoulID")]
        public Int32 SoulID
        {
            get
            {
                return _SoulID;
            }
            private set
            {
                SetChange("SoulID", value);
            }
        }

        private Int32 _DemandNum;

        /// <summary>
        /// �����������
        /// </summary>
        [EntityField("DemandNum")]
        public Int32 DemandNum
        {
            get
            {
                return _DemandNum;
            }
            private set
            {
                SetChange("DemandNum", value);
            }
        }

        private CacheList<GeneralProperty> _Mature;

        /// <summary>
        /// �����ɳ�ֵ
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<GeneralProperty> Mature
        {
            get
            {
                return _Mature;
            }
            private set
            {
                SetChange("Mature", value);
            }
        }

        private GeneralQuality _GeneralQuality;

        /// <summary>
        /// Ӷ��Ʒ��
        /// </summary>
        [EntityField("GeneralQuality")]
        public GeneralQuality GeneralQuality
        {
            get
            {
                return _GeneralQuality;
            }
            private set
            {
                SetChange("GeneralQuality", value);
            }
        }

        private Int32 _ItemID;
        /// <summary>
        /// ��ƷID
        /// </summary>
        [EntityField("ItemID")]
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

        private String _BattleHeadID;
        /// <summary>
        /// ս������
        /// </summary>
        [EntityField("BattleHeadID")]
        public String BattleHeadID
        {
            get
            {
                return _BattleHeadID;
            }
            private set
            {
                SetChange("BattleHeadID", value);
            }
        }
        private Boolean _IsConscribe;
        /// <summary>
        /// �Ƿ����ļ
        /// </summary>
        [EntityField("IsConscribe")]
        public Boolean IsConscribe
        {
            get
            {
                return _IsConscribe;
            }
            private set
            {
                SetChange("IsConscribe", value);
            }
        }
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "GeneralID": return GeneralID;
                    case "HeadID": return HeadID;
                    case "PicturesID": return PicturesID;
                    case "GeneralName": return GeneralName;
                    case "GeneralLv": return GeneralLv;
                    case "LifeNum": return LifeNum;
                    case "CareerID": return CareerID;
                    case "PowerNum": return PowerNum;
                    case "SoulNum": return SoulNum;
                    case "IntellectNum": return IntellectNum;
                    case "HitProbability": return HitProbability;
                    case "AbilityID": return AbilityID;
                    case "IsRecruit": return IsRecruit;
                    case "ShowFilter": return ShowFilter;
                    case "RecruitFilter": return RecruitFilter;
                    case "GiftType": return GiftType;
                    case "Description": return Description;
                    case "ReplaceSkills": return ReplaceSkills;
                    case "GeneralType": return GeneralType;
                    case "SoulID": return SoulID;
                    case "DemandNum": return DemandNum;
                    case "Mature": return Mature;
                    case "GeneralQuality": return GeneralQuality;
                    case "ItemID": return ItemID;
                    case "BattleHeadID": return BattleHeadID;
                    case "IsConscribe": return IsConscribe;
                    default: throw new ArgumentException(string.Format("GeneralInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "GeneralID":
                        _GeneralID = value.ToInt();
                        break;
                    case "HeadID":
                        _HeadID = value.ToNotNullString();
                        break;
                    case "PicturesID":
                        _PicturesID = value.ToNotNullString();
                        break;
                    case "GeneralName":
                        _GeneralName = value.ToNotNullString();
                        break;
                    case "GeneralLv":
                        _GeneralLv = value.ToShort();
                        break;
                    case "LifeNum":
                        _LifeNum = value.ToInt();
                        break;
                    case "CareerID":
                        _CareerID = value.ToShort();
                        break;
                    case "PowerNum":
                        _PowerNum = value.ToShort();
                        break;
                    case "SoulNum":
                        _SoulNum = value.ToShort();
                        break;
                    case "IntellectNum":
                        _IntellectNum = value.ToShort();
                        break;
                    case "HitProbability":
                        _HitProbability = value.ToDecimal();
                        break;
                    case "AbilityID":
                        _AbilityID = value.ToInt();
                        break;
                    case "IsRecruit":
                        _IsRecruit = value.ToBool();
                        break;
                    case "ShowFilter":
                        _ShowFilter = ConvertCustomField<CacheList<ShowFilterInfo>>(value, index);
                        break;
                    case "RecruitFilter":
                        _RecruitFilter = ConvertCustomField<CacheList<RecruitFilter>>(value, index);
                        break;
                    case "Description":
                        _Description = value.ToNotNullString();
                        break;
                    case "GiftType":
                        _GiftType = value.ToEnum<GiftType>();
                        break;
                    case "ReplaceSkills":
                        _ReplaceSkills = ConvertCustomField<SkillInfo>(value, index);
                        break;
                    case "GeneralType":
                        _GeneralType = value.ToEnum<GeneralType>();
                        break;
                    case "SoulID":
                        _SoulID = value.ToInt();
                        break;
                    case "DemandNum":
                        _DemandNum = value.ToInt();
                        break;
                    case "Mature":
                        _Mature = ConvertCustomField<CacheList<GeneralProperty>>(value, index);
                        break;
                    case "GeneralQuality":
                        _GeneralQuality = value.ToEnum<GeneralQuality>();
                        break;
                    case "ItemID":
                        _ItemID = value.ToInt();
                        break;
                    case "BattleHeadID":
                        _BattleHeadID = value.ToNotNullString();
                        break;
                    case "IsConscribe":
                        _IsConscribe = value.ToBool();
                        break;
                    default: throw new ArgumentException(string.Format("GeneralInfo index[{0}] isn't exist.", index));
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
    }
}