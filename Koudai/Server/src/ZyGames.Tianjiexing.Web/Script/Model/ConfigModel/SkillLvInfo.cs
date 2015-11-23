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
    ///  法宝技能等级配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class SkillLvInfo : ShareEntity
    {

        public SkillLvInfo()
            : base(AccessLevel.ReadOnly)
        {
          
        }

        public SkillLvInfo(Int16 SkillID, Int16 SkillLv)
            : this()
        {
            this.SkillID = SkillID;
            this.SkillLv = SkillLv;
        }

        #region 自动生成属性

        private Int16 _SkillID;
        /// <summary>
        ///  技能ID，主键
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("SkillID", IsKey = true)]
        public Int16 SkillID
        {
            get
            {
                return _SkillID;
            }
            private set
            {
                SetChange("SkillID", value);
            }
        }

        private Int16 _SkillLv;
        /// <summary>
        ///  等级，主键
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("SkillLv", IsKey = true)]
        public Int16 SkillLv
        {
            get
            {
                return _SkillLv;
            }
            private set
            {
                SetChange("SkillLv", value);
            }
        }

        private Decimal _Probability;
        /// <summary>
        /// 技能使用几率
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("Probability")]
        public Decimal Probability
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

        private Decimal _Tnum;
        /// <summary>
        /// 特定值
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("Tnum")]
        public decimal Tnum
        {
            get
            {
                return _Tnum;
            }
            private set
            {
                SetChange("Tnum", value);
            }
        }

        private string _Action;

        /// <summary>
        /// 触发动作
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("Action")]
        public string Action
        {
            get
            {
                return _Action;
            }
            private set
            {
                SetChange("Action", value);
            }
        }

        private AbilityType _EffType;

        /// <summary>
        /// 效果技能类型 参照AbilityType枚举
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("EffType")]
        public AbilityType EffType
        {
            get
            {
                return _EffType;
            }
            private set
            {
                SetChange("EffType", value);
            }
        }


        private decimal _EffNum;
        /// <summary>
        /// 加成值
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("EffNum")]
        public decimal EffNum
        {
            get
            {
                return _EffNum;
            }
            private set
            {
                SetChange("EffNum", value);
            }
        }


        private Int32 _ItemID;
        /// <summary>
        ///  升级消耗物品
        /// </summary>        
        [ProtoMember(9)]
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

        private Int32 _ItemNum;
        /// <summary>
        /// 升级消耗物品数量
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("ItemNum")]
        public Int32 ItemNum
        {
            get
            {
                return _ItemNum;
            }
            private set
            {
                SetChange("ItemNum", value);
            }
        }

        private Int32 _GameCoin;
        /// <summary>
        /// 升级消耗金币
        /// </summary>        
        [ProtoMember(11)]
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

        private Int32 _ObtainNum;
        /// <summary>
        /// 升级消耗声望
        /// </summary>        
        [ProtoMember(12)]
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

        private Decimal _Coefficient;
        /// <summary>
        /// 折算系数
        /// </summary>        
        [ProtoMember(13)]
        [EntityField("Coefficient")]
        public Decimal Coefficient
        {
            get
            {
                return _Coefficient;
            }
            private set
            {
                SetChange("Coefficient", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "SkillID": return SkillID;
                    case "SkillLv": return SkillLv;
                    case "Probability": return Probability;
                    case "Tnum": return Tnum;
                    case "Action": return Action;
                    case "EffType": return EffType;
                    case "EffNum": return EffNum;
                    case "ItemID": return ItemID;
                    case "ItemNum": return ItemNum;
                    case "GameCoin": return GameCoin;
                    case "ObtainNum": return ObtainNum;
                    case "Coefficient": return Coefficient;
                    default: throw new ArgumentException(string.Format("SkillLvInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "SkillID":
                        _SkillID = value.ToShort();
                        break;
                    case "SkillLv":
                        _SkillLv = value.ToShort();
                        break;
                    case "Probability":
                        _Probability = value.ToDecimal();
                        break;
                    case "Tnum": _Tnum = value.ToDecimal();
                        break;
                    case "Action":
                        _Action = value.ToNotNullString();
                        break;
                    case "EffType":
                        _EffType = value.ToEnum<AbilityType>();
                        break;
                    case "EffNum":
                        _EffNum = value.ToDecimal();
                        break;
                    case "ItemID":
                        _ItemID = value.ToInt();
                        break;
                    case "ItemNum":
                        _ItemNum = value.ToInt();
                        break;
                    case "GameCoin":
                        _GameCoin = value.ToInt();
                        break;
                    case "ObtainNum":
                        _ObtainNum = value.ToInt();
                        break;
                    case "Coefficient":
                        _Coefficient = value.ToDecimal();
                        break;
                    default: throw new ArgumentException(string.Format("SkillLvInfo index[{0}] isn't exist.", index));
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