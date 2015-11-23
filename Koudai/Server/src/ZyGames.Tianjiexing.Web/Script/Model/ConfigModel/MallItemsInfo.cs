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
using ZyGames.Tianjiexing.Model.Enum;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]

    public class MallItemsInfo : ShareEntity
    {

        public const string Index_CityID_MallType = "Index_CityID_MallType";


        public MallItemsInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        #region auto-generated Property
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemID", IsKey = true)]
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
        private ShopType _MallType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MallType", IsKey = true)]
        public ShopType MallType
        {
            get
            {
                return _MallType;
            }
            private set
            {
                SetChange("MallType", value);
            }
        }
        private Int32 _QishiID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("QishiID")]
        public Int32 QishiID
        {
            get
            {
                return _QishiID;
            }
            private set
            {
                SetChange("QishiID", value);
            }
        }
        private Int32 _SeqNO;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SeqNO")]
        public Int32 SeqNO
        {
            get
            {
                return _SeqNO;
            }
            private set
            {
                SetChange("SeqNO", value);
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
        private String _OpenFilter;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("OpenFilter")]
        public String OpenFilter
        {
            get
            {
                return _OpenFilter;
            }
            private set
            {
                SetChange("OpenFilter", value);
            }
        }

        private Int32 _SpecialPrice;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SpecialPrice")]
        public Int32 SpecialPrice
        {
            get
            {
                return _SpecialPrice;
            }
            private set
            {
                SetChange("SpecialPrice", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ItemID": return ItemID;
                    case "CityID": return CityID;
                    case "MallType": return MallType;
                    case "QishiID": return QishiID;
                    case "SeqNO": return SeqNO;
                    case "Price": return Price;
                    case "OpenFilter": return OpenFilter;
                    case "SpecialPrice": return SpecialPrice;
                    default: throw new ArgumentException(string.Format("MallItemsInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ItemID":
                        _ItemID = value.ToInt();
                        break;
                    case "CityID":
                        _CityID = value.ToInt();
                        break;
                    case "MallType":
                        _MallType = value.ToEnum<ShopType>();
                        break;
                    case "QishiID":
                        _QishiID = value.ToInt();
                        break;
                    case "SeqNO":
                        _SeqNO = value.ToInt();
                        break;
                    case "Price":
                        _Price = value.ToInt();
                        break;
                    case "OpenFilter":
                        _OpenFilter = value.ToNotNullString();
                        break;
                    case "SpecialPrice":
                        _SpecialPrice = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("MallItemsInfo index[{0}] isn't exist.", index));
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