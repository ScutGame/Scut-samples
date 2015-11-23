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
    /// ���ÿ������
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserDailyRestrain : BaseEntity
    {


        public UserDailyRestrain()
            : base(AccessLevel.ReadWrite)
        {
            UserExtend = new DailyUserExtend();
            FunPlot = new CacheList<FunPlot>();
            PlainPlotList = new CacheList<FunPlot>();
        }
        //protected override void BindChangeEvent()
        //{
        //    FunPlot.BindParentChangeEvent(this);
        //    UserExtend.BindParentChangeEvent(this);
        //}

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
        private DateTime _RefreshDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("RefreshDate")]
        public DateTime RefreshDate
        {
            get
            {
                return _RefreshDate;
            }
            set
            {
                SetChange("RefreshDate", value);
            }
        }
        private Int32 _Funtion1;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("Funtion1")]
        public Int32 Funtion1
        {
            get
            {
                return _Funtion1;
            }
            set
            {
                SetChange("Funtion1", value);
            }
        }
        private Int32 _Funtion2;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("Funtion2")]
        public Int32 Funtion2
        {
            get
            {
                return _Funtion2;
            }
            set
            {
                SetChange("Funtion2", value);
            }
        }
        private Int32 _Funtion3;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("Funtion3")]
        public Int32 Funtion3
        {
            get
            {
                return _Funtion3;
            }
            set
            {
                SetChange("Funtion3", value);
            }
        }
        private Int32 _Funtion4;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("Funtion4")]
        public Int32 Funtion4
        {
            get
            {
                return _Funtion4;
            }
            set
            {
                SetChange("Funtion4", value);
            }
        }
        private Int32 _Funtion5;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("Funtion5")]
        public Int32 Funtion5
        {
            get
            {
                return _Funtion5;
            }
            set
            {
                SetChange("Funtion5", value);
            }
        }
        private Int32 _Funtion6;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("Funtion6")]
        public Int32 Funtion6
        {
            get
            {
                return _Funtion6;
            }
            set
            {
                SetChange("Funtion6", value);
            }
        }
        private Int32 _Funtion7;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("Funtion7")]
        public Int32 Funtion7
        {
            get
            {
                return _Funtion7;
            }
            set
            {
                SetChange("Funtion7", value);
            }
        }
        private Int32 _Funtion8;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField("Funtion8")]
        public Int32 Funtion8
        {
            get
            {
                return _Funtion8;
            }
            set
            {
                SetChange("Funtion8", value);
            }
        }
        private Int32 _Funtion9;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField("Funtion9")]
        public Int32 Funtion9
        {
            get
            {
                return _Funtion9;
            }
            set
            {
                SetChange("Funtion9", value);
            }
        }
        private CacheList<FunPlot> _FunPlot;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<FunPlot> FunPlot
        {
            get
            {
                return _FunPlot;
            }
            set
            {
                SetChange("FunPlot", value);
            }
        }
        private Int32 _Funtion10;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        [EntityField("Funtion10")]
        public Int32 Funtion10
        {
            get
            {
                return _Funtion10;
            }
            set
            {
                SetChange("Funtion10", value);
            }
        }
        private DateTime _Funtion11;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        [EntityField("Funtion11")]
        public DateTime Funtion11
        {
            get
            {
                return _Funtion11;
            }
            set
            {
                SetChange("Funtion11", value);
            }
        }
        private String _Funtion12;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(15)]
        [EntityField("Funtion12")]
        public String Funtion12
        {
            get
            {
                return _Funtion12;
            }
            set
            {
                SetChange("Funtion12", value);
            }
        }
        private Int32 _Funtion13;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(16)]
        [EntityField("Funtion13")]
        public Int32 Funtion13
        {
            get
            {
                return _Funtion13;
            }
            set
            {
                SetChange("Funtion13", value);
            }
        }
        private Int32 _Funtion14;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(17)]
        [EntityField("Funtion14")]
        public Int32 Funtion14
        {
            get
            {
                return _Funtion14;
            }
            set
            {
                SetChange("Funtion14", value);
            }
        }
        private DateTime _Funtion15;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(18)]
        [EntityField("Funtion15")]
        public DateTime Funtion15
        {
            get
            {
                return _Funtion15;
            }
            set
            {
                SetChange("Funtion15", value);
            }
        }
        private DailyUserExtend _UserExtend;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(19)]
        [EntityField(true, ColumnDbType.LongText)]
        public DailyUserExtend UserExtend
        {
            get
            {
                return _UserExtend;
            }
            set
            {
                SetChange("UserExtend", value);
            }
        }
        private CacheList<FunPlot> _PlainPlotList;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(20)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<FunPlot> PlainPlotList
        {
            get
            {
                return _PlainPlotList;
            }
            set
            {
                SetChange("PlainPlotList", value);
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
                    case "RefreshDate": return RefreshDate;
                    case "Funtion1": return Funtion1;
                    case "Funtion2": return Funtion2;
                    case "Funtion3": return Funtion3;
                    case "Funtion4": return Funtion4;
                    case "Funtion5": return Funtion5;
                    case "Funtion6": return Funtion6;
                    case "Funtion7": return Funtion7;
                    case "Funtion8": return Funtion8;
                    case "Funtion9": return Funtion9;
                    case "FunPlot": return FunPlot;
                    case "Funtion10": return Funtion10;
                    case "Funtion11": return Funtion11;
                    case "Funtion12": return Funtion12;
                    case "Funtion13": return Funtion13;
                    case "Funtion14": return Funtion14;
                    case "Funtion15": return Funtion15;
                    case "UserExtend": return UserExtend;
                    case "PlainPlotList": return PlainPlotList;
                    default: throw new ArgumentException(string.Format("UserDailyRestrain index[{0}] isn't exist.", index));
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
                    case "RefreshDate":
                        _RefreshDate = value.ToDateTime();
                        break;
                    case "Funtion1":
                        _Funtion1 = value.ToInt();
                        break;
                    case "Funtion2":
                        _Funtion2 = value.ToInt();
                        break;
                    case "Funtion3":
                        _Funtion3 = value.ToInt();
                        break;
                    case "Funtion4":
                        _Funtion4 = value.ToInt();
                        break;
                    case "Funtion5":
                        _Funtion5 = value.ToInt();
                        break;
                    case "Funtion6":
                        _Funtion6 = value.ToInt();
                        break;
                    case "Funtion7":
                        _Funtion7 = value.ToInt();
                        break;
                    case "Funtion8":
                        _Funtion8 = value.ToInt();
                        break;
                    case "Funtion9":
                        _Funtion9 = value.ToInt();
                        break;
                    case "FunPlot":
                        _FunPlot =ConvertCustomField<CacheList<FunPlot>>(value, index); 
                        break;
                    case "Funtion10":
                        _Funtion10 = value.ToInt();
                        break;
                    case "Funtion11":
                        _Funtion11 = value.ToDateTime();
                        break;
                    case "Funtion12":
                        _Funtion12 = value.ToNotNullString();
                        break;
                    case "Funtion13":
                        _Funtion13 = value.ToInt();
                        break;
                    case "Funtion14":
                        _Funtion14 = value.ToInt();
                        break;
                    case "Funtion15":
                        _Funtion15 = value.ToDateTime();
                        break;
                    case "UserExtend":
                        _UserExtend = ConvertCustomField<DailyUserExtend>(value, index);
                        break;
                    case "PlainPlotList":
                        _PlainPlotList = ConvertCustomField<CacheList<FunPlot>>(value, index);
                        break;
                    default: throw new ArgumentException(string.Format("UserDailyRestrain index[{0}] isn't exist.", index));
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