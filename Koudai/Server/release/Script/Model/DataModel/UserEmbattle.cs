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
    /// ������ͱ�
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data, OrderColumn = "UserID,MagicID,Position ASC")]


    public class UserEmbattle : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_UserID_MagicID = "Index_UserID_MagicID";

        public UserEmbattle()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _UserID;
        /// <summary>
        /// 
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
        private Int32 _MagicID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("MagicID", IsKey = true)]
        public Int32 MagicID
        {
            get
            {
                return _MagicID;
            }
            set
            {
                SetChange("MagicID", value);
            }
        }
        private Int16 _Position;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("Position", IsKey = true)]
        public Int16 Position
        {
            get
            {
                return _Position;
            }
            set
            {
                SetChange("Position", value);
            }
        }
        private Int32 _GeneralID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("GeneralID")]
        public Int32 GeneralID
        {
            get
            {
                return _GeneralID;
            }
            set
            {
                SetChange("GeneralID", value);
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
                    case "MagicID": return MagicID;
                    case "Position": return Position;
                    case "GeneralID": return GeneralID;
                    default: throw new ArgumentException(string.Format("UserEmbattle index[{0}] isn't exist.", index));
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
                    case "MagicID":
                        _MagicID = value.ToInt();
                        break;
                    case "Position":
                        _Position = value.ToShort();
                        break;
                    case "GeneralID":
                        _GeneralID = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserEmbattle index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        public int FirstStrike { get; set; }

        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID.ToInt();
        }
    }
}