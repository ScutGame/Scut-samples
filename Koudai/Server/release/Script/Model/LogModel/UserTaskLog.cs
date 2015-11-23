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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserTaskLog")]
    public class UserTaskLog : BaseEntity
    {
        #region auto-generated static method
        static UserTaskLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserTaskLog));
        }
        #endregion
        
        public UserTaskLog()
            : base(AccessLevel.WriteOnly)
        {
            TaskStar = 0;
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
        private Int32 _TaskID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskID")]
        public Int32 TaskID
        {
            private get
            {
                return _TaskID;
            }
            set
            {
                SetChange("TaskID", value);
            }
        }
        private TaskType _TaskType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskType")]
        public TaskType TaskType
        {
            private get
            {
                return _TaskType;
            }
            set
            {
                SetChange("TaskType", value);
            }
        }
        private TaskState _TaskState;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskState")]
        public TaskState TaskState
        {
            private get
            {
                return _TaskState;
            }
            set
            {
                SetChange("TaskState", value);
            }
        }
        private Int32 _TaskStar;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskStar")]
        public Int32 TaskStar
        {
            private get
            {
                return _TaskStar;
            }
            set
            {
                SetChange("TaskStar", value);
            }
        }
        private String _TaskPrize;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskPrize")]
        public String TaskPrize
        {
            private get
            {
                return _TaskPrize;
            }
            set
            {
                SetChange("TaskPrize", value);
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
                    case "TaskID": return TaskID;
                    case "TaskType": return TaskType;
                    case "TaskState": return TaskState;
                    case "TaskStar": return TaskStar;
                    case "TaskPrize": return TaskPrize;
                    case "CreateDate": return CreateDate;
					default: throw new ArgumentException(string.Format("UserTaskLog index[{0}] isn't exist.", index));
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
                    case "TaskID": 
                        _TaskID = value.ToInt(); 
                        break; 
                    case "TaskType":
                        _TaskType = value.ToEnum<TaskType>(); 
                        break; 
                    case "TaskState":
                        _TaskState = value.ToEnum<TaskState>(); 
                        break; 
                    case "TaskStar": 
                        _TaskStar = value.ToInt(); 
                        break; 
                    case "TaskPrize": 
                        _TaskPrize = value.ToNotNullString(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("UserTaskLog index[{0}] isn't exist.", index));
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