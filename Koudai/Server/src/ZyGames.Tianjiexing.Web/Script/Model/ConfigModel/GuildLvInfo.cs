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
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class GuildLvInfo : ShareEntity
    {
        public static int GuildMaxLv = ConfigEnvSet.GetInt("Guild.MaxGuildLv"); //������ߵȼ�

        public GuildLvInfo()
            : base(AccessLevel.ReadOnly)
        {
            ActivityDesc = new CacheList<ActivityShow>(0, true);
        }

        #region auto-generated Property
        private Int16 _GuildLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GuildLv", IsKey = true)]
        public Int16 GuildLv
        {
            get
            {
                return _GuildLv;
            }
            private set
            {
                SetChange("GuildLv", value);
            }
        }
        private Int32 _UpExperience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UpExperience")]
        public Int32 UpExperience
        {
            get
            {
                return _UpExperience;
            }
            private set
            {
                SetChange("UpExperience", value);
            }
        }
        private Int32 _MaxPeople;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MaxPeople")]
        public Int32 MaxPeople
        {
            get
            {
                return _MaxPeople;
            }
            private set
            {
                SetChange("MaxPeople", value);
            }
        }
        private CacheList<ActivityShow> _ActivityDesc;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<ActivityShow> ActivityDesc
        {
            get
            {
                return _ActivityDesc;
            }
            private set
            {
                SetChange("ActivityDesc", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "GuildLv": return GuildLv;
                    case "UpExperience": return UpExperience;
                    case "MaxPeople": return MaxPeople;
                    case "ActivityDesc": return ActivityDesc;
                    default: throw new ArgumentException(string.Format("GuildLvInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "GuildLv":
                        _GuildLv = value.ToShort();
                        break;
                    case "UpExperience":
                        _UpExperience = value.ToInt();
                        break;
                    case "MaxPeople":
                        _MaxPeople = value.ToInt();
                        break;
                    case "ActivityDesc":
                        _ActivityDesc =ConvertCustomField<CacheList<ActivityShow>>(value, index); 
                        break;
                    default: throw new ArgumentException(string.Format("GuildLvInfo index[{0}] isn't exist.", index));
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