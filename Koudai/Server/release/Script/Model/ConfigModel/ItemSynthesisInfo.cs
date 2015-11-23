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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Enum;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]


    public class ItemSynthesisInfo : ShareEntity
    {
        public const string Index_ItemID = "Index_ItemID";
        public const string Index_SynthesisID = "Index_SynthesisID";

        
        public ItemSynthesisInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemID", IsKey = true)]
        public Int32 ItemID
        {
            get
            {
                return _ItemID;
            }
            private set
            {
                SetChange("ItemID", value);
            }
        }
        private Int32 _SynthesisID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SynthesisID", IsKey = true)]
        public Int32 SynthesisID
        {
            get
            {
                return _SynthesisID;
            }
            private set
            {
                SetChange("SynthesisID", value);
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
        private Int32 _SynthesisNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SynthesisNum")]
        public Int32 SynthesisNum
        {
            get
            {
                return _SynthesisNum;
            }
            private set
            {
                SetChange("SynthesisNum", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ItemID": return ItemID;
                    case "SynthesisID": return SynthesisID;
                    case "DemandNum": return DemandNum;
                    case "SynthesisNum": return SynthesisNum;
					default: throw new ArgumentException(string.Format("ItemSynthesisInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ItemID": 
                        _ItemID = value.ToInt(); 
                        break; 
                    case "SynthesisID": 
                        _SynthesisID = value.ToInt(); 
                        break; 
                    case "DemandNum": 
                        _DemandNum = value.ToInt(); 
                        break; 
                    case "SynthesisNum": 
                        _SynthesisNum = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("ItemSynthesisInfo index[{0}] isn't exist.", index));
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
        public Int16 DemandLv
        {
            get { return new ShareCacheStruct<ItemBaseInfo>().FindKey(ItemID).DemandLv; }
        }

        public ItemType ItemType
        {
            get
            {
                return new ShareCacheStruct<ItemBaseInfo>().FindKey(ItemID).ItemType;
            }
        }
	}
}