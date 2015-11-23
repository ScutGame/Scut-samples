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
    public class CityNpcInfo : ShareEntity
    {

        public const string Index_CityID = "Index_CityID";
        
        public CityNpcInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _NpcID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("NpcID", IsKey = true)]
        public Int32 NpcID
        {
            get
            {
                return _NpcID;
            }
            private set
            {
                SetChange("NpcID", value);
            }
        }
        private String _NpcName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("NpcName")]
        public String NpcName
        {
            get
            {
                return _NpcName;
            }
            private set
            {
                SetChange("NpcName", value);
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
        private String _HeadID2;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HeadID2")]
        public String HeadID2
        {
            get
            {
                return _HeadID2;
            }
            private set
            {
                SetChange("HeadID2", value);
            }
        }
        private Int16 _PointX;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PointX")]
        public Int16 PointX
        {
            get
            {
                return _PointX;
            }
            private set
            {
                SetChange("PointX", value);
            }
        }
        private Int16 _PointY;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PointY")]
        public Int16 PointY
        {
            get
            {
                return _PointY;
            }
            private set
            {
                SetChange("PointY", value);
            }
        }
        private Int16 _CityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CityID")]
        public Int16 CityID
        {
            get
            {
                return _CityID;
            }
            private set
            {
                SetChange("CityID", value);
            }
        }
        private Int16 _CommandID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CommandID")]
        public Int16 CommandID
        {
            get
            {
                return _CommandID;
            }
            private set
            {
                SetChange("CommandID", value);
            }
        }
        private String _NpcDesc;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("NpcDesc")]
        public String NpcDesc
        {
            get
            {
                return _NpcDesc;
            }
            private set
            {
                SetChange("NpcDesc", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "NpcID": return NpcID;
                    case "NpcName": return NpcName;
                    case "HeadID": return HeadID;
                    case "HeadID2": return HeadID2;
                    case "PointX": return PointX;
                    case "PointY": return PointY;
                    case "CityID": return CityID;
                    case "CommandID": return CommandID;
                    case "NpcDesc": return NpcDesc;
					default: throw new ArgumentException(string.Format("CityNpcInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "NpcID": 
                        _NpcID = value.ToInt(); 
                        break; 
                    case "NpcName": 
                        _NpcName = value.ToNotNullString(); 
                        break; 
                    case "HeadID": 
                        _HeadID = value.ToNotNullString(); 
                        break; 
                    case "HeadID2": 
                        _HeadID2 = value.ToNotNullString(); 
                        break; 
                    case "PointX": 
                        _PointX = value.ToShort(); 
                        break; 
                    case "PointY": 
                        _PointY = value.ToShort(); 
                        break; 
                    case "CityID": 
                        _CityID = value.ToShort(); 
                        break; 
                    case "CommandID": 
                        _CommandID = value.ToShort(); 
                        break; 
                    case "NpcDesc": 
                        _NpcDesc = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("CityNpcInfo index[{0}] isn't exist.", index));
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