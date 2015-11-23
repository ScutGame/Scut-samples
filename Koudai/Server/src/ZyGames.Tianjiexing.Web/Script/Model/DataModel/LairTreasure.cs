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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ProtoBuf;
using ZyGames.Tianjiexing.Model.Config;

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
    public class LairTreasureInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public LairTreasureInfo()
            : base(AccessLevel.ReadOnly)
        {
            LairTreasureList = new CacheList<LairTreasure>(0, true);
        }        
        /// <summary>
        /// </summary>
        public LairTreasureInfo(int lairTreasureType)
            : this()
        {
            _lairTreasureType = lairTreasureType;
        }

        #region 自动生成属性
        private int _lairTreasureType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("LairTreasureType", IsKey = true)]
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
        private int _lairTreasureNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("LairTreasureNum")]
        public int LairTreasureNum
        {
            get
            {
                return _lairTreasureNum;
            }
            set
            {
                SetChange("LairTreasureNum", value);
            }
            
        }
        private int _useNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("UseNum")]
        public int UseNum
        {
            get
            {
                return _useNum;
            }
            set
            {
                SetChange("UseNum", value);
            }
            
        }
        private int _useType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("UseType")]
        public int UseType
        {
            get
            {
                return _useType;
            }
            set
            {
                SetChange("UseType", value);
            }
            
        }
        private string _lairTreasureDesc;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("LairTreasureDesc")]
        public string LairTreasureDesc
        {
            get
            {
                return _lairTreasureDesc;
            }
            set
            {
                SetChange("LairTreasureDesc", value);
            }
            
        }
        private CacheList<LairTreasure> _lairTreasureList;
        /// <summary>
        /// <LairTreasure>
        /// </summary>        
        [ProtoMember(6)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<LairTreasure> LairTreasureList
        {
            get
            {
                return _lairTreasureList;
            }
            private set
            {
                SetChange("LairTreasureList", value);
            }
            
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "LairTreasureType": return _lairTreasureType;
                    case "LairTreasureNum": return _lairTreasureNum;
                    case "UseNum": return _useNum;
                    case "UseType": return _useType;
                    case "LairTreasureDesc": return _lairTreasureDesc;
                    case "LairTreasureList": return _lairTreasureList;
					default: throw new ArgumentException(string.Format("LairTreasure index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "LairTreasureType": 
                        _lairTreasureType = value.ToInt();
                        break; 
                    case "LairTreasureNum": 
                        _lairTreasureNum = value.ToInt();
                        break; 
                    case "UseNum": 
                        _useNum = value.ToInt();
                        break; 
                    case "UseType": 
                        _useType = value.ToInt();
                        break; 
                    case "LairTreasureDesc": 
                        _lairTreasureDesc = value.ToNotNullString();
                        break; 
                    case "LairTreasureList":
                        _lairTreasureList = ConvertCustomField<CacheList<LairTreasure>>(value, index); 
                        break; 
					default: throw new ArgumentException(string.Format("LairTreasure index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion

	}
}