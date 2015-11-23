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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserOperationLog")]
    public class UserOperationLog : BaseEntity
    {
        #region auto-generated static method
        static UserOperationLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserOperationLog));
        }
        #endregion
        
        public UserOperationLog()
            : base(AccessLevel.WriteOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ID", IsKey = true, IsIdentity = true)]
        public Int32 ID
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
        private Int32 _ActionID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ActionID")]
        public Int32 ActionID
        {
            private get
            {
                return _ActionID;
            }
            set
            {
                SetChange("ActionID", value);
            }
        }
        private String _FunctionID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("FunctionID")]
        public String FunctionID
        {
            private get
            {
                return _FunctionID;
            }
            set
            {
                SetChange("FunctionID", value);
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
        private Int32 _Num;
        /// <summary>
        /// 
        /// </summary>
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
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ID": return ID;
                    case "UserID": return UserID;
                    case "ActionID": return ActionID;
                    case "FunctionID": return FunctionID;
                    case "CreateDate": return CreateDate;
                    case "Num": return Num;
					default: throw new ArgumentException(string.Format("UserOperationLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _ID = value.ToInt(); 
                        break; 
                    case "UserID": 
                        _UserID = value.ToNotNullString(); 
                        break; 
                    case "ActionID": 
                        _ActionID = value.ToInt(); 
                        break; 
                    case "FunctionID": 
                        _FunctionID = value.ToNotNullString(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
                    case "Num": 
                        _Num = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("UserOperationLog index[{0}] isn't exist.", index));
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