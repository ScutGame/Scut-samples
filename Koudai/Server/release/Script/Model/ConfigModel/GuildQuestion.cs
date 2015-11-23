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
    public class GuildQuestion : ShareEntity
    {

        
        public GuildQuestion()
            : base(AccessLevel.ReadOnly)
        {
        }
        
        #region auto-generated Property
        private Int32 _ID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ID", IsKey = true)]
        public Int32 ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                SetChange("ID", value);
            }
        }
        private String _Question;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Question")]
        public String Question
        {
            get
            {
                return _Question;
            }
            private set
            {
                SetChange("Question", value);
            }
        }
        private String _Option_A;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Option_A")]
        public String Option_A
        {
            get
            {
                return _Option_A;
            }
            private set
            {
                SetChange("Option_A", value);
            }
        }
        private String _Option_B;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Option_B")]
        public String Option_B
        {
            get
            {
                return _Option_B;
            }
            private set
            {
                SetChange("Option_B", value);
            }
        }
        private String _Option_C;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Option_C")]
        public String Option_C
        {
            get
            {
                return _Option_C;
            }
            private set
            {
                SetChange("Option_C", value);
            }
        }
        private String _Option_D;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Option_D")]
        public String Option_D
        {
            get
            {
                return _Option_D;
            }
            private set
            {
                SetChange("Option_D", value);
            }
        }
        private Int32 _Answer;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Answer")]
        public Int32 Answer
        {
            get
            {
                return _Answer;
            }
            private set
            {
                SetChange("Answer", value);
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
                    case "Question": return Question;
                    case "Option_A": return Option_A;
                    case "Option_B": return Option_B;
                    case "Option_C": return Option_C;
                    case "Option_D": return Option_D;
                    case "Answer": return Answer;
					default: throw new ArgumentException(string.Format("GuildQuestion index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _ID = value.ToInt(); 
                        break; 
                    case "Question": 
                        _Question = value.ToNotNullString(); 
                        break; 
                    case "Option_A": 
                        _Option_A = value.ToNotNullString(); 
                        break; 
                    case "Option_B": 
                        _Option_B = value.ToNotNullString(); 
                        break; 
                    case "Option_C": 
                        _Option_C = value.ToNotNullString(); 
                        break; 
                    case "Option_D": 
                        _Option_D = value.ToNotNullString(); 
                        break; 
                    case "Answer": 
                        _Answer = value.ToInt(); 
                        break; 
					default: throw new ArgumentException(string.Format("GuildQuestion index[{0}] isn't exist.", index));
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