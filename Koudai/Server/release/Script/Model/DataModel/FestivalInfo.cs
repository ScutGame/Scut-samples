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
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Tianjiexing.Model.Enum;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// ���ջ���ñ�
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data, Condition = "IsStop=1")]

    public class FestivalInfo : ShareEntity
    {

        public const string Index_FestivalType = "Index_FestivalType";

        public FestivalInfo()
            : base(AccessLevel.ReadWrite)
        {
            Reward = new CacheList<PrizeInfo>();
            TimePriod = new TimePriod();
            TaskConfig = new CacheList<TaskConfigInfo>();
            FestivalExtend = new FestivalExtend();
        }

        //protected override void BindChangeEvent()
        //{
        //    Reward.BindParentChangeEvent(this);
        //    TimePriod.BindParentChangeEvent(this);
        //    TaskConfig.BindParentChangeEvent(this);
        //    FestivalExtend.BindParentChangeEvent(this);
        //}

        #region auto-generated Property
        private Int32 _FestivalID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("FestivalID", IsKey = true)]
        public Int32 FestivalID
        {
            get
            {
                return _FestivalID;
            }
            set
            {
                SetChange("FestivalID", value);
            }
        }
        private String _FestivalName;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("FestivalName")]
        public String FestivalName
        {
            get
            {
                return _FestivalName;
            }
            set
            {
                SetChange("FestivalName", value);
            }
        }
        private DateTime _StartDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("StartDate")]
        public DateTime StartDate
        {
            get
            {
                return _StartDate;
            }
            set
            {
                SetChange("StartDate", value);
            }
        }
        private Int32 _ContinuedTime;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("ContinuedTime")]
        public Int32 ContinuedTime
        {
            get
            {
                return _ContinuedTime;
            }
            set
            {
                SetChange("ContinuedTime", value);
            }
        }
        private Int32 _RestrainNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("RestrainNum")]
        public Int32 RestrainNum
        {
            get
            {
                return _RestrainNum;
            }
            set
            {
                SetChange("RestrainNum", value);
            }
        }
        private CacheList<PrizeInfo> _Reward;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeInfo> Reward
        {
            get
            {
                return _Reward;
            }
            set
            {
                SetChange("Reward", value);
            }
        }
        private Boolean _IsStop;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("IsStop")]
        public Boolean IsStop
        {
            get
            {
                return _IsStop;
            }
            set
            {
                SetChange("IsStop", value);
            }
        }
        private String _FestivalDesc;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("FestivalDesc")]
        public String FestivalDesc
        {
            get
            {
                return _FestivalDesc;
            }
            set
            {
                SetChange("FestivalDesc", value);
            }
        }
        private TimePriod _TimePriod;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField(true, ColumnDbType.LongText)]
        public TimePriod TimePriod
        {
            get
            {
                return _TimePriod;
            }
            set
            {
                SetChange("TimePriod", value);
            }
        }
        private CacheList<TaskConfigInfo> _TaskConfig;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<TaskConfigInfo> TaskConfig
        {
            get
            {
                return _TaskConfig;
            }
            set
            {
                SetChange("TaskConfig", value);
            }
        }
        private FestivalExtend _FestivalExtend;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField(true, ColumnDbType.LongText)]
        public FestivalExtend FestivalExtend
        {
            get
            {
                return _FestivalExtend;
            }
            set
            {
                SetChange("FestivalExtend", value);
            }
        }
        private DateTime _EndDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField("EndDate")]
        public DateTime EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                SetChange("EndDate", value);
            }
        }
        private FestivalType _FestivalType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        [EntityField("FestivalType")]
        public FestivalType FestivalType
        {
            get
            {
                return _FestivalType;
            }
            set
            {
                SetChange("FestivalType", value);
            }
        }
        private String _HeadID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        [EntityField("HeadID")]
        public String HeadID
        {
            get
            {
                return _HeadID;
            }
            set
            {
                SetChange("HeadID", value);
            }
        }
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "FestivalID": return FestivalID;
                    case "FestivalName": return FestivalName;
                    case "StartDate": return StartDate;
                    case "ContinuedTime": return ContinuedTime;
                    case "RestrainNum": return RestrainNum;
                    case "Reward": return Reward;
                    case "IsStop": return IsStop;
                    case "FestivalDesc": return FestivalDesc;
                    case "TimePriod": return TimePriod;
                    case "TaskConfig": return TaskConfig;
                    case "FestivalExtend": return FestivalExtend;
                    case "EndDate": return EndDate;
                    case "FestivalType": return FestivalType;
                    case "HeadID": return HeadID;
                    default: throw new ArgumentException(string.Format("FestivalInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "FestivalID":
                        _FestivalID = value.ToInt();
                        break;
                    case "FestivalName":
                        _FestivalName = value.ToNotNullString();
                        break;
                    case "StartDate":
                        _StartDate = value.ToDateTime();
                        break;
                    case "ContinuedTime":
                        _ContinuedTime = value.ToInt();
                        break;
                    case "RestrainNum":
                        _RestrainNum = value.ToInt();
                        break;
                    case "Reward":
                        _Reward = ConvertCustomField<CacheList<PrizeInfo>>(value, index);
                        break;
                    case "IsStop":
                        _IsStop = value.ToBool();
                        break;
                    case "FestivalDesc":
                        _FestivalDesc = value.ToNotNullString();
                        break;
                    case "TimePriod":
                        _TimePriod = ConvertCustomField<TimePriod>(value, index);//  ?? new TimePriod();
                        break;
                    case "TaskConfig":
                        _TaskConfig = ConvertCustomField<CacheList<TaskConfigInfo>>(value, index);
                        break;
                    case "FestivalExtend":
                        _FestivalExtend = ConvertCustomField<FestivalExtend>(value, index);
                        break;
                    case "EndDate":
                        _EndDate = value.ToDateTime();
                        break;
                    case "FestivalType":
                        _FestivalType = value.ToEnum<FestivalType>();
                        break;
                    case "HeadID":
                        _HeadID = value.ToNotNullString();
                        break;
                    default: throw new ArgumentException(string.Format("FestivalInfo index[{0}] isn't exist.", index));
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