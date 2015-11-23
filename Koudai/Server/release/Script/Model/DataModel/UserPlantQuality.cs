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
    ///�����ֲѡ��Ʒ����Ϣ 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]

    public class UserPlantQuality : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;

        public UserPlantQuality()
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
        private Int32 _GeneralID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("GeneralID", IsKey = true)]
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
        [ProtoMember(3)]
        [EntityField("PlantType", IsKey = true)]
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
        private PlantQualityType _PlantQuality;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
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
        private Int32 _RefreshNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("RefreshNum")]
        public Int32 RefreshNum
        {
            get
            {
                return _RefreshNum;
            }
            set
            {
                SetChange("RefreshNum", value);
            }
        }
        private DateTime _RefreshDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("RefreshDate")]
        public DateTime RefreshDate
        {
            get
            {
                return _RefreshDate;
            }
            set
            {
                SetChange("RefreshDate", value);
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
                    case "GeneralID": return GeneralID;
                    case "PlantType": return PlantType;
                    case "PlantQuality": return PlantQuality;
                    case "RefreshNum": return RefreshNum;
                    case "RefreshDate": return RefreshDate;
                    default: throw new ArgumentException(string.Format("UserPlantQuality index[{0}] isn't exist.", index));
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
                    case "GeneralID":
                        _GeneralID = value.ToInt();
                        break;
                    case "PlantType":
                        _PlantType = value.ToEnum<PlantType>();
                        break;
                    case "PlantQuality":
                        _PlantQuality = value.ToEnum<PlantQualityType>();
                        break;
                    case "RefreshNum":
                        _RefreshNum = value.ToInt();
                        break;
                    case "RefreshDate":
                        _RefreshDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserPlantQuality index[{0}] isn't exist.", index));
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
    }
}