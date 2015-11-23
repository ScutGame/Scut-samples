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
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class SJTRewarInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public SJTRewarInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        

        #region 自动生成属性
        private int _plotID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("PlotID",IsKey = true)]
        public int PlotID
        {
            get
            {
                return _plotID;
            } 
            
        }
        private int _gameCoin;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("GameCoin")]
        public int GameCoin
        {
            get
            {
                return _gameCoin;
            }

        }
        private CacheList<SJTRewar> _sJTRewarList;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<SJTRewar> SJTRewarList
        {
            get
            {
                return _sJTRewarList;
            } 
            
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "PlotID": return _plotID;
                    case "GameCoin": return _gameCoin;
                    case "SJTRewarList": return _sJTRewarList;
					default: throw new ArgumentException(string.Format("SJTRewarInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "PlotID": 
                        _plotID = value.ToInt();
                        break;
                    case "GameCoin":
                        _gameCoin = value.ToInt();
                        break; 
                    case "SJTRewarList":
                        _sJTRewarList = ConvertCustomField<CacheList<SJTRewar>>(value, index); 
                        break; 
					default: throw new ArgumentException(string.Format("SJTRewarInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion

	}
}