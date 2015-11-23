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
    /// �������ͳ�Ʊ�
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserConsume : BaseEntity
    {

        
        public UserConsume()
            : base(AccessLevel.ReadWrite)
        {
        }
        
        #region auto-generated Property
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public String UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                SetChange("UserID", value);
            }
        }
        private Int32 _GoldNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("GoldNum")]
        public Int32 GoldNum
        {
            get
            {
                return _GoldNum;
            }
            set
            {
                SetChange("GoldNum", value);
            }
        }
        private DateTime _GoldDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("GoldDate")]
        public DateTime GoldDate
        {
            get
            {
                return _GoldDate;
            }
            set
            {
                SetChange("GoldDate", value);
            }
        }
        private Int32 _GameCoin;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("GameCoin")]
        public Int32 GameCoin
        {
            get
            {
                return _GameCoin;
            }
            set
            {
                SetChange("GameCoin", value);
            }
        }
        private DateTime _CoinDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("CoinDate")]
        public DateTime CoinDate
        {
            get
            {
                return _CoinDate;
            }
            set
            {
                SetChange("CoinDate", value);
            }
        }
        private Int32 _EnergyNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("EnergyNum")]
        public Int32 EnergyNum
        {
            get
            {
                return _EnergyNum;
            }
            set
            {
                SetChange("EnergyNum", value);
            }
        }
        private DateTime _EnergyDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("EnergyDate")]
        public DateTime EnergyDate
        {
            get
            {
                return _EnergyDate;
            }
            set
            {
                SetChange("EnergyDate", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "UserID": return UserID;
                    case "GoldNum": return GoldNum;
                    case "GoldDate": return GoldDate;
                    case "GameCoin": return GameCoin;
                    case "CoinDate": return CoinDate;
                    case "EnergyNum": return EnergyNum;
                    case "EnergyDate": return EnergyDate;
					default: throw new ArgumentException(string.Format("UserConsume index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "UserID": 
                        _UserID = value.ToNotNullString(); 
                        break; 
                    case "GoldNum": 
                        _GoldNum = value.ToInt(); 
                        break; 
                    case "GoldDate": 
                        _GoldDate = value.ToDateTime();                         
                        break; 
                    case "GameCoin": 
                        _GameCoin = value.ToInt(); 
                        break; 
                    case "CoinDate": 
                        _CoinDate = value.ToDateTime();                         
                        break; 
                    case "EnergyNum": 
                        _EnergyNum = value.ToInt(); 
                        break; 
                    case "EnergyDate": 
                        _EnergyDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("UserConsume index[{0}] isn't exist.", index));
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