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
    public class CrystalInfo : ShareEntity
    {
        public const string Index_CrystalQuality = "Index_CrystalQuality";
        
        public CrystalInfo()
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
        private String _CrystalName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CrystalName")]
        public String CrystalName
        {
            get
            {
                return _CrystalName;
            }
            private set
            {
                SetChange("CrystalName", value);
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
        private CrystalQualityType _CrystalQuality;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CrystalQuality")]
        public CrystalQualityType CrystalQuality
        {
            get
            {
                return _CrystalQuality;
            }
            private set
            {
                SetChange("CrystalQuality", value);
            }
        }
        private AbilityType _AbilityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityID")]
        public AbilityType AbilityID
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
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
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
        private Int32 _Price;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Price")]
        public Int32 Price
        {
            get
            {
                return _Price;
            }
            private set
            {
                SetChange("Price", value);
            }
        }
        private Int32 _IsTelegrams;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsTelegrams")]
        public Int32 IsTelegrams
        {
            get
            {
                return _IsTelegrams;
            }
            private set
            {
                SetChange("IsTelegrams", value);
            }
        }
        private Int16 _DemandLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("DemandLv")]
        public Int16 DemandLv
        {
            get
            {
                return _DemandLv;
            }
            private set
            {
                SetChange("DemandLv", value);
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
                    case "CrystalName": return CrystalName;
                    case "HeadID": return HeadID;
                    case "CrystalQuality": return CrystalQuality;
                    case "AbilityID": return AbilityID;
                    case "Experience": return Experience;
                    case "Price": return Price;
                    case "IsTelegrams": return IsTelegrams;
                    case "DemandLv": return DemandLv;
					default: throw new ArgumentException(string.Format("CrystalInfo index[{0}] isn't exist.", index));
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
                    case "CrystalName": 
                        _CrystalName = value.ToNotNullString(); 
                        break; 
                    case "HeadID": 
                        _HeadID = value.ToNotNullString(); 
                        break; 
                    case "CrystalQuality":
                        _CrystalQuality = value.ToEnum<CrystalQualityType>(); 
                        break; 
                    case "AbilityID":
                        _AbilityID = value.ToEnum<AbilityType>(); 
                        break; 
                    case "Experience": 
                        _Experience = value.ToInt(); 
                        break; 
                    case "Price": 
                        _Price = value.ToInt(); 
                        break; 
                    case "IsTelegrams": 
                        _IsTelegrams = value.ToInt(); 
                        break; 
                    case "DemandLv": 
                        _DemandLv = value.ToShort(); 
                        break; 
					default: throw new ArgumentException(string.Format("CrystalInfo index[{0}] isn't exist.", index));
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