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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserStrongLog")]
    public class UserStrongLog : BaseEntity
    {
        #region auto-generated static method
        static UserStrongLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserStrongLog));
        }
        #endregion
        
        public UserStrongLog()
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
        private String _UserItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UserItemID")]
        public String UserItemID
        {
            private get
            {
                return _UserItemID;
            }
            set
            {
                SetChange("UserItemID", value);
            }
        }
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
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
        private Int16 _UseType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UseType")]
        public Int16 UseType
        {
            private get
            {
                return _UseType;
            }
            set
            {
                SetChange("UseType", value);
            }
        }
        private Int16 _StrongLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("StrongLv")]
        public Int16 StrongLv
        {
            private get
            {
                return _StrongLv;
            }
            set
            {
                SetChange("StrongLv", value);
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
        private Int32 _GeneralID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GeneralID")]
        public Int32 GeneralID
        {
            private get
            {
                return _GeneralID;
            }
            set
            {
                SetChange("GeneralID", value);
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
                    case "UserItemID": return UserItemID;
                    case "ItemID": return ItemID;
                    case "UseType": return UseType;
                    case "StrongLv": return StrongLv;
                    case "CreateDate": return CreateDate;
                    case "UseGold": return UseGold;
                    case "GeneralID": return GeneralID;
					default: throw new ArgumentException(string.Format("UserStrongLog index[{0}] isn't exist.", index));
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
                    case "UserItemID": 
                        _UserItemID = value.ToNotNullString(); 
                        break; 
                    case "ItemID": 
                        _ItemID = value.ToInt(); 
                        break; 
                    case "UseType": 
                        _UseType = value.ToShort(); 
                        break; 
                    case "StrongLv": 
                        _StrongLv = value.ToShort(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
                    case "UseGold": 
                        _UseGold = value.ToInt(); 
                        break; 
                    case "GeneralID": 
                        _GeneralID = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("UserStrongLog index[{0}] isn't exist.", index));
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