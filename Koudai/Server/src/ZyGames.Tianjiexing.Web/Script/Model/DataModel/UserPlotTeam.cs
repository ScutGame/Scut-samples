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
    /// ��Ҷ��˸��������
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]



    public class UserPlotTeam : BaseEntity
    {

        public const string Index_TeamID = "Index_TeamID";
        public const string Index_UserID = GameUser.Index_UserID;
        public const string Index_TeamType = "Index_TeamType";

        public UserPlotTeam()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private String _TeamID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("TeamID", IsKey = true)]
        public String TeamID
        {
            get
            {
                return _TeamID;
            }
            set
            {
                SetChange("TeamID", value);
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
        private Int32 _PlotID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("PlotID")]
        public Int32 PlotID
        {
            get
            {
                return _PlotID;
            }
            set
            {
                SetChange("PlotID", value);
            }
        }
        private TeamType _TeamType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("TeamType")]
        public TeamType TeamType
        {
            get
            {
                return _TeamType;
            }
            set
            {
                SetChange("TeamType", value);
            }
        }
        private Int32 _Location;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("Location")]
        public Int32 Location
        {
            get
            {
                return _Location;
            }
            set
            {
                SetChange("Location", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "TeamID": return TeamID;
                    case "UserID": return UserID;
                    case "PlotID": return PlotID;
                    case "TeamType": return TeamType;
                    case "Location": return Location;
                    default: throw new ArgumentException(string.Format("UserPlotTeam index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "TeamID":
                        _TeamID = value.ToNotNullString();
                        break;
                    case "UserID":
                        _UserID = value.ToNotNullString();
                        break;
                    case "PlotID":
                        _PlotID = value.ToInt();
                        break;
                    case "TeamType":
                        _TeamType = value.ToEnum<TeamType>();
                        break;
                    case "Location":
                        _Location = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("UserPlotTeam index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //allow modify return value
            return UserID.ToInt();
        }
    }
}