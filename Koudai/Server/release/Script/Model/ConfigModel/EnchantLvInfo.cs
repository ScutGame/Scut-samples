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
    /// 武器附魔符等级配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class EnchantLvInfo : ShareEntity
    {
      
        public EnchantLvInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        

        public EnchantLvInfo(Int32 EnchantID, Int16 EnchantLv)
            : this()
        {
            this.EnchantID = EnchantID;
            this.EnchantLv = EnchantLv;
        }

        #region 自动生成属性

        private Int32 _EnchantID;
        /// <summary>
        /// 附魔符ID，主键
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("EnchantID", IsKey = true)]
        public Int32 EnchantID
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

        private Int16 _EnchantLv;
        /// <summary>
        /// 等级，主键
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("EnchantLv", IsKey = true)]
        public Int16 EnchantLv
        {
            get
            {
                return _EnchantLv;
            }
            private set
            {
                SetChange("EnchantLv", value);
            }
        }

        private Int32 _Experience;
        /// <summary>
        /// 升级经验
        /// </summary>        
        [ProtoMember(3)]
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

        private Decimal _Num;
        /// <summary>
        /// 属性值
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("Num")]
        public Decimal Num
        {
            get
            {
                return _Num;
            }
            private set
            {
                SetChange("Num", value);
            }
        }

        private Int32 _CoinPrice;
        /// <summary>
        ///  出售获得的金币
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("CoinPrice")]
        public Int32 CoinPrice
        {
            get
            {
                return _CoinPrice;
            }
            private set
            {
                SetChange("CoinPrice", value);
            }
        }

        private Int32 _MoJingPrice;
        /// <summary>
        /// 出售获得的魔晶
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("MoJingPrice")]
        public Int32 MoJingPrice
        {
            get
            {
                return _MoJingPrice;
            }
            private set
            {
                SetChange("MoJingPrice", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "EnchantID": return EnchantID;
                    case "EnchantLv": return EnchantLv;
                    case "Experience": return Experience;
                    case "Num": return Num;
                    case "CoinPrice": return CoinPrice;
                    case "MoJingPrice": return MoJingPrice;
					default: throw new ArgumentException(string.Format("EnchantLvInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "EnchantID": 
                        _EnchantID = value.ToInt(); 
                        break; 
                    case "EnchantLv": 
                        _EnchantLv = value.ToShort(); 
                        break; 
                    case "Experience": 
                        _Experience = value.ToInt(); 
                        break; 
                    case "Num": 
                        _Num = value.ToDecimal(); 
                        break; 
                    case "CoinPrice": 
                        _CoinPrice = value.ToInt(); 
                        break; 
                    case "MoJingPrice": 
                        _MoJingPrice = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("EnchantLvInfo index[{0}] isn't exist.", index));
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