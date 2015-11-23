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
    /// 公会城市争夺战配置表
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class GuildFightInfo : ShareEntity
    {


        public GuildFightInfo()
            : base(AccessLevel.ReadOnly)
        {
            Coefficient = new CacheList<PrizeInfo>(0, true);
        }

        public GuildFightInfo(Int32 CityID)
            : this()
        {
            this.CityID = CityID;
        }

        #region 自动生成属性

        private Int32 _CityID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("CityID", IsKey = true)]
        public Int32 CityID
        {
            get
            {
                return _CityID;
            }
            private set
            {
                SetChange("CityID", value);
            }
        }

        private String _CityHead;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("CityHead")]
        public String CityHead
        {
            get
            {
                return _CityHead;
            }
            private set
            {
                SetChange("CityHead", value);
            }
        }

        private String _HeadID1;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("HeadID1")]
        public String HeadID1
        {
            get
            {
                return _HeadID1;
            }
            private set
            {
                SetChange("HeadID1", value);
            }
        }

        private String _HeadID2;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
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

        private Int16 _GuildLv;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("GuildLv")]
        public Int16 GuildLv
        {
            get
            {
                return _GuildLv;
            }
            private set
            {
                SetChange("GuildLv", value);
            }
        }

        private Int32 _SkillNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("SkillNum")]
        public Int32 SkillNum
        {
            get
            {
                return _SkillNum;
            }
            private set
            {
                SetChange("SkillNum", value);
            }
        }

        private Int32 _FirstPackID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("FirstPackID")]
        public Int32 FirstPackID
        {
            get
            {
                return _FirstPackID;
            }
            private set
            {
                SetChange("FirstPackID", value);
            }
        }

        private Int32 _SecondPackID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("SecondPackID")]
        public Int32 SecondPackID
        {
            get
            {
                return _SecondPackID;
            }
            private set
            {
                SetChange("SecondPackID", value);
            }
        }

        private Int32 _ThirdPackID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("ThirdPackID")]
        public Int32 ThirdPackID
        {
            get
            {
                return _ThirdPackID;
            }
            private set
            {
                SetChange("ThirdPackID", value);
            }
        }

        private Int32 _ParticipateID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("ParticipateID")]
        public Int32 ParticipateID
        {
            get
            {
                return _ParticipateID;
            }
            private set
            {
                SetChange("ParticipateID", value);
            }
        }

        private Decimal _Victory;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("Victory")]
        public Decimal Victory
        {
            get
            {
                return _Victory;
            }
            private set
            {
                SetChange("Victory", value);
            }
        }

        private Decimal _Failure;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(12)]
        [EntityField("Failure")]
        public Decimal Failure
        {
            get
            {
                return _Failure;
            }
            private set
            {
                SetChange("Failure", value);
            }
        }

        private String _CityDesc;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(13)]
        [EntityField("CityDesc")]
        public String CityDesc
        {
            get
            {
                return _CityDesc;
            }
            private set
            {
                SetChange("CityDesc", value);
            }
        }

        private CacheList<PrizeInfo> _Coefficient;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(14)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeInfo> Coefficient
        {
            get
            {
                return _Coefficient;
            }
            private set
            {
                SetChange("Coefficient", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "CityID": return CityID;
                    case "CityHead": return CityHead;
                    case "HeadID1": return HeadID1;
                    case "HeadID2": return HeadID2;
                    case "GuildLv": return GuildLv;
                    case "SkillNum": return SkillNum;
                    case "FirstPackID": return FirstPackID;
                    case "SecondPackID": return SecondPackID;
                    case "ThirdPackID": return ThirdPackID;
                    case "ParticipateID": return ParticipateID;
                    case "Victory": return Victory;
                    case "Failure": return Failure;
                    case "CityDesc": return CityDesc;
                    case "Coefficient": return Coefficient;
                    default: throw new ArgumentException(string.Format("GuildFightInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "CityID":
                        _CityID = value.ToInt();
                        break;
                    case "CityHead":
                        _CityHead = value.ToNotNullString();
                        break;
                    case "HeadID1":
                        _HeadID1 = value.ToNotNullString();
                        break;
                    case "HeadID2":
                        _HeadID2 = value.ToNotNullString();
                        break;
                    case "GuildLv":
                        _GuildLv = value.ToShort();
                        break;
                    case "SkillNum":
                        _SkillNum = value.ToInt();
                        break;
                    case "FirstPackID":
                        _FirstPackID = value.ToInt();
                        break;
                    case "SecondPackID":
                        _SecondPackID = value.ToInt();
                        break;
                    case "ThirdPackID":
                        _ThirdPackID = value.ToInt();
                        break;
                    case "ParticipateID":
                        _ParticipateID = value.ToInt();
                        break;
                    case "Victory":
                        _Victory = value.ToDecimal();
                        break;
                    case "Failure":
                        _Failure = value.ToDecimal();
                        break;
                    case "CityDesc":
                        _CityDesc = value.ToNotNullString();
                        break;
                    case "Coefficient":
                        _Coefficient = ConvertCustomField<CacheList<PrizeInfo>>(value, index);
                        break;
                    default: throw new ArgumentException(string.Format("GuildFightInfo index[{0}] isn't exist.", index));
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