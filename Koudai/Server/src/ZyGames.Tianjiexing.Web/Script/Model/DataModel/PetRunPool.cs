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
    /// ��������
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data)]
    public class PetRunPool : ShareEntity
    {
        public PetRunPool()
            : base(AccessLevel.ReadWrite)
        {
        }

        public PetRunPool(string userId)
            : this()
        {
            UserID = userId;
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
            private set
            {
                SetChange("UserID", value);
            }
        }
        private Int32 _PetID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("PetID")]
        public Int32 PetID
        {
            get
            {
                return _PetID;
            }
            set
            {
                SetChange("PetID", value);
            }
        }
        private String _FriendID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("FriendID")]
        public String FriendID
        {
            get
            {
                return _FriendID;
            }
            set
            {
                SetChange("FriendID", value);
            }
        }
        private Int32 _GameCoin;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
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
        private Int32 _ObtainNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
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
        private DateTime _StartDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("StartDate")]
        public DateTime StartDate
        {
            get
            {
                return _StartDate;
            }
            set
            {
                SetChange("StartDate", value);
            }
        }
        private DateTime _EndDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
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
        private Int32 _CurrInterceptNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("CurrInterceptNum")]
        public Int32 CurrInterceptNum
        {
            get
            {
                return _CurrInterceptNum;
            }
            set
            {
                SetChange("CurrInterceptNum", value);
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
                    case "PetID": return PetID;
                    case "FriendID": return FriendID;
                    case "GameCoin": return GameCoin;
                    case "ObtainNum": return ObtainNum;
                    case "StartDate": return StartDate;
                    case "EndDate": return EndDate;
                    case "CurrInterceptNum": return CurrInterceptNum;
                    default: throw new ArgumentException(string.Format("PetRunPool index[{0}] isn't exist.", index));
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
                    case "PetID":
                        _PetID = value.ToInt();
                        break;
                    case "FriendID":
                        _FriendID = value.ToNotNullString();
                        break;
                    case "GameCoin":
                        _GameCoin = value.ToInt();
                        break;
                    case "ObtainNum":
                        _ObtainNum = value.ToInt();
                        break;
                    case "StartDate":
                        _StartDate = value.ToDateTime();
                        break;
                    case "EndDate":
                        _EndDate = value.ToDateTime();
                        break;
                    case "CurrInterceptNum":
                        _CurrInterceptNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("PetRunPool index[{0}] isn't exist.", index));
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
        /// ������� �Զ��Ÿ��
        /// </summary>
        [ProtoMember(9)]
        public string InterceptUser { get; set; }

        public int ColdTime
        {
            get
            {
                return EndDate > DateTime.Now ? (int)(EndDate - DateTime.Now).TotalSeconds : 0;
            }
        }

        public bool IsRunning
        {
            get { return PetID > 0 && ColdTime > 0; }
        }
        public Int32 InterceptGameCoin
        {
            get
            {
                var petInfo = new ShareCacheStruct<PetInfo>().FindKey(PetID) ?? new PetInfo();
                return (int)Math.Floor(GameCoin * petInfo.CoinRate2);
            }
        }

        public Int32 InterceptObtainNum
        {
            get
            {
                var petInfo = new ShareCacheStruct<PetInfo>().FindKey(PetID) ?? new PetInfo();
                return (int)Math.Floor(ObtainNum * petInfo.ObtainRate2);
            }
        }
    }
}