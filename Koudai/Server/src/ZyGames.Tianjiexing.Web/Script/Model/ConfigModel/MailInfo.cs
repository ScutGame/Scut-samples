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
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class MailInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public MailInfo()
            : base(AccessLevel.ReadOnly)
        {
        }        
        /// <summary>
        /// </summary>
        public MailInfo(Int32 MailType)
            : this()
        {
            this._MailType = MailType;
        }

        #region 自动生成属性

        private Int32 _MailType;
        /// <summary>
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("MailType", IsKey = true)]
        public Int32 MailType
        {
            get
            {
                return _MailType;
            } 
            
        }

        private Int32 _MaxLength;
        /// <summary>
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("MaxLength")]
        public Int32 MaxLength
        {
            get
            {
                return _MaxLength;
            } 
            
        }

        private String _GuideContent;
        /// <summary>
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("GuideContent")]
        public String GuideContent
        {
            get
            {
                return _GuideContent;
            } 
            
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "MailType": return MailType;
                    case "MaxLength": return MaxLength;
                    case "GuideContent": return GuideContent;
					default: throw new ArgumentException(string.Format("MailInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "MailType": 
                        _MailType = value.ToInt(); 
                        break; 
                    case "MaxLength": 
                        _MaxLength = value.ToInt(); 
                        break; 
                    case "GuideContent": 
                        _GuideContent = value.ToNotNullString(); 
                        break; 
					default: throw new ArgumentException(string.Format("MailInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion

	}
}