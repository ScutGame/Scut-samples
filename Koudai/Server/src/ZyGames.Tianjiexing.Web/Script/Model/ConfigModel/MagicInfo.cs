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
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class MagicInfo : ShareEntity
    {

        
        public MagicInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _MagicID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MagicID", IsKey = true)]
        public Int32 MagicID
        {
            get
            {
                return _MagicID;
            }
            private set
            {
                SetChange("MagicID", value);
            }
        }
        private String _MagicName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MagicName")]
        public String MagicName
        {
            get
            {
                return _MagicName;
            }
            private set
            {
                SetChange("MagicName", value);
            }
        }
        private MagicType _MagicType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MagicType")]
        public MagicType MagicType
        {
            get
            {
                return _MagicType;
            }
            private set
            {
                SetChange("MagicType", value);
            }
        }
        private String _HeadID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HeadID")]
        public String HeadID
        {
            get
            {
                return _HeadID;
            }
            private set
            {
                SetChange("HeadID", value);
            }
        }
        private Int16 _MagicLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MagicLv")]
        public Int16 MagicLv
        {
            get
            {
                return _MagicLv;
            }
            private set
            {
                SetChange("MagicLv", value);
            }
        }
        private String _MagicDesc;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MagicDesc")]
        public String MagicDesc
        {
            get
            {
                return _MagicDesc;
            }
            private set
            {
                SetChange("MagicDesc", value);
            }
        }
        private Int16 _DemandLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("DemandLv")]
        public Int16 DemandLv
        {
            get
            {
                return _DemandLv;
            }
            private set
            {
                SetChange("DemandLv", value);
            }
        }
        private Int32 _Version;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Version")]
        public Int32 Version
        {
            get
            {
                return _Version;
            }
            private set
            {
                SetChange("Version", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "MagicID": return MagicID;
                    case "MagicName": return MagicName;
                    case "MagicType": return MagicType;
                    case "HeadID": return HeadID;
                    case "MagicLv": return MagicLv;
                    case "MagicDesc": return MagicDesc;
                    case "DemandLv": return DemandLv;
                    case "Version": return Version;
					default: throw new ArgumentException(string.Format("MagicInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "MagicID": 
                        _MagicID = value.ToInt(); 
                        break; 
                    case "MagicName": 
                        _MagicName = value.ToNotNullString(); 
                        break; 
                    case "MagicType":
                        _MagicType = value.ToEnum<MagicType>(); 
                        break; 
                    case "HeadID": 
                        _HeadID = value.ToNotNullString(); 
                        break; 
                    case "MagicLv": 
                        _MagicLv = value.ToShort(); 
                        break; 
                    case "MagicDesc": 
                        _MagicDesc = value.ToNotNullString(); 
                        break; 
                    case "DemandLv": 
                        _DemandLv = value.ToShort(); 
                        break; 
                    case "Version": 
                        _Version = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("MagicInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
                
        protected override int GetIdentityId()
        {
            //allow modify return value
            return DefIdentityId;
        }
	}
}