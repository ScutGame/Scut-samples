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
    public class CityInfo : ShareEntity
    {


        public CityInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        #region auto-generated Property
        private Int32 _CityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CityID", IsKey = true)]
        public Int32 CityID
        {
            get
            {
                return _CityID;
            }
            private set
            {
                SetChange("CityID", value);
            }
        }
        private short _CityType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CityType")]
        public short CityType
        {
            get
            {
                return _CityType;
            }
            private set
            {
                SetChange("CityType", value);
            }
        }
        private String _CityName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CityName")]
        public String CityName
        {
            get
            {
                return _CityName;
            }
            private set
            {
                SetChange("CityName", value);
            }
        }
        private String _PreCityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PreCityID")]
        public String PreCityID
        {
            get
            {
                return _PreCityID;
            }
            private set
            {
                SetChange("PreCityID", value);
            }
        }
        private Int16 _PointX;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PointX")]
        public Int16 PointX
        {
            get
            {
                return _PointX;
            }
            private set
            {
                SetChange("PointX", value);
            }
        }
        private Int16 _PointY;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PointY")]
        public Int16 PointY
        {
            get
            {
                return _PointY;
            }
            private set
            {
                SetChange("PointY", value);
            }
        }
        private Int16 _GoPointY1;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GoPointY1")]
        public Int16 GoPointY1
        {
            get
            {
                return _GoPointY1;
            }
            private set
            {
                SetChange("GoPointY1", value);
            }
        }
        private Int16 _GoPointY2;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GoPointY2")]
        public Int16 GoPointY2
        {
            get
            {
                return _GoPointY2;
            }
            private set
            {
                SetChange("GoPointY2", value);
            }
        }
        private Int16 _MinLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MinLv")]
        public Int16 MinLv
        {
            get
            {
                return _MinLv;
            }
            private set
            {
                SetChange("MinLv", value);
            }
        }
        private Int16 _MaxLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MaxLv")]
        public Int16 MaxLv
        {
            get
            {
                return _MaxLv;
            }
            private set
            {
                SetChange("MaxLv", value);
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
        private String _BgScence;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BgScence")]
        public String BgScence
        {
            get
            {
                return _BgScence;
            }
            private set
            {
                SetChange("BgScence", value);
            }
        }
        private String _FgScence;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("FgScence")]
        public String FgScence
        {
            get
            {
                return _FgScence;
            }
            private set
            {
                SetChange("FgScence", value);
            }
        }
        private String _CityShowFilter;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CityShowFilter")]
        public String CityShowFilter
        {
            get
            {
                return _CityShowFilter;
            }
            private set
            {
                SetChange("CityShowFilter", value);
            }
        }
        private CountryType _CountryID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CountryID")]
        public CountryType CountryID
        {
            get
            {
                return _CountryID;
            }
            private set
            {
                SetChange("CountryID", value);
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
                    case "CityID": return CityID;
                    case "CityType": return CityType;
                    case "CityName": return CityName;
                    case "PreCityID": return PreCityID;
                    case "PointX": return PointX;
                    case "PointY": return PointY;
                    case "GoPointY1": return GoPointY1;
                    case "GoPointY2": return GoPointY2;
                    case "MinLv": return MinLv;
                    case "MaxLv": return MaxLv;
                    case "HeadID": return HeadID;
                    case "BgScence": return BgScence;
                    case "FgScence": return FgScence;
                    case "CityShowFilter": return CityShowFilter;
                    case "CountryID": return CountryID;
                    case "Version": return Version;
                    default: throw new ArgumentException(string.Format("CityInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "CityID":
                        _CityID = value.ToInt();
                        break;
                    case "CityType":
                        _CityType = value.ToShort();
                        break;
                    case "CityName":
                        _CityName = value.ToNotNullString();
                        break;
                    case "PreCityID":
                        _PreCityID = value.ToNotNullString();
                        break;
                    case "PointX":
                        _PointX = value.ToShort();
                        break;
                    case "PointY":
                        _PointY = value.ToShort();
                        break;
                    case "GoPointY1":
                        _GoPointY1 = value.ToShort();
                        break;
                    case "GoPointY2":
                        _GoPointY2 = value.ToShort();
                        break;
                    case "MinLv":
                        _MinLv = value.ToShort();
                        break;
                    case "MaxLv":
                        _MaxLv = value.ToShort();
                        break;
                    case "HeadID":
                        _HeadID = value.ToNotNullString();
                        break;
                    case "BgScence":
                        _BgScence = value.ToNotNullString();
                        break;
                    case "FgScence":
                        _FgScence = value.ToNotNullString();
                        break;
                    case "CityShowFilter":
                        _CityShowFilter = value.ToNotNullString();
                        break;
                    case "CountryID":
                        _CountryID = value.ToEnum<CountryType>();
                        break;
                    case "Version":
                        _Version = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("CityInfo index[{0}] isn't exist.", index));
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