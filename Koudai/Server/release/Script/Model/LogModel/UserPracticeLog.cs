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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserPracticeLog")]
    public class UserPracticeLog : BaseEntity
    {
        #region auto-generated static method
        static UserPracticeLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserPracticeLog));
        }
        #endregion
        
        public UserPracticeLog()
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
        private DateTime _StartDate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("StartDate")]
        public DateTime StartDate
        {
            private get
            {
                return _StartDate;
            }
            set
            {
                SetChange("StartDate", value);
            }
        }
        private DateTime _EndDate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EndDate")]
        public DateTime EndDate
        {
            private get
            {
                return _EndDate;
            }
            set
            {
                SetChange("EndDate", value);
            }
        }
        private Int32 _ContinuedTime;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ContinuedTime")]
        public Int32 ContinuedTime
        {
            private get
            {
                return _ContinuedTime;
            }
            set
            {
                SetChange("ContinuedTime", value);
            }
        }
        private Int32 _GainExperience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GainExperience")]
        public Int32 GainExperience
        {
            private get
            {
                return _GainExperience;
            }
            set
            {
                SetChange("GainExperience", value);
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
                    case "StartDate": return StartDate;
                    case "EndDate": return EndDate;
                    case "ContinuedTime": return ContinuedTime;
                    case "GainExperience": return GainExperience;
                    case "CreateDate": return CreateDate;
					default: throw new ArgumentException(string.Format("UserPracticeLog index[{0}] isn't exist.", index));
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
                    case "StartDate": 
                        _StartDate = value.ToDateTime();                         
                        break; 
                    case "EndDate": 
                        _EndDate = value.ToDateTime();                         
                        break; 
                    case "ContinuedTime": 
                        _ContinuedTime = value.ToInt(); 
                        break; 
                    case "GainExperience": 
                        _GainExperience = value.ToInt(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("UserPracticeLog index[{0}] isn't exist.", index));
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