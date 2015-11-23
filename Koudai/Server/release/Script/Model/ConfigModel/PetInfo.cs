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
    public class PetInfo : ShareEntity
    {

        
        public PetInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _PetId;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PetId", IsKey = true)]
        public Int32 PetId
        {
            get
            {
                return _PetId;
            }
            private set
            {
                SetChange("PetId", value);
            }
        }
        private String _PetName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PetName")]
        public String PetName
        {
            get
            {
                return _PetName;
            }
            private set
            {
                SetChange("PetName", value);
            }
        }
        private String _PetHead;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PetHead")]
        public String PetHead
        {
            get
            {
                return _PetHead;
            }
            private set
            {
                SetChange("PetHead", value);
            }
        }
        private Int32 _ColdTime;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ColdTime")]
        public Int32 ColdTime
        {
            get
            {
                return _ColdTime;
            }
            private set
            {
                SetChange("ColdTime", value);
            }
        }
        private Decimal _CoinRate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CoinRate")]
        public Decimal CoinRate
        {
            get
            {
                return _CoinRate;
            }
            private set
            {
                SetChange("CoinRate", value);
            }
        }
        private Decimal _ObtainRate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ObtainRate")]
        public Decimal ObtainRate
        {
            get
            {
                return _ObtainRate;
            }
            private set
            {
                SetChange("ObtainRate", value);
            }
        }
        private Decimal _CoinRate2;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CoinRate2")]
        public Decimal CoinRate2
        {
            get
            {
                return _CoinRate2;
            }
            private set
            {
                SetChange("CoinRate2", value);
            }
        }
        private Decimal _ObtainRate2;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ObtainRate2")]
        public Decimal ObtainRate2
        {
            get
            {
                return _ObtainRate2;
            }
            private set
            {
                SetChange("ObtainRate2", value);
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
        private Int32 _Version;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Version")]
        public Int32 Version
        {
            get
            {
                return _Version;
            }
            private set
            {
                SetChange("Version", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "PetId": return PetId;
                    case "PetName": return PetName;
                    case "PetHead": return PetHead;
                    case "ColdTime": return ColdTime;
                    case "CoinRate": return CoinRate;
                    case "ObtainRate": return ObtainRate;
                    case "CoinRate2": return CoinRate2;
                    case "ObtainRate2": return ObtainRate2;
                    case "Light": return Light;
                    case "Version": return Version;
					default: throw new ArgumentException(string.Format("PetInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "PetId": 
                        _PetId = value.ToInt(); 
                        break; 
                    case "PetName": 
                        _PetName = value.ToNotNullString(); 
                        break; 
                    case "PetHead": 
                        _PetHead = value.ToNotNullString(); 
                        break; 
                    case "ColdTime": 
                        _ColdTime = value.ToInt(); 
                        break; 
                    case "CoinRate": 
                        _CoinRate = value.ToDecimal(); 
                        break; 
                    case "ObtainRate": 
                        _ObtainRate = value.ToDecimal(); 
                        break; 
                    case "CoinRate2": 
                        _CoinRate2 = value.ToDecimal(); 
                        break; 
                    case "ObtainRate2": 
                        _ObtainRate2 = value.ToDecimal(); 
                        break; 
                    case "Light": 
                        _Light = value.ToDecimal(); 
                        break; 
                    case "Version": 
                        _Version = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("PetInfo index[{0}] isn't exist.", index));
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