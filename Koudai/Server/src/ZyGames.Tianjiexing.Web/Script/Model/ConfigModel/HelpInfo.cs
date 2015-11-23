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
    public class HelpInfo : ShareEntity
    {

        
        public HelpInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _Category;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Category", IsKey = true)]
        public Int32 Category
        {
            get
            {
                return _Category;
            }
            private set
            {
                SetChange("Category", value);
            }
        }
        private Int32 _SmallType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SmallType", IsKey = true)]
        public Int32 SmallType
        {
            get
            {
                return _SmallType;
            }
            private set
            {
                SetChange("SmallType", value);
            }
        }
        private Int32 _SepNo;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SepNo")]
        public Int32 SepNo
        {
            get
            {
                return _SepNo;
            }
            private set
            {
                SetChange("SepNo", value);
            }
        }
        private String _Content;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Content")]
        public String Content
        {
            get
            {
                return _Content;
            }
            private set
            {
                SetChange("Content", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "Category": return Category;
                    case "SmallType": return SmallType;
                    case "SepNo": return SepNo;
                    case "Content": return Content;
					default: throw new ArgumentException(string.Format("HelpInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "Category": 
                        _Category = value.ToInt(); 
                        break; 
                    case "SmallType": 
                        _SmallType = value.ToInt(); 
                        break; 
                    case "SepNo": 
                        _SepNo = value.ToInt(); 
                        break; 
                    case "Content": 
                        _Content = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("HelpInfo index[{0}] isn't exist.", index));
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