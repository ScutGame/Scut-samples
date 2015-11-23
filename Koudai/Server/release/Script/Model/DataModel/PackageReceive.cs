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

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// ��ҳ�ֵ����ȡ������Ϣ
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class PackageReceive : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_UserID_PacksID = "Index_UserID_PacksID";


        public PackageReceive()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _ReceiveID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("ReceiveID", IsKey = true)]
        public String ReceiveID
        {
            get
            {
                return _ReceiveID;
            }
            set
            {
                SetChange("ReceiveID", value);
            }
        }
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("UserID")]
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
        private Int32 _PacksID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("PacksID")]
        public Int32 PacksID
        {
            get
            {
                return _PacksID;
            }
            set
            {
                SetChange("PacksID", value);
            }
        }
        private Boolean _IsReceive;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("IsReceive")]
        public Boolean IsReceive
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
        private DateTime _ReceiveDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("ReceiveDate")]
        public DateTime ReceiveDate
        {
            get
            {
                return _ReceiveDate;
            }
            set
            {
                SetChange("ReceiveDate", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ReceiveID": return ReceiveID;
                    case "UserID": return UserID;
                    case "PacksID": return PacksID;
                    case "IsReceive": return IsReceive;
                    case "ReceiveDate": return ReceiveDate;
                    default: throw new ArgumentException(string.Format("PackageReceive index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ReceiveID":
                        _ReceiveID = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "PacksID":
                        _PacksID = value.ToInt();
                        break;
                    case "IsReceive":
                        _IsReceive = value.ToBool();
                        break;
                    case "ReceiveDate":
                        _ReceiveDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("PackageReceive index[{0}] isn't exist.", index));
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
        public Int32 PacksType
        {
            get { return new ShareCacheStruct<RechargePacks>().FindKey(PacksID).PacksType; }
        }
    }
}