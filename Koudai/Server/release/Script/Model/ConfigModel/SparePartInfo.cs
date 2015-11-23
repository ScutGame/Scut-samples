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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class SparePartInfo : ShareEntity
    {


        public SparePartInfo()
            : base(AccessLevel.ReadOnly)
        {
            PropertyRange = new SparePartProperty[0];
            ResetProperty = new SparePartReset[0];
        }

        #region auto-generated Property
        private Int32 _Id;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Id", IsKey = true)]
        public Int32 Id
        {
            get
            {
                return _Id;
            }
            private set
            {
                SetChange("Id", value);
            }
        }
        private String _Name;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Name")]
        public String Name
        {
            get
            {
                return _Name;
            }
            private set
            {
                SetChange("Name", value);
            }
        }
        private Int16 _QualityType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("QualityType")]
        public Int16 QualityType
        {
            get
            {
                return _QualityType;
            }
            private set
            {
                SetChange("QualityType", value);
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
        private Int32 _CoinPrice;
        /// <summary>
        /// 
        /// </summary>
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
        private Int32 _LingshiPrice;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LingshiPrice")]
        public Int32 LingshiPrice
        {
            get
            {
                return _LingshiPrice;
            }
            private set
            {
                SetChange("LingshiPrice", value);
            }
        }
        private SparePartProperty[] _PropertyRange;
        /// <summary>
        /// ������Է�Χ
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public SparePartProperty[] PropertyRange
        {
            get
            {
                return _PropertyRange;
            }
            private set
            {
                SetChange("PropertyRange", value);
            }
        }
        private SparePartReset[] _ResetProperty;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public SparePartReset[] ResetProperty
        {
            get
            {
                return _ResetProperty;
            }
            private set
            {
                SetChange("ResetProperty", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "Id": return Id;
                    case "Name": return Name;
                    case "QualityType": return QualityType;
                    case "HeadID": return HeadID;
                    case "CoinPrice": return CoinPrice;
                    case "LingshiPrice": return LingshiPrice;
                    case "PropertyRange": return PropertyRange;
                    case "ResetProperty": return ResetProperty;
                    default: throw new ArgumentException(string.Format("SparePartInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "Id":
                        _Id = value.ToInt();
                        break;
                    case "Name":
                        _Name = value.ToNotNullString();
                        break;
                    case "QualityType":
                        _QualityType = value.ToShort();
                        break;
                    case "HeadID":
                        _HeadID = value.ToNotNullString();
                        break;
                    case "CoinPrice":
                        _CoinPrice = value.ToInt();
                        break;
                    case "LingshiPrice":
                        _LingshiPrice = value.ToInt();
                        break;
                    case "PropertyRange":
                        _PropertyRange = value as SparePartProperty[] ?? new SparePartProperty[0];
                        break;
                    case "ResetProperty":
                        _ResetProperty = value as SparePartReset[] ?? new SparePartReset[0];
                        break;
                    default: throw new ArgumentException(string.Format("SparePartInfo index[{0}] isn't exist.", index));
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
        /// <summary>
        /// �Ƿ����
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public static bool IsExist(int itemId)
        {
            return new ShareCacheStruct<SparePartInfo>().FindKey(itemId) != null;
        }

        public SparePartReset GetSparePartReset(int index)
        {
            return index >= 0 && index < ResetProperty.Length
                ? ResetProperty[index]
                : new SparePartReset();
        }
    }
}