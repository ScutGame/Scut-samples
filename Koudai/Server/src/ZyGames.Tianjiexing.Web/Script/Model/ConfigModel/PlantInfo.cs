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
    public class PlantInfo : ShareEntity
    {

        
        public PlantInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int16 _GeneralLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GeneralLv", IsKey = true)]
        public Int16 GeneralLv
        {
            get
            {
                return _GeneralLv;
            }
            private set
            {
                SetChange("GeneralLv", value);
            }
        }
        private Int16 _PlantType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlantType", IsKey = true)]
        public Int16 PlantType
        {
            get
            {
                return _PlantType;
            }
            private set
            {
                SetChange("PlantType", value);
            }
        }
        private PlantQualityType _PlantQualityType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlantQualityType", IsKey = true)]
        public PlantQualityType PlantQualityType
        {
            get
            {
                return _PlantQualityType;
            }
            private set
            {
                SetChange("PlantQualityType", value);
            }
        }
        private Int32 _GainNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GainNum")]
        public Int32 GainNum
        {
            get
            {
                return _GainNum;
            }
            private set
            {
                SetChange("GainNum", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "GeneralLv": return GeneralLv;
                    case "PlantType": return PlantType;
                    case "PlantQualityType": return PlantQualityType;
                    case "GainNum": return GainNum;
					default: throw new ArgumentException(string.Format("PlantInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "GeneralLv": 
                        _GeneralLv = value.ToShort(); 
                        break; 
                    case "PlantType": 
                        _PlantType = value.ToShort(); 
                        break; 
                    case "PlantQualityType":
                        _PlantQualityType = value.ToEnum<PlantQualityType>(); 
                        break; 
                    case "GainNum": 
                        _GainNum = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("PlantInfo index[{0}] isn't exist.", index));
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