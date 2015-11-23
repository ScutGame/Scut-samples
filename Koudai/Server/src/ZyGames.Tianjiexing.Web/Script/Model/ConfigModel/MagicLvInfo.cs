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
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config, OrderColumn = "MagicID,MagicLv")]

    public class MagicLvInfo : ShareEntity
    {

        public const string Index_MagicID = "Index_MagicID";

        public MagicLvInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        #region auto-generated Property
        private Int32 _MagicID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MagicID", IsKey = true)]
        public Int32 MagicID
        {
            get
            {
                return _MagicID;
            }
            private set
            {
                SetChange("MagicID", value);
            }
        }
        private Int16 _MagicLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MagicLv", IsKey = true)]
        public Int16 MagicLv
        {
            get
            {
                return _MagicLv;
            }
            private set
            {
                SetChange("MagicLv", value);
            }
        }
        private Int16 _ShowMinLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ShowMinLv")]
        public Int16 ShowMinLv
        {
            get
            {
                return _ShowMinLv;
            }
            private set
            {
                SetChange("ShowMinLv", value);
            }
        }
        private Int16 _EscalateMinLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EscalateMinLv")]
        public Int16 EscalateMinLv
        {
            get
            {
                return _EscalateMinLv;
            }
            private set
            {
                SetChange("EscalateMinLv", value);
            }
        }
        private Int32 _ExpNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ExpNum")]
        public Int32 ExpNum
        {
            get
            {
                return _ExpNum;
            }
            private set
            {
                SetChange("ExpNum", value);
            }
        }
        private Int32 _ColdTime;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ColdTime")]
        public Int32 ColdTime
        {
            get
            {
                return _ColdTime;
            }
            private set
            {
                SetChange("ColdTime", value);
            }
        }
        private AbilityType _AbilityType;
        /// <summary>
        /// 
        /// </summary>
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
        private Decimal _EffectNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EffectNum")]
        public Decimal EffectNum
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
        private Int16 _GridMaxNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GridMaxNum")]
        public Int16 GridMaxNum
        {
            get
            {
                return _GridMaxNum;
            }
            private set
            {
                SetChange("GridMaxNum", value);
            }
        }
        private String _GridRange;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GridRange")]
        public String GridRange
        {
            get
            {
                return _GridRange;
            }
            private set
            {
                SetChange("GridRange", value);
            }
        }

        private int _ReplacePostion;

        /// <summary>
        /// �油Ӷ��λ��
        /// </summary>
        [EntityField("ReplacePostion")]
        public int ReplacePostion
        {
            get
            {
                return _ReplacePostion;
            }
            private set
            {
                SetChange("ReplacePostion", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "MagicID": return MagicID;
                    case "MagicLv": return MagicLv;
                    case "ShowMinLv": return ShowMinLv;
                    case "EscalateMinLv": return EscalateMinLv;
                    case "ExpNum": return ExpNum;
                    case "ColdTime": return ColdTime;
                    case "AbilityType": return AbilityType;
                    case "EffectNum": return EffectNum;
                    case "GridMaxNum": return GridMaxNum;
                    case "GridRange": return GridRange;
                    case "ReplacePostion": return ReplacePostion;
                    default: throw new ArgumentException(string.Format("MagicLvInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "MagicID":
                        _MagicID = value.ToInt();
                        break;
                    case "MagicLv":
                        _MagicLv = value.ToShort();
                        break;
                    case "ShowMinLv":
                        _ShowMinLv = value.ToShort();
                        break;
                    case "EscalateMinLv":
                        _EscalateMinLv = value.ToShort();
                        break;
                    case "ExpNum":
                        _ExpNum = value.ToInt();
                        break;
                    case "ColdTime":
                        _ColdTime = value.ToInt();
                        break;
                    case "AbilityType":
                        _AbilityType = value.ToEnum<AbilityType>();
                        break;
                    case "EffectNum":
                        _EffectNum = value.ToDecimal();
                        break;
                    case "GridMaxNum":
                        _GridMaxNum = value.ToShort();
                        break;
                    case "GridRange":
                        _GridRange = value.ToNotNullString();
                        break;
                    case "ReplacePostion":
                        _ReplacePostion = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("MagicLvInfo index[{0}] isn't exist.", index));
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
        /// <summary>
        /// ȡ�׸�λ��
        /// </summary>
        /// <returns></returns>
        public short GetFirstGrid()
        {
            int index = 0;
            string[] str = GridRange.Split(',');
            if (str.Length > index)
            {
                return str[index].ToShort();
            }
            throw new Exception("ȡ��λ�ó�������");
        }
    }
}