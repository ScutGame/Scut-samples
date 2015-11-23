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
    [Serializable, ProtoContract]
    [EntityTable(CacheType.None,DbConfig.Log, "PackageReceiveLog")]
    public class PackageReceiveLog : BaseEntity
    {
        #region auto-generated static method
        static PackageReceiveLog()
        {
            EntitySchemaSet.InitSchema(typeof(PackageReceiveLog));
        }
        #endregion
        
        public PackageReceiveLog()
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
        private String _ReceiveID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ReceiveID")]
        public String ReceiveID
        {
            private get
            {
                return _ReceiveID;
            }
            set
            {
                SetChange("ReceiveID", value);
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
        private Int32 _PacksID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PacksID")]
        public Int32 PacksID
        {
            private get
            {
                return _PacksID;
            }
            set
            {
                SetChange("PacksID", value);
            }
        }
        private DateTime _ReceiveDate;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ReceiveDate")]
        public DateTime ReceiveDate
        {
            private get
            {
                return _ReceiveDate;
            }
            set
            {
                SetChange("ReceiveDate", value);
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
                    case "ReceiveID": return ReceiveID;
                    case "UserID": return UserID;
                    case "PacksID": return PacksID;
                    case "ReceiveDate": return ReceiveDate;
					default: throw new ArgumentException(string.Format("PackageReceiveLog index[{0}] isn't exist.", index));
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
                    case "ReceiveID": 
                        _ReceiveID = value.ToNotNullString(); 
                        break; 
                    case "UserID": 
                        _UserID = value.ToNotNullString(); 
                        break; 
                    case "PacksID": 
                        _PacksID = value.ToInt(); 
                        break; 
                    case "ReceiveDate": 
                        _ReceiveDate = value.ToDateTime();                         
                        break; 
					default: throw new ArgumentException(string.Format("PackageReceiveLog index[{0}] isn't exist.", index));
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