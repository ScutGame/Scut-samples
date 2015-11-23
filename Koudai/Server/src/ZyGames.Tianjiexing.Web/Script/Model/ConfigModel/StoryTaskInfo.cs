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
using System.Collections.Generic;
using System.Linq;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]


    public class StoryTaskInfo : ShareEntity
    {
        public const string Index_PlotID = "Index_PlotID";
        public const string Index_TaskType = "Index_TaskType";

        public StoryTaskInfo()
            : base(AccessLevel.ReadOnly)
        {
            ReleaseDialogue = new CacheList<DialogueInfo>(0, true);
            TakedDialogue = new CacheList<DialogueInfo>(0, true);
            DeliveryDialogue = new CacheList<DialogueInfo>(0, true);
            PreTaskID = new int[0];
            Reward = new CacheList<PrizeInfo>(0, true);
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
        private int[] _PreTaskID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public int[] PreTaskID
        {
            get
            {
                return _PreTaskID;
            }
            private set
            {
                SetChange("PreTaskID", value);
            }
        }
        private CountryType _CountryID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CountryID")]
        public CountryType CountryID
        {
            get
            {
                return _CountryID;
            }
            private set
            {
                SetChange("CountryID", value);
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
        private Int32 _ReleaseNpcID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ReleaseNpcID")]
        public Int32 ReleaseNpcID
        {
            get
            {
                return _ReleaseNpcID;
            }
            private set
            {
                SetChange("ReleaseNpcID", value);
            }
        }
        private CacheList<DialogueInfo> _ReleaseDialogue;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<DialogueInfo> ReleaseDialogue
        {
            get
            {
                return _ReleaseDialogue;
            }
            private set
            {
                SetChange("ReleaseDialogue", value);
            }
        }
        private CacheList<DialogueInfo> _TakedDialogue;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<DialogueInfo> TakedDialogue
        {
            get
            {
                return _TakedDialogue;
            }
            private set
            {
                SetChange("TakedDialogue", value);
            }
        }
        private Int32 _DeliveryNpcID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("DeliveryNpcID")]
        public Int32 DeliveryNpcID
        {
            get
            {
                return _DeliveryNpcID;
            }
            private set
            {
                SetChange("DeliveryNpcID", value);
            }
        }
        private CacheList<DialogueInfo> _DeliveryDialogue;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<DialogueInfo> DeliveryDialogue
        {
            get
            {
                return _DeliveryDialogue;
            }
            private set
            {
                SetChange("DeliveryDialogue", value);
            }
        }
        private Int16 _TaskLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TaskLv")]
        public Int16 TaskLv
        {
            get
            {
                return _TaskLv;
            }
            private set
            {
                SetChange("TaskLv", value);
            }
        }
        private PlotTermsType _TermsType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TermsType")]
        public PlotTermsType TermsType
        {
            get
            {
                return _TermsType;
            }
            private set
            {
                SetChange("TermsType", value);
            }
        }
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotID")]
        public Int32 PlotID
        {
            get
            {
                return _PlotID;
            }
            private set
            {
                SetChange("PlotID", value);
            }
        }
        private Int32 _PlotNpcID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotNpcID")]
        public Int32 PlotNpcID
        {
            get
            {
                return _PlotNpcID;
            }
            private set
            {
                SetChange("PlotNpcID", value);
            }
        }
        private String _TargetMonsterID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TargetMonsterID")]
        public String TargetMonsterID
        {
            get
            {
                return _TargetMonsterID;
            }
            private set
            {
                SetChange("TargetMonsterID", value);
            }
        }
        private String _TargetMonsterNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TargetMonsterNum")]
        public String TargetMonsterNum
        {
            get
            {
                return _TargetMonsterNum;
            }
            private set
            {
                SetChange("TargetMonsterNum", value);
            }
        }
        private Int32 _TargetItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TargetItemID")]
        public Int32 TargetItemID
        {
            get
            {
                return _TargetItemID;
            }
            private set
            {
                SetChange("TargetItemID", value);
            }
        }
        private Int32 _TargetItemNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TargetItemNum")]
        public Int32 TargetItemNum
        {
            get
            {
                return _TargetItemNum;
            }
            private set
            {
                SetChange("TargetItemNum", value);
            }
        }
        private FunctionEnum _FunctionEnum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("FunctionEnum")]
        public FunctionEnum FunctionEnum
        {
            get
            {
                return _FunctionEnum;
            }
            private set
            {
                SetChange("FunctionEnum", value);
            }
        }
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Experience")]
        public Int32 Experience
        {
            get
            {
                return _Experience;
            }
            private set
            {
                SetChange("Experience", value);
            }
        }
        private Int32 _GameCoin;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GameCoin")]
        public Int32 GameCoin
        {
            get
            {
                return _GameCoin;
            }
            private set
            {
                SetChange("GameCoin", value);
            }
        }
        private String _EnablePlot;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EnablePlot")]
        public String EnablePlot
        {
            get
            {
                return _EnablePlot;
            }
            private set
            {
                SetChange("EnablePlot", value);
            }
        }
        private Int32 _Version;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Version")]
        public Int32 Version
        {
            get
            {
                return _Version;
            }
            private set
            {
                SetChange("Version", value);
            }
        }

        private Int32 _GeneralID;

        /// <summary>
        /// Ӷ��ID
        /// </summary>
        [EntityField("GeneralID")]
        public Int32 GeneralID
        {
            get
            {
                return _GeneralID;
            }
            private set
            {
                SetChange("GeneralID", value);
            }
        }

        private CacheList<PrizeInfo> _Reward;

        /// <summary>
        /// Ӷ��ID
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeInfo> Reward
        {
            get
            {
                return _Reward;
            }
            private set
            {
                SetChange("Reward", value);
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
                    case "PreTaskID": return PreTaskID;
                    case "CountryID": return CountryID;
                    case "TaskName": return TaskName;
                    case "TaskDescp": return TaskDescp;
                    case "ReleaseNpcID": return ReleaseNpcID;
                    case "ReleaseDialogue": return ReleaseDialogue;
                    case "TakedDialogue": return TakedDialogue;
                    case "DeliveryNpcID": return DeliveryNpcID;
                    case "DeliveryDialogue": return DeliveryDialogue;
                    case "TaskLv": return TaskLv;
                    case "TermsType": return TermsType;
                    case "PlotID": return PlotID;
                    case "PlotNpcID": return PlotNpcID;
                    case "TargetMonsterID": return TargetMonsterID;
                    case "TargetMonsterNum": return TargetMonsterNum;
                    case "TargetItemID": return TargetItemID;
                    case "TargetItemNum": return TargetItemNum;
                    case "FunctionEnum": return FunctionEnum;
                    case "Experience": return Experience;
                    case "GameCoin": return GameCoin;
                    case "EnablePlot": return EnablePlot;
                    case "Version": return Version;
                    case "GeneralID": return GeneralID;
                    case "Reward": return Reward;
                    default: throw new ArgumentException(string.Format("StoryTaskInfo index[{0}] isn't exist.", index));
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
                    case "PreTaskID":
                        _PreTaskID = value as int[] ?? new int[0];
                        break;
                    case "CountryID":
                        _CountryID = value.ToEnum<CountryType>();
                        break;
                    case "TaskName":
                        _TaskName = value.ToNotNullString();
                        break;
                    case "TaskDescp":
                        _TaskDescp = value.ToNotNullString();
                        break;
                    case "ReleaseNpcID":
                        _ReleaseNpcID = value.ToInt();
                        break;
                    case "ReleaseDialogue":
                        _ReleaseDialogue = ConvertCustomField<CacheList<DialogueInfo>>(value, index);
                        break;
                    case "TakedDialogue":
                        _TakedDialogue = ConvertCustomField<CacheList<DialogueInfo>>(value, index);
                        break;
                    case "DeliveryNpcID":
                        _DeliveryNpcID = value.ToInt();
                        break;
                    case "DeliveryDialogue":
                        _DeliveryDialogue = ConvertCustomField<CacheList<DialogueInfo>>(value, index);
                        break;
                    case "TaskLv":
                        _TaskLv = value.ToShort();
                        break;
                    case "TermsType":
                        _TermsType = value.ToEnum<PlotTermsType>();
                        break;
                    case "PlotID":
                        _PlotID = value.ToInt();
                        break;
                    case "PlotNpcID":
                        _PlotNpcID = value.ToInt();
                        break;
                    case "TargetMonsterID":
                        _TargetMonsterID = value.ToNotNullString();
                        break;
                    case "TargetMonsterNum":
                        _TargetMonsterNum = value.ToNotNullString();
                        break;
                    case "TargetItemID":
                        _TargetItemID = value.ToInt();
                        break;
                    case "TargetItemNum":
                        _TargetItemNum = value.ToInt();
                        break;
                    case "FunctionEnum":
                        _FunctionEnum = value.ToEnum<FunctionEnum>();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    case "GameCoin":
                        _GameCoin = value.ToInt();
                        break;
                    case "EnablePlot":
                        _EnablePlot = value.ToNotNullString();
                        break;
                    case "Version":
                        _Version = value.ToInt();
                        break;
                    case "GeneralID":
                        _GeneralID = value.ToInt();
                        break;
                    case "Reward":
                        _Reward = ConvertCustomField<CacheList<PrizeInfo>>(value, index);
                        break;
                    default: throw new ArgumentException(string.Format("StoryTaskInfo index[{0}] isn't exist.", index));
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

        /// <summary>
        /// ��ȡ�¼�����
        /// </summary>
        /// <param name="parentTaskID"></param>
        /// <returns></returns>
        public static IList<StoryTaskInfo> GetNextTask(int parentTaskID)
        {
            var cacheSet = new ShareCacheStruct<StoryTaskInfo>();
            return cacheSet.FindAll(m => m.PreTaskID.Any(taskId => taskId == parentTaskID));
        }

    }
}