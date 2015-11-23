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
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data, OrderColumn = "IsTop desc,CreateDate desc")]
    public class GameNotice : ShareEntity
    {


        public GameNotice()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _NoticeID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("NoticeID", IsKey = true)]
        public String NoticeID
        {
            get
            {
                return _NoticeID;
            }
            set
            {
                SetChange("NoticeID", value);
            }
        }
        private String _Title;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("Title")]
        public String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                SetChange("Title", value);
            }
        }
        private String _Content;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("Content")]
        public String Content
        {
            get
            {
                return _Content;
            }
            set
            {
                SetChange("Content", value);
            }
        }
        private DateTime _ExpiryDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("ExpiryDate")]
        public DateTime ExpiryDate
        {
            get
            {
                return _ExpiryDate;
            }
            set
            {
                SetChange("ExpiryDate", value);
            }
        }
        private Boolean _IsTop;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("IsTop")]
        public Boolean IsTop
        {
            get
            {
                return _IsTop;
            }
            set
            {
                SetChange("IsTop", value);
            }
        }
        private Boolean _IsBroadcast;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("IsBroadcast")]
        public Boolean IsBroadcast
        {
            get
            {
                return _IsBroadcast;
            }
            set
            {
                SetChange("IsBroadcast", value);
            }
        }
        private String _Creater;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("Creater")]
        public String Creater
        {
            get
            {
                return _Creater;
            }
            set
            {
                SetChange("Creater", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                SetChange("CreateDate", value);
            }
        }
        private int _NoticeType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("NoticeType")]
        public int NoticeType
        {
            get
            {
                return _NoticeType;
            }
            set
            {
                SetChange("NoticeType", value);
            }
        }
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "NoticeID": return NoticeID;
                    case "Title": return Title;
                    case "Content": return Content;
                    case "ExpiryDate": return ExpiryDate;
                    case "IsTop": return IsTop;
                    case "IsBroadcast": return IsBroadcast;
                    case "Creater": return Creater;
                    case "CreateDate": return CreateDate;
                    case "NoticeType": return NoticeType;
                    default: throw new ArgumentException(string.Format("GameNotice index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "NoticeID":
                        _NoticeID = value.ToNotNullString();
                        break;
                    case "Title":
                        _Title = value.ToNotNullString();
                        break;
                    case "Content":
                        _Content = value.ToNotNullString();
                        break;
                    case "ExpiryDate":
                        _ExpiryDate = value.ToDateTime();
                        break;
                    case "IsTop":
                        _IsTop = value.ToBool();
                        break;
                    case "IsBroadcast":
                        _IsBroadcast = value.ToBool();
                        break;
                    case "Creater":
                        _Creater = value.ToNotNullString();
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    case "NoticeType":
                        _NoticeType = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("GameNotice index[{0}] isn't exist.", index));
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