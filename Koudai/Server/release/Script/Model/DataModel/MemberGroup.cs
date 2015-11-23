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
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 公会成员分组表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Entity, DbConfig.Data, Condition = "IsRemove=0")]

    public class MemberGroup : ShareEntity
    {

        public const string Index_FastID = "Index_FastID";
        public MemberGroup()
            : base(AccessLevel.ReadWrite)
        {
        }        

        public MemberGroup(String ID)
            : this()
        {
            this.ID = ID;
        }

        #region 自动生成属性

        private String _ID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("ID", IsKey = true)]
        public String ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                SetChange("ID", value);
            }
        }

        private Int32 _FastID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("FastID")]
        public Int32 FastID
        {
            get
            {
                return _FastID;
            }
            set
            {
                SetChange("FastID", value);
            }
        }

        private String _GuildIDA;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("GuildIDA")]
        public String GuildIDA
        {
            get
            {
                return _GuildIDA;
            }
            set
            {
                SetChange("GuildIDA", value);
            }
        }

        private String _GuildIDB;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("GuildIDB")]
        public String GuildIDB
        {
            get
            {
                return _GuildIDB;
            }
            set
            {
                SetChange("GuildIDB", value);
            }
        }

        private String _UserIDA;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("UserIDA")]
        public String UserIDA
        {
            get
            {
                return _UserIDA;
            }
            set
            {
                SetChange("UserIDA", value);
            }
        }

        private String _UserIDB;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("UserIDB")]
        public String UserIDB
        {
            get
            {
                return _UserIDB;
            }
            set
            {
                SetChange("UserIDB", value);
            }
        }

        private Boolean _Win;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("Win")]
        public Boolean Win
        {
            get
            {
                return _Win;
            }
            set
            {
                SetChange("Win", value);
            }
        }

        private FightCombatProcess _CombatProcess;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField(true, ColumnDbType.LongText)]
        public FightCombatProcess CombatProcess
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

        private bool _IsRemove;

        /// <summary>
        /// 是否移除
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("IsRemove")]
        public bool IsRemove
        {
            get
            {
                return _IsRemove;
            }
            set
            {
                SetChange("IsRemove", value);
            }
        }
        /// <summary>
        /// 本次战斗胜利的会员
        /// </summary>
        [ProtoMember(10)]
        public string ConquerMember { get; set; }

        /// <summary>
        /// 本次战斗失败的会员
        /// </summary>
        [ProtoMember(11)]
        public string DefeatMember { get; set; }

        /// <summary>
        /// 战斗胜利的会员是否战胜方公会会员
        /// </summary>
        [ProtoMember(12)]
        public bool IsEnemy { get; set; }

        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ID": return ID;
                    case "FastID": return FastID;
                    case "GuildIDA": return GuildIDA;
                    case "GuildIDB": return GuildIDB;
                    case "UserIDA": return UserIDA;
                    case "UserIDB": return UserIDB;
                    case "Win": return Win;
                    case "CombatProcess": return CombatProcess;
                    case "IsRemove": return IsRemove;
					default: throw new ArgumentException(string.Format("MemberGroup index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _ID = value.ToNotNullString(); 
                        break; 
                    case "FastID": 
                        _FastID = value.ToInt(); 
                        break; 
                    case "GuildIDA": 
                        _GuildIDA = value.ToNotNullString(); 
                        break; 
                    case "GuildIDB": 
                        _GuildIDB = value.ToNotNullString(); 
                        break; 
                    case "UserIDA": 
                        _UserIDA = value.ToNotNullString(); 
                        break; 
                    case "UserIDB": 
                        _UserIDB = value.ToNotNullString(); 
                        break; 
                    case "Win": 
                        _Win = value.ToBool(); 
                        break; 
                    case "CombatProcess":
                        _CombatProcess = value as FightCombatProcess;
                        break;
                    case "IsRemove":
                        _IsRemove = value.ToBool();
                        break;
					default: throw new ArgumentException(string.Format("MemberGroup index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
                
        protected override int GetIdentityId()
        {
            //allow modify return value
            return DefIdentityId;
        }
	}
}