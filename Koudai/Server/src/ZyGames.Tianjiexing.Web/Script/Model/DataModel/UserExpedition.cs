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
    /// ���̽�մ���
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserExpedition : BaseEntity
    {


        public UserExpedition()
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
        private Int32 _ExpeditionNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("ExpeditionNum")]
        public Int32 ExpeditionNum
        {
            get
            {
                return _ExpeditionNum;
            }
            set
            {
                SetChange("ExpeditionNum", value);
            }
        }
        private Int32 _CodeTime;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("CodeTime")]
        public Int32 CodeTime
        {
            get
            {
                return _CodeTime;
            }
            set
            {
                SetChange("CodeTime", value);
            }
        }
        private DateTime _InsertDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
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
        private Int32 _ExpID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("ExpID")]
        public Int32 ExpID
        {
            get
            {
                return _ExpID;
            }
            set
            {
                SetChange("ExpID", value);
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
                    case "ExpeditionNum": return ExpeditionNum;
                    case "CodeTime": return CodeTime;
                    case "InsertDate": return InsertDate;
                    case "ExpID": return ExpID;
                    default: throw new ArgumentException(string.Format("UserExpedition index[{0}] isn't exist.", index));
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
                    case "ExpeditionNum":
                        _ExpeditionNum = value.ToInt();
                        break;
                    case "CodeTime":
                        _CodeTime = value.ToInt();
                        break;
                    case "InsertDate":
                        _InsertDate = value.ToDateTime();
                        break;
                    case "ExpID":
                        _ExpID = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserExpedition index[{0}] isn't exist.", index));
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
        /// <summary>
        /// ��ȴʱ��
        /// </summary>
        public int DoRefresh()
        {
            int coldTime = 0;
            TimeSpan ts = DateTime.Now - InsertDate;
            coldTime = MathUtils.Subtraction(CodeTime, (int)Math.Floor(ts.TotalSeconds), 0);
            return coldTime;
        }

    }
}