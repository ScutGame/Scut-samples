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
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Model;

namespace ZyGames.Tianjiexing.Model
{
    public enum MagicType
    {
        /// <summary>
        /// ����
        /// </summary>
        JiNeng = 1,
        /// <summary>
        /// ħ����
        /// </summary>
        MoFaZhen
    }
    /// <summary>
    /// �û�ħ����
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data, OrderColumn = "MagicID")]
    public class UserMagic : BaseEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_UserID_MagicType = "Index_UserID_MagicType";


        public UserMagic()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public String UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                SetChange("UserID", value);
            }
        }
        private Int32 _MagicID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("MagicID", IsKey = true)]
        public Int32 MagicID
        {
            get
            {
                return _MagicID;
            }
            set
            {
                SetChange("MagicID", value);
            }
        }
        private MagicType _MagicType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("MagicType")]
        public MagicType MagicType
        {
            get
            {
                return _MagicType;
            }
            set
            {
                SetChange("MagicType", value);
            }
        }
        private Int16 _MagicLv;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("MagicLv")]
        public Int16 MagicLv
        {
            get
            {
                return _MagicLv;
            }
            set
            {
                SetChange("MagicLv", value);
                TraceLog.ReleaseWriteDebug("ħ��������ħ��ID��{0}��ħ���ȼ���{1}�����ID��{2}", MagicID, MagicLv, UserID);
            }
        }
        private Boolean _IsEnabled;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("IsEnabled")]
        public Boolean IsEnabled
        {
            get
            {
                return _IsEnabled;
            }
            set
            {
                SetChange("IsEnabled", value);
            }
        }
       
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "UserID": return UserID;
                    case "MagicID": return MagicID;
                    case "MagicType": return MagicType;
                    case "MagicLv": return MagicLv;
                    case "IsEnabled": return IsEnabled;
                    default: throw new ArgumentException(string.Format("UserMagic index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "MagicID":
                        _MagicID = value.ToInt();
                        break;
                    case "MagicType":
                        _MagicType = value.ToEnum<MagicType>();
                        break;
                    case "MagicLv":
                        _MagicLv = value.ToShort();
                        break;
                    case "IsEnabled":
                        _IsEnabled = value.ToBool();
                        break;
                    default: throw new ArgumentException(string.Format("UserMagic index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        public Int32 IsLv { get; set; }
        public bool IsOpen { get; set; }
        #endregion

        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID.ToInt();
        }
    }
}