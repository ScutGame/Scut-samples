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
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserPlotPrizeLog")]
    public class UserPlotPrizeLog : BaseEntity
    {
        #region auto-generated static method
        static UserPlotPrizeLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserPlotPrizeLog));
        }
        #endregion

        public UserPlotPrizeLog()
            : base(AccessLevel.WriteOnly)
        {
        }

        #region auto-generated Property
        private String _PrizeLogID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PrizeLogID", IsKey = true)]
        public String PrizeLogID
        {
            private get
            {
                return _PrizeLogID;
            }
            set
            {
                SetChange("PrizeLogID", value);
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
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotID")]
        public Int32 PlotID
        {
            private get
            {
                return _PlotID;
            }
            set
            {
                SetChange("PlotID", value);
            }
        }
        private Int32 _ScoreNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ScoreNum")]
        public Int32 ScoreNum
        {
            private get
            {
                return _ScoreNum;
            }
            set
            {
                SetChange("ScoreNum", value);
            }
        }
        private Int32 _ExpNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ExpNum")]
        public Int32 ExpNum
        {
            private get
            {
                return _ExpNum;
            }
            set
            {
                SetChange("ExpNum", value);
            }
        }
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Experience")]
        public Int32 Experience
        {
            private get
            {
                return _Experience;
            }
            set
            {
                SetChange("Experience", value);
            }
        }
        private Int32 _StarScore;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("StarScore")]
        public Int32 StarScore
        {
            private get
            {
                return _StarScore;
            }
            set
            {
                SetChange("StarScore", value);
            }
        }
        private Int32 _GameCoin;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GameCoin")]
        public Int32 GameCoin
        {
            private get
            {
                return _GameCoin;
            }
            set
            {
                SetChange("GameCoin", value);
            }
        }
        private CacheList<PrizeItemInfo> _PrizeItem;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeItemInfo> PrizeItem
        {
            private get
            {
                return _PrizeItem;
            }
            set
            {
                SetChange("PrizeItem", value);
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
                    case "PrizeLogID": return PrizeLogID;
                    case "UserID": return UserID;
                    case "PlotID": return PlotID;
                    case "ScoreNum": return ScoreNum;
                    case "ExpNum": return ExpNum;
                    case "Experience": return Experience;
                    case "StarScore": return StarScore;
                    case "GameCoin": return GameCoin;
                    case "PrizeItem": return PrizeItem;
                    case "CreateDate": return CreateDate;
                    default: throw new ArgumentException(string.Format("UserPlotPrizeLog index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "PrizeLogID":
                        _PrizeLogID = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "PlotID":
                        _PlotID = value.ToInt();
                        break;
                    case "ScoreNum":
                        _ScoreNum = value.ToInt();
                        break;
                    case "ExpNum":
                        _ExpNum = value.ToInt();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    case "StarScore":
                        _StarScore = value.ToInt();
                        break;
                    case "GameCoin":
                        _GameCoin = value.ToInt();
                        break;
                    case "PrizeItem":
                        _PrizeItem = ConvertCustomField<CacheList<PrizeItemInfo>>(value, index);
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserPlotPrizeLog index[{0}] isn't exist.", index));
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