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
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ProtoBuf;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class SJTMonsterInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public SJTMonsterInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        
        /// <summary>
        /// </summary>
        public SJTMonsterInfo(int monsterID)
            : this()
        {
            _monsterID = monsterID;
        }

        #region 自动生成属性
        private int _monsterID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("MonsterID", IsKey = true)]
        public int MonsterID
        {
            get
            {
                return _monsterID;
            } 
            
        }
        private string _headID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("HeadID")]
        public string HeadID
        {
            get
            {
                return _headID;
            } 
            
        }
        private string _generalName;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("GeneralName")]
        public string GeneralName
        {
            get
            {
                return _generalName;
            } 
            
        }
        private short _generalLv;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("GeneralLv")]
        public short GeneralLv
        {
            get
            {
                return _generalLv;
            } 
            
        }
        private int _lifeNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("LifeNum")]
        public int LifeNum
        {
            get
            {
                return _lifeNum;
            } 
            
        }
        private short _careerID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("CareerID")]
        public short CareerID
        {
            get
            {
                return _careerID;
            } 
            
        }
        private short _powerNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("PowerNum")]
        public short PowerNum
        {
            get
            {
                return _powerNum;
            } 
            
        }
        private short _soulNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("SoulNum")]
        public short SoulNum
        {
            get
            {
                return _soulNum;
            } 
            
        }
        private short _intellectNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("IntellectNum")]
        public short IntellectNum
        {
            get
            {
                return _intellectNum;
            } 
            
        }
        private int _abilityID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("AbilityID")]
        public int AbilityID
        {
            get
            {
                return _abilityID;
            } 
            
        }
        private int _abilityLv;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("AbilityLv")]
        public int AbilityLv
        {
            get
            {
                return _abilityLv;
            } 
            
        }
        private int _momentumNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(12)]
        [EntityField("MomentumNum")]
        public int MomentumNum
        {
            get
            {
                return _momentumNum;
            } 
            
        }
        private decimal _baojiNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(13)]
        [EntityField("BaojiNum")]
        public decimal BaojiNum
        {
            get
            {
                return _baojiNum;
            } 
            
        }
        private decimal _renxingNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(14)]
        [EntityField("RenxingNum")]
        public decimal RenxingNum
        {
            get
            {
                return _renxingNum;
            } 
            
        }
        private decimal _hitNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(15)]
        [EntityField("HitNum")]
        public decimal HitNum
        {
            get
            {
                return _hitNum;
            } 
            
        }
        private decimal _shanbiNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(16)]
        [EntityField("ShanbiNum")]
        public decimal ShanbiNum
        {
            get
            {
                return _shanbiNum;
            } 
            
        }
        private decimal _gedangNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(17)]
        [EntityField("GedangNum")]
        public decimal GedangNum
        {
            get
            {
                return _gedangNum;
            } 
            
        }
        private decimal _pojiNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(18)]
        [EntityField("PojiNum")]
        public decimal PojiNum
        {
            get
            {
                return _pojiNum;
            } 
            
        }
        private decimal _bishaNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(19)]
        [EntityField("BishaNum")]
        public decimal BishaNum
        {
            get
            {
                return _bishaNum;
            } 
            
        }
        private int _phyAttackNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(20)]
        [EntityField("PhyAttackNum")]
        public int PhyAttackNum
        {
            get
            {
                return _phyAttackNum;
            } 
            
        }
        private int _phyDefenseNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(21)]
        [EntityField("PhyDefenseNum")]
        public int PhyDefenseNum
        {
            get
            {
                return _phyDefenseNum;
            } 
            
        }
        private int _magAttackNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(22)]
        [EntityField("MagAttackNum")]
        public int MagAttackNum
        {
            get
            {
                return _magAttackNum;
            } 
            
        }
        private int _magDefenseNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(23)]
        [EntityField("MagDefenseNum")]
        public int MagDefenseNum
        {
            get
            {
                return _magDefenseNum;
            } 
            
        }
        private int _abiAttackNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(24)]
        [EntityField("AbiAttackNum")]
        public int AbiAttackNum
        {
            get
            {
                return _abiAttackNum;
            } 
            
        }
        private int _abiDefenseNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(25)]
        [EntityField("AbiDefenseNum")]
        public int AbiDefenseNum
        {
            get
            {
                return _abiDefenseNum;
            } 
            
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "MonsterID": return _monsterID;
                    case "HeadID": return _headID;
                    case "GeneralName": return _generalName;
                    case "GeneralLv": return _generalLv;
                    case "LifeNum": return _lifeNum;
                    case "CareerID": return _careerID;
                    case "PowerNum": return _powerNum;
                    case "SoulNum": return _soulNum;
                    case "IntellectNum": return _intellectNum;
                    case "AbilityID": return _abilityID;
                    case "AbilityLv": return _abilityLv;
                    case "MomentumNum": return _momentumNum;
                    case "BaojiNum": return _baojiNum;
                    case "RenxingNum": return _renxingNum;
                    case "HitNum": return _hitNum;
                    case "ShanbiNum": return _shanbiNum;
                    case "GedangNum": return _gedangNum;
                    case "PojiNum": return _pojiNum;
                    case "BishaNum": return _bishaNum;
                    case "PhyAttackNum": return _phyAttackNum;
                    case "PhyDefenseNum": return _phyDefenseNum;
                    case "MagAttackNum": return _magAttackNum;
                    case "MagDefenseNum": return _magDefenseNum;
                    case "AbiAttackNum": return _abiAttackNum;
                    case "AbiDefenseNum": return _abiDefenseNum;
					default: throw new ArgumentException(string.Format("SJTMonsterInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "MonsterID": 
                        _monsterID = value.ToInt();
                        break; 
                    case "HeadID": 
                        _headID = value.ToNotNullString();
                        break; 
                    case "GeneralName": 
                        _generalName = value.ToNotNullString();
                        break; 
                    case "GeneralLv": 
                        _generalLv = value.ToShort();
                        break; 
                    case "LifeNum": 
                        _lifeNum = value.ToInt();
                        break; 
                    case "CareerID": 
                        _careerID = value.ToShort();
                        break; 
                    case "PowerNum": 
                        _powerNum = value.ToShort();
                        break; 
                    case "SoulNum": 
                        _soulNum = value.ToShort();
                        break; 
                    case "IntellectNum": 
                        _intellectNum = value.ToShort();
                        break; 
                    case "AbilityID": 
                        _abilityID = value.ToInt();
                        break; 
                    case "AbilityLv": 
                        _abilityLv = value.ToInt();
                        break; 
                    case "MomentumNum": 
                        _momentumNum = value.ToInt();
                        break; 
                    case "BaojiNum": 
                        _baojiNum = value.ToDecimal();
                        break; 
                    case "RenxingNum": 
                        _renxingNum = value.ToDecimal();
                        break; 
                    case "HitNum": 
                        _hitNum = value.ToDecimal();
                        break; 
                    case "ShanbiNum": 
                        _shanbiNum = value.ToDecimal();
                        break; 
                    case "GedangNum": 
                        _gedangNum = value.ToDecimal();
                        break; 
                    case "PojiNum": 
                        _pojiNum = value.ToDecimal();
                        break; 
                    case "BishaNum": 
                        _bishaNum = value.ToDecimal();
                        break; 
                    case "PhyAttackNum": 
                        _phyAttackNum = value.ToInt();
                        break; 
                    case "PhyDefenseNum": 
                        _phyDefenseNum = value.ToInt();
                        break; 
                    case "MagAttackNum": 
                        _magAttackNum = value.ToInt();
                        break; 
                    case "MagDefenseNum": 
                        _magDefenseNum = value.ToInt();
                        break; 
                    case "AbiAttackNum": 
                        _abiAttackNum = value.ToInt();
                        break; 
                    case "AbiDefenseNum": 
                        _abiDefenseNum = value.ToInt();
                        break; 
					default: throw new ArgumentException(string.Format("SJTMonsterInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion

	}
}