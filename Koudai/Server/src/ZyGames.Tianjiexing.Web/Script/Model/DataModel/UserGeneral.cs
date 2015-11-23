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
using ZyGames.Framework.Event;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Tianjiexing.Model.Enum;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// �������ί��
    /// </summary>
    public delegate void EscalateHandle(UserGeneral general);
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data, OrderColumn = "GeneralID")]

    public class UserGeneral : BaseEntity
    {
        public const int MainID = 10000;
        public const string Index_UserID = GameUser.Index_UserID;

        /// <summary>
        /// ����������
        /// </summary>
        /// <returns></returns>
        public static UserGeneral GetMainGeneral(string userID)
        {
            var usergeneral = new PersonalCacheStruct<UserGeneral>().Find(userID, s => s.GeneralType == GeneralType.YongHu);
            return usergeneral;
        }

        /// <summary>
        /// ��ȡ�������Ӷ��ID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static int MainGeneralID(string userID)
        {
            UserGeneral general = GetMainGeneral(userID);
            if (general != null)
            {
                return general.GeneralID;
            }
            return 0;
        }

        public static EscalateHandle EscalateHandle { get; set; }


        public UserGeneral()
            : base(AccessLevel.ReadWrite)
        {
            Attribute = new CacheList<GeneralProperty>();
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
        private Int32 _GeneralID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("GeneralID", IsKey = true)]
        public Int32 GeneralID
        {
            get
            {
                return _GeneralID;
            }
            set
            {
                SetChange("GeneralID", value);
            }
        }
        private String _GeneralName;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("GeneralName")]
        public String GeneralName
        {
            get
            {
                return _GeneralName;
            }
            set
            {
                SetChange("GeneralName", value);
            }
        }
        private String _HeadID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("HeadID")]
        public String HeadID
        {
            get
            {
                return _HeadID;
            }
            set
            {
                SetChange("HeadID", value);
            }
        }
        private String _PicturesID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("PicturesID")]
        public String PicturesID
        {
            get
            {
                return _PicturesID;
            }
            set
            {
                SetChange("PicturesID", value);
            }
        }
        private Int16 _GeneralLv;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("GeneralLv")]
        public Int16 GeneralLv
        {
            get
            {
                return _GeneralLv;
            }
            set
            {
                SetChange("GeneralLv", value);
            }
        }
        private Int32 _LifeNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("LifeNum")]
        public Int32 LifeNum
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
        private GeneralType _GeneralType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("GeneralType")]
        public GeneralType GeneralType
        {
            get
            {
                return _GeneralType;
            }
            set
            {
                SetChange("GeneralType", value);
            }
        }
        private Int16 _CareerID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("CareerID")]
        public Int16 CareerID
        {
            get
            {
                return _CareerID;
            }
            set
            {
                SetChange("CareerID", value);
            }
        }
        private Int16 _PowerNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField("PowerNum")]
        public Int16 PowerNum
        {
            get
            {
                return _PowerNum;
            }
            set
            {
                SetChange("PowerNum", value);
            }
        }
        private Int16 _SoulNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField("SoulNum")]
        public Int16 SoulNum
        {
            get
            {
                return _SoulNum;
            }
            set
            {
                SetChange("SoulNum", value);
            }
        }
        private Int16 _IntellectNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField("IntellectNum")]
        public Int16 IntellectNum
        {
            get
            {
                return _IntellectNum;
            }
            set
            {
                SetChange("IntellectNum", value);
            }
        }
        private Int16 _TrainingPower;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        [EntityField("TrainingPower")]
        public Int16 TrainingPower
        {
            get
            {
                return _TrainingPower;
            }
            set
            {
                SetChange("TrainingPower", value);
            }
        }
        private Int16 _TrainingSoul;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        [EntityField("TrainingSoul")]
        public Int16 TrainingSoul
        {
            get
            {
                return _TrainingSoul;
            }
            set
            {
                SetChange("TrainingSoul", value);
            }
        }
        private Int16 _TrainingIntellect;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(15)]
        [EntityField("TrainingIntellect")]
        public Int16 TrainingIntellect
        {
            get
            {
                return _TrainingIntellect;
            }
            set
            {
                SetChange("TrainingIntellect", value);
            }
        }
        private Decimal _HitProbability;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(16)]
        [EntityField("HitProbability")]
        public Decimal HitProbability
        {
            get
            {
                return _HitProbability;
            }
            set
            {
                SetChange("HitProbability", value);
            }
        }
        private Int32 _AbilityID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(17)]
        [EntityField("AbilityID")]
        public Int32 AbilityID
        {
            get
            {
                return _AbilityID;
            }
            set
            {
                SetChange("AbilityID", value);
            }
        }
        private Int16 _Momentum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(18)]
        [EntityField("Momentum")]
        public Int16 Momentum
        {
            get
            {
                return _Momentum;
            }
            set
            {
                SetChange("Momentum", value);
            }
        }
        private String _Description;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(19)]
        [EntityField("Description")]
        public String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                SetChange("Description", value);
            }
        }
        private GeneralStatus _GeneralStatus;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(20)]
        [EntityField("GeneralStatus")]
        public GeneralStatus GeneralStatus
        {
            get
            {
                return _GeneralStatus;
            }
            set
            {
                SetChange("GeneralStatus", value);
            }
        }
        private Int32 _CurrExperience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(21)]
        [EntityField("CurrExperience")]
        public Int32 CurrExperience
        {
            get
            {
                return _CurrExperience;
            }
            set
            {
                SetChange("CurrExperience", value);

                if (!IsLoading && EscalateHandle != null)
                {
                    EscalateHandle(this);
                }
            }
        }
        private Int32 _Experience1;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(22)]
        [EntityField("Experience1")]
        public Int32 Experience1
        {
            get
            {
                return _Experience1;
            }
            set
            {
                SetChange("Experience1", value);
            }
        }
        private Int32 _Experience2;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(23)]
        [EntityField("Experience2")]
        public Int32 Experience2
        {
            get
            {
                return _Experience2;
            }
            set
            {
                SetChange("Experience2", value);
            }
        }

        private HeritageType _HeritageType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(24)]
        [EntityField("HeritageType")]
        public HeritageType HeritageType
        {
            get
            {
                return _HeritageType;
            }
            set
            {
                SetChange("HeritageType", value);
            }
        }

        private Int16 _FeelLv;
        /// <summary>
        /// �øжȵȼ�
        /// </summary>
        [ProtoMember(25)]
        [EntityField("FeelLv")]
        public Int16 FeelLv
        {
            get
            {
                return _FeelLv;
            }
            set
            {
                SetChange("FeelLv", value);
            }
        }

        private int _FeelExperience;
        /// <summary>
        /// �øеľ���
        /// </summary>
        [ProtoMember(26)]
        [EntityField("FeelExperience")]
        public int FeelExperience
        {
            get
            {
                return _FeelExperience;
            }
            set
            {
                SetChange("FeelExperience", value);
            }
        }

        private Int16 _SaturationNum;

        /// <summary>
        /// ��ǰ��ʳ��
        /// </summary>
        [ProtoMember(27)]
        [EntityField("SaturationNum")]
        public Int16 SaturationNum
        {
            get
            {
                return _SaturationNum;
            }
            set
            {
                SetChange("SaturationNum", value);
            }
        }

        private DateTime _HungerDate;
        /// <summary>
        /// �����ʳ��ʱ��
        /// </summary>
        [ProtoMember(28)]
        [EntityField("HungerDate")]
        public DateTime HungerDate
        {
            get
            {
                return _HungerDate;
            }
            set
            {
                SetChange("HungerDate", value);
            }
        }

        private Int32 _AtmanNum;
        /// <summary>
        /// �������
        /// </summary>
        [ProtoMember(31)]
        [EntityField("AtmanNum")]
        public Int32 AtmanNum
        {
            get
            {
                return _AtmanNum;
            }
            set
            {
                SetChange("AtmanNum", value);
            }
        }

        private Int32 _Potential;
        /// <summary>
        /// Ӷ��Ǳ����
        /// </summary>
        [ProtoMember(32)]
        [EntityField("Potential")]
        public Int32 Potential
        {
            get
            {
                return _Potential;
            }
            set
            {
                SetChange("Potential", value);
            }
        }
        private CacheList<GeneralProperty> _Attribute;
        /// <summary>
        /// Ӷ������
        /// </summary>
        [ProtoMember(33)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<GeneralProperty> Attribute
        {
            get
            {
                return _Attribute;
            }
            set
            {
                SetChange("Attribute", value);
            }
        }
        /// <summary>
        /// Ӷ��Ʒ��
        /// </summary>
        public GeneralQuality GeneralQuality
        {
            get
            {
                GeneralInfo generalInfo = null;
                if (GeneralType == GeneralType.Soul)
                {
                    generalInfo = new ShareCacheStruct<GeneralInfo>().Find(s => s.SoulID == GeneralID);
                }
                else
                {
                    generalInfo = new ShareCacheStruct<GeneralInfo>().FindKey(GeneralID);
                }

                if (generalInfo != null)
                {
                    return generalInfo.GeneralQuality;
                }
                return GeneralQuality.White;
            }
        }
        private Int32 _AbilityNum;
        /// <summary>
        /// Ӷ���꼼���������
        /// </summary>
        [ProtoMember(35)]
        [EntityField("AbilityNum")]
        public Int32 AbilityNum
        {
            get
            {
                return _AbilityNum;
            }
            set
            {
                SetChange("AbilityNum", value);
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
                    case "GeneralID": return GeneralID;
                    case "GeneralName": return GeneralName;
                    case "HeadID": return HeadID;
                    case "PicturesID": return PicturesID;
                    case "GeneralLv": return GeneralLv;
                    case "LifeNum": return LifeNum;
                    case "GeneralType": return GeneralType;
                    case "CareerID": return CareerID;
                    case "PowerNum": return PowerNum;
                    case "SoulNum": return SoulNum;
                    case "IntellectNum": return IntellectNum;
                    case "TrainingPower": return TrainingPower;
                    case "TrainingSoul": return TrainingSoul;
                    case "TrainingIntellect": return TrainingIntellect;
                    case "HitProbability": return HitProbability;
                    case "AbilityID": return AbilityID;
                    case "Momentum": return Momentum;
                    case "Description": return Description;
                    case "GeneralStatus": return GeneralStatus;
                    case "CurrExperience": return CurrExperience;
                    case "Experience1": return Experience1;
                    case "Experience2": return Experience2;
                    case "HeritageType": return HeritageType;
                    case "FeelLv": return FeelLv;
                    case "FeelExperience": return FeelExperience;
                    case "SaturationNum": return SaturationNum;
                    case "HungerDate": return HungerDate;
                    case "AtmanNum": return AtmanNum;
                    case "Potential": return Potential;
                    case "Attribute": return Attribute;
                    case "AbilityNum": return AbilityNum;
                    default: throw new ArgumentException(string.Format("UserGeneral index[{0}] isn't exist.", index));
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
                    case "GeneralID":
                        _GeneralID = value.ToInt();
                        break;
                    case "GeneralName":
                        _GeneralName = value.ToNotNullString();
                        break;
                    case "HeadID":
                        _HeadID = value.ToNotNullString();
                        break;
                    case "PicturesID":
                        _PicturesID = value.ToNotNullString();
                        break;
                    case "GeneralLv":
                        _GeneralLv = value.ToShort();
                        break;
                    case "LifeNum":
                        _LifeNum = value.ToInt();
                        break;
                    case "GeneralType":
                        _GeneralType = value.ToEnum<GeneralType>();
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
                    case "TrainingPower":
                        _TrainingPower = value.ToShort();
                        break;
                    case "TrainingSoul":
                        _TrainingSoul = value.ToShort();
                        break;
                    case "TrainingIntellect":
                        _TrainingIntellect = value.ToShort();
                        break;
                    case "HitProbability":
                        _HitProbability = value.ToDecimal();
                        break;
                    case "AbilityID":
                        _AbilityID = value.ToInt();
                        break;
                    case "Momentum":
                        _Momentum = value.ToShort();
                        break;
                    case "Description":
                        _Description = value.ToNotNullString();
                        break;
                    case "GeneralStatus":
                        _GeneralStatus = value.ToEnum<GeneralStatus>();
                        break;
                    case "CurrExperience":
                        _CurrExperience = value.ToInt();
                        break;
                    case "Experience1":
                        _Experience1 = value.ToInt();
                        break;
                    case "Experience2":
                        _Experience2 = value.ToInt();
                        break;
                    case "HeritageType":
                        _HeritageType = value.ToEnum<HeritageType>();
                        break;
                    case "FeelLv":
                        _FeelLv = value.ToShort();
                        break;
                    case "FeelExperience":
                        _FeelExperience = value.ToInt();
                        break;
                    case "SaturationNum":
                        _SaturationNum = value.ToShort();
                        break;
                    case "HungerDate":
                        _HungerDate = value.ToDateTime();
                        break;
                    case "AtmanNum":
                        _AtmanNum = value.ToInt();
                        break;
                    case "Potential":
                        _Potential = value.ToInt();
                        break;
                    case "Attribute":
                        _Attribute = ConvertCustomField<CacheList<GeneralProperty>>(value, index);
                        break;
                    case "AbilityNum":
                        _AbilityNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserGeneral index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        [ProtoMember(29)]
        public int Position
        {
            get;
            set;
        }

        [ProtoMember(30)]
        public int ReplacePosition { get; set; }

        public void ResetEmbatleReplace()
        {
            ReplacePosition = 0;
        }

        [ProtoMember(36)]
        public string GeneralCard { get; set; }

        [ProtoMember(37)]
        public string GeneralCardNum { get; set; }                 //  Ӷ��������Ƭ���������

        [ProtoMember(38)]
        public Int16 PotenceNum { get; set; }

        [ProtoMember(39)]
        public Int16 ThoughtNum { get; set; }

        [ProtoMember(40)]
        public Int16 IntelligenceNum { get; set; }
        [ProtoMember(41)]
        public Int32 DemandNum { get; set; }

        [ProtoMember(42)]
        public Boolean IsBattle { get; set; }
        public int TLifeNum { get; set; }
        public int TLifeMaxNun { get; set; }
        /// <summary>
        /// �Ƿ�ͻ��0����1����
        /// </summary>
        public int IsSurmount { get; set; }
        public bool IsOver
        {
            get
            {
                return this.LifeNum <= 0;
            }
        }

        /// <summary>
        /// �Ƿ������Ӷ��
        /// </summary>
        public bool IsUserGeneral
        {
            get { return this.GeneralID.Equals(MainID); }
        }

        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID.ToInt();
        }

        private int _lifeMaxNum;
        /// <summary>
        /// ���Ѫ��
        /// </summary>
        public int LifeMaxNum
        {
            get
            {
                if (_lifeMaxNum == 0)
                {
                    lock (this)
                    {
                        if (_lifeMaxNum == 0)
                        {
                            _lifeMaxNum = GetMaxLife();
                        }
                    }
                }
                return _lifeMaxNum;
            }
        }

        /// <summary>
        /// ˢ��summary
        /// </summary>
        public void RefreshMaxLife()
        {
            lock (this)
            {
                _lifeMaxNum = GetMaxLife();
                if (LifeNum > _lifeMaxNum || LifeNum < LifeMaxNum) LifeNum = _lifeMaxNum;
            }
        }

        private int GetMaxLife()
        {
            int genLv = 0;
            int currMaxLv = 0;
            GameUser userinfo = new PersonalCacheStruct<GameUser>().FindKey(UserID);
            if (userinfo != null)
            {
                currMaxLv = userinfo.UserLv;
            }
            if (currMaxLv > 0 && GeneralLv > currMaxLv)
            {
                genLv = userinfo.UserLv;
            }
            else
            {
                genLv = GeneralLv;
            }
            //��ʼ����+(�ȼ�-1)*ְҵ�ӳ� + װ������+����ˮ������+ħ����������+������+��ħ����
            int lifeNum = 0;
            CareerInfo careerInfo = new ShareCacheStruct<CareerInfo>().FindKey(CareerID);
            if (careerInfo == null)
            {
                return lifeNum;
            }
            var tempLv = MathUtils.Subtraction(genLv, 1, 0);
            if (IsUserGeneral)
            {
                lifeNum = MathUtils.Addition(careerInfo.LifeNum, careerInfo.LifeIncreaseNum * tempLv, int.MaxValue);
            }
            else
            {
                GeneralInfo generalInfo = new ShareCacheStruct<GeneralInfo>().FindKey(GeneralID);
                if (generalInfo != null)
                {
                    lifeNum = MathUtils.Addition(generalInfo.LifeNum, careerInfo.LifeIncreaseNum * tempLv, int.MaxValue);
                }
            }
            //����ˮ������
            var packageCrystal = UserCrystalPackage.Get(UserID);
            if (packageCrystal != null && packageCrystal.CrystalPackage != null)
            {
                UserCrystalInfo[] crystalList = packageCrystal.CrystalPackage.FindAll(m => m.GeneralID.Equals(GeneralID)).ToArray();
                foreach (UserCrystalInfo item in crystalList)
                {
                    short upLv = 0;
                    if (item.CrystalLv < 10)
                    {
                        upLv = item.CrystalLv; //item.CrystalLv.Addition(1, short.MaxValue);
                    }
                    else
                    {
                        upLv = 10;
                    }
                    //AbilityType abilityType = new ShareCacheStruct<CrystalInfo>().FindKey(item.CrystalID).AbilityID;
                    var cacheSetCrystal = new ShareCacheStruct<CrystalInfo>();
                    var crystalInfo = cacheSetCrystal.FindKey(item.CrystalID);
                    AbilityType abilityType = crystalInfo != null ? crystalInfo.AbilityID : AbilityType.AttackLife;
                    decimal effectNum = 0;
                    CrystalLvInfo lvInfo = new ShareCacheStruct<CrystalLvInfo>().FindKey(item.CrystalID, upLv);
                    if (lvInfo != null)
                    {
                        effectNum = lvInfo.AbilityNum;
                    }
                    if (abilityType == AbilityType.ShengMing)
                    {
                        lifeNum = MathUtils.Addition(lifeNum, effectNum.ToInt(), int.MaxValue);
                    }
                }
            }
            //װ������
            var package = UserItemPackage.Get(UserID);
            if (package != null && package.ItemPackage != null)
            {
                var equList = package.ItemPackage.FindAll(m => !m.IsRemove && m.GeneralID.Equals(GeneralID) && m.ItemStatus.Equals(ItemStatus.YongBing));
                foreach (var item in equList)
                {
                    ItemEquAttrInfo equAttr = new ShareCacheStruct<ItemEquAttrInfo>().FindKey(item.ItemID, AbilityType.ShengMing);
                    if (equAttr != null)
                    {
                        lifeNum = MathUtils.Addition(lifeNum, equAttr.GetEffectNum(item.ItemLv), int.MaxValue);
                    }
                    //���������
                    var user = new PersonalCacheStruct<GameUser>().FindKey(UserID);
                    if (user != null && user.SparePartList != null && user.SparePartList.Count > 0)
                    {
                        var sparepartList = user.SparePartList.FindAll(m => string.Equals(m.UserItemID, item.UserItemID));
                        foreach (var sparepart in sparepartList)
                        {
                            foreach (var property in sparepart.Propertys)
                            {
                                if (property.AbilityType == AbilityType.ShengMing)
                                {
                                    lifeNum = MathUtils.Addition(lifeNum, property.Num.ToInt());
                                }
                            }
                        }
                    }
                }
            }
            //ħ������������������
            var userMagicList = new PersonalCacheStruct<UserMagic>().FindAll(UserID, u => u.MagicID != 1);
            foreach (UserMagic item in userMagicList)
            {
                //�����󷨵ȼ�Ϊ10��
                int mlv = 0;
                if (item.MagicType == MagicType.MoFaZhen && item.MagicLv > 10)
                {
                    mlv = 10;
                }
                else if (item.MagicType == MagicType.JiNeng && item.MagicLv > currMaxLv)
                {
                    mlv = currMaxLv;
                }
                else
                {
                    mlv = item.MagicLv;
                }
                MagicLvInfo magicLvItem = new ShareCacheStruct<MagicLvInfo>().FindKey(item.MagicID, mlv);

                if (magicLvItem != null && magicLvItem.AbilityType == AbilityType.ShengMing)
                {
                    int errNum = magicLvItem.EffectNum.ToInt();
                    lifeNum = MathUtils.Addition(lifeNum, errNum, int.MaxValue);
                }
            }
            // Ӷ���øжȵȼ��ӳ�����
            FeelLvInfo fellLvInfo = new ShareCacheStruct<FeelLvInfo>().FindKey(FeelLv);
            if (fellLvInfo != null && fellLvInfo.Property != null)
            {
                GeneralProperty property = fellLvInfo.Property.Find(m => m.AbilityType.Equals(AbilityType.ShengMing));
                if (property != null)
                {
                    int effectNum = property.AbilityValue.ToInt();
                    lifeNum = MathUtils.Addition(lifeNum, effectNum, int.MaxValue);
                }
            }

            //���������ӳ�
            UserTrump userTrump = new PersonalCacheStruct<UserTrump>().FindKey(UserID, TrumpInfo.CurrTrumpID);
            if (userTrump != null && userTrump.LiftNum > 0 && GeneralID == 10000)
            {
                TrumpInfo trumpInfo = new ShareCacheStruct<TrumpInfo>().FindKey(TrumpInfo.CurrTrumpID, userTrump.TrumpLv);
                if (trumpInfo != null && trumpInfo.Property != null && trumpInfo.Property.Count > 0)
                {
                    int maxMatureNum = ConfigEnvSet.GetInt("Trump.MaxMatrueNum");
                    decimal mature = (decimal)userTrump.MatureNum / maxMatureNum;
                    GeneralProperty property = trumpInfo.Property.Find(m => m.AbilityType == AbilityType.ShengMing);
                    if (property != null)
                    {
                        lifeNum = MathUtils.Addition(lifeNum, (int)Math.Floor(mature * property.AbilityValue));
                    }
                }

                if (userTrump.PropertyInfo.Count > 0)
                {
                    GeneralProperty property = userTrump.PropertyInfo.Find(m => m.AbilityType == AbilityType.ShengMing);
                    if (property != null)
                    {
                        lifeNum = MathUtils.Addition(lifeNum, (int)property.AbilityValue);
                    }
                }
            }

            //��ħ����
            var itempackage = UserItemPackage.Get(UserID);
            var enchantPackage = UserEnchant.Get(UserID);
            if (itempackage != null && itempackage.ItemPackage != null && enchantPackage != null && enchantPackage.EnchantPackage != null)
            {
                var useritem = itempackage.ItemPackage.Find(m => !m.IsRemove && m.GeneralID == GeneralID && m.Equparts == EquParts.WuQi);
                if (useritem != null)
                {
                    var enchantList = enchantPackage.EnchantPackage.FindAll(m => m.UserItemID == useritem.UserItemID && m.AbilityType == AbilityType.ShengMing);
                    foreach (var info in enchantList)
                    {
                        EnchantLvInfo enchantLvInfo = new ShareCacheStruct<EnchantLvInfo>().FindKey(info.EnchantID, info.EnchantLv);
                        if (enchantLvInfo != null)
                        {
                            int maxEnchantMature = ConfigEnvSet.GetInt("Enchant.MaxEnchantMature");
                            decimal growthrate = enchantLvInfo.Num * info.MaxMature / maxEnchantMature * info.EnchantLv;
                            lifeNum = MathUtils.Addition(lifeNum, (int)growthrate);
                        }
                    }
                }
            }
            //Ӷ����������
            if (Attribute.Count > 0)
            {
                var generalPro = Attribute.Find(s => s.AbilityType == AbilityType.ShengMing);
                if (generalPro != null)
                {
                    lifeNum = MathUtils.Addition(lifeNum, generalPro.AbilityValue.ToInt());
                }
            }

            return lifeNum;
        }
        public void AddGeneralStatus(int status)
        {
            GeneralStatus = status.ToEnum<GeneralStatus>();
        }
        public void SetEscalate(int num)
        {
            _CurrExperience = MathUtils.Subtraction(_CurrExperience, num, 0);
            Notify(this, CacheItemChangeType.Modify, "CurrExperience");
        }
    }
}