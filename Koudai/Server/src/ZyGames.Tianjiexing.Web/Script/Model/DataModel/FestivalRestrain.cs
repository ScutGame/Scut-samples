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
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// ���ջ���Ʊ�
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class FestivalRestrain : BaseEntity
    {


        public FestivalRestrain()
            : base(AccessLevel.ReadWrite)
        {
            this.UserExtend = new CacheList<RestrainExtend>();
        }
        //protected override void BindChangeEvent()
        //{
        //    UserExtend.BindParentChangeEvent(this);
        //}

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
        private Int32 _FestivalID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
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
        private Int32 _RestrainNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
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
        private DateTime _RefreashDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("RefreashDate")]
        public DateTime RefreashDate
        {
            get
            {
                return _RefreashDate;
            }
            set
            {
                SetChange("RefreashDate", value);
            }
        }
        private CacheList<RestrainExtend> _UserExtend;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<RestrainExtend> UserExtend
        {
            get
            {
                return _UserExtend;
            }
            set
            {
                SetChange("UserExtend", value);
            }
        }

        private bool _IsReceive;
        /// <summary>
        /// �Ƿ���ȡ
        /// </summary>
        [ProtoMember(6)]
        [EntityField("IsReceive")]
        public bool IsReceive
        {
            get
            {
                return _IsReceive;
            }
            set
            {
                SetChange("IsReceive", value);
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
                    case "FestivalID": return FestivalID;
                    case "RestrainNum": return RestrainNum;
                    case "RefreashDate": return RefreashDate;
                    case "UserExtend": return UserExtend;
                    case "IsReceive": return IsReceive;
                    default: throw new ArgumentException(string.Format("FestivalRestrain index[{0}] isn't exist.", index));
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
                    case "FestivalID":
                        _FestivalID = value.ToInt();
                        break;
                    case "RestrainNum":
                        _RestrainNum = value.ToInt();
                        break;
                    case "RefreashDate":
                        _RefreashDate = value.ToDateTime();
                        break;
                    case "UserExtend":
                        _UserExtend = ConvertCustomField<CacheList<RestrainExtend>>(value, index);
                        break;
                    case "IsReceive":
                        _IsReceive = value.ToBool();
                        break;
                    default: throw new ArgumentException(string.Format("FestivalRestrain index[{0}] isn't exist.", index));
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