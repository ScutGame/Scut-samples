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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserItemLog")]
    public class UserItemLog : BaseEntity
    {
        #region auto-generated static method
        static UserItemLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserItemLog));
        }
        #endregion
        
        public UserItemLog()
            : base(AccessLevel.WriteOnly)
        {
        }
        
        #region auto-generated Property
        private String _LogID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LogID", IsKey = true)]
        public String LogID
        {
            private get
            {
                return _LogID;
            }
            set
            {
                SetChange("LogID", value);
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
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemID")]
        public Int32 ItemID
        {
            private get
            {
                return _ItemID;
            }
            set
            {
                SetChange("ItemID", value);
            }
        }
        private Int16 _ItemLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemLv")]
        public Int16 ItemLv
        {
            private get
            {
                return _ItemLv;
            }
            set
            {
                SetChange("ItemLv", value);
            }
        }
        private Int32 _Num;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Num")]
        public Int32 Num
        {
            private get
            {
                return _Num;
            }
            set
            {
                SetChange("Num", value);
            }
        }
        private Int16 _ItemStatus;
        /// <summary>
        /// 0:���䣬1���ӣ�2ʹ��,3���ۣ�4����ɾ�� 5�ϳ� 6���� 7����ֿ��ȡ����Ʒ��ϲ���Ʒ   8����  9�ϳ�ɾ����Ʒ
        /// </summary>
        [EntityField("ItemStatus")]
        public Int16 ItemStatus
        {
            private get
            {
                return _ItemStatus;
            }
            set
            {
                SetChange("ItemStatus", value);
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
        private String _UserItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UserItemID")]
        public String UserItemID
        {
            private get
            {
                return _UserItemID;
            }
            set
            {
                SetChange("UserItemID", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "LogID": return LogID;
                    case "UserID": return UserID;
                    case "ItemID": return ItemID;
                    case "ItemLv": return ItemLv;
                    case "Num": return Num;
                    case "ItemStatus": return ItemStatus;
                    case "CreateDate": return CreateDate;
                    case "UserItemID": return UserItemID;
					default: throw new ArgumentException(string.Format("UserItemLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "LogID": 
                        _LogID = value.ToNotNullString(); 
                        break; 
                    case "UserID": 
                        _UserID = value.ToNotNullString(); 
                        break; 
                    case "ItemID": 
                        _ItemID = value.ToInt(); 
                        break; 
                    case "ItemLv": 
                        _ItemLv = value.ToShort(); 
                        break; 
                    case "Num": 
                        _Num = value.ToInt(); 
                        break; 
                    case "ItemStatus": 
                        _ItemStatus = value.ToShort(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
                    case "UserItemID": 
                        _UserItemID = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("UserItemLog index[{0}] isn't exist.", index));
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