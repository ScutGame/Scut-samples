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

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// �����Ա��
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data)]


    public class GuildMember : ShareEntity
    {

        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_GuildID = "Index_GuildID";

        public GuildMember()
            : base(AccessLevel.ReadWrite)
        {
        }

        /// <summary>
        /// ף�����
        /// </summary>
        public double BlessingCionPercent = ConfigEnvSet.GetDouble("GuildMember.BlessingCionPercent");

        #region auto-generated Property
        private String _GuildID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("GuildID", IsKey = true)]
        public String GuildID
        {
            get
            {
                return _GuildID;
            }
            set
            {
                SetChange("GuildID", value);
            }
        }
        private String _UserID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
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
        private PostType _PostType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("PostType")]
        public PostType PostType
        {
            get
            {
                return _PostType;
            }
            set
            {
                SetChange("PostType", value);
            }
        }
        private Int32 _Contribution;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("Contribution")]
        public Int32 Contribution
        {
            get
            {
                return _Contribution;
            }
            set
            {
                SetChange("Contribution", value);
            }
        }
        private Int32 _TotalContribution;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("TotalContribution")]
        public Int32 TotalContribution
        {
            get
            {
                return _TotalContribution;
            }
            set
            {
                SetChange("TotalContribution", value);
            }
        }
        private Int32 _IncenseNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("IncenseNum")]
        public Int32 IncenseNum
        {
            get
            {
                return _IncenseNum;
            }
            set
            {
                SetChange("IncenseNum", value);
            }
        }
        private DateTime _IncenseDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("IncenseDate")]
        public DateTime IncenseDate
        {
            get
            {
                return _IncenseDate;
            }
            set
            {
                SetChange("IncenseDate", value);
            }
        }
        private Int32 _DevilNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("DevilNum")]
        public Int32 DevilNum
        {
            get
            {
                return _DevilNum;
            }
            set
            {
                SetChange("DevilNum", value);
            }
        }
        private Int32 _SummonNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("SummonNum")]
        public Int32 SummonNum
        {
            get
            {
                return _SummonNum;
            }
            set
            {
                SetChange("SummonNum", value);
            }
        }
        private Int32 _IsDevil;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField("IsDevil")]
        public Int32 IsDevil
        {
            get
            {
                return _IsDevil;
            }
            set
            {
                SetChange("IsDevil", value);
            }
        }
        private DateTime _DevilDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField("DevilDate")]
        public DateTime DevilDate
        {
            get
            {
                return _DevilDate;
            }
            set
            {
                SetChange("DevilDate", value);
            }
        }
        private DateTime _InsertDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField("InsertDate")]
        public DateTime InsertDate
        {
            get
            {
                return _InsertDate;
            }
            set
            {
                SetChange("InsertDate", value);
            }
        }
        private Int32 _GainBlessing;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
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
        private Int32 _CurrNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        [EntityField("CurrNum")]
        public Int32 CurrNum
        {
            get
            {
                return _CurrNum;
            }
            set
            {
                SetChange("CurrNum", value);
            }
        }
        private DateTime _RefreshDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(15)]
        [EntityField("RefreshDate")]
        public DateTime RefreshDate
        {
            get
            {
                return _RefreshDate;
            }
            set
            {
                SetChange("RefreshDate", value);
            }
        }
        private Int32 _DonateCoin;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(16)]
        [EntityField("DonateCoin")]
        public Int32 DonateCoin
        {
            get
            {
                return _DonateCoin;
            }
            set
            {
                SetChange("DonateCoin", value);
            }
        }
        private Int32 _DonateGold;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(17)]
        [EntityField("DonateGold")]
        public Int32 DonateGold
        {
            get
            {
                return _DonateGold;
            }
            set
            {
                SetChange("DonateGold", value);
            }
        }
        private Int32 _TotalDonate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(18)]
        [EntityField("TotalDonate")]
        public Int32 TotalDonate
        {
            get
            {
                return _TotalDonate;
            }
            set
            {
                SetChange("TotalDonate", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "GuildID": return GuildID;
                    case "UserID": return UserID;
                    case "PostType": return PostType;
                    case "Contribution": return Contribution;
                    case "TotalContribution": return TotalContribution;
                    case "IncenseNum": return IncenseNum;
                    case "IncenseDate": return IncenseDate;
                    case "DevilNum": return DevilNum;
                    case "SummonNum": return SummonNum;
                    case "IsDevil": return IsDevil;
                    case "DevilDate": return DevilDate;
                    case "InsertDate": return InsertDate;
                    case "GainBlessing": return GainBlessing;
                    case "CurrNum": return CurrNum;
                    case "RefreshDate": return RefreshDate;
                    case "DonateCoin": return DonateCoin;
                    case "DonateGold": return DonateGold;
                    case "TotalDonate": return TotalDonate;
                    default: throw new ArgumentException(string.Format("GuildMember index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "GuildID":
                        _GuildID = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "PostType":
                        _PostType = value.ToEnum<PostType>();
                        break;
                    case "Contribution":
                        _Contribution = value.ToInt();
                        break;
                    case "TotalContribution":
                        _TotalContribution = value.ToInt();
                        break;
                    case "IncenseNum":
                        _IncenseNum = value.ToInt();
                        break;
                    case "IncenseDate":
                        _IncenseDate = value.ToDateTime();
                        break;
                    case "DevilNum":
                        _DevilNum = value.ToInt();
                        break;
                    case "SummonNum":
                        _SummonNum = value.ToInt();
                        break;
                    case "IsDevil":
                        _IsDevil = value.ToInt();
                        break;
                    case "DevilDate":
                        _DevilDate = value.ToDateTime();
                        break;
                    case "InsertDate":
                        _InsertDate = value.ToDateTime();
                        break;
                    case "GainBlessing":
                        _GainBlessing = value.ToInt();
                        break;
                    case "CurrNum":
                        _CurrNum = value.ToInt();
                        break;
                    case "RefreshDate":
                        _RefreshDate = value.ToDateTime();
                        break;
                    case "DonateCoin":
                        _DonateCoin = value.ToInt();
                        break;
                    case "DonateGold":
                        _DonateGold = value.ToInt();
                        break;
                    case "TotalDonate":
                        _TotalDonate = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("GuildMember index[{0}] isn't exist.", index));
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

        /// <summary>
        /// ����,�����Ա���ߵģ�ְ�������ܹ��׽��򣬼���ʱ�併��
        /// </summary>
        /// <param name="itemData"></param>
        /// <returns></returns>
        public override int CompareTo(ShareEntity itemData)
        {
            GuildMember other = itemData as GuildMember;
            int result = 0;
            if (this == null && other == null) return 0;
            if (this != null && other == null) return 1;
            if (this == null && other != null) return -1;

            var cacheSet = new PersonalCacheStruct<GameUser>();
            GameUser otherUser = cacheSet.FindKey(other.UserID);
            if (otherUser == null)
            {
                otherUser = UserCacheGlobal.CheckLoadUser(other.UserID);
            }
            GameUser user = cacheSet.FindKey(UserID);
            if (user == null)
            {
                user = UserCacheGlobal.CheckLoadUser(UserID);
            }
            if (otherUser != null && user != null)
            {
                result = otherUser.IsOnline.CompareTo(user.IsOnline);
            }
            if (result == 0)
            {
                result = ((int)PostType).CompareTo((int)other.PostType);
                if (result == 0)
                {
                    result = other.TotalContribution.CompareTo(TotalContribution);
                    if (result == 0)
                    {
                        result = other.InsertDate.CompareTo(InsertDate);
                    }
                }
            }
            return result;
        }
    }
}