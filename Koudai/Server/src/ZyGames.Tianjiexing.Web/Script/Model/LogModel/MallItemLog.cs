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
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ProtoBuf;
using ZyGames.Framework.Game.Service;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.None,DbConfig.Log, "MallItemLog")]
    public class MallItemLog : BaseEntity
    {
        #region auto-generated static method
        static MallItemLog()
        {
            EntitySchemaSet.InitSchema(typeof(MallItemLog));
        }
        #endregion
        
        public MallItemLog()
            : base(AccessLevel.WriteOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _LogID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
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
        private String _RetailID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("RetailID")]
        public String RetailID
        {
            private get
            {
                return _RetailID;
            }
            set
            {
                SetChange("RetailID", value);
            }
        }
        private MobileType _MobileType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("MobileType")]
        public MobileType MobileType
        {
            private get
            {
                return _MobileType;
            }
            set
            {
                SetChange("MobileType", value);
            }
        }
        private String _Pid;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("Pid")]
        public String Pid
        {
            private get
            {
                return _Pid;
            }
            set
            {
                SetChange("Pid", value);
            }
        }
        private Int32 _Uid;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("Uid")]
        public Int32 Uid
        {
            private get
            {
                return _Uid;
            }
            set
            {
                SetChange("Uid", value);
            }
        }
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("ItemID")]
        public Int32 ItemID
        {
            private get
            {
                return _ItemID;
            }
            set
            {
                SetChange("ItemID", value);
            }
        }
        private Int32 _PropType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("PropType")]
        public Int32 PropType
        {
            private get
            {
                return _PropType;
            }
            set
            {
                SetChange("PropType", value);
            }
        }
        private String _ItemName;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("ItemName")]
        public String ItemName
        {
            private get
            {
                return _ItemName;
            }
            set
            {
                SetChange("ItemName", value);
            }
        }
        private Int32 _ItemNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("ItemNum")]
        public Int32 ItemNum
        {
            private get
            {
                return _ItemNum;
            }
            set
            {
                SetChange("ItemNum", value);
            }
        }
        private Int32 _Amount;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("Amount")]
        public Int32 Amount
        {
            private get
            {
                return _Amount;
            }
            set
            {
                SetChange("Amount", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
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
                    case "RetailID": return RetailID;
                    case "MobileType": return MobileType;
                    case "Pid": return Pid;
                    case "Uid": return Uid;
                    case "ItemID": return ItemID;
                    case "PropType": return PropType;
                    case "ItemName": return ItemName;
                    case "ItemNum": return ItemNum;
                    case "Amount": return Amount;
                    case "CreateDate": return CreateDate;
                    default: throw new ArgumentException(string.Format("MallItemLog index[{0}] isn't exist.", index));
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
                    case "RetailID": 
                        _RetailID = value.ToNotNullString(); 
                        break; 
                    case "MobileType":
                        _MobileType = value.ToEnum<MobileType>(); 
                        break; 
                    case "Pid": 
                        _Pid = value.ToNotNullString(); 
                        break; 
                    case "Uid": 
                        _Uid = value.ToInt(); 
                        break; 
                    case "ItemID": 
                        _ItemID = value.ToInt(); 
                        break; 
                    case "PropType": 
                        _PropType = value.ToInt(); 
                        break; 
                    case "ItemName": 
                        _ItemName = value.ToNotNullString(); 
                        break; 
                    case "ItemNum": 
                        _ItemNum = value.ToInt(); 
                        break; 
                    case "Amount": 
                        _Amount = value.ToInt(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
                    default: throw new ArgumentException(string.Format("MallItemLog index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }
        
        #endregion
                
        protected override int GetIdentityId()
        {
            //allow modify return value
            return Uid;
        }
    }
}