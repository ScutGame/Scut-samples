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
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data, Condition = "IsTasked=0")]

    public class UserTakePrize : ShareEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;

        public UserTakePrize()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _ID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("ID", IsKey = true)]
        public String ID
        {
            get
            {
                return _ID;
            }
            set
            {
                SetChange("ID", value);
            }
        }
        private Int32 _UserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("UserID")]
        public Int32 UserID
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
        private Int32 _ObtainNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("ObtainNum")]
        public Int32 ObtainNum
        {
            get
            {
                return _ObtainNum;
            }
            set
            {
                SetChange("ObtainNum", value);
            }
        }
        private Int32 _EnergyNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("EnergyNum")]
        public Int32 EnergyNum
        {
            get
            {
                return _EnergyNum;
            }
            set
            {
                SetChange("EnergyNum", value);
            }
        }
        private Int32 _GameCoin;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("GameCoin")]
        public Int32 GameCoin
        {
            get
            {
                return _GameCoin;
            }
            set
            {
                SetChange("GameCoin", value);
            }
        }
        private Int32 _Gold;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("Gold")]
        public Int32 Gold
        {
            get
            {
                return _Gold;
            }
            set
            {
                SetChange("Gold", value);
            }
        }
        private Int32 _ExpNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("ExpNum")]
        public Int32 ExpNum
        {
            get
            {
                return _ExpNum;
            }
            set
            {
                SetChange("ExpNum", value);
            }
        }
        private Int32 _VipLv;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("VipLv")]
        public Int32 VipLv
        {
            get
            {
                return _VipLv;
            }
            set
            {
                SetChange("VipLv", value);
            }
        }
        private Int32 _GainBlessing;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("GainBlessing")]
        public Int32 GainBlessing
        {
            get
            {
                return _GainBlessing;
            }
            set
            {
                SetChange("GainBlessing", value);
            }
        }
        private String _ItemPackage;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField("ItemPackage")]
        public String ItemPackage
        {
            get
            {
                return _ItemPackage;
            }
            set
            {
                SetChange("ItemPackage", value);
            }
        }
        private String _CrystalPackage;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField("CrystalPackage")]
        public String CrystalPackage
        {
            get
            {
                return _CrystalPackage;
            }
            set
            {
                SetChange("CrystalPackage", value);
            }
        }
        private String _SparePackage;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField("SparePackage")]
        public String SparePackage
        {
            get
            {
                return _SparePackage;
            }
            set
            {
                SetChange("SparePackage", value);
            }
        }
        private String _MailContent;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        [EntityField("MailContent")]
        public String MailContent
        {
            get
            {
                return _MailContent;
            }
            set
            {
                SetChange("MailContent", value);
            }
        }
        private Boolean _IsTasked;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        [EntityField("IsTasked")]
        public Boolean IsTasked
        {
            get
            {
                return _IsTasked;
            }
            set
            {
                SetChange("IsTasked", value);
            }
        }
        private DateTime _TaskDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(15)]
        [EntityField("TaskDate")]
        public DateTime TaskDate
        {
            get
            {
                return _TaskDate;
            }
            set
            {
                SetChange("TaskDate", value);
            }
        }
        private Int32 _OpUserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(16)]
        [EntityField("OpUserID")]
        public Int32 OpUserID
        {
            get
            {
                return _OpUserID;
            }
            set
            {
                SetChange("OpUserID", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(17)]
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                SetChange("CreateDate", value);
            }
        }

        private string _EnchantPackage;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(18)]
        [EntityField("EnchantPackage")]
        public string EnchantPackage
        {
            get
            {
                return _EnchantPackage;
            }
            set
            {
                SetChange("EnchantPackage", value);
            }
        }
        private Int32 _HonourNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(19)]
        [EntityField("HonourNum")]
        public Int32 HonourNum
        {
            get
            {
                return _HonourNum;
            }
            set
            {
                SetChange("HonourNum", value);
            }
        }
        private String _Items;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(20)]
        [EntityField("Items")]
        public String Items
        {
            get
            {
                return _Items;
            }
            set
            {
                SetChange("Items", value);
            }
        }
        private Int32 _Experience;
        /// <summary>
        /// ����
        /// </summary>
        [ProtoMember(21)]
        [EntityField("Experience")]
        public Int32 Experience
        {
            get
            {
                return _Experience;
            }
            set
            {
                SetChange("Experience", value);
            }
        }
   
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ID": return ID;
                    case "UserID": return UserID;
                    case "ObtainNum": return ObtainNum;
                    case "EnergyNum": return EnergyNum;
                    case "GameCoin": return GameCoin;
                    case "Gold": return Gold;
                    case "ExpNum": return ExpNum;
                    case "VipLv": return VipLv;
                    case "GainBlessing": return GainBlessing;
                    case "ItemPackage": return ItemPackage;
                    case "CrystalPackage": return CrystalPackage;
                    case "SparePackage": return SparePackage;
                    case "MailContent": return MailContent;
                    case "IsTasked": return IsTasked;
                    case "TaskDate": return TaskDate;
                    case "OpUserID": return OpUserID;
                    case "CreateDate": return CreateDate;
                    case "EnchantPackage": return EnchantPackage;
                    case "HonourNum": return HonourNum;
                    case "Items": return Items;
                    case "Experience": return Experience;
                    default: throw new ArgumentException(string.Format("UserTakePrize index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ID":
                        _ID = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToInt();
                        break;
                    case "ObtainNum":
                        _ObtainNum = value.ToInt();
                        break;
                    case "EnergyNum":
                        _EnergyNum = value.ToInt();
                        break;
                    case "GameCoin":
                        _GameCoin = value.ToInt();
                        break;
                    case "Gold":
                        _Gold = value.ToInt();
                        break;
                    case "ExpNum":
                        _ExpNum = value.ToInt();
                        break;
                    case "VipLv":
                        _VipLv = value.ToInt();
                        break;
                    case "GainBlessing":
                        _GainBlessing = value.ToInt();
                        break;
                    case "ItemPackage":
                        _ItemPackage = value.ToNotNullString();
                        break;
                    case "CrystalPackage":
                        _CrystalPackage = value.ToNotNullString();
                        break;
                    case "SparePackage":
                        _SparePackage = value.ToNotNullString();
                        break;
                    case "MailContent":
                        _MailContent = value.ToNotNullString();
                        break;
                    case "IsTasked":
                        _IsTasked = value.ToBool();
                        break;
                    case "TaskDate":
                        _TaskDate = value.ToDateTime();
                        break;
                    case "OpUserID":
                        _OpUserID = value.ToInt();
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    case "EnchantPackage":
                        _EnchantPackage = value.ToNotNullString();
                        break;
                    case "HonourNum":
                        _HonourNum = value.ToInt();
                        break;
                    case "Items":
                        _Items = value.ToNotNullString();
                        break;
                    case "Experience":
                        _Experience = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserTakePrize index[{0}] isn't exist.", index));
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