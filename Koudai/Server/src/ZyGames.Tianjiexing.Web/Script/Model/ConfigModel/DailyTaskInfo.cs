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
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class DailyTaskInfo : ShareEntity
    {

        
        public DailyTaskInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _TaskID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskID", IsKey = true)]
        public Int32 TaskID
        {
            get
            {
                return _TaskID;
            }
            private set
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
            get
            {
                return _TaskType;
            }
            private set
            {
                SetChange("TaskType", value);
            }
        }
        private String _TaskName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskName")]
        public String TaskName
        {
            get
            {
                return _TaskName;
            }
            private set
            {
                SetChange("TaskName", value);
            }
        }
        private String _TaskDescp;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskDescp")]
        public String TaskDescp
        {
            get
            {
                return _TaskDescp;
            }
            private set
            {
                SetChange("TaskDescp", value);
            }
        }
        private String _TaskTarget;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskTarget")]
        public String TaskTarget
        {
            get
            {
                return _TaskTarget;
            }
            private set
            {
                SetChange("TaskTarget", value);
            }
        }
        private String _StarProbability;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("StarProbability")]
        public String StarProbability
        {
            get
            {
                return _StarProbability;
            }
            private set
            {
                SetChange("StarProbability", value);
            }
        }
        private Decimal _ExpRatioNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ExpRatioNum")]
        public Decimal ExpRatioNum
        {
            get
            {
                return _ExpRatioNum;
            }
            private set
            {
                SetChange("ExpRatioNum", value);
            }
        }
        private String _QishiNumRank;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("QishiNumRank")]
        public String QishiNumRank
        {
            get
            {
                return _QishiNumRank;
            }
            private set
            {
                SetChange("QishiNumRank", value);
            }
        }
        private String _UserLvRank;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UserLvRank")]
        public String UserLvRank
        {
            get
            {
                return _UserLvRank;
            }
            private set
            {
                SetChange("UserLvRank", value);
            }
        }
        private String _QishiRank;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("QishiRank")]
        public String QishiRank
        {
            get
            {
                return _QishiRank;
            }
            private set
            {
                SetChange("QishiRank", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "TaskID": return TaskID;
                    case "TaskType": return TaskType;
                    case "TaskName": return TaskName;
                    case "TaskDescp": return TaskDescp;
                    case "TaskTarget": return TaskTarget;
                    case "StarProbability": return StarProbability;
                    case "ExpRatioNum": return ExpRatioNum;
                    case "QishiNumRank": return QishiNumRank;
                    case "UserLvRank": return UserLvRank;
                    case "QishiRank": return QishiRank;
					default: throw new ArgumentException(string.Format("DailyTaskInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "TaskID": 
                        _TaskID = value.ToInt(); 
                        break; 
                    case "TaskType":
                        _TaskType = value.ToEnum<TaskType>(); 
                        break; 
                    case "TaskName": 
                        _TaskName = value.ToNotNullString(); 
                        break; 
                    case "TaskDescp": 
                        _TaskDescp = value.ToNotNullString(); 
                        break; 
                    case "TaskTarget": 
                        _TaskTarget = value.ToNotNullString(); 
                        break; 
                    case "StarProbability": 
                        _StarProbability = value.ToNotNullString(); 
                        break; 
                    case "ExpRatioNum": 
                        _ExpRatioNum = value.ToDecimal(); 
                        break; 
                    case "QishiNumRank": 
                        _QishiNumRank = value.ToNotNullString(); 
                        break; 
                    case "UserLvRank": 
                        _UserLvRank = value.ToNotNullString(); 
                        break; 
                    case "QishiRank": 
                        _QishiRank = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("DailyTaskInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
                
        protected override int GetIdentityId()
        {
            //allow modify return value
            return DefIdentityId;
        }
	}
}