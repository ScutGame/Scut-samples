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
    /// ���������
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data)]
    public class GuildIdol : ShareEntity
    {


        public GuildIdol()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _GuildID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("GuildID", IsKey = true)]
        public String GuildID
        {
            get
            {
                return _GuildID;
            }
            set
            {
                SetChange("GuildID", value);
            }
        }
        private Int16 _IdolLv;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("IdolLv")]
        public Int16 IdolLv
        {
            get
            {
                return _IdolLv;
            }
            set
            {
                SetChange("IdolLv", value);
            }
        }
        private Int32 _CurrExperience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("CurrExperience")]
        public Int32 CurrExperience
        {
            get
            {
                return _CurrExperience;
            }
            set
            {
                SetChange("CurrExperience", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "GuildID": return GuildID;
                    case "IdolLv": return IdolLv;
                    case "CurrExperience": return CurrExperience;
                    default: throw new ArgumentException(string.Format("GuildIdol index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "GuildID":
                        _GuildID = value.ToNotNullString();
                        break;
                    case "IdolLv":
                        _IdolLv = value.ToShort();
                        break;
                    case "CurrExperience":
                        _CurrExperience = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("GuildIdol index[{0}] isn't exist.", index));
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