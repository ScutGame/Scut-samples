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
    /// 法宝随机属性配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class TrumpPropertyInfo : ShareEntity
    {
        /// <summary>
        /// 附加属性最高等级
        /// </summary>
        public static short MaxTrumpPropertyLv = ConfigEnvSet.GetInt("TrumpProperty.MaxTrumpPropertyLv").ToShort();
        public TrumpPropertyInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        public TrumpPropertyInfo(AbilityType AbilityType, Int16 AbilityLv)
            : this()
        {
            this.AbilityType = AbilityType;
            this.AbilityLv = AbilityLv;
        }

        #region 自动生成属性

        private AbilityType _AbilityType;
        /// <summary>
        /// 随机属性类型，主键 参照AbilityType枚举
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("AbilityType", IsKey = true)]
        public AbilityType AbilityType
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

        private Int16 _AbilityLv;
        /// <summary>
        /// 随机属性等级，主键
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("AbilityLv", IsKey = true)]
        public Int16 AbilityLv
        {
            get
            {
                return _AbilityLv;
            }
            private set
            {
                SetChange("AbilityLv", value);
            }
        }

        private Decimal _PropertyNum;
        /// <summary>
        /// 随机属性加值
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("PropertyNum")]
        public Decimal PropertyNum
        {
            get
            {
                return _PropertyNum;
            }
            private set
            {
                SetChange("PropertyNum", value);
            }
        }

        private Int32 _ItemID;
        /// <summary>
        /// 升级该等级随机属性需要消耗的物品
        /// </summary>        
        [ProtoMember(4)]
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
        /// 消耗该物品的数量
        /// </summary>        
        [ProtoMember(5)]
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
        /// 消耗金币
        /// </summary>        
        [ProtoMember(6)]
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
        /// 消耗声望
        /// </summary>        
        [ProtoMember(7)]
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

        private Decimal _SuccessNum;
        /// <summary>
        ///  升级成功率
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("SuccessNum")]
        public Decimal SuccessNum
        {
            get
            {
                return _SuccessNum;
            }
            private set
            {
                SetChange("SuccessNum", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "AbilityType": return AbilityType;
                    case "AbilityLv": return AbilityLv;
                    case "PropertyNum": return PropertyNum;
                    case "ItemID": return ItemID;
                    case "ItemNum": return ItemNum;
                    case "GameCoin": return GameCoin;
                    case "ObtainNum": return ObtainNum;
                    case "SuccessNum": return SuccessNum;
					default: throw new ArgumentException(string.Format("TrumpPropertyInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "AbilityType":
                        _AbilityType = value.ToEnum<AbilityType>();
                        break; 
                    case "AbilityLv": 
                        _AbilityLv = value.ToShort(); 
                        break; 
                    case "PropertyNum": 
                        _PropertyNum = value.ToDecimal(); 
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
                    case "SuccessNum": 
                        _SuccessNum = value.ToDecimal(); 
                        break; 
					default: throw new ArgumentException(string.Format("TrumpPropertyInfo index[{0}] isn't exist.", index));
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