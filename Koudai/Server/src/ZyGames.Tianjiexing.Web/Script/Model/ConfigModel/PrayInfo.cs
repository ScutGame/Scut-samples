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
using ZyGames.Framework.Model;
using ProtoBuf;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 祈祷奖励表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class PrayInfo : ShareEntity
    {


        public PrayInfo()
            : base(AccessLevel.ReadOnly)
        {
            PrayReward = new CacheList<PrizeInfo>();
        }

        public PrayInfo(Int32 PrayType)
            : this()
        {
            this.PrayType = PrayType;
        }

        #region 自动生成属性

        private Int32 _PrayType;
        /// <summary>
        /// 祈祷类型
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("PrayType", IsKey = true)]
        public Int32 PrayType
        {
            get
            {
                return _PrayType;
            }
            private set
            {
                SetChange("PrayType", value);
            }
        }

        private String _Describe;
        /// <summary>
        /// 祈祷说明
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("Describe")]
        public String Describe
        {
            get
            {
                return _Describe;
            }
            private set
            {
                SetChange("Describe", value);
            }
        }

        private CacheList<PrizeInfo> _PrayReward;
        /// <summary>
        /// 祈祷奖励配置
        /// </summary>        
        [ProtoMember(3)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeInfo> PrayReward
        {
            get
            {
                return _PrayReward;
            }
            private set
            {
                SetChange("PrayReward", value);
            }
        }
        private Int32 _DayNum;
        /// <summary>
        /// 祈祷类型天数
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("DayNum")]
        public Int32 DayNum
        {
            get
            {
                return _DayNum;
            }
            private set
            {
                SetChange("DayNum", value);
            }
        }
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "PrayType": return PrayType;
                    case "Describe": return Describe;
                    case "PrayReward": return PrayReward;
                    case "DayNum": return DayNum;
                    default: throw new ArgumentException(string.Format("PrayInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "PrayType":
                        _PrayType = value.ToInt();
                        break;
                    case "Describe":
                        _Describe = value.ToNotNullString();
                        break;
                    case "PrayReward":
                        _PrayReward = ConvertCustomField<CacheList<PrizeInfo>>(value, index); ;
                        break;
                    case "DayNum":
                        _DayNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("PrayInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

    }
}