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
    /// ���������ֲ
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data, OrderColumn = " LandPositon")]

    public class UserLand : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;

        public int LandCodeTime = ConfigEnvSet.GetInt("UserLand.LandCodeTime");

        public UserLand()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public String UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                SetChange("UserID", value);
            }
        }
        private Int32 _LandPositon;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("LandPositon", IsKey = true)]
        public Int32 LandPositon
        {
            get
            {
                return _LandPositon;
            }
            set
            {
                SetChange("LandPositon", value);
            }
        }
        private Int32 _GeneralID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("GeneralID")]
        public Int32 GeneralID
        {
            get
            {
                return _GeneralID;
            }
            set
            {
                SetChange("GeneralID", value);
            }
        }
        private PlantType _PlantType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("PlantType")]
        public PlantType PlantType
        {
            get
            {
                return _PlantType;
            }
            set
            {
                SetChange("PlantType", value);
            }
        }
        private Int16 _IsGain;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("IsGain")]
        public Int16 IsGain
        {
            get
            {
                return _IsGain;
            }
            set
            {
                SetChange("IsGain", value);
            }
        }
        private Int16 _IsRedLand;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("IsRedLand")]
        public Int16 IsRedLand
        {
            get
            {
                return _IsRedLand;
            }
            set
            {
                SetChange("IsRedLand", value);
            }
        }
        private Int16 _IsBlackLand;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("IsBlackLand")]
        public Int16 IsBlackLand
        {
            get
            {
                return _IsBlackLand;
            }
            set
            {
                SetChange("IsBlackLand", value);
            }
        }
        private DateTime _GainDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("GainDate")]
        public DateTime GainDate
        {
            get
            {
                return _GainDate;
            }
            set
            {
                SetChange("GainDate", value);
            }
        }
        private PlantQualityType _PlantQuality;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("PlantQuality")]
        public PlantQualityType PlantQuality
        {
            get
            {
                return _PlantQuality;
            }
            set
            {
                SetChange("PlantQuality", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "UserID": return UserID;
                    case "LandPositon": return LandPositon;
                    case "GeneralID": return GeneralID;
                    case "PlantType": return PlantType;
                    case "IsGain": return IsGain;
                    case "IsRedLand": return IsRedLand;
                    case "IsBlackLand": return IsBlackLand;
                    case "GainDate": return GainDate;
                    case "PlantQuality": return PlantQuality;
                    default: throw new ArgumentException(string.Format("UserLand index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "LandPositon":
                        _LandPositon = value.ToInt();
                        break;
                    case "GeneralID":
                        _GeneralID = value.ToInt();
                        break;
                    case "PlantType":
                        _PlantType = value.ToEnum<PlantType>();
                        break;
                    case "IsGain":
                        _IsGain = value.ToShort();
                        break;
                    case "IsRedLand":
                        _IsRedLand = value.ToShort();
                        break;
                    case "IsBlackLand":
                        _IsBlackLand = value.ToShort();
                        break;
                    case "GainDate":
                        _GainDate = value.ToDateTime();
                        break;
                    case "PlantQuality":
                        _PlantQuality = value.ToEnum<PlantQualityType>();
                        break;
                    default: throw new ArgumentException(string.Format("UserLand index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID.ToInt();
        }
        /// <summary>
        /// ˢ����ȴʱ��
        /// </summary>
        /// <returns>����ʣ����ȴʱ��</returns>
        public int DoRefresh()
        {
            int coldTime = 0;
            TimeSpan ts = DateTime.Now - GainDate;
            coldTime = MathUtils.Subtraction(LandCodeTime, (int)Math.Floor(ts.TotalSeconds), 0);
            return coldTime;
        }
    }
}