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
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class SJTRankRewarInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public SJTRankRewarInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        
        /// <summary>
        /// </summary>
        public SJTRankRewarInfo(int ranKing, int rankStype)
            : this()
        {
            _ranKing = ranKing;
            _rankStype = rankStype;
        }

        #region 自动生成属性
        private int _ranKing;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("RanKing", IsKey = true)]
        public int RanKing
        {
            get
            {
                return _ranKing;
            } 
            
        }
        private int _rankStype;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("RankStype", IsKey = true)]
        public int RankStype
        {
            get
            {
                return _rankStype;
            } 
            
        }
        private int _giftGold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("GiftGold")]
        public int GiftGold
        {
            get
            {
                return _giftGold;
            } 
            
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "RanKing": return _ranKing;
                    case "RankStype": return _rankStype;
                    case "GiftGold": return _giftGold;
					default: throw new ArgumentException(string.Format("SJTRankRewarInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "RanKing": 
                        _ranKing = value.ToInt();
                        break; 
                    case "RankStype": 
                        _rankStype = value.ToInt();
                        break; 
                    case "GiftGold": 
                        _giftGold = value.ToInt();
                        break; 
					default: throw new ArgumentException(string.Format("SJTRankRewarInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion

	}
}