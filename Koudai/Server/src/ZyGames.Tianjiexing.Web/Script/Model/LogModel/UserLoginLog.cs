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
using ZyGames.Framework.Game.Service;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.None,DbConfig.Log, "UserLoginLog")]
    public class UserLoginLog : BaseEntity
    {
        #region auto-generated static method
        static UserLoginLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserLoginLog));
        }
        #endregion

        public UserLoginLog()
            : base(AccessLevel.WriteOnly)
        {
        }

        #region auto-generated Property
        private Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ID", IsKey = true, IsIdentity = true)]
        public Int32 ID
        {
            private get
            {
                return _ID;
            }
            set
            {
                SetChange("ID", value);
            }
        }
        private String _SessionID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SessionID")]
        public String SessionID
        {
            private get
            {
                return _SessionID;
            }
            set
            {
                SetChange("SessionID", value);
            }
        }
        private MobileType _MobileType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MobileType")]
        public MobileType MobileType
        {
            private get
            {
                return _MobileType;
            }
            set
            {
                SetChange("MobileType", value);
            }
        }
        private Int16 _ScreenX;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ScreenX")]
        public Int16 ScreenX
        {
            private get
            {
                return _ScreenX;
            }
            set
            {
                SetChange("ScreenX", value);
            }
        }
        private Int16 _ScreenY;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ScreenY")]
        public Int16 ScreenY
        {
            private get
            {
                return _ScreenY;
            }
            set
            {
                SetChange("ScreenY", value);
            }
        }
        private String _RetailId;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("RetailId")]
        public String RetailId
        {
            private get
            {
                return _RetailId;
            }
            set
            {
                SetChange("RetailId", value);
            }
        }
        private String _Model;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Model")]
        public String Model
        {
            private get
            {
                return _Model;
            }
            set
            {
                SetChange("Model", value);
            }
        }
        private Int16 _NetWork;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("NetWork")]
        public Int16 NetWork
        {
            private get
            {
                return _NetWork;
            }
            set
            {
                SetChange("NetWork", value);
            }
        }
        private String _UserId;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UserId")]
        public String UserId
        {
            private get
            {
                return _UserId;
            }
            set
            {
                SetChange("UserId", value);
            }
        }
        private DateTime _AddTime;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AddTime")]
        public DateTime AddTime
        {
            private get
            {
                return _AddTime;
            }
            set
            {
                SetChange("AddTime", value);
            }
        }
        private LoginStatus _State;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("State")]
        public LoginStatus State
        {
            private get
            {
                return _State;
            }
            set
            {
                SetChange("State", value);
            }
        }
        private String _DeviceID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("DeviceID")]
        public String DeviceID
        {
            private get
            {
                return _DeviceID;
            }
            set
            {
                SetChange("DeviceID", value);
            }
        }
        private String _Ip;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Ip")]
        public String Ip
        {
            private get
            {
                return _Ip;
            }
            set
            {
                SetChange("Ip", value);
            }
        }


        private String _Pid;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Pid")]
        public String Pid
        {
            private get
            {
                return _Pid;
            }
            set
            {
                SetChange("Pid", value);
            }
        }

        private Int16 _UserLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UserLv")]
        public Int16 UserLv
        {
            private get
            {
                return _UserLv;
            }
            set
            {
                SetChange("UserLv", value);
            }
        }

        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotID")]
        public Int32 PlotID
        {
            private get
            {
                return _PlotID;
            }
            set
            {
                SetChange("PlotID", value);
            }
        }

        private string _PlotName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotName")]
        public string PlotName
        {
            private get
            {
                return _PlotName;
            }
            set
            {
                SetChange("PlotName", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ID": return ID;
                    case "SessionID": return SessionID;
                    case "MobileType": return MobileType;
                    case "ScreenX": return ScreenX;
                    case "ScreenY": return ScreenY;
                    case "RetailId": return RetailId;
                    case "Model": return Model;
                    case "NetWork": return NetWork;
                    case "UserId": return UserId;
                    case "AddTime": return AddTime;
                    case "State": return State;
                    case "DeviceID": return DeviceID;
                    case "Ip": return Ip;
                    case "Pid": return Pid;
                    case "UserLv": return UserLv;
                    case "PlotID": return PlotID;
                    case "PlotName": return PlotName;
                    default: throw new ArgumentException(string.Format("UserLoginLog index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ID":
                        _ID = value.ToInt();
                        break;
                    case "SessionID":
                        _SessionID = value.ToNotNullString();
                        break;
                    case "MobileType":
                        _MobileType = value.ToEnum<MobileType>();
                        break;
                    case "ScreenX":
                        _ScreenX = value.ToShort();
                        break;
                    case "ScreenY":
                        _ScreenY = value.ToShort();
                        break;
                    case "RetailId":
                        _RetailId = value.ToNotNullString();
                        break;
                    case "Model":
                        _Model = value.ToNotNullString();
                        break;
                    case "NetWork":
                        _NetWork = value.ToShort();
                        break;
                    case "UserId":
                        _UserId = value.ToNotNullString();
                        break;
                    case "AddTime":
                        _AddTime = value.ToDateTime();
                        break;
                    case "State":
                        _State = value.ToEnum<LoginStatus>();
                        break;
                    case "DeviceID":
                        _DeviceID = value.ToNotNullString();
                        break;
                    case "Ip":
                        _Ip = value.ToNotNullString();
                        break;
                    case "Pid":
                        _Pid = value.ToNotNullString();
                        break;
                    case "UserLv":
                        _UserLv = value.ToShort();
                        break;
                    case "PlotID":
                        _PlotID = value.ToInt();
                        break;
                    case "PlotName":
                        _PlotName = value.ToNotNullString();
                        break;
                    default: throw new ArgumentException(string.Format("UserLoginLog index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserId.ToInt();
        }
    }
}