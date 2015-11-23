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
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Entity, DbConfig.Data)]
    public class ActiveListInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public ActiveListInfo()
            : base(AccessLevel.ReadWrite)
        {
        }
        /// <summary>
        /// </summary>
        public ActiveListInfo(Int32 ActiveID)
            : this()
        {
            this._ActiveID = ActiveID;
        }

        #region 自动生成属性

        private Int32 _ActiveID;
        /// <summary>
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("ActiveID", IsKey = true)]
        public Int32 ActiveID
        {
            get
            {
                return _ActiveID;
            }
            set
            {
                SetChange("ActiveID", value);
            }

        }

        private String _ActiveName;
        /// <summary>
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("ActiveName")]
        public String ActiveName
        {
            get
            {
                return _ActiveName;
            }
            set
            {
                SetChange("ActiveName", value);
            }
        }

        private Int16 _ActiveType;
        /// <summary>
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("ActiveType")]
        public Int16 ActiveType
        {
            get
            {
                return _ActiveType;
            }
            set
            {
                SetChange("ActiveType", value);
            }
        }

        private DateTime _BeginDate;
        /// <summary>
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("BeginDate")]
        public DateTime BeginDate
        {
            get
            {
                return _BeginDate;
            }
            set
            {
                SetChange("BeginDate", value);
            }
        }

        private DateTime _EndDate;
        /// <summary>
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("EndDate")]
        public DateTime EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                SetChange("EndDate", value);
            }
        }

        private String _HeadID;
        /// <summary>
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("HeadID")]
        public String HeadID
        {
            get
            {
                return _HeadID;
            }
            set
            {
                SetChange("HeadID", value);
            }
        }

        private Int32 _EffectiveCount;
        /// <summary>
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("EffectiveCount")]
        public Int32 EffectiveCount
        {
            get
            {
                return _EffectiveCount;
            }
            set
            {
                SetChange("EffectiveCount", value);
            }
        }

        private String _Describe;
        /// <summary>
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("Describe")]
        public String Describe
        {
            get
            {
                return _Describe;
            }
            set
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
                    case "ActiveID": return ActiveID;
                    case "ActiveName": return ActiveName;
                    case "ActiveType": return ActiveType;
                    case "BeginDate": return BeginDate;
                    case "EndDate": return EndDate;
                    case "HeadID": return HeadID;
                    case "EffectiveCount": return EffectiveCount;
                    case "Describe": return Describe;
                    default: throw new ArgumentException(string.Format("ActiveListInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ActiveID":
                        _ActiveID = value.ToInt();
                        break;
                    case "ActiveName":
                        _ActiveName = value.ToNotNullString();
                        break;
                    case "ActiveType":
                        _ActiveType = value.ToShort();
                        break;
                    case "BeginDate":
                        _BeginDate = value.ToDateTime();
                        break;
                    case "EndDate":
                        _EndDate = value.ToDateTime();
                        break;
                    case "HeadID":
                        _HeadID = value.ToNotNullString();
                        break;
                    case "EffectiveCount":
                        _EffectiveCount = value.ToInt();
                        break;
                    case "Describe":
                        _Describe = value.ToNotNullString();
                        break;
                    default: throw new ArgumentException(string.Format("ActiveListInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //设置玩家的UserID
            //若要做为全局使用设置类绑定的自定义属性[EntityTable(CacheType.Entity, DbConfig.Config, @TableName, @PeriodTime)]
            return DefIdentityId;
        }
    }
}