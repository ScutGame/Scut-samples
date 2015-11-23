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

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data)]
    public class LairRewardInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public LairRewardInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        
        /// <summary>
        /// </summary>
        public LairRewardInfo(int id)
            : this()
        {
            _ID = id;
            
        }

        #region 自动生成属性
        private int _ID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("ID", IsKey = true)]
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                SetChange("ID", value);
            }

        }
        private int _lairTreasureType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("LairTreasureType")]
        public int LairTreasureType
        {
            get
            {
                return _lairTreasureType;
            }
            set
            {
                SetChange("LairTreasureType", value);
            }
            
        }
        private int _itemID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("ItemID")]
        public int ItemID
        {
            get
            {
                return _itemID;
            }
            set
            {
                SetChange("ItemID", value);
            }
            
        }
        private int _lairRewardType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("LairRewardType")]
        public int LairRewardType
        {
            get
            {
                return _lairRewardType;
            }
            set
            {
                SetChange("LairRewardType", value);
            }
            
        }
        private string _RewardDesc;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("RewardDesc")]
        public string RewardDesc
        {
            get
            {
                return _RewardDesc;
            }
            set
            {
                SetChange("RewardDesc", value);
            }
            
        }
        private int _LairPosition;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("LairPosition")]
        public int LairPosition
        {
            get
            {
                return _LairPosition;
            }
            set
            {
                SetChange("LairPosition", value);
            }

        }
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ID": return _ID;
                    case "LairTreasureType": return _lairTreasureType;
                    case "ItemID": return _itemID;
                    case "LairRewardType": return _lairRewardType;
                    case "RewardDesc": return _RewardDesc;
                    case "LairPosition": return _LairPosition;
					default: throw new ArgumentException(string.Format("LairRewardInfo index[{0}] isn't exist.", index));
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
                    case "LairTreasureType": 
                        _lairTreasureType = value.ToInt();
                        break; 
                    case "ItemID": 
                        _itemID = value.ToInt();
                        break; 
                    case "LairRewardType": 
                        _lairRewardType = value.ToInt();
                        break; 
                    case "RewardDesc": 
                        _RewardDesc = value.ToNotNullString();
                        break;
                    case "LairPosition":
                        _LairPosition = value.ToInt();
                        break; 
					default: throw new ArgumentException(string.Format("LairRewardInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion

	}
}