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
    /// 武器附魔镶嵌配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class MosaicInfo : ShareEntity
    {


        public MosaicInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        

        public MosaicInfo(Int32 Position)
            : this()
        {
            this.Position = Position;
        }

        #region 自动生成属性

        private Int32 _Position;
        /// <summary>
        /// 镶嵌孔序号 （位置），主键
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("Position", IsKey = true)]
        public Int32 Position
        {
            get
            {
                return _Position;
            }
            private set
            {
                SetChange("Position", value);
            }
        }

        private Int16 _DemandLv;
        /// <summary>
        /// 需求武器等级
        /// </summary>        
        [ProtoMember(2)]
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

        private String _MosaicColor;
        /// <summary>
        /// 镶嵌颜色 (支持多个配置，例如1,3)参照ColorType枚举
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("MosaicColor")]
        public String MosaicColor
        {
            get
            {
                return _MosaicColor;
            }
            private set
            {
                SetChange("MosaicColor", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "Position": return Position;
                    case "DemandLv": return DemandLv;
                    case "MosaicColor": return MosaicColor;
					default: throw new ArgumentException(string.Format("MosaicInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "Position": 
                        _Position = value.ToInt(); 
                        break; 
                    case "DemandLv": 
                        _DemandLv = value.ToShort(); 
                        break; 
                    case "MosaicColor": 
                        _MosaicColor = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("MosaicInfo index[{0}] isn't exist.", index));
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