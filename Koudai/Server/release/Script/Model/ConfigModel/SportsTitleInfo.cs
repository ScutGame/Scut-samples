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
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config, OrderColumn = "Obtian desc")]
    public class SportsTitleInfo : ShareEntity
    {

        
        public SportsTitleInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _SprotsID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SprotsID", IsKey = true)]
        public Int32 SprotsID
        {
            get
            {
                return _SprotsID;
            }
            private set
            {
                SetChange("SprotsID", value);
            }
        }
        private String _SprotsName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SprotsName")]
        public String SprotsName
        {
            get
            {
                return _SprotsName;
            }
            private set
            {
                SetChange("SprotsName", value);
            }
        }
        private Int32 _Obtian;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Obtian")]
        public Int32 Obtian
        {
            get
            {
                return _Obtian;
            }
            private set
            {
                SetChange("Obtian", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "SprotsID": return SprotsID;
                    case "SprotsName": return SprotsName;
                    case "Obtian": return Obtian;
					default: throw new ArgumentException(string.Format("SportsTitleInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "SprotsID": 
                        _SprotsID = value.ToInt(); 
                        break; 
                    case "SprotsName": 
                        _SprotsName = value.ToNotNullString(); 
                        break; 
                    case "Obtian": 
                        _Obtian = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("SportsTitleInfo index[{0}] isn't exist.", index));
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