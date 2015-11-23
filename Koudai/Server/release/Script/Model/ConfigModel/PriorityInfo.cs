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
using ZyGames.Tianjiexing.Model.Enum;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class PriorityInfo : ShareEntity
    {


        public PriorityInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        #region auto-generated Property
        private PriorityType _PriorityType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PriorityType", IsKey = true)]
        public PriorityType PriorityType
        {
            get
            {
                return _PriorityType;
            }
            private set
            {
                SetChange("PriorityType", value);
            }
        }
        private PriorityQuality _PriorityQuality;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PriorityQuality", IsKey = true)]
        public PriorityQuality PriorityQuality
        {
            get
            {
                return _PriorityQuality;
            }
            private set
            {
                SetChange("PriorityQuality", value);
            }
        }
        private Int16 _BaseNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BaseNum")]
        public Int16 BaseNum
        {
            get
            {
                return _BaseNum;
            }
            private set
            {
                SetChange("BaseNum", value);
            }
        }
        private Int16 _EffectNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EffectNum")]
        public Int16 EffectNum
        {
            get
            {
                return _EffectNum;
            }
            private set
            {
                SetChange("EffectNum", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "PriorityType": return PriorityType;
                    case "PriorityQuality": return PriorityQuality;
                    case "BaseNum": return BaseNum;
                    case "EffectNum": return EffectNum;
                    default: throw new ArgumentException(string.Format("PriorityInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "PriorityType":
                        _PriorityType = value.ToEnum<PriorityType>();
                        break;
                    case "PriorityQuality":
                        _PriorityQuality = value.ToEnum<PriorityQuality>();
                        break;
                    case "BaseNum":
                        _BaseNum = value.ToShort();
                        break;
                    case "EffectNum":
                        _EffectNum = value.ToShort();
                        break;
                    default: throw new ArgumentException(string.Format("PriorityInfo index[{0}] isn't exist.", index));
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