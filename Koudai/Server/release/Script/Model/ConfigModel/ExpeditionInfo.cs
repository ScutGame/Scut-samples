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
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class ExpeditionInfo : ShareEntity
    {

        public const string Index_GroupID = "Index_GroupID";
        
        public ExpeditionInfo()
            : base(AccessLevel.ReadOnly)
        {
            RewardNum1 = new CacheList<RewardShow>(0,true);
            RewardNum2 = new CacheList<RewardShow>(0, true);
        }
        
        #region auto-generated Property
        private Int32 _ExpID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ExpID", IsKey = true)]
        public Int32 ExpID
        {
            get
            {
                return _ExpID;
            }
            private set
            {
                SetChange("ExpID", value);
            }
        }
        private Int32 _GroupID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GroupID")]
        public Int32 GroupID
        {
            get
            {
                return _GroupID;
            }
            private set
            {
                SetChange("GroupID", value);
            }
        }
        private String _ExpName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ExpName")]
        public String ExpName
        {
            get
            {
                return _ExpName;
            }
            private set
            {
                SetChange("ExpName", value);
            }
        }
        private String _Answer1;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Answer1")]
        public String Answer1
        {
            get
            {
                return _Answer1;
            }
            private set
            {
                SetChange("Answer1", value);
            }
        }
        private String _Answer2;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Answer2")]
        public String Answer2
        {
            get
            {
                return _Answer2;
            }
            private set
            {
                SetChange("Answer2", value);
            }
        }
        private CacheList<RewardShow> _RewardNum1;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<RewardShow> RewardNum1
        {
            get
            {
                return _RewardNum1;
            }
            private set
            {
                SetChange("RewardNum1", value);
            }
        }
        private CacheList<RewardShow> _RewardNum2;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<RewardShow> RewardNum2
        {
            get
            {
                return _RewardNum2;
            }
            private set
            {
                SetChange("RewardNum2", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ExpID": return ExpID;
                    case "GroupID": return GroupID;
                    case "ExpName": return ExpName;
                    case "Answer1": return Answer1;
                    case "Answer2": return Answer2;
                    case "RewardNum1": return RewardNum1;
                    case "RewardNum2": return RewardNum2;
					default: throw new ArgumentException(string.Format("ExpeditionInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ExpID": 
                        _ExpID = value.ToInt(); 
                        break; 
                    case "GroupID": 
                        _GroupID = value.ToInt(); 
                        break; 
                    case "ExpName": 
                        _ExpName = value.ToNotNullString(); 
                        break; 
                    case "Answer1": 
                        _Answer1 = value.ToNotNullString(); 
                        break; 
                    case "Answer2": 
                        _Answer2 = value.ToNotNullString(); 
                        break; 
                    case "RewardNum1":
                        _RewardNum1 = ConvertCustomField<CacheList<RewardShow>>(value, index); 
                        break; 
                    case "RewardNum2":
                        _RewardNum2 = ConvertCustomField<CacheList<RewardShow>>(value, index);
                        break; 
					default: throw new ArgumentException(string.Format("ExpeditionInfo index[{0}] isn't exist.", index));
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