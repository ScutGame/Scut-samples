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
    [Serializable, ProtoContract, EntityTable(CacheType.None, DbConfig.Log, "UserUseGoldLog")]
    public class UserUseGoldLog : BaseEntity
    {
        #region auto-generated static method
        static UserUseGoldLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserUseGoldLog));
        }
        #endregion
        
        public UserUseGoldLog()
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
        private Int16 _OpType;
        /// <summary>
        /// �������� 1������ 2����� 3��ʥˮ 4����ս���� 5���������ӿ��� 6���ֿ���ӿ��� 7������ˮ�����ӿ��� 8����ħ�����ӿ���
        /// </summary>
        [EntityField("OpType")]
        public Int16 OpType
        {
            private get
            {
                return _OpType;
            }
            set
            {
                SetChange("OpType", value);
            }
        }
        private Int32 _SumNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SumNum")]
        public Int32 SumNum
        {
            private get
            {
                return _SumNum;
            }
            set
            {
                SetChange("SumNum", value);
            }
        }
        private Int32 _OpNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("OpNum")]
        public Int32 OpNum
        {
            private get
            {
                return _OpNum;
            }
            set
            {
                SetChange("OpNum", value);
            }
        }
        private Int32 _UseGold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UseGold")]
        public Int32 UseGold
        {
            private get
            {
                return _UseGold;
            }
            set
            {
                SetChange("UseGold", value);
            }
        }
        private Int32 _SurplusGold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SurplusGold")]
        public Int32 SurplusGold
        {
            private get
            {
                return _SurplusGold;
            }
            set
            {
                SetChange("SurplusGold", value);
            }
        }
        private Int32 _TotalGold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("TotalGold")]
        public Int32 TotalGold
        {
            private get
            {
                return _TotalGold;
            }
            set
            {
                SetChange("TotalGold", value);
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
                    case "OpType": return OpType;
                    case "SumNum": return SumNum;
                    case "OpNum": return OpNum;
                    case "UseGold": return UseGold;
                    case "SurplusGold": return SurplusGold;
                    case "TotalGold": return TotalGold;
                    case "CreateDate": return CreateDate;
					default: throw new ArgumentException(string.Format("UserUseGoldLog index[{0}] isn't exist.", index));
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
                    case "OpType": 
                        _OpType = value.ToShort(); 
                        break; 
                    case "SumNum": 
                        _SumNum = value.ToInt(); 
                        break; 
                    case "OpNum": 
                        _OpNum = value.ToInt(); 
                        break; 
                    case "UseGold": 
                        _UseGold = value.ToInt(); 
                        break; 
                    case "SurplusGold": 
                        _SurplusGold = value.ToInt(); 
                        break; 
                    case "TotalGold": 
                        _TotalGold = value.ToInt(); 
                        break; 
                    case "CreateDate": 
                        _CreateDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("UserUseGoldLog index[{0}] isn't exist.", index));
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