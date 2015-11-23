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
    public class NoviceActivities : ShareEntity
    {

        
        public NoviceActivities()
            : base(AccessLevel.ReadOnly)
        {
            Reward = new CacheList<NoviceReward>(0, true);
        }
        
        #region auto-generated Property
        private Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ID", IsKey = true)]
        public Int32 ID
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
        private Int16 _ActivitiesType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ActivitiesType")]
        public Int16 ActivitiesType
        {
            get
            {
                return _ActivitiesType;
            }
            private set
            {
                SetChange("ActivitiesType", value);
            }
        }
        private Int32 _DemandNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("DemandNum")]
        public Int32 DemandNum
        {
            get
            {
                return _DemandNum;
            }
            private set
            {
                SetChange("DemandNum", value);
            }
        }
        private CacheList<NoviceReward> _Reward;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<NoviceReward> Reward
        {
            get
            {
                return _Reward;
            }
            private set
            {
                SetChange("Reward", value);
            }
        }
        private String _Description;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Description")]
        public String Description
        {
            get
            {
                return _Description;
            }
            private set
            {
                SetChange("Description", value);
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
                    case "ActivitiesType": return ActivitiesType;
                    case "DemandNum": return DemandNum;
                    case "Reward": return Reward;
                    case "Description": return Description;
					default: throw new ArgumentException(string.Format("NoviceActivities index[{0}] isn't exist.", index));
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
                    case "ActivitiesType": 
                        _ActivitiesType = value.ToShort(); 
                        break; 
                    case "DemandNum": 
                        _DemandNum = value.ToInt(); 
                        break; 
                    case "Reward":
                        _Reward =ConvertCustomField<CacheList<NoviceReward>>(value, index); 
                        break; 
                    case "Description": 
                        _Description = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("NoviceActivities index[{0}] isn't exist.", index));
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