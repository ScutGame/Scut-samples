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
    [EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserRegistration : BaseEntity
    {

        /// <summary>
        /// </summary>
        public UserRegistration()
            : base(AccessLevel.ReadWrite)
        {
        }        
        /// <summary>
        /// </summary>
        public UserRegistration(int userID)
            : this()
        {
            _userID = userID;
        }

        #region 自动生成属性
        private int _userID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                SetChange("UserID", value);
            } 
            
        }
        private DateTime _registrationDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("RegistrationDate")]
        public DateTime RegistrationDate
        {
            get
            {
                return _registrationDate;
            } 
            set
            {
                SetChange("RegistrationDate", value);
            }
        }
        private int _registrationNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("RegistrationNum")]
        public int RegistrationNum
        {
            get
            {
                return _registrationNum;
            } 
            set
            {
                SetChange("RegistrationNum", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "UserID": return _userID;
                    case "RegistrationDate": return _registrationDate;
                    case "RegistrationNum": return _registrationNum;
					default: throw new ArgumentException(string.Format("UserRegistration index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "UserID": 
                        _userID = value.ToInt();
                        break; 
                    case "RegistrationDate": 
                        _registrationDate = value.ToDateTime();
                        break; 
                    case "RegistrationNum": 
                        _registrationNum = value.ToInt();
                        break; 
					default: throw new ArgumentException(string.Format("UserRegistration index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        
        protected override int GetIdentityId()
        {
            //设置玩家的UserID
            //若要做为全局使用设置类绑定的自定义属性[EntityTable(CacheType.Entity, DbConfig.Config, @TableName, @PeriodTime)]
            return UserID;
        }
	}
}