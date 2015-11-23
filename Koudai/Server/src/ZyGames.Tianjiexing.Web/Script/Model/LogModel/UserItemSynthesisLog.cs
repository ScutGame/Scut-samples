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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserItemSynthesisLog")]
    public class UserItemSynthesisLog : BaseEntity
    {
        #region auto-generated static method
        static UserItemSynthesisLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserItemSynthesisLog));
        }
        #endregion
        
        public UserItemSynthesisLog()
            : base(AccessLevel.WriteOnly)
        {
        }
        
        #region auto-generated Property
        private String _ID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ID", IsKey = true)]
        public String ID
        {
            private get
            {
                return _ID;
            }
            set
            {
                SetChange("ID", value);
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
        private Int16 _OpType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("OpType")]
        public Int16 OpType
        {
            private get
            {
                return _OpType;
            }
            set
            {
                SetChange("OpType", value);
            }
        }
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemID")]
        public Int32 ItemID
        {
            private get
            {
                return _ItemID;
            }
            set
            {
                SetChange("ItemID", value);
            }
        }
        private Int32 _OpNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("OpNum")]
        public Int32 OpNum
        {
            private get
            {
                return _OpNum;
            }
            set
            {
                SetChange("OpNum", value);
            }
        }
        private CacheList<SynthesisInfo> _DemandMaterial;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<SynthesisInfo> DemandMaterial
        {
            private get
            {
                return _DemandMaterial;
            }
            set
            {
                SetChange("DemandMaterial", value);
            }
        }
        private SynthesisInfo _SurplusMaterial;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public SynthesisInfo SurplusMaterial
        {
            private get
            {
                return _SurplusMaterial;
            }
            set
            {
                SetChange("SurplusMaterial", value);
            }
        }
        private Int32 _UseGold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UseGold")]
        public Int32 UseGold
        {
            private get
            {
                return _UseGold;
            }
            set
            {
                SetChange("UseGold", value);
            }
        }
        private Int16 _BeforeLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BeforeLv")]
        public Int16 BeforeLv
        {
            private get
            {
                return _BeforeLv;
            }
            set
            {
                SetChange("BeforeLv", value);
            }
        }
        private Int16 _AfterLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AfterLv")]
        public Int16 AfterLv
        {
            private get
            {
                return _AfterLv;
            }
            set
            {
                SetChange("AfterLv", value);
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
                    case "ID": return ID;
                    case "UserID": return UserID;
                    case "OpType": return OpType;
                    case "ItemID": return ItemID;
                    case "OpNum": return OpNum;
                    case "DemandMaterial": return DemandMaterial;
                    case "SurplusMaterial": return SurplusMaterial;
                    case "UseGold": return UseGold;
                    case "BeforeLv": return BeforeLv;
                    case "AfterLv": return AfterLv;
                    case "CreateDate": return CreateDate;
					default: throw new ArgumentException(string.Format("UserItemSynthesisLog index[{0}] isn't exist.", index));
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
                    case "UserID": 
                        _UserID = value.ToNotNullString(); 
                        break; 
                    case "OpType": 
                        _OpType = value.ToShort(); 
                        break; 
                    case "ItemID": 
                        _ItemID = value.ToInt(); 
                        break; 
                    case "OpNum": 
                        _OpNum = value.ToInt(); 
                        break; 
                    case "DemandMaterial":
                        _DemandMaterial =ConvertCustomField<CacheList<SynthesisInfo>>(value, index); 
                        break; 
                    case "SurplusMaterial":
                        _SurplusMaterial = ConvertCustomField<SynthesisInfo>(value, index); 
                        break; 
                    case "UseGold": 
                        _UseGold = value.ToInt(); 
                        break; 
                    case "BeforeLv": 
                        _BeforeLv = value.ToShort(); 
                        break; 
                    case "AfterLv": 
                        _AfterLv = value.ToShort(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("UserItemSynthesisLog index[{0}] isn't exist.", index));
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