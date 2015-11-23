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
    /// ���Լ����
    /// </summary>
    [Obsolete("", true)]
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserRestrain : BaseEntity
    {


        public UserRestrain()
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
        private RestrainType _RestrainType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("RestrainType")]
        public RestrainType RestrainType
        {
            get
            {
                return _RestrainType;
            }
            set
            {
                SetChange("RestrainType", value);
            }
        }
        private Int32 _CurrNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("CurrNum")]
        public Int32 CurrNum
        {
            get
            {
                return _CurrNum;
            }
            set
            {
                SetChange("CurrNum", value);
            }
        }
        private Int32 _MaxNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("MaxNum")]
        public Int32 MaxNum
        {
            get
            {
                return _MaxNum;
            }
            set
            {
                SetChange("MaxNum", value);
            }
        }
        private DateTime _RefreshDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
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
                    case "RestrainType": return RestrainType;
                    case "CurrNum": return CurrNum;
                    case "MaxNum": return MaxNum;
                    case "RefreshDate": return RefreshDate;
                    default: throw new ArgumentException(string.Format("UserRestrain index[{0}] isn't exist.", index));
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
                    case "RestrainType":
                        _RestrainType = value.ToEnum<RestrainType>();
                        break;
                    case "CurrNum":
                        _CurrNum = value.ToInt();
                        break;
                    case "MaxNum":
                        _MaxNum = value.ToInt();
                        break;
                    case "RefreshDate":
                        _RefreshDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserRestrain index[{0}] isn't exist.", index));
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