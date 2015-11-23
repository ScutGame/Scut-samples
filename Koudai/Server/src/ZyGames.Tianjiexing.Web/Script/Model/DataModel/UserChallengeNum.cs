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
    /// ��Ҿ���������ս����
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserChallengeNum : BaseEntity
    {


        public UserChallengeNum()
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
        private Int32 _ChallengeNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("ChallengeNum")]
        public Int32 ChallengeNum
        {
            get
            {
                return _ChallengeNum;
            }
            set
            {
                SetChange("ChallengeNum", value);
            }
        }
        private DateTime _InsertDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("InsertDate")]
        public DateTime InsertDate
        {
            get
            {
                return _InsertDate;
            }
            set
            {
                SetChange("InsertDate", value);
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
                    case "ChallengeNum": return ChallengeNum;
                    case "InsertDate": return InsertDate;
                    default: throw new ArgumentException(string.Format("UserChallengeNum index[{0}] isn't exist.", index));
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
                    case "ChallengeNum":
                        _ChallengeNum = value.ToInt();
                        break;
                    case "InsertDate":
                        _InsertDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("UserChallengeNum index[{0}] isn't exist.", index));
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