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
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 法宝配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]

    public class TrumpInfo : ShareEntity
    {
        public const string Index_TrumpID = "Index_TrumpID";

        public const int CurrTrumpID = 1001;

        public TrumpInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        public TrumpInfo(Int32 TrumpID, Int16 TrumpLv)
            : this()
        {
            this.TrumpID = TrumpID;
            this.TrumpLv = TrumpLv;
        }

        #region 自动生成属性

        private Int32 _TrumpID;
        /// <summary>
        /// 法宝ID，主键
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("TrumpID", IsKey = true)]
        public Int32 TrumpID
        {
            get
            {
                return _TrumpID;
            }
            private set
            {
                SetChange("TrumpID", value);
            }
        }

        private Int16 _TrumpLv;
        /// <summary>
        /// 法宝等级，主键
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("TrumpLv", IsKey = true)]
        public Int16 TrumpLv
        {
            get
            {
                return _TrumpLv;
            }
            private set
            {
                SetChange("TrumpLv", value);
            }
        }

        private String _TrumpName;
        /// <summary>
        /// 法宝名称
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("TrumpName")]
        public String TrumpName
        {
            get
            {
                return _TrumpName;
            }
            private set
            {
                SetChange("TrumpName", value);
            }
        }

        private Int16 _TrumpType;
        /// <summary>
        /// 法宝类型 （1通用）
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("TrumpType")]
        public Int16 TrumpType
        {
            get
            {
                return _TrumpType;
            }
            private set
            {
                SetChange("TrumpType", value);
            }
        }

        private Int16 _DemandLv;
        /// <summary>
        /// 需求等级
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("DemandLv")]
        public Int16 DemandLv
        {
            get
            {
                return _DemandLv;
            }
            private set
            {
                SetChange("DemandLv", value);
            }
        }

        private Int16 _MaxLift;
        /// <summary>
        /// 寿命
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("MaxLift")]
        public Int16 MaxLift
        {
            get
            {
                return _MaxLift;
            }
            private set
            {
                SetChange("MaxLift", value);
            }
        }

        private Int16 _BeseMature;
        /// <summary>
        /// 初始成长率下线
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("BeseMature")]
        public Int16 BeseMature
        {
            get
            {
                return _BeseMature;
            }
            private set
            {
                SetChange("BeseMature", value);
            }
        }

        private Int16 _MaxMature;
        /// <summary>
        ///  初始成长率上限
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("MaxMature")]
        public Int16 MaxMature
        {
            get
            {
                return _MaxMature;
            }
            private set
            {
                SetChange("MaxMature", value);
            }
        }

        private CacheList<GeneralProperty> _Property;
        /// <summary>
        /// 加成属性 Json格式 [{"AbilityType":1," AbilityValue ":1}]
        /// </summary>        
        [ProtoMember(9)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<GeneralProperty> Property
        {
            get
            {
                return _Property;
            }
            private set
            {
                SetChange("Property", value);
            }
        }

        private Int16 _SkillID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("SkillID")]
        public Int16 SkillID
        {
            get
            {
                return _SkillID;
            }
            private set
            {
                SetChange("SkillID", value);
            }
        }

        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("Experience")]
        public Int32 Experience
        {
            get
            {
                return _Experience;
            }
            private set
            {
                SetChange("Experience", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "TrumpID": return TrumpID;
                    case "TrumpLv": return TrumpLv;
                    case "TrumpName": return TrumpName;
                    case "TrumpType": return TrumpType;
                    case "DemandLv": return DemandLv;
                    case "MaxLift": return MaxLift;
                    case "BeseMature": return BeseMature;
                    case "MaxMature": return MaxMature;
                    case "Property": return Property;
                    case "SkillID": return SkillID;
                    case "Experience": return Experience;
                    default: throw new ArgumentException(string.Format("TrumpInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "TrumpID":
                        _TrumpID = value.ToInt();
                        break;
                    case "TrumpLv":
                        _TrumpLv = value.ToShort();
                        break;
                    case "TrumpName":
                        _TrumpName = value.ToNotNullString();
                        break;
                    case "TrumpType":
                        _TrumpType = value.ToShort();
                        break;
                    case "DemandLv":
                        _DemandLv = value.ToShort();
                        break;
                    case "MaxLift":
                        _MaxLift = value.ToShort();
                        break;
                    case "BeseMature":
                        _BeseMature = value.ToShort();
                        break;
                    case "MaxMature":
                        _MaxMature = value.ToShort();
                        break;
                    case "Property":
                        _Property =ConvertCustomField<CacheList<GeneralProperty>>(value, index); 
                        break;
                    case "SkillID":
                        _SkillID = value.ToShort();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("TrumpInfo index[{0}] isn't exist.", index));
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