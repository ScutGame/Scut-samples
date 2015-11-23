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
    /// ��ҹ�����Ϣ��
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data, OrderColumn = "GuildRank")]

    public class UserGuild : ShareEntity
    {

        public const int ActiveID = 8;
        public const string Index_GuildName = "Index_GuildName";

        public UserGuild()
            : base(AccessLevel.ReadWrite)
        {
            GuildBossInfo = new GuildBossInfo();
            AbilityInfo = new CacheList<GuildAbility>();
            GuildExercise = new GuildExercise();
        }
        //protected override void BindChangeEvent()
        //{
        //    GuildBossInfo.BindParentChangeEvent(this);
        //    AbilityInfo.BindParentChangeEvent(this);
        //    GuildExercise.BindParentChangeEvent(this);
        //}

        #region auto-generated Property
        private String _GuildID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("GuildID", IsKey = true)]
        public String GuildID
        {
            get
            {
                return _GuildID;
            }
            set
            {
                SetChange("GuildID", value);
            }
        }
        private String _GuildName;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("GuildName")]
        public String GuildName
        {
            get
            {
                return _GuildName;
            }
            set
            {
                SetChange("GuildName", value);
            }
        }
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("UserID")]
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
        private Int16 _GuildLv;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("GuildLv")]
        public Int16 GuildLv
        {
            get
            {
                return _GuildLv;
            }
            set
            {
                SetChange("GuildLv", value);
            }
        }
        private Int32 _GuildRank;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("GuildRank")]
        public Int32 GuildRank
        {
            get
            {
                return _GuildRank;
            }
            set
            {
                SetChange("GuildRank", value);
            }
        }
        private Int32 _CurrExperience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("CurrExperience")]
        public Int32 CurrExperience
        {
            get
            {
                return _CurrExperience;
            }
            set
            {
                SetChange("CurrExperience", value);
            }
        }
        private Int32 _WeekExperience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("WeekExperience")]
        public Int32 WeekExperience
        {
            get
            {
                return _WeekExperience;
            }
            set
            {
                SetChange("WeekExperience", value);
            }
        }
        private String _Announcement;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("Announcement")]
        public String Announcement
        {
            get
            {
                return _Announcement;
            }
            set
            {
                SetChange("Announcement", value);
            }
        }
        private String _GuildDesc;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("GuildDesc")]
        public String GuildDesc
        {
            get
            {
                return _GuildDesc;
            }
            set
            {
                SetChange("GuildDesc", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
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
        private GuildBossInfo _GuildBossInfo;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField(true, ColumnDbType.LongText)]
        public GuildBossInfo GuildBossInfo
        {
            get
            {
                return _GuildBossInfo;
            }
            set
            {
                SetChange("GuildBossInfo", value);
            }
        }
        private Int32 _AddMember;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField("AddMember")]
        public Int32 AddMember
        {
            get
            {
                return _AddMember;
            }
            set
            {
                SetChange("AddMember", value);
            }
        }
        private Int32 _CurrDonateNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        [EntityField("CurrDonateNum")]
        public Int32 CurrDonateNum
        {
            get
            {
                return _CurrDonateNum;
            }
            set
            {
                SetChange("CurrDonateNum", value);
            }
        }
        private CacheList<GuildAbility> _AbilityInfo;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<GuildAbility> AbilityInfo
        {
            get
            {
                return _AbilityInfo;
            }
            set
            {
                SetChange("AbilityInfo", value);
            }
        }
        private GuildExercise _GuildExercise;
        /// <summary>
        /// ���᳿����Ϣ
        /// </summary>
        [ProtoMember(15)]
        [EntityField(true, ColumnDbType.LongText)]
        public GuildExercise GuildExercise
        {
            get
            {
                return _GuildExercise;
            }
            set
            {
                SetChange("GuildExercise", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "GuildID": return GuildID;
                    case "GuildName": return GuildName;
                    case "UserID": return UserID;
                    case "GuildLv": return GuildLv;
                    case "GuildRank": return GuildRank;
                    case "CurrExperience": return CurrExperience;
                    case "WeekExperience": return WeekExperience;
                    case "Announcement": return Announcement;
                    case "GuildDesc": return GuildDesc;
                    case "CreateDate": return CreateDate;
                    case "GuildBossInfo": return GuildBossInfo;
                    case "AddMember": return AddMember;
                    case "CurrDonateNum": return CurrDonateNum;
                    case "AbilityInfo": return AbilityInfo;
                    case "GuildExercise": return GuildExercise;
                    default: throw new ArgumentException(string.Format("UserGuild index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "GuildID":
                        _GuildID = value.ToNotNullString();
                        break;
                    case "GuildName":
                        _GuildName = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "GuildLv":
                        _GuildLv = value.ToShort();
                        break;
                    case "GuildRank":
                        _GuildRank = value.ToInt();
                        break;
                    case "CurrExperience":
                        _CurrExperience = value.ToInt();
                        break;
                    case "WeekExperience":
                        _WeekExperience = value.ToInt();
                        break;
                    case "Announcement":
                        _Announcement = value.ToNotNullString();
                        break;
                    case "GuildDesc":
                        _GuildDesc = value.ToNotNullString();
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    case "GuildBossInfo":
                        _GuildBossInfo = ConvertCustomField<GuildBossInfo>(value, index);
                        break;
                    case "AddMember":
                        _AddMember = value.ToInt();
                        break;
                    case "CurrDonateNum":
                        _CurrDonateNum = value.ToInt();
                        break;
                    case "AbilityInfo":
                        _AbilityInfo = ConvertCustomField<CacheList<GuildAbility>>(value, index);
                        break;
                    case "GuildExercise":
                        _GuildExercise = ConvertCustomField<GuildExercise>(value, index);
                        break;
                    default: throw new ArgumentException(string.Format("UserGuild index[{0}] isn't exist.", index));
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
        /// �����л�Boss����
        /// </summary>
        public BossActivePrize BossPrize
        {
            get;
            set;
        }

        /// <summary>
        /// �״̬
        /// </summary>
        public CombatStatus CombatStatus { get; set; }

        /// <summary>
        /// ���ʼʱ��
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// �����ʱ��
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// �Ƿ��ʼ���ɹ�
        /// </summary>
        public bool LoadSuccess { get; set; }

        /// <summary>
        /// �����ʱ��
        /// </summary>
        public int ColdTime
        {
            get
            {
                var cacheSet = new ShareCacheStruct<GameActive>();
                var gactive = cacheSet.FindKey(ActiveID);
                if (CombatStatus == CombatStatus.Wait)
                {
                    //��1����״̬�ı���ӳ�ʱ��
                    return (int)Math.Floor((BeginTime.AddMinutes(gactive.WaitMinutes) - DateTime.Now).TotalSeconds);
                }
                if (CombatStatus == CombatStatus.Combat)
                {
                    return (int)Math.Floor((BeginTime.AddMinutes(gactive.Minutes) - DateTime.Now).TotalSeconds);
                }
                return 0;
            }
        }
        public CombatStatus GuildBossRefreshStatus()
        {
            if (CombatStatus != CombatStatus.NoStart && CombatStatus != CombatStatus.Over)
            {
                var cacheSet = new ShareCacheStruct<GameActive>();
                DateTime currTime = DateTime.Now;
                GameActive active = cacheSet.FindKey(ActiveID);
                if (active != null)
                {
                    if (GuildBossInfo != null)
                    {
                        BeginTime = GuildBossInfo.EnablePeriod.ToDateTime(DateTime.MinValue);
                        EndTime = BeginTime.AddMinutes(active.Minutes);
                        if (BeginTime > currTime)
                        {
                            lock (this)
                            {
                                CombatStatus = CombatStatus.NoStart;
                            }
                        }
                        else if (EndTime < currTime)
                        {
                            lock (this)
                            {
                                CombatStatus = CombatStatus.Over;
                            }
                        }
                    }
                }
            }
            return CombatStatus;
        }
    }
}