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
using ZyGames.Tianjiexing.Model.Enum;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 附魔符配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class EnchantInfo : ShareEntity
    {
        public EnchantInfo()
            : base(AccessLevel.ReadOnly)
        {
;        }

        public EnchantInfo(Int32 EnchantID)
            : this()
        {
            this.EnchantID = EnchantID;
        }

        #region 自动生成属性

        private Int32 _EnchantID;
        /// <summary>
        /// 附魔符ID，主键
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("EnchantID", IsKey = true)]
        public Int32 EnchantID
        {
            get
            {
                return _EnchantID;
            }
            private set
            {
                SetChange("EnchantID", value);
            }
        }

        private String _EnchantName;
        /// <summary>
        /// 附魔符名称
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("EnchantName")]
        public String EnchantName
        {
            get
            {
                return _EnchantName;
            }
            private set
            {
                SetChange("EnchantName", value);
            }
        }

        private ColorType _ColorType;
        /// <summary>
        /// 附魔符颜色，ColorType枚举
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("ColorType")]
        public ColorType ColorType
        {
            get
            {
                return _ColorType;
            }
            private set
            {
                SetChange("ColorType", value);
            }
        }

        private AbilityType _AbilityType;
        /// <summary>
        /// 附魔符属性 参照AbilityType枚举
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("AbilityType")]
        public AbilityType AbilityType
        {
            get
            {
                return _AbilityType;
            }
            private set
            {
                SetChange("AbilityType", value);
            }
        }

        private Int16 _BeseNum;
        /// <summary>
        ///  初始成长值下限
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("BeseNum")]
        public Int16 BeseNum
        {
            get
            {
                return _BeseNum;
            }
            private set
            {
                SetChange("BeseNum", value);
            }
        }

        private Int16 _MaxNum;
        /// <summary>
        ///  初始成长值上限
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("MaxNum")]
        public Int16 MaxNum
        {
            get
            {
                return _MaxNum;
            }
            private set
            {
                SetChange("MaxNum", value);
            }
        }

        private Int32 _Experience;
        /// <summary>
        /// 初始经验
        /// </summary>        
        [ProtoMember(7)]
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

        private string _HeadID;

        /// <summary>
        /// 图片
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("HeadID")]
        public string HeadID
        {
            get
            {
                return _HeadID;
            }
            private set
            {
                SetChange("HeadID", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "EnchantID": return EnchantID;
                    case "EnchantName": return EnchantName;
                    case "ColorType": return ColorType;
                    case "AbilityType": return AbilityType;
                    case "BeseNum": return BeseNum;
                    case "MaxNum": return MaxNum;
                    case "Experience": return Experience;
                    case "HeadID": return HeadID;
                    default: throw new ArgumentException(string.Format("EnchantInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "EnchantID":
                        _EnchantID = value.ToInt();
                        break;
                    case "EnchantName":
                        _EnchantName = value.ToNotNullString();
                        break;
                    case "ColorType":
                        _ColorType = value.ToEnum<ColorType>();
                        break;
                    case "AbilityType":
                        _AbilityType = value.ToEnum<AbilityType>();
                        break;
                    case "BeseNum":
                        _BeseNum = value.ToShort();
                        break;
                    case "MaxNum":
                        _MaxNum = value.ToShort();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    case "HeadID": _HeadID = value.ToNotNullString();
                        break;
                    default: throw new ArgumentException(string.Format("EnchantInfo index[{0}] isn't exist.", index));
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