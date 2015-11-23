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
    /// ��ҳ�ֵͳ����Ϣ
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data, OrderColumn = " ChargeDate")]
    public class UserRecharge : BaseEntity
    {


        public UserRecharge()
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
        private Int32 _MonthNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("MonthNum")]
        public Int32 MonthNum
        {
            get
            {
                return _MonthNum;
            }
            set
            {
                SetChange("MonthNum", value);
            }
        }
        private Int32 _WeekNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("WeekNum")]
        public Int32 WeekNum
        {
            get
            {
                return _WeekNum;
            }
            set
            {
                SetChange("WeekNum", value);
            }
        }
        private DateTime _ChargeDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("ChargeDate")]
        public DateTime ChargeDate
        {
            get
            {
                return _ChargeDate;
            }
            set
            {
                SetChange("ChargeDate", value);
            }
        }
        private Int32 _TotalGoldNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("TotalGoldNum")]
        public Int32 TotalGoldNum
        {
            get
            {
                return _TotalGoldNum;
            }
            set
            {
                SetChange("TotalGoldNum", value);
            }
        }
        private Int32 _FirstNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("FirstNum")]
        public Int32 FirstNum
        {
            get
            {
                return _FirstNum;
            }
            set
            {
                SetChange("FirstNum", value);
            }
        }
        private Int32 _LastNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("LastNum")]
        public Int32 LastNum
        {
            get
            {
                return _LastNum;
            }
            set
            {
                SetChange("LastNum", value);
            }
        }
        private Int32 _FestivalCount;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("FestivalCount")]
        public Int32 FestivalCount
        {
            get
            {
                return _FestivalCount;
            }
            set
            {
                SetChange("FestivalCount", value);
            }
        }
        private DateTime _FestivalDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("FestivalDate")]
        public DateTime FestivalDate
        {
            get
            {
                return _FestivalDate;
            }
            set
            {
                SetChange("FestivalDate", value);
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
                    case "MonthNum": return MonthNum;
                    case "WeekNum": return WeekNum;
                    case "ChargeDate": return ChargeDate;
                    case "TotalGoldNum": return TotalGoldNum;
                    case "FirstNum": return FirstNum;
                    case "LastNum": return LastNum;
                    case "FestivalCount": return FestivalCount;
                    case "FestivalDate": return FestivalDate;
                    default: throw new ArgumentException(string.Format("UserRecharge index[{0}] isn't exist.", index));
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
                    case "MonthNum":
                        _MonthNum = value.ToInt();
                        break;
                    case "WeekNum":
                        _WeekNum = value.ToInt();
                        break;
                    case "ChargeDate":
                        _ChargeDate = value.ToDateTime();
                        break;
                    case "TotalGoldNum":
                        _TotalGoldNum = value.ToInt();
                        break;
                    case "FirstNum":
                        _FirstNum = value.ToInt();
                        break;
                    case "LastNum":
                        _LastNum = value.ToInt();
                        break;
                    case "FestivalCount":
                        _FestivalCount = value.ToInt();
                        break;
                    case "FestivalDate":
                        _FestivalDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserRecharge index[{0}] isn't exist.", index));
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