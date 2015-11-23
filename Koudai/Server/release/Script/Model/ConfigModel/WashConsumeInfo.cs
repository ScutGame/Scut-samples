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
    /// 法宝洗练消耗物品配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]

    public class WashConsumeInfo : ShareEntity
    {
        public const string Index_TrumpID = "Index_TrumpID";

        public WashConsumeInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        

        public WashConsumeInfo(Int32 TrumpID, Int16 MatureType)
            : this()
        {
            this.TrumpID = TrumpID;
            this.MatureType = MatureType;
        }

        #region 自动生成属性

        private Int32 _TrumpID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("TrumpID", IsKey = true)]
        public Int32 TrumpID
        {
            get
            {
                return _TrumpID;
            }
            private set
            {
                SetChange("TrumpID", value);
            }
        }

        private Int16 _MatureType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("MatureType", IsKey = true)]
        public Int16 MatureType
        {
            get
            {
                return _MatureType;
            }
            private set
            {
                SetChange("MatureType", value);
            }
        }

        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
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
        /// 
        /// </summary>        
        [ProtoMember(4)]
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

        private Decimal _SuccessNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
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

        private Int32 _MatureNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("MatureNum")]
        public Int32 MatureNum
        {
            get
            {
                return _MatureNum;
            }
            private set
            {
                SetChange("MatureNum", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "TrumpID": return TrumpID;
                    case "MatureType": return MatureType;
                    case "ItemID": return ItemID;
                    case "ItemNum": return ItemNum;
                    case "SuccessNum": return SuccessNum;
                    case "MatureNum": return MatureNum;
					default: throw new ArgumentException(string.Format("WashConsumeInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "TrumpID": 
                        _TrumpID = value.ToInt(); 
                        break; 
                    case "MatureType": 
                        _MatureType = value.ToShort(); 
                        break; 
                    case "ItemID": 
                        _ItemID = value.ToInt(); 
                        break; 
                    case "ItemNum": 
                        _ItemNum = value.ToInt(); 
                        break; 
                    case "SuccessNum": 
                        _SuccessNum = value.ToDecimal(); 
                        break; 
                    case "MatureNum": 
                        _MatureNum = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("WashConsumeInfo index[{0}] isn't exist.", index));
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