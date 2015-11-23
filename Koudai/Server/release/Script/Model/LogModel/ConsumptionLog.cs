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

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 消费日志报表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.None,DbConfig.Log, "ConsumptionLog")]
    public class ConsumptionLog : BaseEntity
    {
        #region auto-generated static method
        static ConsumptionLog()
        {
            EntitySchemaSet.InitSchema(typeof(ConsumptionLog));
        }
        #endregion

        public ConsumptionLog()
            : base(AccessLevel.WriteOnly)
        {
        }        

        public ConsumptionLog(Int32 LogID)
            : this()
        {
            this.LogID = LogID;
        }

        #region 自动生成属性

        private Int32 _LogID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("LogID", IsKey = true, IsIdentity = true)]
        public Int32 LogID
        {
            get
            {
                return _LogID;
            }
            private set
            {
                SetChange("LogID", value);
            }
        }

        private Int16 _ConItemID;
        /// <summary>
        /// 消费项目ID
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("ConItemID")]
        public Int16 ConItemID
        {
            private get
            {
                return _ConItemID;
            }
            set
            {
                SetChange("ConItemID", value);
            }
        }

        private String _ConItemName;
        /// <summary>
        /// 消费项目名称
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("ConItemName")]
        public String ConItemName
        {
            private get
            {
                return _ConItemName;
            }
            set
            {
                SetChange("ConItemName", value);
            }
        }

        private Int16 _ConItemType;
        /// <summary>
        /// 消费项目分类
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("ConItemType")]
        public Int16 ConItemType
        {
            private get
            {
                return _ConItemType;
            }
            set
            {
                SetChange("ConItemType", value);
            }
        }

        private String _ConItemTypeName;
        /// <summary>
        /// 消费项目分类名称
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("ConItemTypeName")]
        public String ConItemTypeName
        {
            private get
            {
                return _ConItemTypeName;
            }
            set
            {
                SetChange("ConItemTypeName", value);
            }
        }

        private Int32 _Num;
        /// <summary>
        /// 消费数量
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("Num")]
        public Int32 Num
        {
            private get
            {
                return _Num;
            }
            set
            {
                SetChange("Num", value);
            }
        }

        private Int32 _RemainNum;
        /// <summary>
        /// 剩余数量
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("RemainNum")]
        public Int32 RemainNum
        {
            private get
            {
                return _RemainNum;
            }
            set
            {
                SetChange("RemainNum", value);
            }
        }

        private Int16 _Currency;
        /// <summary>
        /// 币别1：充值币 2：游戏币
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("Currency")]
        public Int16 Currency
        {
            private get
            {
                return _Currency;
            }
            set
            {
                SetChange("Currency", value);
            }
        }

        private Int32 _Amount;
        /// <summary>
        /// 金额
        /// </summary>        
        [ProtoMember(9)]
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

        private String _Pid;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
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
        [ProtoMember(11)]
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

        private String _NickName;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(12)]
        [EntityField("NickName")]
        public String NickName
        {
            private get
            {
                return _NickName;
            }
            set
            {
                SetChange("NickName", value);
            }
        }

        private String _RetailID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(13)]
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

        private Int32 _MobileType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(14)]
        [EntityField("MobileType")]
        public Int32 MobileType
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

        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(15)]
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
                    case "ConItemID": return ConItemID;
                    case "ConItemName": return ConItemName;
                    case "ConItemType": return ConItemType;
                    case "ConItemTypeName": return ConItemTypeName;
                    case "Num": return Num;
                    case "RemainNum": return RemainNum;
                    case "Currency": return Currency;
                    case "Amount": return Amount;
                    case "Pid": return Pid;
                    case "Uid": return Uid;
                    case "NickName": return NickName;
                    case "RetailID": return RetailID;
                    case "MobileType": return MobileType;
                    case "CreateDate": return CreateDate;
					default: throw new ArgumentException(string.Format("ConsumptionLog index[{0}] isn't exist.", index));
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
                    case "ConItemID": 
                        _ConItemID = value.ToShort(); 
                        break; 
                    case "ConItemName": 
                        _ConItemName = value.ToNotNullString(); 
                        break; 
                    case "ConItemType": 
                        _ConItemType = value.ToShort(); 
                        break; 
                    case "ConItemTypeName": 
                        _ConItemTypeName = value.ToNotNullString(); 
                        break; 
                    case "Num": 
                        _Num = value.ToInt(); 
                        break; 
                    case "RemainNum": 
                        _RemainNum = value.ToInt(); 
                        break; 
                    case "Currency": 
                        _Currency = value.ToShort(); 
                        break; 
                    case "Amount": 
                        _Amount = value.ToInt(); 
                        break; 
                    case "Pid": 
                        _Pid = value.ToNotNullString(); 
                        break; 
                    case "Uid": 
                        _Uid = value.ToInt(); 
                        break; 
                    case "NickName": 
                        _NickName = value.ToNotNullString(); 
                        break; 
                    case "RetailID": 
                        _RetailID = value.ToNotNullString(); 
                        break; 
                    case "MobileType": 
                        _MobileType = value.ToInt(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("ConsumptionLog index[{0}] isn't exist.", index));
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