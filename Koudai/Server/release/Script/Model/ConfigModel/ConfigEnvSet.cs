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
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class ConfigEnvSet : ShareEntity
    {


        public static int GetInt(string key)
        {
            var item = new ShareCacheStruct<ConfigEnvSet>().FindKey(key);
            return item == null ? 0 : item.EnvValue.ToInt();
        }

        public static decimal GetDecimal(string key)
        {
            var item = new ShareCacheStruct<ConfigEnvSet>().FindKey(key);
            return item == null ? 0 : item.EnvValue.ToDecimal();
        }
        public static double GetDouble(string key)
        {
            var item = new ShareCacheStruct<ConfigEnvSet>().FindKey(key);
            return item == null ? 0 : item.EnvValue.ToDouble();
        }

        public static string GetString(string key)
        {
            var item = new ShareCacheStruct<ConfigEnvSet>().FindKey(key);
            return item == null ? "" : item.EnvValue.ToNotNullString();
        }
        
        public ConfigEnvSet()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private String _EnvKey;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EnvKey", IsKey = true)]
        public String EnvKey
        {
            get
            {
                return _EnvKey;
            }
            private set
            {
                SetChange("EnvKey", value);
            }
        }
        private String _EnvValue;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EnvValue")]
        public String EnvValue
        {
            get
            {
                return _EnvValue;
            }
            private set
            {
                SetChange("EnvValue", value);
            }
        }
        private Int16 _EnvType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EnvType")]
        public Int16 EnvType
        {
            get
            {
                return _EnvType;
            }
            private set
            {
                SetChange("EnvType", value);
            }
        }
        private String _EnvDesc;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EnvDesc")]
        public String EnvDesc
        {
            get
            {
                return _EnvDesc;
            }
            private set
            {
                SetChange("EnvDesc", value);
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
                    case "EnvType": return EnvType;
                    case "EnvDesc": return EnvDesc;
					default: throw new ArgumentException(string.Format("ConfigEnvSet index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "EnvKey": 
                        _EnvKey = value.ToNotNullString(); 
                        break; 
                    case "EnvValue": 
                        _EnvValue = value.ToNotNullString(); 
                        break; 
                    case "EnvType": 
                        _EnvType = value.ToShort(); 
                        break; 
                    case "EnvDesc": 
                        _EnvDesc = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("ConfigEnvSet index[{0}] isn't exist.", index));
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