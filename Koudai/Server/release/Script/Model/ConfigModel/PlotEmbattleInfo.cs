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


    public class PlotEmbattleInfo : ShareEntity
    {

        public const string Index_NpcID = "Index_NpcID";
        public const string Index_MonsterID = "Index_MonsterID";
        
        public PlotEmbattleInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _PlotNpcID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotNpcID", IsKey = true)]
        public Int32 PlotNpcID
        {
            get
            {
                return _PlotNpcID;
            }
            private set
            {
                SetChange("PlotNpcID", value);
            }
        }
        private Int16 _GridSeqNo;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GridSeqNo", IsKey = true)]
        public Int16 GridSeqNo
        {
            get
            {
                return _GridSeqNo;
            }
            private set
            {
                SetChange("GridSeqNo", value);
            }
        }
        private Int32 _MonsterID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MonsterID")]
        public Int32 MonsterID
        {
            get
            {
                return _MonsterID;
            }
            private set
            {
                SetChange("MonsterID", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "PlotNpcID": return PlotNpcID;
                    case "GridSeqNo": return GridSeqNo;
                    case "MonsterID": return MonsterID;
					default: throw new ArgumentException(string.Format("PlotEmbattleInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "PlotNpcID": 
                        _PlotNpcID = value.ToInt(); 
                        break; 
                    case "GridSeqNo": 
                        _GridSeqNo = value.ToShort(); 
                        break; 
                    case "MonsterID": 
                        _MonsterID = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("PlotEmbattleInfo index[{0}] isn't exist.", index));
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