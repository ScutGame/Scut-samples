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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserRechargeLog")]
    public class UserRechargeLog : BaseEntity
    {
        #region auto-generated static method
        static UserRechargeLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserRechargeLog));
        }
        #endregion
        
        public UserRechargeLog()
            : base(AccessLevel.WriteOnly)
        {
        }
        
        #region auto-generated Property
        private String _LogID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LogID", IsKey = true)]
        public String LogID
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
        private String _OrderNo;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("OrderNo")]
        public String OrderNo
        {
            private get
            {
                return _OrderNo;
            }
            set
            {
                SetChange("OrderNo", value);
            }
        }
        private Int32 _PayGold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PayGold")]
        public Int32 PayGold
        {
            private get
            {
                return _PayGold;
            }
            set
            {
                SetChange("PayGold", value);
            }
        }
        private Decimal _ChargeAmount;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ChargeAmount")]
        public Decimal ChargeAmount
        {
            private get
            {
                return _ChargeAmount;
            }
            set
            {
                SetChange("ChargeAmount", value);
            }
        }
        private DateTime _ReargeDate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ReargeDate")]
        public DateTime ReargeDate
        {
            private get
            {
                return _ReargeDate;
            }
            set
            {
                SetChange("ReargeDate", value);
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
                    case "OrderNo": return OrderNo;
                    case "PayGold": return PayGold;
                    case "ChargeAmount": return ChargeAmount;
                    case "ReargeDate": return ReargeDate;
					default: throw new ArgumentException(string.Format("UserRechargeLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "LogID": 
                        _LogID = value.ToNotNullString(); 
                        break; 
                    case "UserID": 
                        _UserID = value.ToNotNullString(); 
                        break; 
                    case "OrderNo": 
                        _OrderNo = value.ToNotNullString(); 
                        break; 
                    case "PayGold": 
                        _PayGold = value.ToInt(); 
                        break; 
                    case "ChargeAmount": 
                        _ChargeAmount = value.ToDecimal(); 
                        break; 
                    case "ReargeDate": 
                        _ReargeDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("UserRechargeLog index[{0}] isn't exist.", index));
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