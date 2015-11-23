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
    public class ProbabilityInfo : ShareEntity
    {


        public ProbabilityInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        #region auto-generated Property
        private Int32 _HuntingID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HuntingID", IsKey = true)]
        public Int32 HuntingID
        {
            get
            {
                return _HuntingID;
            }
            private set
            {
                SetChange("HuntingID", value);
            }
        }
        private String _HuntingName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HuntingName")]
        public String HuntingName
        {
            get
            {
                return _HuntingName;
            }
            private set
            {
                SetChange("HuntingName", value);
            }
        }
        private Int16 _HuntingType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HuntingType")]
        public Int16 HuntingType
        {
            get
            {
                return _HuntingType;
            }
            private set
            {
                SetChange("HuntingType", value);
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
        private Decimal _Gray;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Gray")]
        public Decimal Gray
        {
            get
            {
                return _Gray;
            }
            private set
            {
                SetChange("Gray", value);
            }
        }
        private Decimal _Green;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Green")]
        public Decimal Green
        {
            get
            {
                return _Green;
            }
            private set
            {
                SetChange("Green", value);
            }
        }
        private Decimal _Blue;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Blue")]
        public Decimal Blue
        {
            get
            {
                return _Blue;
            }
            private set
            {
                SetChange("Blue", value);
            }
        }
        private Decimal _Purple;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Purple")]
        public Decimal Purple
        {
            get
            {
                return _Purple;
            }
            private set
            {
                SetChange("Purple", value);
            }
        }
        private Decimal _Yellow;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Yellow")]
        public Decimal Yellow
        {
            get
            {
                return _Yellow;
            }
            private set
            {
                SetChange("Yellow", value);
            }
        }
        private Decimal _Red;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Red")]
        public Decimal Red
        {
            get
            {
                return _Red;
            }
            private set
            {
                SetChange("Red", value);
            }
        }

        private Int32 _GoldHunting;
        /// <summary>
        /// ��ʯ������Ӧ������
        /// </summary>
        [EntityField("GoldHunting")]
        public Int32 GoldHunting
        {
            get
            {
                return _GoldHunting;
            }
            private set
            {
                SetChange("GoldHunting", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "HuntingID": return HuntingID;
                    case "HuntingName": return HuntingName;
                    case "HuntingType": return HuntingType;
                    case "Price": return Price;
                    case "Light": return Light;
                    case "Gray": return Gray;
                    case "Green": return Green;
                    case "Blue": return Blue;
                    case "Purple": return Purple;
                    case "Yellow": return Yellow;
                    case "Red": return Red;
                    case "GoldHunting": return GoldHunting;
                    default: throw new ArgumentException(string.Format("ProbabilityInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "HuntingID":
                        _HuntingID = value.ToInt();
                        break;
                    case "HuntingName":
                        _HuntingName = value.ToNotNullString();
                        break;
                    case "HuntingType":
                        _HuntingType = value.ToShort();
                        break;
                    case "Price":
                        _Price = value.ToInt();
                        break;
                    case "Light":
                        _Light = value.ToDecimal();
                        break;
                    case "Gray":
                        _Gray = value.ToDecimal();
                        break;
                    case "Green":
                        _Green = value.ToDecimal();
                        break;
                    case "Blue":
                        _Blue = value.ToDecimal();
                        break;
                    case "Purple":
                        _Purple = value.ToDecimal();
                        break;
                    case "Yellow":
                        _Yellow = value.ToDecimal();
                        break;
                    case "Red":
                        _Red = value.ToDecimal();
                        break;
                    case "GoldHunting":
                        _GoldHunting = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("ProbabilityInfo index[{0}] isn't exist.", index));
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