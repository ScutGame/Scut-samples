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
using ZyGames.Tianjiexing.Model.Enum;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 神秘事件配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class MysteryInfo : ShareEntity
    {


        public MysteryInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        public MysteryInfo(MysteryType MysteryType)
            : this()
        {
            this.MysteryType = MysteryType;
        }

        #region 自动生成属性

        private MysteryType _MysteryType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("MysteryType", IsKey = true)]
        public MysteryType MysteryType
        {
            get
            {
                return _MysteryType;
            }
            private set
            {
                SetChange("MysteryType", value);
            }
        }

        private Decimal _Probability;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("Probability")]
        public Decimal Probability
        {
            get
            {
                return _Probability;
            }
            private set
            {
                SetChange("Probability", value);
            }
        }

        private Int32 _DailyNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("DailyNum")]
        public Int32 DailyNum
        {
            get
            {
                return _DailyNum;
            }
            private set
            {
                SetChange("DailyNum", value);
            }
        }

        private CacheList<PrizeInfo> _PrizeInfo;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeInfo> PrizeInfo
        {
            get
            {
                return _PrizeInfo;
            }
            private set
            {
                SetChange("PrizeInfo", value);
            }
        }

        private String _Prompt;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("Prompt")]
        public String Prompt
        {
            get
            {
                return _Prompt;
            }
            private set
            {
                SetChange("Prompt", value);
            }
        }

        private String _Broadcast;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("Broadcast")]
        public String Broadcast
        {
            get
            {
                return _Broadcast;
            }
            private set
            {
                SetChange("Broadcast", value);
            }
        }
        private string _winPrompt;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("WinPrompt")]
        public string WinPrompt
        {
            get
            {
                return _winPrompt;
            }

        }
        private string _winBroadcast;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("WinBroadcast")]
        public string WinBroadcast
        {
            get
            {
                return _winBroadcast;
            }

        }
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "MysteryType": return MysteryType;
                    case "Probability": return Probability;
                    case "DailyNum": return DailyNum;
                    case "PrizeInfo": return PrizeInfo;
                    case "Prompt": return Prompt;
                    case "Broadcast": return Broadcast;
                    case "WinPrompt": return _winPrompt;
                    case "WinBroadcast": return _winBroadcast;

                    default: throw new ArgumentException(string.Format("MysteryInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "MysteryType":
                        _MysteryType = value.ToEnum<MysteryType>();
                        break;
                    case "Probability":
                        _Probability = value.ToDecimal();
                        break;
                    case "DailyNum":
                        _DailyNum = value.ToInt();
                        break;
                    case "PrizeInfo":
                        _PrizeInfo = ConvertCustomField<CacheList<PrizeInfo>>(value, index);
                        break;
                    case "Prompt":
                        _Prompt = value.ToNotNullString();
                        break;
                    case "Broadcast":
                        _Broadcast = value.ToNotNullString();
                        break;
                    case "WinPrompt":
                        _winPrompt = value.ToNotNullString();
                        break;
                    case "WinBroadcast":
                        _winBroadcast = value.ToNotNullString();
                        break; 
                    default: throw new ArgumentException(string.Format("MysteryInfo index[{0}] isn't exist.", index));
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