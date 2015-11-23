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
    /// ��Ҷ�����Ϣ
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]


    public class UserQueue : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_UserID_Type = "Index_UserID_Type";

        public UserQueue()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _QueueID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("QueueID", IsKey = true)]
        public String QueueID
        {
            get
            {
                return _QueueID;
            }
            set
            {
                SetChange("QueueID", value);
            }
        }
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("UserID")]
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
        private QueueType _QueueType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("QueueType")]
        public QueueType QueueType
        {
            get
            {
                return _QueueType;
            }
            set
            {
                SetChange("QueueType", value);
            }
        }
        private String _QueueName;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("QueueName")]
        public String QueueName
        {
            get
            {
                return _QueueName;
            }
            set
            {
                SetChange("QueueName", value);
            }
        }
        private Int32 _TotalColdTime;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("TotalColdTime")]
        public Int32 TotalColdTime
        {
            get
            {
                return _TotalColdTime;
            }
            set
            {
                SetChange("TotalColdTime", value);
            }
        }
        private DateTime _Timing;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("Timing")]
        public DateTime Timing
        {
            get
            {
                return _Timing;
            }
            set
            {
                SetChange("Timing", value);
            }
        }
        private Int32 _ColdTime;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("ColdTime")]
        public Int32 ColdTime
        {
            get
            {
                return _ColdTime;
            }
            set
            {
                SetChange("ColdTime", value);
            }
        }
        private Boolean _IsSuspend;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("IsSuspend")]
        public Boolean IsSuspend
        {
            get
            {
                return _IsSuspend;
            }
            set
            {
                SetChange("IsSuspend", value);
            }
        }
        private Int32 _StrengNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("StrengNum")]
        public Int32 StrengNum
        {
            get
            {
                return _StrengNum;
            }
            set
            {
                SetChange("StrengNum", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "QueueID": return QueueID;
                    case "UserID": return UserID;
                    case "QueueType": return QueueType;
                    case "QueueName": return QueueName;
                    case "TotalColdTime": return TotalColdTime;
                    case "Timing": return Timing;
                    case "ColdTime": return ColdTime;
                    case "IsSuspend": return IsSuspend;
                    case "StrengNum": return StrengNum;
                    default: throw new ArgumentException(string.Format("UserQueue index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "QueueID":
                        _QueueID = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "QueueType":
                        _QueueType = value.ToEnum<QueueType>();
                        break;
                    case "QueueName":
                        _QueueName = value.ToNotNullString();
                        break;
                    case "TotalColdTime":
                        _TotalColdTime = value.ToInt();
                        break;
                    case "Timing":
                        _Timing = value.ToDateTime();
                        break;
                    case "ColdTime":
                        _ColdTime = value.ToInt();
                        break;
                    case "IsSuspend":
                        _IsSuspend = value.ToBool();
                        break;
                    case "StrengNum":
                        _StrengNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserQueue index[{0}] isn't exist.", index));
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
        /// ��ͣ
        /// </summary>
        public void DoSuspend()
        {
            if (!IsSuspend)
            {
                DateTime currDate = DateTime.Now;
                TimeSpan ts = currDate - Timing;
                IsSuspend = true;
                ColdTime = MathUtils.Subtraction(ColdTime, (int)Math.Floor(ts.TotalSeconds), 0);
                Timing = currDate;
                //Update();
            }
        }

        /// <summary>
        /// ��ʼ
        /// </summary>
        public void DoStart()
        {
            if (IsSuspend)
            {
                IsSuspend = false;
                Timing = DateTime.Now;
                //Update();
            }
        }

        /// <summary>
        /// ��ȡ��ʱʱ��
        /// </summary>
        /// <returns></returns>
        public int GetTiming()
        {
            TimeSpan ts = DateTime.Now - Timing;
            int num = (int)Math.Floor(ts.TotalSeconds);
            num = num < 0 ? 0 : num;
            return num < TotalColdTime ? num : TotalColdTime;
        }
        /// <summary>
        /// ˢ����ȴʱ��
        /// </summary>
        /// <returns>����ʣ����ȴʱ��</returns>
        public int DoRefresh()
        {
            int coldTime = 0;
            if (IsSuspend)
            {
                coldTime = ColdTime;
            }
            else
            {
                TimeSpan ts = DateTime.Now - Timing;
                coldTime = MathUtils.Subtraction(ColdTime, (int)Math.Floor(ts.TotalSeconds), 0);
                coldTime = MathUtils.Addition(coldTime, 0, TotalColdTime);
            }
            return coldTime;
        }
    }
}