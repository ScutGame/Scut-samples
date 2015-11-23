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

    public class MonsterInfo : ShareEntity
    {

        public const string Index_ItemID = "Index_ItemID";
        
        public MonsterInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _MonsterID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MonsterID", IsKey = true)]
        public Int32 MonsterID
        {
            get
            {
                return _MonsterID;
            }
            private set
            {
                SetChange("MonsterID", value);
            }
        }
        private Int16 _MonsterType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MonsterType")]
        public Int16 MonsterType
        {
            get
            {
                return _MonsterType;
            }
            private set
            {
                SetChange("MonsterType", value);
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
        private Int32 _MomentumNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MomentumNum")]
        public Int32 MomentumNum
        {
            get
            {
                return _MomentumNum;
            }
            private set
            {
                SetChange("MomentumNum", value);
            }
        }
        private Decimal _BaojiNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BaojiNum")]
        public Decimal BaojiNum
        {
            get
            {
                return _BaojiNum;
            }
            private set
            {
                SetChange("BaojiNum", value);
            }
        }
        private Decimal _RenxingNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("RenxingNum")]
        public Decimal RenxingNum
        {
            get
            {
                return _RenxingNum;
            }
            private set
            {
                SetChange("RenxingNum", value);
            }
        }
        private Decimal _HitNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HitNum")]
        public Decimal HitNum
        {
            get
            {
                return _HitNum;
            }
            private set
            {
                SetChange("HitNum", value);
            }
        }
        private Decimal _ShanbiNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ShanbiNum")]
        public Decimal ShanbiNum
        {
            get
            {
                return _ShanbiNum;
            }
            private set
            {
                SetChange("ShanbiNum", value);
            }
        }
        private Decimal _GedangNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GedangNum")]
        public Decimal GedangNum
        {
            get
            {
                return _GedangNum;
            }
            private set
            {
                SetChange("GedangNum", value);
            }
        }
        private Decimal _PojiNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PojiNum")]
        public Decimal PojiNum
        {
            get
            {
                return _PojiNum;
            }
            private set
            {
                SetChange("PojiNum", value);
            }
        }
        private Decimal _BishaNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BishaNum")]
        public Decimal BishaNum
        {
            get
            {
                return _BishaNum;
            }
            private set
            {
                SetChange("BishaNum", value);
            }
        }
        private Int32 _ItemID;
        /// <summary>
        /// 
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
        private Int32 _DamageNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("DamageNum")]
        public Int32 DamageNum
        {
            get
            {
                return _DamageNum;
            }
            private set
            {
                SetChange("DamageNum", value);
            }
        }
        private Int32 _PhyAttackNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PhyAttackNum")]
        public Int32 PhyAttackNum
        {
            get
            {
                return _PhyAttackNum;
            }
            private set
            {
                SetChange("PhyAttackNum", value);
            }
        }
        private Int32 _PhyDefenseNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PhyDefenseNum")]
        public Int32 PhyDefenseNum
        {
            get
            {
                return _PhyDefenseNum;
            }
            private set
            {
                SetChange("PhyDefenseNum", value);
            }
        }
        private Int32 _MagAttackNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MagAttackNum")]
        public Int32 MagAttackNum
        {
            get
            {
                return _MagAttackNum;
            }
            private set
            {
                SetChange("MagAttackNum", value);
            }
        }
        private Int32 _MagDefenseNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MagDefenseNum")]
        public Int32 MagDefenseNum
        {
            get
            {
                return _MagDefenseNum;
            }
            private set
            {
                SetChange("MagDefenseNum", value);
            }
        }
        private Int32 _AbiAttackNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbiAttackNum")]
        public Int32 AbiAttackNum
        {
            get
            {
                return _AbiAttackNum;
            }
            private set
            {
                SetChange("AbiAttackNum", value);
            }
        }
        private Int32 _AbiDefenseNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbiDefenseNum")]
        public Int32 AbiDefenseNum
        {
            get
            {
                return _AbiDefenseNum;
            }
            private set
            {
                SetChange("AbiDefenseNum", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "MonsterID": return MonsterID;
                    case "MonsterType": return MonsterType;
                    case "HeadID": return HeadID;
                    case "GeneralName": return GeneralName;
                    case "GeneralLv": return GeneralLv;
                    case "LifeNum": return LifeNum;
                    case "CareerID": return CareerID;
                    case "PowerNum": return PowerNum;
                    case "SoulNum": return SoulNum;
                    case "IntellectNum": return IntellectNum;
                    case "AbilityID": return AbilityID;
                    case "MomentumNum": return MomentumNum;
                    case "BaojiNum": return BaojiNum;
                    case "RenxingNum": return RenxingNum;
                    case "HitNum": return HitNum;
                    case "ShanbiNum": return ShanbiNum;
                    case "GedangNum": return GedangNum;
                    case "PojiNum": return PojiNum;
                    case "BishaNum": return BishaNum;
                    case "ItemID": return ItemID;
                    case "ItemProbability": return ItemProbability;
                    case "DamageNum": return DamageNum;
                    case "PhyAttackNum": return PhyAttackNum;
                    case "PhyDefenseNum": return PhyDefenseNum;
                    case "MagAttackNum": return MagAttackNum;
                    case "MagDefenseNum": return MagDefenseNum;
                    case "AbiAttackNum": return AbiAttackNum;
                    case "AbiDefenseNum": return AbiDefenseNum;
					default: throw new ArgumentException(string.Format("MonsterInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "MonsterID": 
                        _MonsterID = value.ToInt(); 
                        break; 
                    case "MonsterType": 
                        _MonsterType = value.ToShort(); 
                        break; 
                    case "HeadID": 
                        _HeadID = value.ToNotNullString(); 
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
                    case "AbilityID": 
                        _AbilityID = value.ToInt(); 
                        break; 
                    case "MomentumNum": 
                        _MomentumNum = value.ToInt(); 
                        break; 
                    case "BaojiNum": 
                        _BaojiNum = value.ToDecimal(); 
                        break; 
                    case "RenxingNum": 
                        _RenxingNum = value.ToDecimal(); 
                        break; 
                    case "HitNum": 
                        _HitNum = value.ToDecimal(); 
                        break; 
                    case "ShanbiNum": 
                        _ShanbiNum = value.ToDecimal(); 
                        break; 
                    case "GedangNum": 
                        _GedangNum = value.ToDecimal(); 
                        break; 
                    case "PojiNum": 
                        _PojiNum = value.ToDecimal(); 
                        break; 
                    case "BishaNum": 
                        _BishaNum = value.ToDecimal(); 
                        break; 
                    case "ItemID": 
                        _ItemID = value.ToInt(); 
                        break; 
                    case "ItemProbability": 
                        _ItemProbability = value.ToDecimal(); 
                        break; 
                    case "DamageNum": 
                        _DamageNum = value.ToInt(); 
                        break; 
                    case "PhyAttackNum": 
                        _PhyAttackNum = value.ToInt(); 
                        break; 
                    case "PhyDefenseNum": 
                        _PhyDefenseNum = value.ToInt(); 
                        break; 
                    case "MagAttackNum": 
                        _MagAttackNum = value.ToInt(); 
                        break; 
                    case "MagDefenseNum": 
                        _MagDefenseNum = value.ToInt(); 
                        break; 
                    case "AbiAttackNum": 
                        _AbiAttackNum = value.ToInt(); 
                        break; 
                    case "AbiDefenseNum": 
                        _AbiDefenseNum = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("MonsterInfo index[{0}] isn't exist.", index));
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