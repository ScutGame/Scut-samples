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
    /// ���ֻ��ȡ���Ʊ�
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class NoviceRestrain : BaseEntity
    {


        public NoviceRestrain()
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
        private Int32 _EnergyNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("EnergyNum")]
        public Int32 EnergyNum
        {
            get
            {
                return _EnergyNum;
            }
            set
            {
                SetChange("EnergyNum", value);
            }
        }
        private DateTime _EnergyDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("EnergyDate")]
        public DateTime EnergyDate
        {
            get
            {
                return _EnergyDate;
            }
            set
            {
                SetChange("EnergyDate", value);
            }
        }
        private Int32 _GoldNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("GoldNum")]
        public Int32 GoldNum
        {
            get
            {
                return _GoldNum;
            }
            set
            {
                SetChange("GoldNum", value);
            }
        }
        private Int32 _PackageNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("PackageNum")]
        public Int32 PackageNum
        {
            get
            {
                return _PackageNum;
            }
            set
            {
                SetChange("PackageNum", value);
            }
        }
        private Boolean _IsCard;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("IsCard")]
        public Boolean IsCard
        {
            get
            {
                return _IsCard;
            }
            set
            {
                SetChange("IsCard", value);
            }
        }
        private DateTime _ReceiveDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
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
        private Int32 _ExpObtain;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("ExpObtain")]
        public Int32 ExpObtain
        {
            get
            {
                return _ExpObtain;
            }
            set
            {
                SetChange("ExpObtain", value);
            }
        }
        private DateTime _ExpObtainDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("ExpObtainDate")]
        public DateTime ExpObtainDate
        {
            get
            {
                return _ExpObtainDate;
            }
            set
            {
                SetChange("ExpObtainDate", value);
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
                    case "EnergyNum": return EnergyNum;
                    case "EnergyDate": return EnergyDate;
                    case "GoldNum": return GoldNum;
                    case "PackageNum": return PackageNum;
                    case "IsCard": return IsCard;
                    case "ReceiveDate": return ReceiveDate;
                    case "ExpObtain": return ExpObtain;
                    case "ExpObtainDate": return ExpObtainDate;
                    default: throw new ArgumentException(string.Format("NoviceRestrain index[{0}] isn't exist.", index));
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
                    case "EnergyNum":
                        _EnergyNum = value.ToInt();
                        break;
                    case "EnergyDate":
                        _EnergyDate = value.ToDateTime();
                        break;
                    case "GoldNum":
                        _GoldNum = value.ToInt();
                        break;
                    case "PackageNum":
                        _PackageNum = value.ToInt();
                        break;
                    case "IsCard":
                        _IsCard = value.ToBool();
                        break;
                    case "ReceiveDate":
                        _ReceiveDate = value.ToDateTime();
                        break;
                    case "ExpObtain":
                        _ExpObtain = value.ToInt();
                        break;
                    case "ExpObtainDate":
                        _ExpObtainDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("NoviceRestrain index[{0}] isn't exist.", index));
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