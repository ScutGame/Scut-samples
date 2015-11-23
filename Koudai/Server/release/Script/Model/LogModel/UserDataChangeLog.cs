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
using ZyGames.Framework.Net;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserDataChangeLog")]
    public class UserDataChangeLog : BaseEntity
    {
        #region auto-generated static method
        static UserDataChangeLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserDataChangeLog));
        }
        #endregion
        
        public UserDataChangeLog()
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
        private String _EntityName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EntityName")]
        public String EntityName
        {
            private get
            {
                return _EntityName;
            }
            set
            {
                SetChange("EntityName", value);
            }
        }
        private String _Name;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Name")]
        public String Name
        {
            private get
            {
                return _Name;
            }
            set
            {
                SetChange("Name", value);
            }
        }
        private String _PreValue;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PreValue")]
        public String PreValue
        {
            private get
            {
                return _PreValue;
            }
            set
            {
                SetChange("PreValue", value);
            }
        }
        private String _Value;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Value")]
        public String Value
        {
            private get
            {
                return _Value;
            }
            set
            {
                SetChange("Value", value);
            }
        }
        private DateTime _ModifyDate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ModifyDate")]
        public DateTime ModifyDate
        {
            private get
            {
                return _ModifyDate;
            }
            set
            {
                SetChange("ModifyDate", value);
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
                    case "EntityName": return EntityName;
                    case "Name": return Name;
                    case "PreValue": return PreValue;
                    case "Value": return Value;
                    case "ModifyDate": return ModifyDate;
					default: throw new ArgumentException(string.Format("UserDataChangeLog index[{0}] isn't exist.", index));
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
                    case "EntityName": 
                        _EntityName = value.ToNotNullString(); 
                        break; 
                    case "Name": 
                        _Name = value.ToNotNullString(); 
                        break; 
                    case "PreValue": 
                        _PreValue = value.ToNotNullString(); 
                        break; 
                    case "Value": 
                        _Value = value.ToNotNullString(); 
                        break; 
                    case "ModifyDate": 
                        _ModifyDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("UserDataChangeLog index[{0}] isn't exist.", index));
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

        public static void SaveLog<T>(string property, string userID, object oldValue, object value)
        {
            string v1 = oldValue.ToString();
            string v2 = value.ToString();
            if (!Equals(v1, v2))
            {
                UserDataChangeLog changeLog = new UserDataChangeLog
                {
                    UserID = userID,
                    EntityName = typeof(T).Name,
                    Name = property,
                    PreValue = v1,
                    Value = v2,
                    ModifyDate = DateTime.Now
                };
                var sender = DataSyncManager.GetDataSender();
                sender.Send(changeLog);
            }
        }

	}
}