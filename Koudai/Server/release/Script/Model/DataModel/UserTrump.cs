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
using ZyGames.Tianjiexing.Model.Enum;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 玩家法宝表
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]

    public class UserTrump : BaseEntity
    {
        public const string Index_UserID = "Index_UserID";

        public UserTrump()
            : base(AccessLevel.ReadWrite)
        {
            SkillInfo = new CacheList<SkillInfo>();
            PropertyInfo = new CacheList<GeneralProperty>();
        }

        //protected override void BindChangeEvent()
        //{
        //    SkillInfo.BindParentChangeEvent(this);
        //    PropertyInfo.BindParentChangeEvent(this);
        //}

        public UserTrump(String UserID, Int32 TrumpID)
            : this()
        {
            this.UserID = UserID;
            this.TrumpID = TrumpID;
        }

        #region 自动生成属性

        private String _UserID;
        /// <summary>
        ///  用户ID主键
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
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

        private Int32 _TrumpID;
        /// <summary>
        /// 法宝ID，主键
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("TrumpID", IsKey = true)]
        public Int32 TrumpID
        {
            get
            {
                return _TrumpID;
            }
            set
            {
                SetChange("TrumpID", value);
            }
        }

        private Int16 _TrumpLv;
        /// <summary>
        /// 法宝等级
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("TrumpLv")]
        public Int16 TrumpLv
        {
            get
            {
                return _TrumpLv;
            }
            set
            {
                SetChange("TrumpLv", value);
            }
        }

        private Int16 _WorshipLv;

        /// <summary>
        /// 祭祀Lv
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("WorshipLv")]
        public Int16 WorshipLv
        {
            get
            {
                return _WorshipLv;
            }
            set
            {
                SetChange("WorshipLv", value);
            }
        }

        private Int32 _LiftNum;
        /// <summary>
        /// 寿命
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("LiftNum")]
        public Int32 LiftNum
        {
            get
            {
                return _LiftNum;
            }
            set
            {
                SetChange("LiftNum", value);
            }
        }

        private Int32 _Experience;
        /// <summary>
        /// 经验
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("Experience")]
        public Int32 Experience
        {
            get
            {
                return _Experience;
            }
            set
            {
                SetChange("Experience", value);
            }
        }

        private Int16 _MatureNum;
        /// <summary>
        /// 成长值
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("MatureNum")]
        public Int16 MatureNum
        {
            get
            {
                return _MatureNum;
            }
            set
            {
                SetChange("MatureNum", value);
            }
        }

        private ZodiacType _Zodiac;
        /// <summary>
        /// 属相
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("Zodiac")]
        public ZodiacType Zodiac
        {
            get
            {
                return _Zodiac;
            }
            set
            {
                SetChange("Zodiac", value);
            }
        }

        private CacheList<SkillInfo> _SkillInfo;
        /// <summary>
        /// 技能 json
        /// </summary>        
        [ProtoMember(9)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<SkillInfo> SkillInfo
        {
            get
            {
                return _SkillInfo;
            }
            set
            {
                SetChange("SkillInfo", value);
            }
        }

        private CacheList<GeneralProperty> _PropertyInfo;
        /// <summary>
        /// 随机属性 json
        /// </summary>        
        [ProtoMember(10)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<GeneralProperty> PropertyInfo
        {
            get
            {
                return _PropertyInfo;
            }
            set
            {
                SetChange("PropertyInfo", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "UserID": return UserID;
                    case "TrumpID": return TrumpID;
                    case "TrumpLv": return TrumpLv;
                    case "WorshipLv": return WorshipLv;
                    case "LiftNum": return LiftNum;
                    case "Experience": return Experience;
                    case "MatureNum": return MatureNum;
                    case "Zodiac": return Zodiac;
                    case "SkillInfo": return SkillInfo;
                    case "PropertyInfo": return PropertyInfo;
                    default: throw new ArgumentException(string.Format("UserTrump index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "TrumpID":
                        _TrumpID = value.ToInt();
                        break;
                    case "TrumpLv":
                        _TrumpLv = value.ToShort();
                        break;
                    case "WorshipLv":
                        _WorshipLv = value.ToShort();
                        break;
                    case "LiftNum":
                        _LiftNum = value.ToInt();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    case "MatureNum":
                        _MatureNum = value.ToShort();
                        break;
                    case "Zodiac":
                        _Zodiac = value.ToEnum<ZodiacType>();
                        break;
                    case "SkillInfo":
                        _SkillInfo =ConvertCustomField<CacheList<SkillInfo>>(value, index); 
                        break;
                    case "PropertyInfo":
                        _PropertyInfo =ConvertCustomField<CacheList<GeneralProperty>>(value, index); 
                        break;
                    default: throw new ArgumentException(string.Format("UserTrump index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID.ToInt();
        }
    }
}