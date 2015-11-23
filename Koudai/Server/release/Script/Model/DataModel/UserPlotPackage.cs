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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Model;
using ProtoBuf;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserPlotPackage : BaseEntity
    {

        public static UserPlotPackage Get(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentNullException("UserID为空");
            }
            var cacheSet = new PersonalCacheStruct<UserPlotPackage>();
            var data = cacheSet.FindKey(userId);
            if (data != null)
            {
                return data;
            }
            BaseLog log = new BaseLog();
            log.SaveLog(new NullReferenceException(string.Format("User:{0} UserPlot package is null.", userId)));
            return null;
        }

        /// <summary>
        /// </summary>
        public UserPlotPackage()
            : base(AccessLevel.ReadWrite)
        {
        }
        /// <summary>
        /// </summary>
        public UserPlotPackage(String UserID)
            : this()
        {
            this._UserID = UserID;
            PlotPackage = new CacheList<UserPlotInfo>
                              {
                                  new UserPlotInfo(){PlotID = 1222, BossChallengeCount = 5},
                                  new UserPlotInfo(){PlotID = 1223, BossChallengeCount = 5},
                                  new UserPlotInfo(){PlotID = 1224, BossChallengeCount = 5}
                              };
        }

        #region 自动生成属性

        private String _UserID;
        /// <summary>
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

        private CacheList<UserPlotInfo> _PlotPackage;
        /// <summary>
        /// </summary>        
        [ProtoMember(2)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<UserPlotInfo> PlotPackage
        {
            get
            {
                return _PlotPackage;
            }
            set
            {
                SetChange("PlotPackage", value);
            }
        }
        private DateTime _EngageDate;
        /// <summary>
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("EngageDate")]
        public DateTime EngageDate
        {
            get
            {
                return _EngageDate;
            }
            set
            {
                SetChange("EngageDate", value);
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
                    case "PlotPackage": return PlotPackage;
                    case "EngageDate": return EngageDate;
                    default: throw new ArgumentException(string.Format("UserPlotPackage index[{0}] isn't exist.", index));
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
                    case "PlotPackage":
                        _PlotPackage = ConvertCustomField<CacheList<UserPlotInfo>>(value, index);
                        break;
                    case "EngageDate":
                        _EngageDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserPlotPackage index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //设置玩家的UserID
            //若要做为全局使用设置类绑定的自定义属性[EntityTable(CacheType.Entity, DbConfig.Config, @TableName, @PeriodTime)]
            return UserID.ToInt();
        }


        public void SaveItem(UserPlotInfo item)
        {
            if (item == null || item.PlotID == 0) return;
            var tempItem = PlotPackage.Find(s => s.PlotID == item.PlotID);
            if (tempItem == null)
            {
                PlotPackage.Add(item);
            }
            else
            {
                tempItem.UpdateNotify(obj =>
                {
                    tempItem.PlotID = item.PlotID;
                    tempItem.PlotStatus = item.PlotStatus;
                    tempItem.ScoreNum = item.ScoreNum;
                    tempItem.AttackScore = item.AttackScore;
                    tempItem.DefenseScore = item.DefenseScore;
                    tempItem.StarScore = item.StarScore;
                    tempItem.ExpNum = item.ExpNum;
                    tempItem.Experience = item.Experience;
                    tempItem.PennyNum = item.PennyNum;
                    tempItem.GoldNum = item.GoldNum;
                    tempItem.ItemID = item.ItemID;
                    tempItem.CompleteDate = item.CompleteDate;
                    tempItem.RefleshDate = item.RefleshDate;
                    tempItem.CreateDate = item.CreateDate;
                    tempItem.BlessPennyNum = item.BlessPennyNum;
                    tempItem.BlessExperience = item.BlessExperience;
                    tempItem.EnchantID = item.EnchantID;
                    return true;
                });
            }
        }
    }
}