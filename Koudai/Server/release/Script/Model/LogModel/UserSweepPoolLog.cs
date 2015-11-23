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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserSweepPoolLog")]
    public class UserSweepPoolLog : BaseEntity
    {
        #region auto-generated static method
        static UserSweepPoolLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserSweepPoolLog));
        }
        #endregion
        
        public UserSweepPoolLog()
            : base(AccessLevel.WriteOnly)
        {
        }
        
        #region auto-generated Property
        private String _LogID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LogID", IsKey = true)]
        public String LogID
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
        private Int32 _TurnsNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TurnsNum")]
        public Int32 TurnsNum
        {
            private get
            {
                return _TurnsNum;
            }
            set
            {
                SetChange("TurnsNum", value);
            }
        }
        private Int32 _BattleNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BattleNum")]
        public Int32 BattleNum
        {
            private get
            {
                return _BattleNum;
            }
            set
            {
                SetChange("BattleNum", value);
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
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Experience")]
        public Int32 Experience
        {
            private get
            {
                return _Experience;
            }
            set
            {
                SetChange("Experience", value);
            }
        }
        private Int32 _GameCoin;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GameCoin")]
        public Int32 GameCoin
        {
            private get
            {
                return _GameCoin;
            }
            set
            {
                SetChange("GameCoin", value);
            }
        }
        private Int32 _Gold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Gold")]
        public Int32 Gold
        {
            private get
            {
                return _Gold;
            }
            set
            {
                SetChange("Gold", value);
            }
        }
        private Int32 _ExpNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ExpNum")]
        public Int32 ExpNum
        {
            private get
            {
                return _ExpNum;
            }
            set
            {
                SetChange("ExpNum", value);
            }
        }
        private String _PrizeItems;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PrizeItems")]
        public String PrizeItems
        {
            private get
            {
                return _PrizeItems;
            }
            set
            {
                SetChange("PrizeItems", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            private get
            {
                return _CreateDate;
            }
            set
            {
                SetChange("CreateDate", value);
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
                    case "TurnsNum": return TurnsNum;
                    case "BattleNum": return BattleNum;
                    case "PlotID": return PlotID;
                    case "Experience": return Experience;
                    case "GameCoin": return GameCoin;
                    case "Gold": return Gold;
                    case "ExpNum": return ExpNum;
                    case "PrizeItems": return PrizeItems;
                    case "CreateDate": return CreateDate;
					default: throw new ArgumentException(string.Format("UserSweepPoolLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "LogID": 
                        _LogID = value.ToNotNullString(); 
                        break; 
                    case "UserID": 
                        _UserID = value.ToNotNullString(); 
                        break; 
                    case "TurnsNum": 
                        _TurnsNum = value.ToInt(); 
                        break; 
                    case "BattleNum": 
                        _BattleNum = value.ToInt(); 
                        break; 
                    case "PlotID": 
                        _PlotID = value.ToInt(); 
                        break; 
                    case "Experience": 
                        _Experience = value.ToInt(); 
                        break; 
                    case "GameCoin": 
                        _GameCoin = value.ToInt(); 
                        break; 
                    case "Gold": 
                        _Gold = value.ToInt(); 
                        break; 
                    case "ExpNum": 
                        _ExpNum = value.ToInt(); 
                        break; 
                    case "PrizeItems": 
                        _PrizeItems = value.ToNotNullString(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("UserSweepPoolLog index[{0}] isn't exist.", index));
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