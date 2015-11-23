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
    /// 魂技等级表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class AbilityLvInfo : ShareEntity
    {


        public AbilityLvInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        

        public AbilityLvInfo(Int32 AbilityID, Int16 Lv)
            : this()
        {
            this.AbilityID = AbilityID;
            this.Lv = Lv;
        }

        #region 自动生成属性

        private Int32 _AbilityID;
        /// <summary>
        /// 魂技ID，主键 
        /// </summary>        
        [ProtoMember(1)]
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

        private Int16 _Lv;
        /// <summary>
        /// 等级，主键
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("Lv", IsKey = true)]
        public Int16 Lv
        {
            get
            {
                return _Lv;
            }
            private set
            {
                SetChange("Lv", value);
            }
        }

        private Int32 _Experience;
        /// <summary>
        /// 升级所需经验
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
        private Boolean _IsMaxLv;
        /// <summary>
        /// 是否最高等级0：False否1：True是
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("IsMaxLv")]
        public Boolean IsMaxLv
        {
            get
            {
                return _IsMaxLv;
            }
            private set
            {
                SetChange("IsMaxLv", value);
            }
        }
        private Decimal _EffectValue;
        /// <summary>
        /// 等级效果加成值
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("EffectValue")]
        public Decimal EffectValue
        {
            get
            {
                return _EffectValue;
            }
            private set
            {
                SetChange("EffectValue", value);
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
                    case "Lv": return Lv;
                    case "Experience": return Experience;
                    case "IsMaxLv": return IsMaxLv;
                    case "EffectValue": return EffectValue;
					default: throw new ArgumentException(string.Format("AbilityLvInfo index[{0}] isn't exist.", index));
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
                    case "Lv": 
                        _Lv = value.ToShort(); 
                        break; 
                    case "Experience": 
                        _Experience = value.ToInt(); 
                        break;
                    case "IsMaxLv":
				        _IsMaxLv = value.ToBool();
                        break;
                    case "EffectValue":
                        _EffectValue = value.ToDecimal();
                        break; 
					default: throw new ArgumentException(string.Format("AbilityLvInfo index[{0}] isn't exist.", index));
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