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
    /// 培养配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class BringUpInfo : ShareEntity
    {


        public BringUpInfo()
            : base(AccessLevel.ReadOnly)
        {
            AttributeChance = new AttributeChance();
            AttributeValueChance = new AttributeValueChance();
        }        

        public BringUpInfo(Int32 BringUpType)
            : this()
        {
            this.BringUpType = BringUpType;
        }

        #region 自动生成属性

        private Int32 _BringUpType;
        /// <summary>
        /// 培养类型，主键。参照BringUpType枚举
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("BringUpType", IsKey = true)]
        public Int32 BringUpType
        {
            get
            {
                return _BringUpType;
            }
            private set
            {
                SetChange("BringUpType", value);
            }
        }

        private Int16 _UseUpType;
        /// <summary>
        /// 培养消耗的类型1 :物品2: 晶石
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("UseUpType")]
        public Int16 UseUpType
        {
            get
            {
                return _UseUpType;
            }
            private set
            {
                SetChange("UseUpType", value);
            }
        }

        private Int32 _UseUpNum;
        /// <summary>
        /// 培养消耗的数量
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("UseUpNum")]
        public Int32 UseUpNum
        {
            get
            {
                return _UseUpNum;
            }
            private set
            {
                SetChange("UseUpNum", value);
            }
        }

        private AttributeChance _AttributeChance;
        /// <summary>
        /// 佣兵培养力量,魂力,智力属性概率JSON格式
        /// </summary>        
        [ProtoMember(4)]
        [EntityField(true, ColumnDbType.LongText)]
        public AttributeChance AttributeChance
        {
            get
            {
                return _AttributeChance;
            }
            private set
            {
                SetChange("AttributeChance", value);
            }
        }

        private  AttributeValueChance _AttributeValueChance;
        /// <summary>
        /// 佣兵培养属性值概率JSON格式
        /// </summary>        
        [ProtoMember(5)]
        [EntityField(true, ColumnDbType.LongText)]
        public AttributeValueChance AttributeValueChance
        {
            get
            {
                return _AttributeValueChance;
            }
            private set
            {
                SetChange("AttributeValueChance", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "BringUpType": return BringUpType;
                    case "UseUpType": return UseUpType;
                    case "UseUpNum": return UseUpNum;
                    case "AttributeChance": return AttributeChance;
                    case "AttributeValueChance": return AttributeValueChance;
					default: throw new ArgumentException(string.Format("BringUpInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "BringUpType": 
                        _BringUpType = value.ToInt(); 
                        break; 
                    case "UseUpType": 
                        _UseUpType = value.ToShort(); 
                        break; 
                    case "UseUpNum": 
                        _UseUpNum = value.ToInt(); 
                        break; 
                    case "AttributeChance": 
                        _AttributeChance = ConvertCustomField<AttributeChance>(value, index);
                        break; 
                    case "AttributeValueChance": 
                        _AttributeValueChance = ConvertCustomField<AttributeValueChance>(value, index); 
                        break; 
					default: throw new ArgumentException(string.Format("BringUpInfo index[{0}] isn't exist.", index));
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