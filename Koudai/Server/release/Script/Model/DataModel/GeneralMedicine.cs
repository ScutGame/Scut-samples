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
    /// Ӷ�����õ�ҩ
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class GeneralMedicine : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_UserID_GeneralID = "Index_UserID_GeneralID";

        public GeneralMedicine()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _GeneralMedicineID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("GeneralMedicineID", IsKey = true)]
        public String GeneralMedicineID
        {
            get
            {
                return _GeneralMedicineID;
            }
            set
            {
                SetChange("GeneralMedicineID", value);
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
        private Int32 _MedicineID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("MedicineID")]
        public Int32 MedicineID
        {
            get
            {
                return _MedicineID;
            }
            set
            {
                SetChange("MedicineID", value);
            }
        }
        private Int32 _BaseNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("BaseNum")]
        public Int32 BaseNum
        {
            get
            {
                return _BaseNum;
            }
            set
            {
                SetChange("BaseNum", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "GeneralMedicineID": return GeneralMedicineID;
                    case "UserID": return UserID;
                    case "GeneralID": return GeneralID;
                    case "MedicineID": return MedicineID;
                    case "BaseNum": return BaseNum;
                    default: throw new ArgumentException(string.Format("GeneralMedicine index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "GeneralMedicineID":
                        _GeneralMedicineID = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "GeneralID":
                        _GeneralID = value.ToInt();
                        break;
                    case "MedicineID":
                        _MedicineID = value.ToInt();
                        break;
                    case "BaseNum":
                        _BaseNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("GeneralMedicine index[{0}] isn't exist.", index));
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

        public Int16 MedicineType
        {
            get
            {
                ItemBaseInfo itemInfo = new ShareCacheStruct<ItemBaseInfo>().FindKey(MedicineID);
                if (itemInfo != null)
                {
                    return itemInfo.MedicineType;
                }
                return 0;
            }
        }
    }
}