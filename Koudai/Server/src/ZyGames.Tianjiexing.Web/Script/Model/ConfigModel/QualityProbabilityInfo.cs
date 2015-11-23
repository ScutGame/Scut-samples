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
    public class QualityProbabilityInfo : ShareEntity
    {

        
        public QualityProbabilityInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private PlantQualityType _QualityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("QualityID", IsKey = true)]
        public PlantQualityType QualityID
        {
            get
            {
                return _QualityID;
            }
            private set
            {
                SetChange("QualityID", value);
            }
        }
        private String _QualityName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("QualityName")]
        public String QualityName
        {
            get
            {
                return _QualityName;
            }
            private set
            {
                SetChange("QualityName", value);
            }
        }
        private Decimal _Light;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Light")]
        public Decimal Light
        {
            get
            {
                return _Light;
            }
            private set
            {
                SetChange("Light", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "QualityID": return QualityID;
                    case "QualityName": return QualityName;
                    case "Light": return Light;
					default: throw new ArgumentException(string.Format("QualityProbabilityInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "QualityID":
				        _QualityID = value.ToEnum<PlantQualityType>();
                        break; 
                    case "QualityName": 
                        _QualityName = value.ToNotNullString(); 
                        break; 
                    case "Light": 
                        _Light = value.ToDecimal(); 
                        break; 
					default: throw new ArgumentException(string.Format("QualityProbabilityInfo index[{0}] isn't exist.", index));
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