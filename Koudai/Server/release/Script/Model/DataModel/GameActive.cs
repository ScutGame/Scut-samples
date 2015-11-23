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
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Entity, DbConfig.Data)]

    public class GameActive : ShareEntity
    {

        public const string Index_ActiveType = "Index_ActiveType";

        public GameActive()
            : base(AccessLevel.ReadWrite)
        {
        }

        #region auto-generated Property
        private Int32 _ActiveId;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(1)]
        [EntityField("ActiveId", IsKey = true)]
        public Int32 ActiveId
        {
            get
            {
                return _ActiveId;
            }
            set
            {
                SetChange("ActiveId", value);
            }
        }
        private String _ActiveName;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("ActiveName")]
        public String ActiveName
        {
            get
            {
                return _ActiveName;
            }
            set
            {
                SetChange("ActiveName", value);
            }
        }
        private String _HeadID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("HeadID")]
        public String HeadID
        {
            get
            {
                return _HeadID;
            }
            set
            {
                SetChange("HeadID", value);
            }
        }
        private String _Descption;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("Descption")]
        public String Descption
        {
            get
            {
                return _Descption;
            }
            set
            {
                SetChange("Descption", value);
            }
        }
        private FunctionEnum _ActiveType;
        /// <summary>
        /// �����
        /// </summary>
        [ProtoMember(5)]
        [EntityField("ActiveType")]
        public FunctionEnum ActiveType
        {
            get
            {
                return _ActiveType;
            }
            set
            {
                SetChange("ActiveType", value);
            }
        }
        private Int32 _BossDefLv;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("BossDefLv")]
        public Int32 BossDefLv
        {
            get
            {
                return _BossDefLv;
            }
            set
            {
                SetChange("BossDefLv", value);
            }
        }
        private short _BossLv;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("BossLv")]
        public short BossLv
        {
            get
            {
                return _BossLv;
            }
            set
            {
                SetChange("BossLv", value);
            }
        }
        private Int32 _BossPlotID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("BossPlotID")]
        public Int32 BossPlotID
        {
            get
            {
                return _BossPlotID;
            }
            set
            {
                SetChange("BossPlotID", value);
            }
        }
        private String _EnablePeriod;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("EnablePeriod")]
        public String EnablePeriod
        {
            get
            {
                return _EnablePeriod;
            }
            set
            {
                SetChange("EnablePeriod", value);
            }
        }
        private Int32 _WaitMinutes;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField("WaitMinutes")]
        public Int32 WaitMinutes
        {
            get
            {
                return _WaitMinutes;
            }
            set
            {
                SetChange("WaitMinutes", value);
            }
        }
        private Int32 _Minutes;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField("Minutes")]
        public Int32 Minutes
        {
            get
            {
                return _Minutes;
            }
            set
            {
                SetChange("Minutes", value);
            }
        }
        private String _ActivePize;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(12)]
        [EntityField("ActivePize")]
        public String ActivePize
        {
            get
            {
                return _ActivePize;
            }
            set
            {
                SetChange("ActivePize", value);
            }
        }
        private Boolean _State;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(13)]
        [EntityField("State")]
        public Boolean State
        {
            get
            {
                return _State;
            }
            set
            {
                SetChange("State", value);
            }
        }
        private String _Broadcast;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(14)]
        [EntityField("Broadcast")]
        public String Broadcast
        {
            get
            {
                return _Broadcast;
            }
            set
            {
                SetChange("Broadcast", value);
            }
        }
        private Int16 _ActiveStyle;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(15)]
        [EntityField("ActiveStyle")]
        public Int16 ActiveStyle
        {
            get
            {
                return _ActiveStyle;
            }
            set
            {
                SetChange("ActiveStyle", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ActiveId": return ActiveId;
                    case "ActiveName": return ActiveName;
                    case "HeadID": return HeadID;
                    case "Descption": return Descption;
                    case "ActiveType": return ActiveType;
                    case "BossDefLv": return BossDefLv;
                    case "BossLv": return BossLv;
                    case "BossPlotID": return BossPlotID;
                    case "EnablePeriod": return EnablePeriod;
                    case "WaitMinutes": return WaitMinutes;
                    case "Minutes": return Minutes;
                    case "ActivePize": return ActivePize;
                    case "State": return State;
                    case "Broadcast": return Broadcast;
                    case "ActiveStyle": return ActiveStyle;
                    default: throw new ArgumentException(string.Format("GameActive index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ActiveId":
                        _ActiveId = value.ToInt();
                        break;
                    case "ActiveName":
                        _ActiveName = value.ToNotNullString();
                        break;
                    case "HeadID":
                        _HeadID = value.ToNotNullString();
                        break;
                    case "Descption":
                        _Descption = value.ToNotNullString();
                        break;
                    case "ActiveType":
                        _ActiveType = value.ToEnum<FunctionEnum>();
                        break;
                    case "BossDefLv":
                        _BossDefLv = value.ToInt();
                        break;
                    case "BossLv":
                        _BossLv = value.ToShort();
                        break;
                    case "BossPlotID":
                        _BossPlotID = value.ToInt();
                        break;
                    case "EnablePeriod":
                        _EnablePeriod = value.ToNotNullString();
                        break;
                    case "WaitMinutes":
                        _WaitMinutes = value.ToInt();
                        break;
                    case "Minutes":
                        _Minutes = value.ToInt();
                        break;
                    case "ActivePize":
                        _ActivePize = value.ToNotNullString();
                        break;
                    case "State":
                        _State = value.ToBool();
                        break;
                    case "Broadcast":
                        _Broadcast = value.ToNotNullString();
                        break;
                    case "ActiveStyle":
                        _ActiveStyle = value.ToShort();
                        break;
                    default: throw new ArgumentException(string.Format("GameActive index[{0}] isn't exist.", index));
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
        /// �����л�Boss����
        /// </summary>
        public BossActivePrize BossPrize
        {
            get;
            set;
        }

        public CombatStatus _combatStatus;
        /// <summary>
        /// �״̬
        /// </summary>
        public CombatStatus CombatStatus
        {
            get { return _combatStatus; }
            set { _combatStatus = value; }
        }

        /// <summary>
        /// ���ʼʱ��
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// �����ʱ��
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// �Ƿ��ʼ���ɹ�
        /// </summary>
        public bool LoadSuccess { get; set; }

        public CombatStatus RefreshStatus()
        {
            if (CombatStatus != CombatStatus.NoStart && CombatStatus != CombatStatus.Over)
            {
                DateTime currTime = DateTime.Now;

                if (BeginTime > currTime)
                {
                    lock (this)
                    {
                        CombatStatus = CombatStatus.NoStart;
                    }
                }
                else if (EndTime < currTime)
                {
                    lock (this)
                    {
                        CombatStatus = CombatStatus.Over;
                    }
                }
            }
            return CombatStatus;
        }

        /// <summary>
        /// �����ʱ��
        /// </summary>
        public int ColdTime
        {
            get
            {
                if (CombatStatus == CombatStatus.Wait)
                {
                    //��1����״̬�ı���ӳ�ʱ��
                    return (int)Math.Floor((BeginTime.AddMinutes(WaitMinutes) - DateTime.Now).TotalSeconds);
                }
                if (CombatStatus == CombatStatus.Combat)
                {
                    return (int)Math.Floor((BeginTime.AddMinutes(Minutes) - DateTime.Now).TotalSeconds);
                }
                return 0;
            }
        }
    }
}