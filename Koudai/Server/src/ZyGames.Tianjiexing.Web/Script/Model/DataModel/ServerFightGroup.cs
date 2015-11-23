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
    /// 公会城市争夺战分组表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Entity, DbConfig.Data, Condition = "IsRemove=0")]

    public class ServerFightGroup : ShareEntity
    {
        public const string Index_FastID = "Index_FastID";

        public ServerFightGroup()
            : base(AccessLevel.ReadWrite)
        {
        }

        public ServerFightGroup(String ID)
            : this()
        {
            this.ID = ID;
        }

        #region 自动生成属性

        private String _ID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("ID", IsKey = true)]
        public String ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                SetChange("ID", value);
            }
        }

        private Int32 _FastID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("FastID")]
        public Int32 FastID
        {
            get
            {
                return _FastID;
            }
            set
            {
                SetChange("FastID", value);
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

        private FightStage _Stage;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
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

        private Int32 _NO;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("NO")]
        public Int32 NO
        {
            get
            {
                return _NO;
            }
            set
            {
                SetChange("NO", value);
            }
        }

        private Int32 _Round;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("Round")]
        public Int32 Round
        {
            get
            {
                return _Round;
            }
            set
            {
                SetChange("Round", value);
            }
        }

        private String _GuildIDA;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("GuildIDA")]
        public String GuildIDA
        {
            get
            {
                return _GuildIDA;
            }
            set
            {
                SetChange("GuildIDA", value);
            }
        }

        private Int32 _Awin;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("Awin")]
        public Int32 Awin
        {
            get
            {
                return _Awin;
            }
            set
            {
                SetChange("Awin", value);
            }
        }

        private String _GuildIDB;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("GuildIDB")]
        public String GuildIDB
        {
            get
            {
                return _GuildIDB;
            }
            set
            {
                SetChange("GuildIDB", value);
            }
        }

        private Int32 _Bwin;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("Bwin")]
        public Int32 Bwin
        {
            get
            {
                return _Bwin;
            }
            set
            {
                SetChange("Bwin", value);
            }
        }

        private String _WinGuildID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("WinGuildID")]
        public String WinGuildID
        {
            get
            {
                return _WinGuildID;
            }
            set
            {
                SetChange("WinGuildID", value);
            }
        }

        private bool _IsRemove;

        /// <summary>
        /// 是否移除
        /// </summary>        
        [ProtoMember(12)]
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

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ID": return ID;
                    case "FastID": return FastID;
                    case "CityID": return CityID;
                    case "Stage": return Stage;
                    case "NO": return NO;
                    case "Round": return Round;
                    case "GuildIDA": return GuildIDA;
                    case "Awin": return Awin;
                    case "GuildIDB": return GuildIDB;
                    case "Bwin": return Bwin;
                    case "WinGuildID": return WinGuildID;
                    case "IsRemove": return IsRemove;
                    default: throw new ArgumentException(string.Format("ServerFightGroup index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ID":
                        _ID = value.ToNotNullString();
                        break;
                    case "FastID":
                        _FastID = value.ToInt();
                        break;
                    case "CityID":
                        _CityID = value.ToInt();
                        break;
                    case "Stage":
                        _Stage = value.ToEnum<FightStage>();
                        break;
                    case "NO":
                        _NO = value.ToInt();
                        break;
                    case "Round":
                        _Round = value.ToInt();
                        break;
                    case "GuildIDA":
                        _GuildIDA = value.ToNotNullString();
                        break;
                    case "Awin":
                        _Awin = value.ToInt();
                        break;
                    case "GuildIDB":
                        _GuildIDB = value.ToNotNullString();
                        break;
                    case "Bwin":
                        _Bwin = value.ToInt();
                        break;
                    case "WinGuildID":
                        _WinGuildID = value.ToNotNullString();
                        break;
                    case "IsRemove":
                        _IsRemove = value.ToBool();
                        break;
                    default: throw new ArgumentException(string.Format("ServerFightGroup index[{0}] isn't exist.", index));
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
        /// 结果0没有结果
        /// </summary>
        public int Result
        {
            get
            {
                if (Awin == 0 && Bwin == 0)
                    return 0;
                switch (Stage)
                {
                    case FightStage.Close:
                    case FightStage.Apply:
                        return 0;
                    case FightStage.quarter_final:
                    case FightStage.semi_final:
                    case FightStage.final:
                        if (WinGuildID == GuildIDA) return 1;
                        if (WinGuildID == GuildIDB) return 2;
                        return 0;
                    default:
                        return 0;
                }
            }
        }

    }
}