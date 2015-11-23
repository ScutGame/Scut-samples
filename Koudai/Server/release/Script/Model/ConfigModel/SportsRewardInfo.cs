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
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class SportsRewardInfo : ShareEntity
    {

        
        public SportsRewardInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _TopID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TopID", IsKey = true)]
        public Int32 TopID
        {
            get
            {
                return _TopID;
            }
            private set
            {
                SetChange("TopID", value);
            }
        }
        private Int32 _RewardGoin;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("RewardGoin")]
        public Int32 RewardGoin
        {
            get
            {
                return _RewardGoin;
            }
            private set
            {
                SetChange("RewardGoin", value);
            }
        }
        private Int32 _RewardObtian;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("RewardObtian")]
        public Int32 RewardObtian
        {
            get
            {
                return _RewardObtian;
            }
            private set
            {
                SetChange("RewardObtian", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "TopID": return TopID;
                    case "RewardGoin": return RewardGoin;
                    case "RewardObtian": return RewardObtian;
					default: throw new ArgumentException(string.Format("SportsRewardInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "TopID": 
                        _TopID = value.ToInt(); 
                        break; 
                    case "RewardGoin": 
                        _RewardGoin = value.ToInt(); 
                        break; 
                    case "RewardObtian": 
                        _RewardObtian = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("SportsRewardInfo index[{0}] isn't exist.", index));
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