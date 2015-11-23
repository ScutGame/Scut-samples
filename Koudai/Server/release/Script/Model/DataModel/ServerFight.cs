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
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ProtoBuf;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 公会城市争夺战全局表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Entity, DbConfig.Data, Condition = "IsRemove=0")]

    public class ServerFight : ShareEntity
    {
        public const string Index_FastID = "Index_FastID";
        public ServerFight()
            : base(AccessLevel.ReadWrite)
        {
        }

        public ServerFight(Int32 FastID, String GuildID)
            : this()
        {
            this.FastID = FastID;
            this.GuildID = GuildID;
        }

        #region 自动生成属性

        private Int32 _FastID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("FastID", IsKey = true)]
        public Int32 FastID
        {
            get { return _FastID; }
            private set
            {
                SetChange("FastID", value);
            }
        }

        private String _GuildID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("GuildID", IsKey = true)]
        public String GuildID
        {
            get
            {
                return _GuildID;
            }
            private set
            {
                SetChange("GuildID", value);
            }
        }

        private Int32 _CityID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("CityID")]
        public Int32 CityID
        {
            get
            {
                return _CityID;
            }
            set
            {
                SetChange("CityID", value);
            }
        }

        private String _GuildBanner;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("GuildBanner")]
        public String GuildBanner
        {
            get
            {
                return _GuildBanner;
            }
            set
            {
                SetChange("GuildBanner", value);
            }
        }

        private Int16 _RankID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("RankID")]
        public Int16 RankID
        {
            get
            {
                return _RankID;
            }
            set
            {
                SetChange("RankID", value);
            }
        }

        private DateTime _ApplyDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("ApplyDate")]
        public DateTime ApplyDate
        {
            get
            {
                return _ApplyDate;
            }
            set
            {
                SetChange("ApplyDate", value);
            }
        }

        private String _CombatMember;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("CombatMember")]
        public String CombatMember
        {
            get
            {
                return _CombatMember;
            }
            set
            {
                SetChange("CombatMember", value);
            }
        }

        private FightStage _Stage;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("Stage")]
        public FightStage Stage
        {
            get
            {
                return _Stage;
            }
            set
            {
                SetChange("Stage", value);
            }
        }

        private Int16 _LostCount = 0;
        /// <summary>
        /// 胜利次数
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("LostCount")]
        public Int16 LostCount
        {
            get
            {
                return _LostCount;
            }
            set
            {
                SetChange("LostCount", value);
            }
        }

        private bool _IsRemove;

        /// <summary>
        /// 是否移除
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("IsRemove")]
        public bool IsRemove
        {
            get
            {
                return _IsRemove;
            }
            set
            {
                SetChange("IsRemove", value);
            }
        }

        private bool _IsBanner;
        /// <summary>
        /// 旗帜名称是否变换
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("IsBanner")]
        public bool IsBanner
        {
            get
            {
                return _IsBanner;
            }
            set
            {
                SetChange("IsBanner", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "FastID": return FastID;
                    case "GuildID": return GuildID;
                    case "CityID": return CityID;
                    case "GuildBanner": return GuildBanner;
                    case "RankID": return RankID;
                    case "ApplyDate": return ApplyDate;
                    case "CombatMember": return CombatMember;
                    case "Stage": return Stage;
                    case "LostCount": return LostCount;
                    case "IsRemove": return IsRemove;
                    case "IsBanner": return IsBanner;
                    default: throw new ArgumentException(string.Format("ServerFight index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "FastID":
                        _FastID = value.ToInt();
                        break;
                    case "GuildID":
                        _GuildID = value.ToNotNullString();
                        break;
                    case "CityID":
                        _CityID = value.ToInt();
                        break;
                    case "GuildBanner":
                        _GuildBanner = value.ToNotNullString();
                        break;
                    case "RankID":
                        _RankID = value.ToShort();
                        break;
                    case "ApplyDate":
                        _ApplyDate = value.ToDateTime();
                        break;
                    case "CombatMember":
                        _CombatMember = value.ToNotNullString();
                        break;
                    case "Stage":
                        _Stage = value.ToEnum<FightStage>();
                        break;
                    case "LostCount":
                        _LostCount = value.ToShort();
                        break;
                    case "IsRemove":
                        _IsRemove = value.ToBool();
                        break;
                    case "IsBanner":
                        _IsBanner = value.ToBool();
                        break;
                    default: throw new ArgumentException(string.Format("ServerFight index[{0}] isn't exist.", index));
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
        /// 结果
        /// </summary>
        public bool GetResult(FightStage stage)
        {
            switch (stage)
            {
                case FightStage.Close:
                case FightStage.Apply:
                    return true;
                case FightStage.quarter_final:
                    return LostCount >= 1;
                case FightStage.semi_final:
                    return LostCount >= 2;
                case FightStage.final:
                    return LostCount >= 3;
                default:
                    break;
            }
            return true;

        }
    }
}