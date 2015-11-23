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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]


    public class UserTask : BaseEntity
    {
        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_UserIDTaskType = "Index_UserIDTaskType";


        public UserTask()
            : base(AccessLevel.ReadWrite)
        {
            CompleteNum = 0;
            TaskStar = 0;
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
        private Int32 _TaskID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("TaskID", IsKey = true)]
        public Int32 TaskID
        {
            get
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
        [ProtoMember(3)]
        [EntityField("TaskType")]
        public TaskType TaskType
        {
            get
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
        [ProtoMember(4)]
        [EntityField("TaskState")]
        public TaskState TaskState
        {
            get
            {
                return _TaskState;
            }
            set
            {
                SetChange("TaskState", value);
            }
        }
        private TaskStar _TaskStar;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("TaskStar")]
        public TaskStar TaskStar
        {
            get
            {
                return _TaskStar;
            }
            set
            {
                SetChange("TaskStar", value);
            }
        }
        private String _TaskTargetNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("TaskTargetNum")]
        public String TaskTargetNum
        {
            get
            {
                return _TaskTargetNum;
            }
            set
            {
                SetChange("TaskTargetNum", value);
            }
        }
        private DateTime _TakeDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("TakeDate")]
        public DateTime TakeDate
        {
            get
            {
                return _TakeDate;
            }
            set
            {
                SetChange("TakeDate", value);
            }
        }
        private Int32 _CompleteNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("CompleteNum")]
        public Int32 CompleteNum
        {
            get
            {
                return _CompleteNum;
            }
            set
            {
                SetChange("CompleteNum", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            get
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
                    case "UserID": return UserID;
                    case "TaskID": return TaskID;
                    case "TaskType": return TaskType;
                    case "TaskState": return TaskState;
                    case "TaskStar": return TaskStar;
                    case "TaskTargetNum": return TaskTargetNum;
                    case "TakeDate": return TakeDate;
                    case "CompleteNum": return CompleteNum;
                    case "CreateDate": return CreateDate;
                    default: throw new ArgumentException(string.Format("UserTask index[{0}] isn't exist.", index));
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
                        _TaskStar = value.ToEnum<TaskStar>();
                        break;
                    case "TaskTargetNum":
                        _TaskTargetNum = value.ToNotNullString();
                        break;
                    case "TakeDate":
                        _TakeDate = value.ToDateTime();
                        break;
                    case "CompleteNum":
                        _CompleteNum = value.ToInt();
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserTask index[{0}] isn't exist.", index));
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

        /// <summary>
        /// ����ճ�������������
        /// ��ʽ���Ǽ� * ��ɫ�ȼ� * ϵ��
        /// </summary>
        /// <returns></returns>
        public int GetDailyExpNum(short userLv)
        {
            var cacheSet = new ShareCacheStruct<DailyTaskInfo>();
            int num = (int)Math.Floor((short)TaskStar * userLv * cacheSet.FindKey(TaskID).ExpRatioNum);
            return num.IsValid(0, int.MaxValue) ? num : 0;
        }

        /// <summary>
        /// ����ճ�������Ʒ����
        /// </summary>
        /// <param name="userLv"></param>
        /// <returns></returns>
        public UserItemInfo GetDailyItem(short userLv)
        {
            UserItemInfo userItem = null;
            int index = (int)TaskStar - 1;
            var cacheSet = new ShareCacheStruct<DailyTaskInfo>();
            DailyTaskInfo dtaskInfo = cacheSet.FindKey(TaskID);
            string[] NumRank = dtaskInfo.QishiNumRank.ToNotNullString().Split(new char[] { ',' });
            int num = NumRank.Length > index && index >= 0 ? NumRank[index].ToInt() : 0;
            if (num <= 0)
            {
                return userItem;
            }

            string[] QishiRank = dtaskInfo.QishiRank.ToNotNullString().Split(new char[] { ',' });
            string[] UserLvRank = dtaskInfo.UserLvRank.ToNotNullString().Split(new char[] { ',' });
            if (QishiRank.Length > 0 && QishiRank.Length == UserLvRank.Length)
            {
                int itemIndex = GetItemIndex(UserLvRank, userLv);
                int itemID = QishiRank.Length > itemIndex ? QishiRank[itemIndex].ToInt() : 0;
                ItemBaseInfo itemInfo = new ShareCacheStruct<ItemBaseInfo>().FindKey(itemID);
                if (itemInfo != null)
                {
                    userItem = new UserItemInfo();
                    userItem.ItemID = itemInfo.ItemID;
                    userItem.Num = num;
                }
            }
            return userItem;
        }

        private static int GetItemIndex(string[] UserLvRank, short userLv)
        {
            int index = 0;
            foreach (string item in UserLvRank)
            {
                if (item.ToInt() >= userLv)
                {
                    break;
                }
                index++;
            }
            return index;
        }

    }
}