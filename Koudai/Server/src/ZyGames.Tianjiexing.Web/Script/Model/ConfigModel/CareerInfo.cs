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
    public class CareerInfo : ShareEntity
    {

        
        public CareerInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _CareerID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CareerID", IsKey = true)]
        public Int32 CareerID
        {
            get
            {
                return _CareerID;
            }
            private set
            {
                SetChange("CareerID", value);
            }
        }
        private CareerType _CareerType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CareerType")]
        public CareerType CareerType
        {
            get
            {
                return _CareerType;
            }
            private set
            {
                SetChange("CareerType", value);
            }
        }
        private String _CareerName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CareerName")]
        public String CareerName
        {
            get
            {
                return _CareerName;
            }
            private set
            {
                SetChange("CareerName", value);
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
        private String _PicturesID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PicturesID")]
        public String PicturesID
        {
            get
            {
                return _PicturesID;
            }
            private set
            {
                SetChange("PicturesID", value);
            }
        }
        private String _PicturesID2;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PicturesID2")]
        public String PicturesID2
        {
            get
            {
                return _PicturesID2;
            }
            private set
            {
                SetChange("PicturesID2", value);
            }
        }
        private Int16 _Lv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Lv")]
        public Int16 Lv
        {
            get
            {
                return _Lv;
            }
            private set
            {
                SetChange("Lv", value);
            }
        }
        private Int32 _LifeNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LifeNum")]
        public Int32 LifeNum
        {
            get
            {
                return _LifeNum;
            }
            private set
            {
                SetChange("LifeNum", value);
            }
        }
        private Int32 _LifeIncreaseNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("LifeIncreaseNum")]
        public Int32 LifeIncreaseNum
        {
            get
            {
                return _LifeIncreaseNum;
            }
            private set
            {
                SetChange("LifeIncreaseNum", value);
            }
        }
        private Int16 _PowerNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PowerNum")]
        public Int16 PowerNum
        {
            get
            {
                return _PowerNum;
            }
            private set
            {
                SetChange("PowerNum", value);
            }
        }
        private Int16 _SoulNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SoulNum")]
        public Int16 SoulNum
        {
            get
            {
                return _SoulNum;
            }
            private set
            {
                SetChange("SoulNum", value);
            }
        }
        private Int16 _IntellectNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IntellectNum")]
        public Int16 IntellectNum
        {
            get
            {
                return _IntellectNum;
            }
            private set
            {
                SetChange("IntellectNum", value);
            }
        }
        private Int32 _AbilityID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityID")]
        public Int32 AbilityID
        {
            get
            {
                return _AbilityID;
            }
            private set
            {
                SetChange("AbilityID", value);
            }
        }
        private String _Description;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Description")]
        public String Description
        {
            get
            {
                return _Description;
            }
            private set
            {
                SetChange("Description", value);
            }
        }
        private String _BaseEffectID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BaseEffectID")]
        public String BaseEffectID
        {
            get
            {
                return _BaseEffectID;
            }
            private set
            {
                SetChange("BaseEffectID", value);
            }
        }
        private Boolean _IsMove;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsMove")]
        public Boolean IsMove
        {
            get
            {
                return _IsMove;
            }
            private set
            {
                SetChange("IsMove", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "CareerID": return CareerID;
                    case "CareerType": return CareerType;
                    case "CareerName": return CareerName;
                    case "HeadID": return HeadID;
                    case "HeadID2": return HeadID2;
                    case "PicturesID": return PicturesID;
                    case "PicturesID2": return PicturesID2;
                    case "Lv": return Lv;
                    case "LifeNum": return LifeNum;
                    case "LifeIncreaseNum": return LifeIncreaseNum;
                    case "PowerNum": return PowerNum;
                    case "SoulNum": return SoulNum;
                    case "IntellectNum": return IntellectNum;
                    case "AbilityID": return AbilityID;
                    case "Description": return Description;
                    case "BaseEffectID": return BaseEffectID;
                    case "IsMove": return IsMove;
					default: throw new ArgumentException(string.Format("CareerInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "CareerID": 
                        _CareerID = value.ToInt(); 
                        break; 
                    case "CareerType":
                        _CareerType = value.ToEnum<CareerType>(); 
                        break; 
                    case "CareerName": 
                        _CareerName = value.ToNotNullString(); 
                        break; 
                    case "HeadID": 
                        _HeadID = value.ToNotNullString(); 
                        break; 
                    case "HeadID2": 
                        _HeadID2 = value.ToNotNullString(); 
                        break; 
                    case "PicturesID": 
                        _PicturesID = value.ToNotNullString(); 
                        break; 
                    case "PicturesID2": 
                        _PicturesID2 = value.ToNotNullString(); 
                        break; 
                    case "Lv": 
                        _Lv = value.ToShort(); 
                        break; 
                    case "LifeNum": 
                        _LifeNum = value.ToInt(); 
                        break; 
                    case "LifeIncreaseNum": 
                        _LifeIncreaseNum = value.ToInt(); 
                        break; 
                    case "PowerNum": 
                        _PowerNum = value.ToShort(); 
                        break; 
                    case "SoulNum": 
                        _SoulNum = value.ToShort(); 
                        break; 
                    case "IntellectNum": 
                        _IntellectNum = value.ToShort(); 
                        break; 
                    case "AbilityID": 
                        _AbilityID = value.ToInt(); 
                        break; 
                    case "Description": 
                        _Description = value.ToNotNullString(); 
                        break; 
                    case "BaseEffectID": 
                        _BaseEffectID = value.ToNotNullString(); 
                        break; 
                    case "IsMove": 
                        _IsMove = value.ToBool(); 
                        break; 
					default: throw new ArgumentException(string.Format("CareerInfo index[{0}] isn't exist.", index));
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