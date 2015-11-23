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
    public class GuildAbilityLvInfo : ShareEntity
    {
        public const string Index_ID = "Index_ID";

        
        public GuildAbilityLvInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ID", IsKey = true)]
        public Int32 ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                SetChange("ID", value);
            }
        }
        private Int16 _AbilityLv;
        /// <summary>
        /// 
        /// </summary>
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
        private Int32 _UpDonateNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UpDonateNum")]
        public Int32 UpDonateNum
        {
            get
            {
                return _UpDonateNum;
            }
            private set
            {
                SetChange("UpDonateNum", value);
            }
        }
        private Decimal _EffectNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EffectNum")]
        public Decimal EffectNum
        {
            get
            {
                return _EffectNum;
            }
            private set
            {
                SetChange("EffectNum", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ID": return ID;
                    case "AbilityLv": return AbilityLv;
                    case "UpDonateNum": return UpDonateNum;
                    case "EffectNum": return EffectNum;
					default: throw new ArgumentException(string.Format("GuildAbilityLvInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _ID = value.ToInt(); 
                        break; 
                    case "AbilityLv": 
                        _AbilityLv = value.ToShort(); 
                        break; 
                    case "UpDonateNum": 
                        _UpDonateNum = value.ToInt(); 
                        break; 
                    case "EffectNum": 
                        _EffectNum = value.ToDecimal(); 
                        break; 
					default: throw new ArgumentException(string.Format("GuildAbilityLvInfo index[{0}] isn't exist.", index));
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