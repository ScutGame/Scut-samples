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
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class VipLvInfo : ShareEntity
    {


        public VipLvInfo()
            : base(AccessLevel.ReadOnly)
        {
            DailyRestrain = new CacheList<DailyRestrain>(0, true);
            _EquStreng =new EquStreng();
        }

        #region auto-generated Property
        private Int16 _VipLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("VipLv", IsKey = true)]
        public Int16 VipLv
        {
            get
            {
                return _VipLv;
            }
            private set
            {
                SetChange("VipLv", value);
            }
        }
        private Int32 _PayGold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PayGold")]
        public Int32 PayGold
        {
            get
            {
                return _PayGold;
            }
            private set
            {
                SetChange("PayGold", value);
            }
        }
        private CacheList<DailyRestrain> _DailyRestrain;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<DailyRestrain> DailyRestrain
        {
            get
            {
                return _DailyRestrain;
            }
            private set
            {
                SetChange("DailyRestrain", value);
            }
        }
        private String _ExpandFun;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ExpandFun")]
        public String ExpandFun
        {
            get
            {
                return _ExpandFun;
            }
            private set
            {
                SetChange("ExpandFun", value);
            }
        }

        private EquStreng _EquStreng;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public EquStreng EquStreng
        {
            get
            {
                return _EquStreng;
            }
            private set
            {
                SetChange("EquStreng", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "VipLv": return VipLv;
                    case "PayGold": return PayGold;
                    case "DailyRestrain": return DailyRestrain;
                    case "ExpandFun": return ExpandFun;
                    case "EquStreng": return EquStreng;
                    default: throw new ArgumentException(string.Format("VipLvInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "VipLv":
                        _VipLv = value.ToShort();
                        break;
                    case "PayGold":
                        _PayGold = value.ToInt();
                        break;
                    case "DailyRestrain":
                        _DailyRestrain = ConvertCustomField<CacheList<DailyRestrain>>(value, index);
                        break;
                    case "ExpandFun":
                        _ExpandFun = value.ToNotNullString();
                        break;
                    case "EquStreng": 
                        _EquStreng = ConvertCustomField<EquStreng>(value, index);
                        break;
                    default: throw new ArgumentException(string.Format("VipLvInfo index[{0}] isn't exist.", index));
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