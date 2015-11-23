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
    /// 法宝祭祀配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]

    public class WorshipInfo : ShareEntity
    {
        public const string Index_TrumpID = "Index_TrumpID";
        public WorshipInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        

        public WorshipInfo(Int32 TrumpID, Int16 WorshipLv)
            : this()
        {
            this.TrumpID = TrumpID;
            this.WorshipLv = WorshipLv;
        }

        #region 自动生成属性

        private Int32 _TrumpID;
        /// <summary>
        ///  法宝ID，主键
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("TrumpID", IsKey = true)]
        public Int32 TrumpID
        {
            get
            {
                return _TrumpID;
            }
            private set
            {
                SetChange("TrumpID", value);
            }
        }

        private Int16 _WorshipLv;
        /// <summary>
        ///  法宝祭祀等级，主键
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("WorshipLv", IsKey = true)]
        public Int16 WorshipLv
        {
            get
            {
                return _WorshipLv;
            }
            private set
            {
                SetChange("WorshipLv", value);
            }
        }

        private Int32 _ItemID;
        /// <summary>
        /// 祭祀消耗材料类型（物品ID）
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("ItemID")]
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

        private Int32 _ItemNum;
        /// <summary>
        ///  祭祀消耗材料数量
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("ItemNum")]
        public Int32 ItemNum
        {
            get
            {
                return _ItemNum;
            }
            private set
            {
                SetChange("ItemNum", value);
            }
        }

        private Int32 _GameCoin;
        /// <summary>
        /// 祭祀消耗金币
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("GameCoin")]
        public Int32 GameCoin
        {
            get
            {
                return _GameCoin;
            }
            private set
            {
                SetChange("GameCoin", value);
            }
        }

        private Int32 _ObtainNum;
        /// <summary>
        /// 祭祀消耗声望
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("ObtainNum")]
        public Int32 ObtainNum
        {
            get
            {
                return _ObtainNum;
            }
            private set
            {
                SetChange("ObtainNum", value);
            }
        }

        private Decimal _SuccessNum;
        /// <summary>
        /// 祭祀成功率
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("SuccessNum")]
        public Decimal SuccessNum
        {
            get
            {
                return _SuccessNum;
            }
            private set
            {
                SetChange("SuccessNum", value);
            }
        }

        private Boolean _IsOpen;
        /// <summary>
        /// 祭祀是否开启附加属性
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("IsOpen")]
        public Boolean IsOpen
        {
            get
            {
                return _IsOpen;
            }
            private set
            {
                SetChange("IsOpen", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "TrumpID": return TrumpID;
                    case "WorshipLv": return WorshipLv;
                    case "ItemID": return ItemID;
                    case "ItemNum": return ItemNum;
                    case "GameCoin": return GameCoin;
                    case "ObtainNum": return ObtainNum;
                    case "SuccessNum": return SuccessNum;
                    case "IsOpen": return IsOpen;
					default: throw new ArgumentException(string.Format("WorshipInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "TrumpID": 
                        _TrumpID = value.ToInt(); 
                        break; 
                    case "WorshipLv": 
                        _WorshipLv = value.ToShort(); 
                        break; 
                    case "ItemID": 
                        _ItemID = value.ToInt(); 
                        break; 
                    case "ItemNum": 
                        _ItemNum = value.ToInt(); 
                        break; 
                    case "GameCoin": 
                        _GameCoin = value.ToInt(); 
                        break; 
                    case "ObtainNum": 
                        _ObtainNum = value.ToInt(); 
                        break; 
                    case "SuccessNum": 
                        _SuccessNum = value.ToDecimal(); 
                        break; 
                    case "IsOpen": 
                        _IsOpen = value.ToBool(); 
                        break; 
					default: throw new ArgumentException(string.Format("WorshipInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
                
	}
}