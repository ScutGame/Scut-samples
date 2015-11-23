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

    public class RechargePacks : ShareEntity
    {

        public const string Index_PacksType = "Index_PacksType";
        
        public RechargePacks()
            : base(AccessLevel.ReadOnly)
        {
            Reward = new CacheList<PackageReward>(0, true);
        }
        
        #region auto-generated Property
        private Int32 _PacksID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PacksID", IsKey = true)]
        public Int32 PacksID
        {
            get
            {
                return _PacksID;
            }
            private set
            {
                SetChange("PacksID", value);
            }
        }
        private Int32 _PacksType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PacksType")]
        public Int32 PacksType
        {
            get
            {
                return _PacksType;
            }
            private set
            {
                SetChange("PacksType", value);
            }
        }
        private Int32 _RechargeNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("RechargeNum")]
        public Int32 RechargeNum
        {
            get
            {
                return _RechargeNum;
            }
            private set
            {
                SetChange("RechargeNum", value);
            }
        }
        private String _PacksName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PacksName")]
        public String PacksName
        {
            get
            {
                return _PacksName;
            }
            private set
            {
                SetChange("PacksName", value);
            }
        }
        private Decimal _ProportionNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ProportionNum")]
        public Decimal ProportionNum
        {
            get
            {
                return _ProportionNum;
            }
            private set
            {
                SetChange("ProportionNum", value);
            }
        }
        private CacheList<PackageReward> _Reward;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PackageReward> Reward
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
        private String _PacksDesc;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PacksDesc")]
        public String PacksDesc
        {
            get
            {
                return _PacksDesc;
            }
            private set
            {
                SetChange("PacksDesc", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "PacksID": return PacksID;
                    case "PacksType": return PacksType;
                    case "RechargeNum": return RechargeNum;
                    case "PacksName": return PacksName;
                    case "ProportionNum": return ProportionNum;
                    case "Reward": return Reward;
                    case "PacksDesc": return PacksDesc;
					default: throw new ArgumentException(string.Format("RechargePacks index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "PacksID": 
                        _PacksID = value.ToInt(); 
                        break; 
                    case "PacksType": 
                        _PacksType = value.ToInt(); 
                        break; 
                    case "RechargeNum": 
                        _RechargeNum = value.ToInt(); 
                        break; 
                    case "PacksName": 
                        _PacksName = value.ToNotNullString(); 
                        break; 
                    case "ProportionNum": 
                        _ProportionNum = value.ToDecimal(); 
                        break; 
                    case "Reward":
                        _Reward =ConvertCustomField<CacheList<PackageReward>>(value, index); 
                        break; 
                    case "PacksDesc": 
                        _PacksDesc = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("RechargePacks index[{0}] isn't exist.", index));
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