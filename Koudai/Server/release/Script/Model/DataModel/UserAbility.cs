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
    /// 玩家魂技表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserAbility : BaseEntity
    {


        public UserAbility()
            : base(AccessLevel.ReadWrite)
        {
            AbilityList =new CacheList<Ability>();
        }        

        public UserAbility(Int32 UserID)
            : this()
        {
            this.UserID = UserID;
        }

        #region 自动生成属性

        private Int32 _UserID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public Int32 UserID
        {
            get
            {
                return _UserID;
            }
            private set
            {
                SetChange("UserID", value);
            }
        }

        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                SetChange("CreateDate", value);
            }
        }

        private CacheList<Ability> _AbilityList;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<Ability> AbilityList
        {
            get
            {
                return _AbilityList;
            }
            set
            {
                SetChange("AbilityList", value);
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
                    case "CreateDate": return CreateDate;
                    case "AbilityList": return AbilityList;
					default: throw new ArgumentException(string.Format("UserAbility index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "UserID": 
                        _UserID = value.ToInt(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
                    case "AbilityList":
                        _AbilityList = ConvertCustomField<CacheList<Ability>>(value, index);
                        break; 
					default: throw new ArgumentException(string.Format("UserAbility index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID;
        }
	}
}