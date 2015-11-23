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
    public class CareerAdditionInfo : ShareEntity
    {

        public const string Index_CareerID = "Index_CareerID";
        
        public CareerAdditionInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int16 _CareerID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CareerID", IsKey = true)]
        public Int16 CareerID
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
        private AbilityType _AbilityType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AbilityType", IsKey = true)]
        public AbilityType AbilityType
        {
            get
            {
                return _AbilityType;
            }
            private set
            {
                SetChange("AbilityType", value);
            }
        }
        private Decimal _AdditionNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("AdditionNum")]
        public Decimal AdditionNum
        {
            get
            {
                return _AdditionNum;
            }
            private set
            {
                SetChange("AdditionNum", value);
            }
        }
        private Decimal _MomentumNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MomentumNum")]
        public Decimal MomentumNum
        {
            get
            {
                return _MomentumNum;
            }
            private set
            {
                SetChange("MomentumNum", value);
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
                    case "AbilityType": return AbilityType;
                    case "AdditionNum": return AdditionNum;
                    case "MomentumNum": return MomentumNum;
					default: throw new ArgumentException(string.Format("CareerAdditionInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "CareerID": 
                        _CareerID = value.ToShort(); 
                        break; 
                    case "AbilityType":
                        _AbilityType = value.ToEnum<AbilityType>(); 
                        break; 
                    case "AdditionNum": 
                        _AdditionNum = value.ToDecimal(); 
                        break; 
                    case "MomentumNum": 
                        _MomentumNum = value.ToDecimal(); 
                        break; 
					default: throw new ArgumentException(string.Format("CareerAdditionInfo index[{0}] isn't exist.", index));
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