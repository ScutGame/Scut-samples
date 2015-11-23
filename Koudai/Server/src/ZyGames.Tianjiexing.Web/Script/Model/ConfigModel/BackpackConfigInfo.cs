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
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ProtoBuf;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class BackpackConfigInfo : ShareEntity
    {


        public BackpackConfigInfo()
            : base(AccessLevel.ReadOnly)
        {
        }

        public BackpackConfigInfo(BackpackType BackpackType)
            : this()
        {
            this.BackpackType = BackpackType;
        }

        #region 自动生成属性

        private BackpackType _BackpackType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("BackpackType", IsKey = true)]
        public BackpackType BackpackType
        {
            get
            {
                return _BackpackType;
            }
            private set
            {
                SetChange("BackpackType", value);
            }
        }

        private Int32 _DefaultNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("DefaultNum")]
        public Int32 DefaultNum
        {
            get
            {
                return _DefaultNum;
            }
            private set
            {
                SetChange("DefaultNum", value);
            }
        }

        private Int32 _MaxOpenNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("MaxOpenNum")]
        public Int32 MaxOpenNum
        {
            get
            {
                return _MaxOpenNum;
            }
            private set
            {
                SetChange("MaxOpenNum", value);
            }
        }

        private Int32 _EveryAddNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("EveryAddNum")]
        public Int32 EveryAddNum
        {
            get
            {
                return _EveryAddNum;
            }
            private set
            {
                SetChange("EveryAddNum", value);
            }
        }

        private Int32 _MaxCellNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("MaxCellNum")]
        public Int32 MaxCellNum
        {
            get
            {
                return _MaxCellNum;
            }
            private set
            {
                SetChange("MaxCellNum", value);
            }
        }

        private Int32 _RequiredGoldNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("RequiredGoldNum")]
        public Int32 RequiredGoldNum
        {
            get
            {
                return _RequiredGoldNum;
            }
            private set
            {
                SetChange("RequiredGoldNum", value);
            }
        }

        private String _Describe;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("Describe")]
        public String Describe
        {
            get
            {
                return _Describe;
            }
            private set
            {
                SetChange("Describe", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "BackpackType": return BackpackType;
                    case "DefaultNum": return DefaultNum;
                    case "MaxOpenNum": return MaxOpenNum;
                    case "EveryAddNum": return EveryAddNum;
                    case "MaxCellNum": return MaxCellNum;
                    case "RequiredGoldNum": return RequiredGoldNum;
                    case "Describe": return Describe;
					default: throw new ArgumentException(string.Format("BackpackConfigInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "BackpackType":
                        _BackpackType = value.ToEnum<BackpackType>(); 
                        break; 
                    case "DefaultNum": 
                        _DefaultNum = value.ToInt(); 
                        break; 
                    case "MaxOpenNum": 
                        _MaxOpenNum = value.ToInt(); 
                        break; 
                    case "EveryAddNum": 
                        _EveryAddNum = value.ToInt(); 
                        break; 
                    case "MaxCellNum": 
                        _MaxCellNum = value.ToInt(); 
                        break; 
                    case "RequiredGoldNum": 
                        _RequiredGoldNum = value.ToInt(); 
                        break; 
                    case "Describe": 
                        _Describe = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("BackpackConfigInfo index[{0}] isn't exist.", index));
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