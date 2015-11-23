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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class GeneralEscalateInfo : ShareEntity
    {


        public GeneralEscalateInfo()
            : base(AccessLevel.ReadOnly)
        {
            Award = new CacheList<PrizeInfo>();
        }

        #region auto-generated Property
        private Int16 _GeneralLv;
        /// <summary>
        ///     Ӷ���ȼ�������
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

        private GeneralType _GeneralType;
        /// <summary>
        /// ����GeneralTypeö�٣�����
        /// </summary>
        [EntityField("GeneralType", IsKey = true)]
        public GeneralType GeneralType
        {
            get
            {
                return _GeneralType;
            }
            private set
            {
                SetChange("GeneralType", value);
            }
        }

        private Int32 _UpExperience;
        /// <summary>
        /// Ӷ����������
        /// </summary>
        [EntityField("UpExperience")]
        public Int32 UpExperience
        {
            get
            {
                return _UpExperience;
            }
            private set
            {
                SetChange("UpExperience", value);
            }
        }

        private string _FunctionEnum;
        /// <summary>
        /// ����FunctionEnumö��
        /// </summary>
        [EntityField("FunctionEnum")]
        public string FunctionEnum
        {
            get
            {
                return _FunctionEnum;
            }
            private set
            {
                SetChange("FunctionEnum", value);
            }
        }

        private Int32 _Leadership;
        /// <summary>
        /// ��������쵼��
        /// </summary>
        [EntityField("Leadership")]
        public Int32 Leadership
        {
            get
            {
                return _Leadership;
            }
            private set
            {
                SetChange("Leadership", value);
            }
        }
        private CacheList<PrizeInfo> _Award;
        /// <summary>
        /// 
        /// </summary>
         [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeInfo> Award
        {
            get
            {
                return _Award;
            }
            private set
            {
                SetChange("Award", value);
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
                    case "UpExperience": return UpExperience;
                    case "GeneralType": return GeneralType;
                    case "FunctionEnum": return FunctionEnum;
                    case "Leadership": return Leadership;
                    case "Award": return Award;
                    default: throw new ArgumentException(string.Format("GeneralEscalateInfo index[{0}] isn't exist.", index));
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
                    case "UpExperience":
                        _UpExperience = value.ToInt();
                        break;
                    case "GeneralType":
                        _GeneralType = value.ToEnum<GeneralType>();
                        break;
                    case "FunctionEnum":
                        _FunctionEnum = value.ToNotNullString();
                        break;
                    case "Leadership":
                        _Leadership = value.ToInt();
                        break;
                    case "Award":
                        _Award = ConvertCustomField<CacheList<PrizeInfo>>(value, index); 
                        break;
                    default: throw new ArgumentException(string.Format("GeneralEscalateInfo index[{0}] isn't exist.", index));
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