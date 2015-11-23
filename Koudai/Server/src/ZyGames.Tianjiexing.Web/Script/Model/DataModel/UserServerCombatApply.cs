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
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ProtoBuf;
using ZyGames.Tianjiexing.Model.Enum;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 玩家跨服战报名表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Entity, DbConfig.Data)]
    public class UserServerCombatApply : ShareEntity
    {


        public UserServerCombatApply()
            : base(AccessLevel.ReadWrite)
        {
        }        

        public UserServerCombatApply(String UserID, Int32 FastID, Int32 ServerID)
            : this()
        {
            this.UserID = UserID;
            this.FastID = FastID;
            this.ServerID = ServerID;
        }

        #region 自动生成属性

        private String _UserID;
        /// <summary>
        /// 玩家ID
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public String UserID
        {
            get
            {
                return _UserID;
            }
            private set
            {
                SetChange("UserID", value);
            }
        }

        private Int32 _FastID;
        /// <summary>
        /// 活动ID
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("FastID", IsKey = true)]
        public Int32 FastID
        {
            get
            {
                return _FastID;
            }
            private set
            {
                SetChange("FastID", value);
            }
        }

        private Int32 _ServerID;
        /// <summary>
        /// 服ID
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("ServerID", IsKey = true)]
        public Int32 ServerID
        {
            get
            {
                return _ServerID;
            }
            private set
            {
                SetChange("ServerID", value);
            }
        }

        private Int32 _LostCount;
        /// <summary>
        /// 失败次数
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("LostCount")]
        public Int32 LostCount
        {
            get
            {
                return _LostCount;
            }
            set
            {
                SetChange("LostCount", value);
            }
        }

        private Int32 _CombatType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("CombatType")]
        public Int32 CombatType
        {
            get
            {
                return _CombatType;
            }
            set
            {
                SetChange("CombatType", value);
            }
        }

        private ServerCombatStage _Stage;
        /// <summary>
        /// 阶段
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("Stage")]
        public ServerCombatStage Stage
        {
            get
            {
                return _Stage;
            }
            set
            {
                SetChange("Stage", value);
            }
        }

        private Boolean _Issued;
        /// <summary>
        /// 是否下发奖励
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("Issued")]
        public Boolean Issued
        {
            get
            {
                return _Issued;
            }
            set
            {
                SetChange("Issued", value);
            }
        }

        private Int32 _TotalCombatNum;
        /// <summary>
        /// 战力
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("TotalCombatNum")]
        public Int32 TotalCombatNum
        {
            get
            {
                return _TotalCombatNum;
            }
            set
            {
                SetChange("TotalCombatNum", value);
            }
        }

        private Int32 _Social;
        /// <summary>
        /// 身价
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("Social")]
        public Int32 Social
        {
            get
            {
                return _Social;
            }
            set
            {
                SetChange("Social", value);
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
                    case "FastID": return FastID;
                    case "ServerID": return ServerID;
                    case "LostCount": return LostCount;
                    case "CombatType": return CombatType;
                    case "Stage": return Stage;
                    case "Issued": return Issued;
                    case "TotalCombatNum": return TotalCombatNum;
                    case "Social": return Social;
					default: throw new ArgumentException(string.Format("UserServerCombatApply index[{0}] isn't exist.", index));
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
                    case "FastID": 
                        _FastID = value.ToInt(); 
                        break; 
                    case "ServerID": 
                        _ServerID = value.ToInt(); 
                        break; 
                    case "LostCount": 
                        _LostCount = value.ToInt(); 
                        break; 
                    case "CombatType": 
                        _CombatType = value.ToInt(); 
                        break; 
                    case "Stage": 
                        _Stage = value.ToEnum<ServerCombatStage>(); 
                        break; 
                    case "Issued": 
                        _Issued = value.ToBool(); 
                        break; 
                    case "TotalCombatNum": 
                        _TotalCombatNum = value.ToInt(); 
                        break; 
                    case "Social": 
                        _Social = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("UserServerCombatApply index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
                
        protected override int GetIdentityId()
        {
            return DefIdentityId;
        }
        
        public string CombatUserID
        {
            get
            {
                //return UserID;
                return string.Concat(UserID, ServerID.ToString().PadLeft(2, '0'));
            }
        }

        private GameUser _gameuser;

        public GameUser gameuser
        {
            get
            {
                if (_gameuser == null)
                {
                    _gameuser = UserCacheGlobal.GetGameUser(CombatUserID);
                }
                return _gameuser;
            }
        }

        /// <summary>
        /// 结果
        /// </summary>
        public bool GetResult(ServerCombatStage stage)
        {
            switch (stage)
            {
                case ServerCombatStage.Close:
                case ServerCombatStage.Apply:
                    return true;
                case ServerCombatStage.serverkonckout:
                case ServerCombatStage.finalskonckout:
                    return LostCount < 5;
                case ServerCombatStage.finals_32:
                case ServerCombatStage.finals_16:
                case ServerCombatStage.quarter_final:
                case ServerCombatStage.semi_final:
                case ServerCombatStage.final:
                    return LostCount < 3;
                default:
                    break;
            }
            return true;

        }

	}
}