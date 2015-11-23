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
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserCrystalLog")]
    public class UserCrystalLog : BaseEntity
    {
        #region auto-generated static method
        static UserCrystalLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserCrystalLog));
        }
        #endregion

        public UserCrystalLog()
            : base(AccessLevel.WriteOnly)
        {
        }

        #region auto-generated Property
        private String _ID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ID", IsKey = true)]
        public String ID
        {
            private get
            {
                return _ID;
            }
            set
            {
                SetChange("ID", value);
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
        private Int16 _OpType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("OpType")]
        public Int16 OpType
        {
            private get
            {
                return _OpType;
            }
            set
            {
                SetChange("OpType", value);
            }
        }
        private Int32 _CrystalID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CrystalID")]
        public Int32 CrystalID
        {
            private get
            {
                return _CrystalID;
            }
            set
            {
                SetChange("CrystalID", value);
            }
        }
        private Int32 _CoinNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CoinNum")]
        public Int32 CoinNum
        {
            private get
            {
                return _CoinNum;
            }
            set
            {
                SetChange("CoinNum", value);
            }
        }
        private Int32 _UseGold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UseGold")]
        public Int32 UseGold
        {
            private get
            {
                return _UseGold;
            }
            set
            {
                SetChange("UseGold", value);
            }
        }
        private CacheList<SynthesisInfo> _SynthesisCrystal;
        /// <summary>
        /// 
        /// </summary>
       [EntityField(true, ColumnDbType.LongText)]
        public CacheList<SynthesisInfo> SynthesisCrystal
        {
            private get
            {
                return _SynthesisCrystal;
            }
            set
            {
                SetChange("SynthesisCrystal", value);
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
        private Int16 _CrystalLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CrystalLv")]
        public Int16 CrystalLv
        {
            private get
            {
                return _CrystalLv;
            }
            set
            {
                SetChange("CrystalLv", value);
            }
        }
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Experience")]
        public Int32 Experience
        {
            private get
            {
                return _Experience;
            }
            set
            {
                SetChange("Experience", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ID": return ID;
                    case "UserID": return UserID;
                    case "OpType": return OpType;
                    case "CrystalID": return CrystalID;
                    case "CoinNum": return CoinNum;
                    case "UseGold": return UseGold;
                    case "SynthesisCrystal": return SynthesisCrystal;
                    case "CreateDate": return CreateDate;
                    case "CrystalLv": return CrystalLv;
                    case "Experience": return Experience;
                    default: throw new ArgumentException(string.Format("UserCrystalLog index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ID":
                        _ID = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "OpType":
                        _OpType = value.ToShort();
                        break;
                    case "CrystalID":
                        _CrystalID = value.ToInt();
                        break;
                    case "CoinNum":
                        _CoinNum = value.ToInt();
                        break;
                    case "UseGold":
                        _UseGold = value.ToInt();
                        break;
                    case "SynthesisCrystal":
                        _SynthesisCrystal = ConvertCustomField<CacheList<SynthesisInfo>>(value, index);
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    case "CrystalLv":
                        _CrystalLv = value.ToShort();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserCrystalLog index[{0}] isn't exist.", index));
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