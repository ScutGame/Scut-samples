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

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserSparePartLog")]
    public class UserSparePartLog : BaseEntity
    {
        #region auto-generated static method
        static UserSparePartLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserSparePartLog));
        }
        #endregion

        public UserSparePartLog()
            : base(AccessLevel.WriteOnly)
        {
        }

        #region auto-generated Property
        private Int32 _LogID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LogID", IsKey = true, IsIdentity = true)]
        public Int32 LogID
        {
            private get
            {
                return _LogID;
            }
            set
            {
                SetChange("LogID", value);
            }
        }
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UserID")]
        public String UserID
        {
            private get
            {
                return _UserID;
            }
            set
            {
                SetChange("UserID", value);
            }
        }
        private Int32 _SparePartID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SparePartID")]
        public Int32 SparePartID
        {
            private get
            {
                return _SparePartID;
            }
            set
            {
                SetChange("SparePartID", value);
            }
        }
        private UserSparePart _SparePart;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public UserSparePart SparePart
        {
            private get
            {
                return _SparePart;
            }
            set
            {
                SetChange("SparePart", value);
            }
        }
        private Int16 _PartStatus;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PartStatus")]
        public Int16 PartStatus
        {
            private get
            {
                return _PartStatus;
            }
            set
            {
                SetChange("PartStatus", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            private get
            {
                return _CreateDate;
            }
            set
            {
                SetChange("CreateDate", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "LogID": return LogID;
                    case "UserID": return UserID;
                    case "SparePartID": return SparePartID;
                    case "SparePart": return SparePart;
                    case "PartStatus": return PartStatus;
                    case "CreateDate": return CreateDate;
                    default: throw new ArgumentException(string.Format("UserSparePartLog index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "LogID":
                        _LogID = value.ToInt();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "SparePartID":
                        _SparePartID = value.ToInt();
                        break;
                    case "SparePart":
                        _SparePart = ConvertCustomField<UserSparePart>(value, index);
                        break;
                    case "PartStatus":
                        _PartStatus = value.ToShort();
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserSparePartLog index[{0}] isn't exist.", index));
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