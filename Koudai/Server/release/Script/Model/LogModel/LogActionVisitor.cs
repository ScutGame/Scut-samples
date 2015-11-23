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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "LogActionVisitor")]
    public class LogActionVisitor : BaseEntity
    {
        #region auto-generated static method
        static LogActionVisitor()
        {
            EntitySchemaSet.InitSchema(typeof(LogActionVisitor));
        }
        #endregion

        public LogActionVisitor()
            : base(AccessLevel.WriteOnly)
        {
        }

        #region auto-generated Property
        private Int64 _LogID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LogID", IsKey = true, IsIdentity = true)]
        public Int64 LogID
        {
            private get
            {
                return _LogID;
            }
            set
            {
                SetChange("LogID", value);
            }
        }
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UserID")]
        public String UserID
        {
            private get
            {
                return _UserID;
            }
            set
            {
                SetChange("UserID", value);
            }
        }
        private Int32 _ActionID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ActionID")]
        public Int32 ActionID
        {
            private get
            {
                return _ActionID;
            }
            set
            {
                SetChange("ActionID", value);
            }
        }
        private Int32 _ActionStat;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ActionStat")]
        public Int32 ActionStat
        {
            private get
            {
                return _ActionStat;
            }
            set
            {
                SetChange("ActionStat", value);
            }
        }
        private String _VisitUrl;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("VisitUrl")]
        public String VisitUrl
        {
            private get
            {
                return _VisitUrl;
            }
            set
            {
                SetChange("VisitUrl", value);
            }
        }
        private String _RespCont;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("RespCont", DbType = ColumnDbType.Text)]
        public String RespCont
        {
            private get
            {
                return _RespCont;
            }
            set
            {
                SetChange("RespCont", value);
            }
        }
        private String _IP;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IP")]
        public String IP
        {
            private get
            {
                return _IP;
            }
            set
            {
                SetChange("IP", value);
            }
        }
        private DateTime _VisitBeginTime;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("VisitBeginTime")]
        public DateTime VisitBeginTime
        {
            private get
            {
                return _VisitBeginTime;
            }
            set
            {
                SetChange("VisitBeginTime", value);
            }
        }
        private DateTime _VisitEndTime;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("VisitEndTime")]
        public DateTime VisitEndTime
        {
            private get
            {
                return _VisitEndTime;
            }
            set
            {
                SetChange("VisitEndTime", value);
            }
        }
        private DateTime _Addtime;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Addtime")]
        public DateTime Addtime
        {
            private get
            {
                return _Addtime;
            }
            set
            {
                SetChange("Addtime", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "LogID": return LogID;
                    case "UserID": return UserID;
                    case "ActionID": return ActionID;
                    case "ActionStat": return ActionStat;
                    case "VisitUrl": return VisitUrl;
                    case "RespCont": return RespCont;
                    case "IP": return IP;
                    case "VisitBeginTime": return VisitBeginTime;
                    case "VisitEndTime": return VisitEndTime;
                    case "Addtime": return Addtime;
                    default: throw new ArgumentException(string.Format("LogActionVisitor index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "LogID":
                        long.TryParse(value.ToNotNullString(), out _LogID);
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "ActionID":
                        _ActionID = value.ToInt();
                        break;
                    case "ActionStat":
                        _ActionStat = value.ToInt();
                        break;
                    case "VisitUrl":
                        _VisitUrl = value.ToNotNullString();
                        break;
                    case "RespCont":
                        _RespCont = value.ToNotNullString();
                        break;
                    case "IP":
                        _IP = value.ToNotNullString();
                        break;
                    case "VisitBeginTime":
                        _VisitBeginTime = value.ToDateTime();
                        break;
                    case "VisitEndTime":
                        _VisitEndTime = value.ToDateTime();
                        break;
                    case "Addtime":
                        _Addtime = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("LogActionVisitor index[{0}] isn't exist.", index));
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