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
    /// 玩家集邮表
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class UserAlbum : BaseEntity
    {

        /// <summary>
        /// </summary>
        public UserAlbum()
            : base(AccessLevel.ReadWrite)
        {
            AlbumList = new CacheList<Album>();
        }
        /// <summary>
        /// </summary>
        public UserAlbum(string userID)
            : this()
        {
            _userID = userID;
        }

        #region 自动生成属性
        private string _userID;
        /// <summary>
        /// 玩家Id
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public string UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                SetChange("UserID", value);
            }

        }
        private CacheList<Album> _albumList;
        /// <summary>
        /// 集邮列表[CacheList<Album>]
        /// </summary>        
        [ProtoMember(2)]
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<Album> AlbumList
        {
            get
            {
                return _albumList;
            }
            set
            {
                SetChange("AlbumList", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "UserID": return _userID;
                    case "AlbumList": return _albumList;
                    default: throw new ArgumentException(string.Format("UserAlbum index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "UserID":
                        _userID = value.ToNotNullString();
                        break;
                    case "AlbumList":
                        _albumList = ConvertCustomField<CacheList<Album>>(value, index);
                        break;
                    default: throw new ArgumentException(string.Format("UserAlbum index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //设置玩家的UserID
            //若要做为全局使用设置类绑定的自定义属性[EntityTable(CacheType.Entity, DbConfig.Config, @TableName, @PeriodTime)]
            return UserID.ToInt();
        }
    }
}