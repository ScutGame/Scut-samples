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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ProtoBuf;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class SJTPlotInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public SJTPlotInfo()
            : base(AccessLevel.ReadOnly)
        {
            
        }        
        /// <summary>
        /// </summary>
        public SJTPlotInfo(int plotID)
            : this()
        {
            _plotID = plotID;
            DifficultyList = new CacheList<Difficulty>(0,true);
        }

        #region 自动生成属性
        private int _plotID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("PlotID", IsKey = true)]
        public int PlotID
        {
            get
            {
                return _plotID;
            } 
            
        }
        private int _plotSeqNo;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("PlotSeqNo")]
        public int PlotSeqNo
        {
            get
            {
                return _plotSeqNo;
            } 
            
        }
        private string _plotName;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("PlotName")]
        public string PlotName
        {
            get
            {
                return _plotName;
            } 
            
        }
        private string _bgScene;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("BgScene")]
        public string BgScene
        {
            get
            {
                return _bgScene;
            } 
            
        }
        private int _prePlotID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("PrePlotID")]
        public int PrePlotID
        {
            get
            {
                return _prePlotID;
            } 
            
        }
        private int _aftPlotID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("AftPlotID")]
        public int AftPlotID
        {
            get
            {
                return _aftPlotID;
            } 
            
        }
        private bool _isRewar;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("IsRewar")]
        public bool IsRewar
        {
            get
            {
                return _isRewar;
            } 
            
        }
        private bool _isOrigin;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("IsOrigin")]
        public bool IsOrigin
        {
            get
            {
                return _isOrigin;
            } 
            
        }
        private string _npcName;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("NpcName")]
        public string NpcName
        {
            get
            {
                return _npcName;
            } 
            
        }
        private string _headID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("HeadID")]
        public string HeadID
        {
            get
            {
                return _headID;
            } 
            
        }
        private int _partInNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("PartInNum")]
        public int PartInNum
        {
            get
            {
                return _partInNum;
            } 
            
        }
        private string _plotDesc;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(12)]
        [EntityField("PlotDesc")]
        public string PlotDesc
        {
            get
            {
                return _plotDesc;
            } 
            
        }

        private CacheList<Difficulty> _difficultyList;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(13)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<Difficulty> DifficultyList
        {
            get
            {
                return _difficultyList;
            }
            private set
            {
                SetChange("DifficultyList", value);
            }

        }
        private Boolean _IsProperty;              //当前层数是否加属性
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        [EntityField("IsProperty")]
        public Boolean IsProperty
        {
            get
            {
                return _IsProperty;
            }
            set
            {
                SetChange("IsProperty", value);
            }
        }
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "PlotID": return _plotID;
                    case "PlotSeqNo": return _plotSeqNo;
                    case "PlotName": return _plotName;
                    case "BgScene": return _bgScene;
                    case "PrePlotID": return _prePlotID;
                    case "AftPlotID": return _aftPlotID;
                    case "IsRewar": return _isRewar;
                    case "IsOrigin": return _isOrigin;
                    case "NpcName": return _npcName;
                    case "HeadID": return _headID;
                    case "PartInNum": return _partInNum;
                    case "DifficultyList": return _difficultyList;
                    case "PlotDesc": return _plotDesc;
                    case "IsProperty": return _IsProperty;
					default: throw new ArgumentException(string.Format("SJTPlotInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "PlotID": 
                        _plotID = value.ToInt();
                        break; 
                    case "PlotSeqNo": 
                        _plotSeqNo = value.ToInt();
                        break; 
                    case "PlotName": 
                        _plotName = value.ToNotNullString();
                        break; 
                    case "BgScene": 
                        _bgScene = value.ToNotNullString();
                        break; 
                    case "PrePlotID": 
                        _prePlotID = value.ToInt();
                        break; 
                    case "AftPlotID": 
                        _aftPlotID = value.ToInt();
                        break; 
                    case "IsRewar": 
                        _isRewar = value.ToBool();
                        break; 
                    case "IsOrigin": 
                        _isOrigin = value.ToBool();
                        break; 
                    case "NpcName": 
                        _npcName = value.ToNotNullString();
                        break; 
                    case "HeadID": 
                        _headID = value.ToNotNullString();
                        break; 
                    case "PartInNum": 
                        _partInNum = value.ToInt();
                        break;
                    case "DifficultyList":
                        _difficultyList = ConvertCustomField<CacheList<Difficulty>>(value, index); 
                        break; 
                    case "PlotDesc": 
                        _plotDesc = value.ToNotNullString();
                        break;
                    case "IsProperty":
                        _IsProperty = value.ToBool();
                        break;
					default: throw new ArgumentException(string.Format("SJTPlotInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion

	}
}