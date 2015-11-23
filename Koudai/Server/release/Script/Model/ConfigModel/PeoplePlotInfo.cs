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
    public class PeoplePlotInfo : ShareEntity
    {

        
        public PeoplePlotInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotID", IsKey = true)]
        public Int32 PlotID
        {
            get
            {
                return _PlotID;
            }
            private set
            {
                SetChange("PlotID", value);
            }
        }
        private String _PlotName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PlotName")]
        public String PlotName
        {
            get
            {
                return _PlotName;
            }
            private set
            {
                SetChange("PlotName", value);
            }
        }
        private String _BgScene;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("BgScene")]
        public String BgScene
        {
            get
            {
                return _BgScene;
            }
            private set
            {
                SetChange("BgScene", value);
            }
        }
        private String _FgScene;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("FgScene")]
        public String FgScene
        {
            get
            {
                return _FgScene;
            }
            private set
            {
                SetChange("FgScene", value);
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
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemID")]
        public Int32 ItemID
        {
            get
            {
                return _ItemID;
            }
            private set
            {
                SetChange("ItemID", value);
            }
        }
        private Int32 _ItemNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemNum")]
        public Int32 ItemNum
        {
            get
            {
                return _ItemNum;
            }
            private set
            {
                SetChange("ItemNum", value);
            }
        }
        private Int32 _ExpNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ExpNum")]
        public Int32 ExpNum
        {
            get
            {
                return _ExpNum;
            }
            private set
            {
                SetChange("ExpNum", value);
            }
        }
        private Int32 _Experience;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Experience")]
        public Int32 Experience
        {
            get
            {
                return _Experience;
            }
            private set
            {
                SetChange("Experience", value);
            }
        }
        private Int32 _SceneY1;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SceneY1")]
        public Int32 SceneY1
        {
            get
            {
                return _SceneY1;
            }
            private set
            {
                SetChange("SceneY1", value);
            }
        }
        private Int32 _SceneY2;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SceneY2")]
        public Int32 SceneY2
        {
            get
            {
                return _SceneY2;
            }
            private set
            {
                SetChange("SceneY2", value);
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
                    case "PlotID": return PlotID;
                    case "PlotName": return PlotName;
                    case "BgScene": return BgScene;
                    case "FgScene": return FgScene;
                    case "DemandLv": return DemandLv;
                    case "ItemID": return ItemID;
                    case "ItemNum": return ItemNum;
                    case "ExpNum": return ExpNum;
                    case "Experience": return Experience;
                    case "SceneY1": return SceneY1;
                    case "SceneY2": return SceneY2;
                    case "Version": return Version;
					default: throw new ArgumentException(string.Format("PeoplePlotInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "PlotID": 
                        _PlotID = value.ToInt(); 
                        break; 
                    case "PlotName": 
                        _PlotName = value.ToNotNullString(); 
                        break; 
                    case "BgScene": 
                        _BgScene = value.ToNotNullString(); 
                        break; 
                    case "FgScene": 
                        _FgScene = value.ToNotNullString(); 
                        break; 
                    case "DemandLv": 
                        _DemandLv = value.ToShort(); 
                        break; 
                    case "ItemID": 
                        _ItemID = value.ToInt(); 
                        break; 
                    case "ItemNum": 
                        _ItemNum = value.ToInt(); 
                        break; 
                    case "ExpNum": 
                        _ExpNum = value.ToInt(); 
                        break; 
                    case "Experience": 
                        _Experience = value.ToInt(); 
                        break; 
                    case "SceneY1": 
                        _SceneY1 = value.ToInt(); 
                        break; 
                    case "SceneY2": 
                        _SceneY2 = value.ToInt(); 
                        break; 
                    case "Version": 
                        _Version = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("PeoplePlotInfo index[{0}] isn't exist.", index));
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