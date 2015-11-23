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
    public class GeneralPracticeInfo : ShareEntity
    {

        
        public GeneralPracticeInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int16 _GeneralLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GeneralLv", IsKey = true)]
        public Int16 GeneralLv
        {
            get
            {
                return _GeneralLv;
            }
            private set
            {
                SetChange("GeneralLv", value);
            }
        }
        private Int16 _IntervalTime;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IntervalTime")]
        public Int16 IntervalTime
        {
            get
            {
                return _IntervalTime;
            }
            private set
            {
                SetChange("IntervalTime", value);
            }
        }
        private Int32 _Exprience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Exprience")]
        public Int32 Exprience
        {
            get
            {
                return _Exprience;
            }
            private set
            {
                SetChange("Exprience", value);
            }
        }
        private Int16 _MaxHour;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MaxHour")]
        public Int16 MaxHour
        {
            get
            {
                return _MaxHour;
            }
            private set
            {
                SetChange("MaxHour", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "GeneralLv": return GeneralLv;
                    case "IntervalTime": return IntervalTime;
                    case "Exprience": return Exprience;
                    case "MaxHour": return MaxHour;
					default: throw new ArgumentException(string.Format("GeneralPracticeInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "GeneralLv": 
                        _GeneralLv = value.ToShort(); 
                        break; 
                    case "IntervalTime": 
                        _IntervalTime = value.ToShort(); 
                        break; 
                    case "Exprience": 
                        _Exprience = value.ToInt(); 
                        break; 
                    case "MaxHour": 
                        _MaxHour = value.ToShort(); 
                        break; 
					default: throw new ArgumentException(string.Format("GeneralPracticeInfo index[{0}] isn't exist.", index));
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