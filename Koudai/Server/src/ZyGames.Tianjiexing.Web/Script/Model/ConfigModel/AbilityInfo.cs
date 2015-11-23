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

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class AbilityInfo : ShareEntity
    {
        public const string Index_AbilityStyle = "Index_AbilityStyle";

        public AbilityInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        #region auto-generated Property
        private Int32 _AbilityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityID", IsKey = true)]
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
        private String _AbilityName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityName")]
        public String AbilityName
        {
            get
            {
                return _AbilityName;
            }
            private set
            {
                SetChange("AbilityName", value);
            }
        }
        private AttackType _AttackType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AttackType")]
        public AttackType AttackType
        {
            get
            {
                return _AttackType;
            }
            private set
            {
                SetChange("AttackType", value);
            }
        }
        private AbilityProperty _AbilityProperty;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityProperty")]
        public AbilityProperty AbilityProperty
        {
            get
            {
                return _AbilityProperty;
            }
            private set
            {
                SetChange("AbilityProperty", value);
            }
        }
        private AttackUnit _AttackUnit;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AttackUnit")]
        public AttackUnit AttackUnit
        {
            get
            {
                return _AttackUnit;
            }
            private set
            {
                SetChange("AttackUnit", value);
            }
        }
        private AttackTaget _AttackTaget;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AttackTaget")]
        public AttackTaget AttackTaget
        {
            get
            {
                return _AttackTaget;
            }
            private set
            {
                SetChange("AttackTaget", value);
            }
        }
        private Decimal _RatioNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("RatioNum")]
        public Decimal RatioNum
        {
            get
            {
                return _RatioNum;
            }
            private set
            {
                SetChange("RatioNum", value);
            }
        }
        private Boolean _IsIncrease;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsIncrease")]
        public Boolean IsIncrease
        {
            get
            {
                return _IsIncrease;
            }
            private set
            {
                SetChange("IsIncrease", value);
            }
        }
        private Decimal _HitPercent;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HitPercent")]
        public Decimal HitPercent
        {
            get
            {
                return _HitPercent;
            }
            private set
            {
                SetChange("HitPercent", value);
            }
        }
        private Boolean _IsCorrect;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsCorrect")]
        public Boolean IsCorrect
        {
            get
            {
                return _IsCorrect;
            }
            private set
            {
                SetChange("IsCorrect", value);
            }
        }
        private Boolean _IsIncreaseCorrect;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsIncreaseCorrect")]
        public Boolean IsIncreaseCorrect
        {
            get
            {
                return _IsIncreaseCorrect;
            }
            private set
            {
                SetChange("IsIncreaseCorrect", value);
            }
        }
        private String _AbilityType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityType")]
        public String AbilityType
        {
            get
            {
                return _AbilityType;
            }
            private set
            {
                SetChange("AbilityType", value);
            }
        }
        private String _BaseEffectNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BaseEffectNum")]
        public String BaseEffectNum
        {
            get
            {
                return _BaseEffectNum;
            }
            private set
            {
                SetChange("BaseEffectNum", value);
            }
        }
        private String _IncreaseNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IncreaseNum")]
        public String IncreaseNum
        {
            get
            {
                return _IncreaseNum;
            }
            private set
            {
                SetChange("IncreaseNum", value);
            }
        }
        private Int16 _EffectCount;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EffectCount")]
        public Int16 EffectCount
        {
            get
            {
                return _EffectCount;
            }
            private set
            {
                SetChange("EffectCount", value);
            }
        }
        private Decimal _RatioIncreaseNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("RatioIncreaseNum")]
        public Decimal RatioIncreaseNum
        {
            get
            {
                return _RatioIncreaseNum;
            }
            private set
            {
                SetChange("RatioIncreaseNum", value);
            }
        }
        private String _EffectDesc;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EffectDesc")]
        public String EffectDesc
        {
            get
            {
                return _EffectDesc;
            }
            private set
            {
                SetChange("EffectDesc", value);
            }
        }
        private String _AbilityDesc;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityDesc")]
        public String AbilityDesc
        {
            get
            {
                return _AbilityDesc;
            }
            private set
            {
                SetChange("AbilityDesc", value);
            }
        }
        private Boolean _IsMove;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsMove")]
        public Boolean IsMove
        {
            get
            {
                return _IsMove;
            }
            private set
            {
                SetChange("IsMove", value);
            }
        }
        private String _EffectID1;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EffectID1")]
        public String EffectID1
        {
            get
            {
                return _EffectID1;
            }
            private set
            {
                SetChange("EffectID1", value);
            }
        }
        private String _EffectID2;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EffectID2")]
        public String EffectID2
        {
            get
            {
                return _EffectID2;
            }
            private set
            {
                SetChange("EffectID2", value);
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

        private Int32 _AbilityStyle;
        /// <summary>
        /// �������� 0 ��ͨ 1 ����
        /// </summary>
        [EntityField("AbilityStyle")]
        public Int32 AbilityStyle
        {
            get
            {
                return _AbilityStyle;
            }
            private set
            {
                SetChange("AbilityStyle", value);
            }
        }

        private string _HeadID;
        /// <summary>
        /// ����ͼƬ
        /// </summary>
        [EntityField("HeadID")]
        public string HeadID
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

        private Int32 _DemandLv;
        /// <summary>
        /// �跨���ȼ�
        /// </summary>
        [EntityField("DemandLv")]
        public Int32 DemandLv
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

        private AbilityType _ChangeAbility;
        /// <summary>
        /// ת���Ļ꼼����
        /// </summary>
        [EntityField("ChangeAbility")]
        public AbilityType ChangeAbility
        {
            get
            {
                return _ChangeAbility;
            }
            private set
            {
                SetChange("ChangeAbility", value);
            }
        }

        private AbilityType _AfterAbility;
        /// <summary>
        /// ת����Ļ꼼����
        /// </summary>
        [EntityField("AfterAbility")]
        public AbilityType AfterAbility
        {
            get
            {
                return _AfterAbility;
            }
            private set
            {
                SetChange("AfterAbility", value);
            }
        }

        private String _MaxHeadID;
        /// <summary>
        /// ���ܴ�ͼƬ
        /// </summary>
        [EntityField("MaxHeadID")]
        public String MaxHeadID
        {
            get
            {
                return _MaxHeadID;
            }
            private set
            {
                SetChange("MaxHeadID", value);
            }
        }

        private decimal _Probability;
        /// <summary>
        /// �����ͷŸ���
        /// </summary>
        [EntityField("Probability")]
        public decimal Probability
        {
            get
            {
                return _Probability;
            }
            private set
            {
                SetChange("Probability", value);
            }
        }
        private String _FntHeadID;
        /// <summary>
        /// �����ͷŸ���
        /// </summary>
        [EntityField("FntHeadID")]
        public String FntHeadID
        {
            get
            {
                return _FntHeadID;
            }
            private set
            {
                SetChange("FntHeadID", value);
            }
        }
        private Int16 _IsActive;
        /// <summary>
        /// �Ƿ���������0������1������
        /// </summary>
        [EntityField("IsActive")]
        public Int16 IsActive
        {
            get
            {
                return _IsActive;
            }
            private set
            {
                SetChange("IsActive", value);
            }
        }
        private Int32 _AbilityQuality;
        /// <summary>
        /// Ʒ��
        /// </summary>
        [EntityField("AbilityQuality")]
        public Int32 AbilityQuality
        {
            get
            {
                return _AbilityQuality;
            }
            private set
            {
                SetChange("AbilityQuality", value);
            }
        }
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "AbilityID": return AbilityID;
                    case "AbilityName": return AbilityName;
                    case "AttackType": return AttackType;
                    case "AbilityProperty": return AbilityProperty;
                    case "AttackUnit": return AttackUnit;
                    case "AttackTaget": return AttackTaget;
                    case "RatioNum": return RatioNum;
                    case "IsIncrease": return IsIncrease;
                    case "HitPercent": return HitPercent;
                    case "IsCorrect": return IsCorrect;
                    case "IsIncreaseCorrect": return IsIncreaseCorrect;
                    case "AbilityType": return AbilityType;
                    case "BaseEffectNum": return BaseEffectNum;
                    case "IncreaseNum": return IncreaseNum;
                    case "EffectCount": return EffectCount;
                    case "RatioIncreaseNum": return RatioIncreaseNum;
                    case "EffectDesc": return EffectDesc;
                    case "AbilityDesc": return AbilityDesc;
                    case "IsMove": return IsMove;
                    case "EffectID1": return EffectID1;
                    case "EffectID2": return EffectID2;
                    case "Version": return Version;
                    case "AbilityStyle": return AbilityStyle;
                    case "HeadID": return HeadID;
                    case "DemandLv": return DemandLv;
                    case "ChangeAbility": return ChangeAbility;
                    case "AfterAbility": return AfterAbility;
                    case "MaxHeadID": return MaxHeadID;
                    case "Probability": return Probability;
                    case "FntHeadID": return FntHeadID;
                    case "IsActive": return IsActive;
                    case "AbilityQuality": return AbilityQuality;
                    default: throw new ArgumentException(string.Format("AbilityInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "AbilityID":
                        _AbilityID = value.ToInt();
                        break;
                    case "AbilityName":
                        _AbilityName = value.ToNotNullString();
                        break;
                    case "AttackType":
                        _AttackType = value.ToEnum<AttackType>();
                        break;
                    case "AbilityProperty":
                        _AbilityProperty = value.ToEnum<AbilityProperty>();
                        break;
                    case "AttackUnit":
                        _AttackUnit = value.ToEnum<AttackUnit>();
                        break;
                    case "AttackTaget":
                        _AttackTaget = value.ToEnum<AttackTaget>();
                        break;
                    case "RatioNum":
                        _RatioNum = value.ToDecimal();
                        break;
                    case "IsIncrease":
                        _IsIncrease = value.ToBool();
                        break;
                    case "HitPercent":
                        _HitPercent = value.ToDecimal();
                        break;
                    case "IsCorrect":
                        _IsCorrect = value.ToBool();
                        break;
                    case "IsIncreaseCorrect":
                        _IsIncreaseCorrect = value.ToBool();
                        break;
                    case "AbilityType":
                        _AbilityType = value.ToNotNullString();
                        break;
                    case "BaseEffectNum":
                        _BaseEffectNum = value.ToNotNullString();
                        break;
                    case "IncreaseNum":
                        _IncreaseNum = value.ToNotNullString();
                        break;
                    case "EffectCount":
                        _EffectCount = value.ToShort();
                        break;
                    case "RatioIncreaseNum":
                        _RatioIncreaseNum = value.ToDecimal();
                        break;
                    case "EffectDesc":
                        _EffectDesc = value.ToNotNullString();
                        break;
                    case "AbilityDesc":
                        _AbilityDesc = value.ToNotNullString();
                        break;
                    case "IsMove":
                        _IsMove = value.ToBool();
                        break;
                    case "EffectID1":
                        _EffectID1 = value.ToNotNullString();
                        break;
                    case "EffectID2":
                        _EffectID2 = value.ToNotNullString();
                        break;
                    case "Version":
                        _Version = value.ToInt();
                        break;
                    case "AbilityStyle":
                        _AbilityStyle = value.ToShort();
                        break;
                    case "HeadID":
                        _HeadID = value.ToNotNullString();
                        break;
                    case "DemandLv":
                        _DemandLv = value.ToShort();
                        break;
                    case "ChangeAbility":
                        _ChangeAbility = value.ToEnum<AbilityType>();
                        break;
                    case "AfterAbility": _AfterAbility = value.ToEnum<AbilityType>();
                        break;
                    case "MaxHeadID":
                        _MaxHeadID = value.ToNotNullString();
                        break;
                    case "Probability":
                        _Probability = value.ToDecimal();
                        break;
                    case "FntHeadID":
                        _FntHeadID = value.ToNotNullString();
                        break;
                    case "IsActive":
                        _IsActive = value.ToShort();
                        break;
                    case "AbilityQuality":
                        _AbilityQuality = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("AbilityInfo index[{0}] isn't exist.", index));
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