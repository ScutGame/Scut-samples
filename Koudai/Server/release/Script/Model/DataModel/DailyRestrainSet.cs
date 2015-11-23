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
    /// ÿ������ȫ�����ñ�
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data)]
    public class DailyRestrainSet : ShareEntity
    {


        public DailyRestrainSet()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private RestrainType _RestrainID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("RestrainID", IsKey = true)]
        public RestrainType RestrainID
        {
            get
            {
                return _RestrainID;
            }
            set
            {
                SetChange("RestrainID", value);
            }
        }
        private String _RestrainDesc;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("RestrainDesc")]
        public String RestrainDesc
        {
            get
            {
                return _RestrainDesc;
            }
            set
            {
                SetChange("RestrainDesc", value);
            }
        }
        private Int32 _MaxNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("MaxNum")]
        public Int32 MaxNum
        {
            get
            {
                return _MaxNum;
            }
            set
            {
                SetChange("MaxNum", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "RestrainID": return RestrainID;
                    case "RestrainDesc": return RestrainDesc;
                    case "MaxNum": return MaxNum;
                    default: throw new ArgumentException(string.Format("DailyRestrainSet index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "RestrainID":
                        _RestrainID = value.ToEnum<RestrainType>();
                        break;
                    case "RestrainDesc":
                        _RestrainDesc = value.ToNotNullString();
                        break;
                    case "MaxNum":
                        _MaxNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("DailyRestrainSet index[{0}] isn't exist.", index));
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