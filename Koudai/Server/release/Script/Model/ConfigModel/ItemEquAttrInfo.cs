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
    public class ItemEquAttrInfo : ShareEntity
    {

        public const string Index_ItemID = "Index_ItemID";

        public ItemEquAttrInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        #region auto-generated Property
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemID", IsKey = true)]
        public Int32 ItemID
        {
            get
            {
                return _ItemID;
            }
            private set
            {
                SetChange("ItemID", value);
            }
        }
        private AbilityType _AttributeID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AttributeID", IsKey = true)]
        public AbilityType AttributeID
        {
            get
            {
                return _AttributeID;
            }
            private set
            {
                SetChange("AttributeID", value);
            }
        }
        private Int32 _BaseNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BaseNum")]
        public Int32 BaseNum
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
        private Int32 _IncreaseNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IncreaseNum")]
        public Int32 IncreaseNum
        {
            get
            {
                return _IncreaseNum;
            }
            private set
            {
                SetChange("IncreaseNum", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ItemID": return ItemID;
                    case "AttributeID": return AttributeID;
                    case "BaseNum": return BaseNum;
                    case "IncreaseNum": return IncreaseNum;
                    default: throw new ArgumentException(string.Format("ItemEquAttrInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ItemID":
                        _ItemID = value.ToInt();
                        break;
                    case "AttributeID":
                        _AttributeID = value.ToEnum<AbilityType>();
                        break;
                    case "BaseNum":
                        _BaseNum = value.ToInt();
                        break;
                    case "IncreaseNum":
                        _IncreaseNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("ItemEquAttrInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        /// <summary>
        /// ��õȼ�Ч��
        /// </summary>
        /// <param name="lv"></param>
        /// <returns></returns>
        public int GetEffectNum(short lv)
        {
            return MathUtils.Addition(BaseNum, lv * IncreaseNum, int.MaxValue);
        }

        protected override int GetIdentityId()
        {
            //allow modify return value
            return DefIdentityId;
        }
    }
}