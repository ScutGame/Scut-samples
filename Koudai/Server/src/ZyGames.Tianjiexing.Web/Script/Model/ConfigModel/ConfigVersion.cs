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

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class ConfigVersion : ShareEntity
    {


        public ConfigVersion()
            : base(AccessLevel.ReadOnly)
        {
        }

        #region auto-generated Property
        private VersionType _VersionType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("VersionType", IsKey = true)]
        public VersionType VersionType
        {
            get
            {
                return _VersionType;
            }
            private set
            {
                SetChange("VersionType", value);
            }
        }
        private Int32 _ActionID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ActionID")]
        public Int32 ActionID
        {
            get
            {
                return _ActionID;
            }
            private set
            {
                SetChange("ActionID", value);
            }
        }
        private String _TypeName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TypeName")]
        public String TypeName
        {
            get
            {
                return _TypeName;
            }
            private set
            {
                SetChange("TypeName", value);
            }
        }
        private Int32 _CurVersion;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CurVersion")]
        public Int32 CurVersion
        {
            get
            {
                return _CurVersion;
            }
            private set
            {
                SetChange("CurVersion", value);
            }
        }
        private DateTime _ModifyTime;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ModifyTime")]
        public DateTime ModifyTime
        {
            get
            {
                return _ModifyTime;
            }
            private set
            {
                SetChange("ModifyTime", value);
            }
        }
        private Int32 _State;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("State")]
        public Int32 State
        {
            get
            {
                return _State;
            }
            private set
            {
                SetChange("State", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "VersionType": return VersionType;
                    case "ActionID": return ActionID;
                    case "TypeName": return TypeName;
                    case "CurVersion": return CurVersion;
                    case "ModifyTime": return ModifyTime;
                    case "State": return State;
                    default: throw new ArgumentException(string.Format("ConfigVersion index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "VersionType":
                        _VersionType = value.ToEnum<VersionType>();
                        break;
                    case "ActionID":
                        _ActionID = value.ToInt();
                        break;
                    case "TypeName":
                        _TypeName = value.ToNotNullString();
                        break;
                    case "CurVersion":
                        _CurVersion = value.ToInt();
                        break;
                    case "ModifyTime":
                        _ModifyTime = value.ToDateTime();
                        break;
                    case "State":
                        _State = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("ConfigVersion index[{0}] isn't exist.", index));
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