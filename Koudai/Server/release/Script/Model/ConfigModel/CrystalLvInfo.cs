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
    public class CrystalLvInfo : ShareEntity
    {

        
        public CrystalLvInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _CrystalID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CrystalID", IsKey = true)]
        public Int32 CrystalID
        {
            get
            {
                return _CrystalID;
            }
            private set
            {
                SetChange("CrystalID", value);
            }
        }
        private Int16 _CrystalLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CrystalLv", IsKey = true)]
        public Int16 CrystalLv
        {
            get
            {
                return _CrystalLv;
            }
            private set
            {
                SetChange("CrystalLv", value);
            }
        }
        private Int32 _UpExperience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UpExperience")]
        public Int32 UpExperience
        {
            get
            {
                return _UpExperience;
            }
            private set
            {
                SetChange("UpExperience", value);
            }
        }
        private Decimal _AbilityNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityNum")]
        public Decimal AbilityNum
        {
            get
            {
                return _AbilityNum;
            }
            private set
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
                    case "CrystalID": return CrystalID;
                    case "CrystalLv": return CrystalLv;
                    case "UpExperience": return UpExperience;
                    case "AbilityNum": return AbilityNum;
					default: throw new ArgumentException(string.Format("CrystalLvInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "CrystalID": 
                        _CrystalID = value.ToInt(); 
                        break; 
                    case "CrystalLv": 
                        _CrystalLv = value.ToShort(); 
                        break; 
                    case "UpExperience": 
                        _UpExperience = value.ToInt(); 
                        break; 
                    case "AbilityNum": 
                        _AbilityNum = value.ToDecimal(); 
                        break; 
					default: throw new ArgumentException(string.Format("CrystalLvInfo index[{0}] isn't exist.", index));
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