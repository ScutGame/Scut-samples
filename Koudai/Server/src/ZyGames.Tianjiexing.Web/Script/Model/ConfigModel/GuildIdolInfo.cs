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
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class GuildIdolInfo : ShareEntity
    {

        
        public GuildIdolInfo()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _IdolID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IdolID", IsKey = true)]
        public Int32 IdolID
        {
            get
            {
                return _IdolID;
            }
            private set
            {
                SetChange("IdolID", value);
            }
        }
        private String _IdolName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IdolName")]
        public String IdolName
        {
            get
            {
                return _IdolName;
            }
            private set
            {
                SetChange("IdolName", value);
            }
        }
        private Int32 _GainObtion;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GainObtion")]
        public Int32 GainObtion
        {
            get
            {
                return _GainObtion;
            }
            private set
            {
                SetChange("GainObtion", value);
            }
        }
        private Int32 _GainBlessing;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GainBlessing")]
        public Int32 GainBlessing
        {
            get
            {
                return _GainBlessing;
            }
            private set
            {
                SetChange("GainBlessing", value);
            }
        }
        private Int32 _GainAura;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("GainAura")]
        public Int32 GainAura
        {
            get
            {
                return _GainAura;
            }
            private set
            {
                SetChange("GainAura", value);
            }
        }
        private Int32 _UseExpNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UseExpNum")]
        public Int32 UseExpNum
        {
            get
            {
                return _UseExpNum;
            }
            private set
            {
                SetChange("UseExpNum", value);
            }
        }
        private Int32 _UseGold;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("UseGold")]
        public Int32 UseGold
        {
            get
            {
                return _UseGold;
            }
            private set
            {
                SetChange("UseGold", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "IdolID": return IdolID;
                    case "IdolName": return IdolName;
                    case "GainObtion": return GainObtion;
                    case "GainBlessing": return GainBlessing;
                    case "GainAura": return GainAura;
                    case "UseExpNum": return UseExpNum;
                    case "UseGold": return UseGold;
					default: throw new ArgumentException(string.Format("GuildIdolInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "IdolID": 
                        _IdolID = value.ToInt(); 
                        break; 
                    case "IdolName": 
                        _IdolName = value.ToNotNullString(); 
                        break; 
                    case "GainObtion": 
                        _GainObtion = value.ToInt(); 
                        break; 
                    case "GainBlessing": 
                        _GainBlessing = value.ToInt(); 
                        break; 
                    case "GainAura": 
                        _GainAura = value.ToInt(); 
                        break; 
                    case "UseExpNum": 
                        _UseExpNum = value.ToInt(); 
                        break; 
                    case "UseGold": 
                        _UseGold = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("GuildIdolInfo index[{0}] isn't exist.", index));
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