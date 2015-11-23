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
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]


    public class UserPlotCombat : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_UserPlot = "Index_UserPlot";

        public UserPlotCombat()
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
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("PlotID")]
        public Int32 PlotID
        {
            get
            {
                return _PlotID;
            }
            set
            {
                SetChange("PlotID", value);
            }
        }
        private Int32 _PlotNpcID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("PlotNpcID", IsKey = true)]
        public Int32 PlotNpcID
        {
            get
            {
                return _PlotNpcID;
            }
            set
            {
                SetChange("PlotNpcID", value);
            }
        }
        private Boolean _IsWin;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("IsWin")]
        public Boolean IsWin
        {
            get
            {
                return _IsWin;
            }
            set
            {
                SetChange("IsWin", value);
            }
        }
        private Int32 _GeneralNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("GeneralNum")]
        public Int32 GeneralNum
        {
            get
            {
                return _GeneralNum;
            }
            set
            {
                SetChange("GeneralNum", value);
            }
        }
        private Int32 _GeneralOverNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("GeneralOverNum")]
        public Int32 GeneralOverNum
        {
            get
            {
                return _GeneralOverNum;
            }
            set
            {
                SetChange("GeneralOverNum", value);
            }
        }
        private Int32 _OverNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("OverNum")]
        public Int32 OverNum
        {
            get
            {
                return _OverNum;
            }
            set
            {
                SetChange("OverNum", value);
            }
        }
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("Experience")]
        public Int32 Experience
        {
            get
            {
                return _Experience;
            }
            set
            {
                SetChange("Experience", value);
            }
        }
        private String _PrizeItems;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("PrizeItems")]
        public String PrizeItems
        {
            get
            {
                return _PrizeItems;
            }
            set
            {
                SetChange("PrizeItems", value);
            }
        }
        private String _CombatProcess;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField("CombatProcess", DbType = ColumnDbType.Text)]
        public String CombatProcess
        {
            get
            {
                return _CombatProcess;
            }
            set
            {
                SetChange("CombatProcess", value);
            }
        }
        private DateTime _CombatDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField("CombatDate")]
        public DateTime CombatDate
        {
            get
            {
                return _CombatDate;
            }
            set
            {
                SetChange("CombatDate", value);
            }
        }
        private Int32 _BlessExperience;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField("BlessExperience")]
        public Int32 BlessExperience
        {
            get
            {
                return _BlessExperience;
            }
            set
            {
                SetChange("BlessExperience", value);
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
                    case "PlotID": return PlotID;
                    case "PlotNpcID": return PlotNpcID;
                    case "IsWin": return IsWin;
                    case "GeneralNum": return GeneralNum;
                    case "GeneralOverNum": return GeneralOverNum;
                    case "OverNum": return OverNum;
                    case "Experience": return Experience;
                    case "PrizeItems": return PrizeItems;
                    case "CombatProcess": return CombatProcess;
                    case "CombatDate": return CombatDate;
                    case "BlessExperience": return BlessExperience;
                    default: throw new ArgumentException(string.Format("UserPlotCombat index[{0}] isn't exist.", index));
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
                    case "PlotID":
                        _PlotID = value.ToInt();
                        break;
                    case "PlotNpcID":
                        _PlotNpcID = value.ToInt();
                        break;
                    case "IsWin":
                        _IsWin = value.ToBool();
                        break;
                    case "GeneralNum":
                        _GeneralNum = value.ToInt();
                        break;
                    case "GeneralOverNum":
                        _GeneralOverNum = value.ToInt();
                        break;
                    case "OverNum":
                        _OverNum = value.ToInt();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    case "PrizeItems":
                        _PrizeItems = value.ToNotNullString();
                        break;
                    case "CombatProcess":
                        _CombatProcess = value.ToNotNullString();
                        break;
                    case "CombatDate":
                        _CombatDate = value.ToDateTime();
                        break;
                    case "BlessExperience":
                        _BlessExperience = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserPlotCombat index[{0}] isn't exist.", index));
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