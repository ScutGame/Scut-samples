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
using ZyGames.Tianjiexing.Model.Enum;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class GuildAbilityInfo : ShareEntity
    {

        
        public GuildAbilityInfo()
            : base(AccessLevel.ReadOnly)
        {
            PreAbility = new List<string>();
        }
        
        #region auto-generated Property
        private Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ID", IsKey = true)]
        public Int32 ID
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
        private Boolean _IsCityCombat;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsCityCombat")]
        public Boolean IsCityCombat
        {
            get
            {
                return _IsCityCombat;
            }
            private set
            {
                SetChange("IsCityCombat", value);
            }
        }
        private GuildAbilityType _GuildAbilityType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GuildAbilityType")]
        public GuildAbilityType GuildAbilityType
        {
            get
            {
                return _GuildAbilityType;
            }
            private set
            {
                SetChange("GuildAbilityType", value);
            }
        }
        private String _AbilityName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityName")]
        public String AbilityName
        {
            get
            {
                return _AbilityName;
            }
            private set
            {
                SetChange("AbilityName", value);
            }
        }
        private String _AbilityHead;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityHead")]
        public String AbilityHead
        {
            get
            {
                return _AbilityHead;
            }
            private set
            {
                SetChange("AbilityHead", value);
            }
        }
        private List<string> _PreAbility;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PreAbility")]
        public List<string> PreAbility
        {
            get
            {
                return _PreAbility;
            }
            private set
            {
                SetChange("PreAbility", value);
            }
        }
        private String _PreAbilityLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PreAbilityLv")]
        public String PreAbilityLv
        {
            get
            {
                return _PreAbilityLv;
            }
            private set
            {
                SetChange("PreAbilityLv", value);
            }
        }
        private String _AbilityDesc;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityDesc")]
        public String AbilityDesc
        {
            get
            {
                return _AbilityDesc;
            }
            private set
            {
                SetChange("AbilityDesc", value);
            }
        }
        private Int32 _Version;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Version")]
        public Int32 Version
        {
            get
            {
                return _Version;
            }
            private set
            {
                SetChange("Version", value);
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
                    case "IsCityCombat": return IsCityCombat;
                    case "GuildAbilityType": return GuildAbilityType;
                    case "AbilityName": return AbilityName;
                    case "AbilityHead": return AbilityHead;
                    case "PreAbility": return PreAbility;
                    case "PreAbilityLv": return PreAbilityLv;
                    case "AbilityDesc": return AbilityDesc;
                    case "Version": return Version;
					default: throw new ArgumentException(string.Format("GuildAbilityInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _ID = value.ToInt(); 
                        break; 
                    case "IsCityCombat": 
                        _IsCityCombat = value.ToBool(); 
                        break; 
                    case "GuildAbilityType":
                        _GuildAbilityType = value.ToEnum<GuildAbilityType>(); 
                        break; 
                    case "AbilityName": 
                        _AbilityName = value.ToNotNullString(); 
                        break; 
                    case "AbilityHead": 
                        _AbilityHead = value.ToNotNullString(); 
                        break; 
                    case "PreAbility":
                        _PreAbility = value as List<string> ?? new List<string>(); 
                        break; 
                    case "PreAbilityLv": 
                        _PreAbilityLv = value.ToNotNullString(); 
                        break; 
                    case "AbilityDesc": 
                        _AbilityDesc = value.ToNotNullString(); 
                        break; 
                    case "Version": 
                        _Version = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("GuildAbilityInfo index[{0}] isn't exist.", index));
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