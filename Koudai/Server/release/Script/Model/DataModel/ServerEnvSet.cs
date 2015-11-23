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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data)]
    public class ServerEnvSet : ShareEntity
    {
        public ServerEnvSet()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private ServerEnvKey _EnvKey;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("EnvKey", IsKey = true)]
        public ServerEnvKey EnvKey
        {
            get
            {
                return _EnvKey;
            }
            set
            {
                SetChange("EnvKey", value);
            }
        }
        private String _EnvValue;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("EnvValue")]
        public String EnvValue
        {
            get
            {
                return _EnvValue;
            }
            set
            {
                SetChange("EnvValue", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "EnvKey": return EnvKey;
                    case "EnvValue": return EnvValue;
                    default: throw new ArgumentException(string.Format("ServerEnvSet index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "EnvKey":
                        _EnvKey = value.ToEnum<ServerEnvKey>();
                        break;
                    case "EnvValue":
                        _EnvValue = value.ToNotNullString();
                        break;
                    default: throw new ArgumentException(string.Format("ServerEnvSet index[{0}] isn't exist.", index));
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
        public static string Get(ServerEnvKey envKey, Object defaultValue)
        {
            var cacheSet = new ShareCacheStruct<ServerEnvSet>();
            if (cacheSet.FindKey(envKey) == null)
            {
                Set(envKey, defaultValue);
                return defaultValue.ToNotNullString();
            }
            else
            {
                return new ShareCacheStruct<ServerEnvSet>().FindKey(envKey).EnvValue;
            }
        }

        public static void Set(ServerEnvKey envKey, Object value)
        {
            var cacheSet = new ShareCacheStruct<ServerEnvSet>();
            ServerEnvSet envSet = cacheSet.FindKey(envKey);
            if (envSet == null)
            {
                envSet = new ServerEnvSet() { EnvKey = envKey, EnvValue = value.ToNotNullString() };
                cacheSet.Add(envSet, 0);
            }
            else
            {
                envSet.EnvValue = value.ToNotNullString();
            }
        }

        public static int GetInt(ServerEnvKey envKey, int defaultValue)
        {
            var cacheSet = new ShareCacheStruct<ServerEnvSet>();
            if (cacheSet.FindKey(envKey) == null)
            {
                Set(envKey, defaultValue);
                return defaultValue;
            }
            return new ShareCacheStruct<ServerEnvSet>().FindKey(envKey).EnvValue.ToInt();
        }
    }
}