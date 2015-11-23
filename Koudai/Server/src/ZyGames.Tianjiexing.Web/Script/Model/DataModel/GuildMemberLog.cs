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
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data)]
    public class GuildMemberLog : ShareEntity
    {

        private const int LogMax = 50;

        public GuildMemberLog()
            : base(AccessLevel.ReadWrite)
        {
            GuildLog = new CacheList<MemberLog>();
        }
        //protected override void BindChangeEvent()
        //{
        //    GuildLog.BindParentChangeEvent(this);
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
        private CacheList<MemberLog> _GuildLog;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<MemberLog> GuildLog
        {
            get
            {
                return _GuildLog;
            }
            set
            {
                SetChange("GuildLog", value);
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
                    case "GuildLog": return GuildLog;
                    default: throw new ArgumentException(string.Format("GuildMemberLog index[{0}] isn't exist.", index));
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
                    case "GuildLog":
                        _GuildLog =ConvertCustomField<CacheList<MemberLog>>(value, index); 
                        break;
                    default: throw new ArgumentException(string.Format("GuildMemberLog index[{0}] isn't exist.", index));
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

        public List<MemberLog> GetLog(Predicate<MemberLog> match)
        {
            int rd = 0;
            var list = GuildLog.FindAll(match);//var list = (match != null) ? GuildLog.FindAll(match) : GuildLog;
            return list.GetPaging(0, LogMax, out rd); //list.GetRange(0, LogMax, out rd);
        }

        private CacheList<MemberLog> GetPaging<T1>(int p, int LogMax, out int rd)
        {
            throw new NotImplementedException();
        }

        public static void AddLog(string guidId, MemberLog log)
        {
            var cacheSet = new ShareCacheStruct<GuildMemberLog>();
            GuildMemberLog memberLog = cacheSet.FindKey(guidId);
            if (memberLog == null)
            {
                memberLog = new GuildMemberLog() { GuildID = guidId };
                cacheSet.Add(memberLog,DefIdentityId);
            }
            int Count = memberLog.GuildLog.Count > LogMax ? memberLog.GuildLog.Count - LogMax : 0;
            for (int i = 0; i < Count; i++)
            {
                memberLog.GuildLog.RemoveAt(0);
            }
            memberLog.GuildLog.Add(log);
        }

    }
}