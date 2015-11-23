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
using System.Collections.Generic;
using System.Data;
using ProtoBuf;
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Data;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Game.Context;
using ZyGames.Framework.Model;
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{

    public enum Location
    {
        /// <summary>
        /// ����
        /// </summary>
        City = 1,
        /// <summary>
        /// ������
        /// </summary>
        Guid = 2,
        /// <summary>
        /// ����
        /// </summary>
        GuildExercise = 3,
    }

    /// <summary>
    /// ������ұ������
    /// </summary>
    /// <param name="property">����</param>
    /// <param name="userID"></param>
    /// <param name="oldValue">ԭʼֵ</param>
    /// <param name="value">����ֵ</param>
    public delegate void AsyncDataChangeCallback(string property, string userID, object oldValue, object value);

    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract, EntityTable(CacheType.Dictionary, DbConfig.Data)]
    public class GameUser : BaseUser
    {
        public const string Index_UserID = "Index_UserID";
        public const string Index_Session = "Index_SessionID";
        public const string Index_CityID = "Index_CityID";
        public const string Index_RankID = "Index_RankID";

        public static AsyncDataChangeCallback Callback { get; set; }
        private const int SportsCombatMax = 4;
        public static int festId = 1012; //��ֵ����ID

        public GameUser()
            : base(AccessLevel.ReadWrite)
        {
            UserExtend = new GameUserExtend();
            GrayCrystalList = new CacheList<GrayCrystal>();
            SportsCombatQueue = new CacheQueue<SportsCombat>();
            PropertyInfo = new CacheList<GuildAbility>();
            HeritageList = new CacheList<GeneralHeritage>();
            SweepPool = new SweepPoolInfo();
            OpenFun = new List<UserFunction>();
        }

        //protected override void BindChangeEvent()
        //{
        //    UserExtend.BindParentChangeEvent(this);
        //    GrayCrystalList.BindParentChangeEvent(this);
        //    SportsCombatQueue.BindParentChangeEvent(this);
        //    PropertyInfo.BindParentChangeEvent(this);
        //    HeritageList.BindParentChangeEvent(this);
        //}

        #region ConfigEnvSet Property
        public int UserMagicID = ConfigEnvSet.GetInt("User.MagicID");
        public int QueueMinNum = ConfigEnvSet.GetInt("Queue.QueueMinNum");

        /// <summary>
        /// ��ҳ�ʼ����������
        /// </summary>
        public short GridMinNum = (short)ConfigEnvSet.GetInt("User.GridMinNum");

        /// <summary>
        /// ���������ʼ����
        /// </summary>
        public short SparePartMinGridNum = (short)ConfigEnvSet.GetInt("SparePart.GridNum");
        /// <summary>
        /// �����������
        /// </summary>
        public short SparePartMaxGridNum = (short)ConfigEnvSet.GetInt("SparePart.MaxGridNum");

        /// <summary>
        /// ��ұ������������
        /// </summary>
        public int GridMaxNum = ConfigEnvSet.GetInt("User.GridMaxNum");

        /// <summary>
        /// ��ҳ�ʼ�ֿ⿪����
        /// </summary>
        public int WarehouseMinNum = ConfigEnvSet.GetInt("User.WarehouseMinNum");

        /// <summary>
        /// ��Ҳֿ���������
        /// </summary>
        public int WarehouseMaxNum = ConfigEnvSet.GetInt("User.WarehouseMaxNum");

        /// <summary>
        /// ��ҳ�ʼ���˱�������
        /// </summary>
        public int CrystalMinNum = ConfigEnvSet.GetInt("UserCrystal.CrystalMinNum");

        /// <summary>
        /// ������˱������������
        /// </summary>
        public int CrystalMaxNum = ConfigEnvSet.GetInt("UserCrystal.CrystalMaxNum");

        /// <summary>
        /// ��Ҿ�������
        /// </summary>
        public short EnergyMaxNum = (short)ConfigEnvSet.GetInt("User.MaxEnergyNum");

        /// <summary>
        /// ף�����
        /// </summary>
        public double BlessingCionPercent = ConfigEnvSet.GetDouble("GuildMember.BlessingCionPercent");

        /// <summary>
        /// ���ݼ��ʱ���ж��Ƿ�����
        /// </summary>
        public int OnlineIntervalDate = ConfigEnvSet.GetInt("GuildMember.IntervarDate");

        #endregion

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
        private CountryType _CountryID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(2)]
        [EntityField("CountryID")]
        public CountryType CountryID
        {
            get
            {
                return _CountryID;
            }
            set
            {
                SetChange("CountryID", value);
            }
        }
        private Int32 _CityID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(3)]
        [EntityField("CityID")]
        public Int32 CityID
        {
            get
            {
                return _CityID;
            }
            set
            {
                SetChange("CityID", value);
            }
        }
        private Int16 _PointX;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(4)]
        [EntityField("PointX")]
        public Int16 PointX
        {
            get
            {
                return _PointX;
            }
            set
            {
                SetChange("PointX", value);
            }
        }
        private Int16 _PointY;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(5)]
        [EntityField("PointY")]
        public Int16 PointY
        {
            get
            {
                return _PointY;
            }
            set
            {
                SetChange("PointY", value);
            }
        }
        private String _NickName;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(6)]
        [EntityField("NickName")]
        public String NickName
        {
            get
            {
                return _NickName;
            }
            set
            {
                SetChange("NickName", value);
            }
        }
        private Boolean _Sex;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(7)]
        [EntityField("Sex")]
        public Boolean Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                SetChange("Sex", value);
            }
        }
        private String _MercenariesID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(8)]
        [EntityField("MercenariesID")]
        public String MercenariesID
        {
            get
            {
                return _MercenariesID;
            }
            set
            {
                SetChange("MercenariesID", value);
            }
        }
        private Int16 _UserLv;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(9)]
        [EntityField("UserLv")]
        public Int16 UserLv
        {
            get
            {
                return _UserLv;
            }
            set
            {
                if (Callback != null && !IsLoading)
                {
                    Callback.BeginInvoke("UserLv", UserID, _UserLv, value, null, this);
                }
                SetChange("UserLv", value);
            }
        }
        private Int32 _ObtainNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(10)]
        [EntityField("ObtainNum")]
        public Int32 ObtainNum
        {
            get
            {
                return _ObtainNum;
            }
            set
            {
                if (Callback != null && !IsLoading)
                {
                    Callback.BeginInvoke("ObtainNum", UserID, _ObtainNum, value, null, this);
                }
                SetChange("ObtainNum", value);
            }
        }
        private Int16 _EnergyNum;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(11)]
        [EntityField("EnergyNum")]
        public Int16 EnergyNum
        {
            get
            {
                return _EnergyNum;
            }
            set
            {
                if (Callback != null && !IsLoading)
                {
                    Callback.BeginInvoke("EnergyNum", UserID, _EnergyNum, value, null, this);
                }
                SetChange("EnergyNum", value);
            }
        }
        private Int32 _GiftGold;
        /// <summary>
        /// ���͵ľ�ʯ
        /// </summary>
        [ProtoMember(12)]
        [EntityField("GiftGold")]
        public Int32 GiftGold
        {
            get
            {
                return _GiftGold;
            }
            set
            {
                if (Callback != null && !IsLoading)
                {
                    Callback.BeginInvoke("GiftGold", UserID, _GiftGold, value, null, this);
                }
                SetChange("GiftGold", value);
            }
        }
        private Int32 _PayGold;
        /// <summary>
        /// ��ֵ�ľ�ʯ
        /// </summary>
        [ProtoMember(13)]
        [EntityField("PayGold")]
        public Int32 PayGold
        {
            get
            {
                return _PayGold;
            }
            set
            {
                if (Callback != null && !IsLoading)
                {
                    Callback.BeginInvoke("PayGold", UserID, _PayGold, value, null, this);
                }
                SetChange("PayGold", value);
            }
        }
        private Int32 _ItemGold;
        /// <summary>
        /// ����ľ�ʯ
        /// </summary>
        [ProtoMember(14)]
        [EntityField("ItemGold")]
        public Int32 ItemGold
        {
            get
            {
                return _ItemGold;
            }
            set
            {
                if (Callback != null && !IsLoading)
                {
                    Callback.BeginInvoke("ItemGold", UserID, _ItemGold, value, null, this);
                }
                SetChange("ItemGold", value);
            }
        }
        private Int32 _UseGold;
        /// <summary>
        /// ���ľ�ʯ
        /// </summary>
        [ProtoMember(15)]
        [EntityField("UseGold")]
        public Int32 UseGold
        {
            get
            {
                return _UseGold;
            }
            set
            {
                if (Callback != null && !IsLoading)
                {
                    Callback.BeginInvoke("UseGold", UserID, _UseGold, value, null, this);
                }
                SetChange("UseGold", value);
            }
        }
        private Int32 _GameCoin;
        /// <summary>
        /// ��Ϸ�ң���ң�
        /// </summary>
        [ProtoMember(16)]
        [EntityField("GameCoin")]
        public Int32 GameCoin
        {
            get
            {
                return _GameCoin;
            }
            set
            {
                if (Callback != null && !IsLoading)
                {
                    Callback.BeginInvoke("GameCoin", UserID, _GameCoin, value, null, this);
                }
                SetChange("GameCoin", value);
            }
        }
        private Int32 _ExpNum;
        /// <summary>
        /// ����
        /// </summary>
        [ProtoMember(17)]
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
        [ProtoMember(18)]
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
        private UserStatus _UserStatus;
        /// <summary>
        ///  �û�״̬UserStatusö��
        /// </summary>
        [ProtoMember(19)]
        [EntityField("UserStatus")]
        public UserStatus UserStatus
        {
            get
            {
                return _UserStatus;
            }
            set
            {
                SetChange("UserStatus", value);
            }
        }
        private Boolean _MsgState;
        /// <summary>
        /// ����״̬false������true������
        /// </summary>
        [ProtoMember(20)]
        [EntityField("MsgState")]
        public Boolean MsgState
        {
            get
            {
                return _MsgState;
            }
            set
            {
                SetChange("MsgState", value);
            }
        }
        private Int32 _GridNum;
        /// <summary>
        /// �������ӿ������
        /// </summary>
        [ProtoMember(21)]
        [EntityField("GridNum")]
        public Int32 GridNum
        {
            get
            {
                return _GridNum;
            }
            set
            {
                SetChange("GridNum", value);
            }
        }
        private Int32 _WarehouseNum;
        /// <summary>
        /// �ֿ���ӿ������
        /// </summary>
        [ProtoMember(22)]
        [EntityField("WarehouseNum")]
        public Int32 WarehouseNum
        {
            get
            {
                return _WarehouseNum;
            }
            set
            {
                SetChange("WarehouseNum", value);
            }
        }
        private Int32 _CrystalNum;
        /// <summary>
        /// �����������ӿ�����
        /// </summary>
        [ProtoMember(23)]
        [EntityField("CrystalNum")]
        public Int32 CrystalNum
        {
            get
            {
                return _CrystalNum;
            }
            set
            {
                SetChange("CrystalNum", value);
            }
        }
        private Int16 _QueueNum;
        /// <summary>
        /// ǿ�����и���
        /// </summary>
        [ProtoMember(24)]
        [EntityField("QueueNum")]
        public Int16 QueueNum
        {
            get
            {
                return _QueueNum;
            }
            set
            {
                SetChange("QueueNum", value);
            }
        }
        private Int32 _UseMagicID;
        /// <summary>
        /// ʹ�õ���
        /// </summary>
        [ProtoMember(25)]
        [EntityField("UseMagicID")]
        public Int32 UseMagicID
        {
            get
            {
                return _UseMagicID;
            }
            set
            {
                SetChange("UseMagicID", value);
            }
        }
        private Int32 _TaskProgress;
        /// <summary>
        /// �����������
        /// </summary>
        [ProtoMember(26)]
        [EntityField("TaskProgress")]
        public Int32 TaskProgress
        {
            get
            {
                return _TaskProgress;
            }
            set
            {
                SetChange("TaskProgress", value);
            }
        }
        private Int32 _PlotProgress;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(100)]
        [EntityField("PlotProgress")]
        public Int32 PlotProgress
        {
            get
            {
                return _PlotProgress;
            }
            set
            {
                SetChange("PlotProgress", value);
            }
        }
        private DateTime _PlotCompleteDate;
        /// <summary>
        /// ����ͨ��ʱ��
        /// </summary>
        [ProtoMember(27)]
        [EntityField("PlotCompleteDate")]
        public DateTime PlotCompleteDate
        {
            get
            {
                return _PlotCompleteDate;
            }
            set
            {
                SetChange("PlotCompleteDate", value);
            }
        }
        private Int32 _RankID;
        /// <summary>
        /// ��������
        /// </summary>
        [ProtoMember(28)]
        [EntityField("RankID")]
        public Int32 RankID
        {
            get
            {
                return _RankID;
            }
            set
            {
                SetChange("RankID", value);
            }
        }
        private String _RetailID;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(29)]
        [EntityField("RetailID")]
        public String RetailID
        {
            get
            {
                return _RetailID;
            }
            set
            {
                SetChange("RetailID", value);
            }
        }
        private String _Pid;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(30)]
        [EntityField("Pid")]
        public String Pid
        {
            get
            {
                return _Pid;
            }
            set
            {
                SetChange("Pid", value);
            }
        }
        private MobileType _MobileType;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(31)]
        [EntityField("MobileType")]
        public MobileType MobileType
        {
            get
            {
                return _MobileType;
            }
            set
            {
                SetChange("MobileType", value);
            }
        }
        private Int16 _ScreenX;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(32)]
        [EntityField("ScreenX")]
        public Int16 ScreenX
        {
            get
            {
                return _ScreenX;
            }
            set
            {
                SetChange("ScreenX", value);
            }
        }
        private Int16 _ScreenY;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(33)]
        [EntityField("ScreenY")]
        public Int16 ScreenY
        {
            get
            {
                return _ScreenY;
            }
            set
            {
                SetChange("ScreenY", value);
            }
        }
        private Int16 _ClientAppVersion;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(34)]
        [EntityField("ClientAppVersion")]
        public Int16 ClientAppVersion
        {
            get
            {
                return _ClientAppVersion;
            }
            set
            {
                SetChange("ClientAppVersion", value);
            }
        }
        private DateTime _CreateDate;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(35)]
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
        private Location _UserLocation;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(36)]
        [EntityField("UserLocation")]
        public Location UserLocation
        {
            get
            {
                return _UserLocation;
            }
            set
            {
                SetChange("UserLocation", value);
            }
        }
        private SweepPoolInfo _SweepPool;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(37)]
        [EntityField(true, ColumnDbType.LongText)]
        public SweepPoolInfo SweepPool
        {
            get
            {
                return _SweepPool;
            }
            set
            {
                SetChange("SweepPool", value);
            }
        }
        private Int32 _ExtGold;
        /// <summary>
        /// ����ľ�ʯ
        /// </summary>
        [ProtoMember(38)]
        [EntityField("ExtGold")]
        public Int32 ExtGold
        {
            get
            {
                return _ExtGold;
            }
            set
            {
                SetChange("ExtGold", value);
            }
        }
        private DateTime _LoginTime;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(39)]
        [EntityField("LoginTime")]
        public DateTime LoginTime
        {
            get
            {
                return _LoginTime;
            }
            set
            {
                SetChange("LoginTime", value);
            }
        }
        private Int16 _SurplusEnergy;
        /// <summary>
        /// ��ȡ����
        /// </summary>
        [ProtoMember(40)]
        [EntityField("SurplusEnergy")]
        public Int16 SurplusEnergy
        {
            get
            {
                return _SurplusEnergy;
            }
            set
            {
                SetChange("SurplusEnergy", value);
            }
        }
        private GameUserExtend _UserExtend;
        /// <summary>
        /// 
        /// </summary>
        [ProtoMember(41)]
        [EntityField(true, ColumnDbType.LongText)]
        public GameUserExtend UserExtend
        {
            get
            {
                return _UserExtend;
            }
            set
            {
                SetChange("UserExtend", value);
            }
        }

        private string _CardID;
        /// <summary>
        ///  ���¿���
        /// </summary>
        [ProtoMember(42)]
        [EntityField("CardID")]
        public string CardID
        {
            get
            {
                return _CardID;
            }
            set
            {
                SetChange("CardID", value);
            }
        }

        private int _CardTimes;
        /// <summary>
        /// ���¿�����
        /// </summary>
        [ProtoMember(43)]
        [EntityField("CardTimes")]
        public int CardTimes
        {
            get
            {
                return _CardTimes;
            }
            set
            {
                SetChange("CardTimes", value);
            }
        }

        private int _VictoryNum;
        /// <summary>
        /// ��Ҿ�����ʤ
        /// </summary>
        [ProtoMember(67)]
        [EntityField("VictoryNum")]
        public int VictoryNum
        {
            get
            {
                return _VictoryNum;
            }
            set
            {
                SetChange("VictoryNum", value);
            }
        }
        private int _CombatNum;
        /// <summary>
        /// ���ս��
        /// </summary>
        [ProtoMember(68)]
        [EntityField("CombatNum")]
        public int CombatNum
        {
            get
            {
                return _CombatNum;
            }
            set
            {
                SetChange("CombatNum", value);
            }
        }

        private int _Leadership;
        /// <summary>
        /// ����쵼��
        /// </summary>
        [ProtoMember(69)]
        [EntityField("Leadership")]
        public int Leadership
        {
            get
            {
                return _Leadership;
            }
            set
            {
                SetChange("Leadership", value);
            }
        }
        private int _AbilityExperienceNum;
        /// <summary>
        /// �꼼����
        /// </summary>
        [ProtoMember(70)]
        [EntityField("AbilityExperienceNum")]
        public int AbilityExperienceNum
        {
            get
            {
                return _AbilityExperienceNum;
            }
            set
            {
                SetChange("AbilityExperienceNum", value);
            }
        }
        private int _HonourNum;
        /// <summary>
        /// ����ֵ
        /// </summary>
        [ProtoMember(71)]
        [EntityField("HonourNum")]
        public int HonourNum
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
        private Boolean _IsLv;
        /// <summary>
        /// FALSE:δ����TRUE������
        /// </summary>
        [ProtoMember(201)]
        [EntityField("IsLv")]
        public Boolean IsLv
        {
            get
            {
                return _IsLv;
            }
            set
            {
                SetChange("IsLv", value);
            }
        }

        private Decimal _SportsIntegral;
        /// <summary>
        /// </summary>        
        [ProtoMember(72)]
        [EntityField("SportsIntegral")]
        public Decimal SportsIntegral
        {
            get
            {
                return _SportsIntegral;
            }
            set
            {
                SetChange("SportsIntegral", value);
            }
        }

        private DateTime _RankDate;
        /// <summary>
        /// </summary>        
        [ProtoMember(73)]
        [EntityField("RankDate")]
        public DateTime RankDate
        {
            get
            {
                return _RankDate;
            }
            set
            {
                SetChange("RankDate", value);
            }
        }
        private DateTime _WizardDate;
        /// <summary>
        /// ����ף��
        /// </summary>        
        [ProtoMember(74)]
        [EntityField("WizardDate")]
        public DateTime WizardDate
        {
            get
            {
                return _WizardDate;
            }
            set
            {
                SetChange("WizardDate", value);
            }
        }
        private Int32 _WizardNum;
        /// <summary>
        /// ����ף������
        /// </summary>        
        [ProtoMember(75)]
        [EntityField("WizardNum")]
        public Int32 WizardNum
        {
            get
            {
                return _WizardNum;
            }
            set
            {
                SetChange("WizardNum", value);
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
                    case "CountryID": return CountryID;
                    case "CityID": return CityID;
                    case "PointX": return PointX;
                    case "PointY": return PointY;
                    case "NickName": return NickName;
                    case "Sex": return Sex;
                    case "MercenariesID": return MercenariesID;
                    case "UserLv": return UserLv;
                    case "ObtainNum": return ObtainNum;
                    case "EnergyNum": return EnergyNum;
                    case "GiftGold": return GiftGold;
                    case "PayGold": return PayGold;
                    case "ItemGold": return ItemGold;
                    case "UseGold": return UseGold;
                    case "GameCoin": return GameCoin;
                    case "ExpNum": return ExpNum;
                    case "VipLv": return VipLv;
                    case "UserStatus": return UserStatus;
                    case "MsgState": return MsgState;
                    case "GridNum": return GridNum;
                    case "WarehouseNum": return WarehouseNum;
                    case "CrystalNum": return CrystalNum;
                    case "QueueNum": return QueueNum;
                    case "UseMagicID": return UseMagicID;
                    case "TaskProgress": return TaskProgress;
                    case "PlotProgress": return PlotProgress;
                    case "PlotCompleteDate": return PlotCompleteDate;
                    case "RankID": return RankID;
                    case "RetailID": return RetailID;
                    case "Pid": return Pid;
                    case "MobileType": return MobileType;
                    case "ScreenX": return ScreenX;
                    case "ScreenY": return ScreenY;
                    case "ClientAppVersion": return ClientAppVersion;
                    case "CreateDate": return CreateDate;
                    case "UserLocation": return UserLocation;
                    case "SweepPool": return SweepPool;
                    case "ExtGold": return ExtGold;
                    case "LoginTime": return LoginTime;
                    case "SurplusEnergy": return SurplusEnergy;
                    case "UserExtend": return UserExtend;
                    case "SessionID": return SessionID;
                    case "CardID": return CardID;
                    case "CardTimes": return CardTimes;
                    case "VictoryNum": return VictoryNum;
                    case "CombatNum": return CombatNum;
                    case "Leadership": return Leadership;
                    case "AbilityExperienceNum": return AbilityExperienceNum;
                    case "HonourNum": return HonourNum;
                    case "SportsIntegral": return SportsIntegral;
                    case "RankDate": return RankDate;
                    case "IsLv": return IsLv;
                    case "WizardDate": return WizardDate;
                    case "WizardNum": return WizardNum;
                    default: throw new ArgumentException(string.Format("GameUser index[{0}] isn't exist.", index));
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
                    case "CountryID":
                        _CountryID = value.ToEnum<CountryType>();
                        break;
                    case "CityID":
                        _CityID = value.ToInt();
                        break;
                    case "PointX":
                        _PointX = value.ToShort();
                        break;
                    case "PointY":
                        _PointY = value.ToShort();
                        break;
                    case "NickName":
                        _NickName = value.ToNotNullString();
                        break;
                    case "Sex":
                        _Sex = value.ToBool();
                        break;
                    case "MercenariesID":
                        _MercenariesID = value.ToNotNullString();
                        break;
                    case "UserLv":
                        _UserLv = value.ToShort();
                        break;
                    case "ObtainNum":
                        _ObtainNum = value.ToInt();
                        break;
                    case "EnergyNum":
                        _EnergyNum = value.ToShort();
                        break;
                    case "GiftGold":
                        _GiftGold = value.ToInt();
                        break;
                    case "PayGold":
                        _PayGold = value.ToInt();
                        break;
                    case "ItemGold":
                        _ItemGold = value.ToInt();
                        break;
                    case "UseGold":
                        _UseGold = value.ToInt();
                        break;
                    case "GameCoin":
                        _GameCoin = value.ToInt();
                        break;
                    case "ExpNum":
                        _ExpNum = value.ToInt();
                        break;
                    case "VipLv":
                        _VipLv = value.ToInt();
                        break;
                    case "UserStatus":
                        _UserStatus = value.ToEnum<UserStatus>();
                        break;
                    case "MsgState":
                        _MsgState = value.ToBool();
                        break;
                    case "GridNum":
                        _GridNum = value.ToInt();
                        break;
                    case "WarehouseNum":
                        _WarehouseNum = value.ToInt();
                        break;
                    case "CrystalNum":
                        _CrystalNum = value.ToInt();
                        break;
                    case "QueueNum":
                        _QueueNum = value.ToShort();
                        break;
                    case "UseMagicID":
                        _UseMagicID = value.ToInt();
                        break;
                    case "TaskProgress":
                        _TaskProgress = value.ToInt();
                        break;
                    case "PlotProgress":
                        _PlotProgress = value.ToInt();
                        break;
                    case "PlotCompleteDate":
                        _PlotCompleteDate = value.ToDateTime();
                        break;
                    case "RankID":
                        _RankID = value.ToInt();
                        break;
                    case "RetailID":
                        _RetailID = value.ToNotNullString();
                        break;
                    case "Pid":
                        _Pid = value.ToNotNullString();
                        break;
                    case "MobileType":
                        _MobileType = value.ToEnum<MobileType>();
                        break;
                    case "ScreenX":
                        _ScreenX = value.ToShort();
                        break;
                    case "ScreenY":
                        _ScreenY = value.ToShort();
                        break;
                    case "ClientAppVersion":
                        _ClientAppVersion = value.ToShort();
                        break;
                    case "CreateDate":
                        _CreateDate = value.ToDateTime();
                        break;
                    case "UserLocation":
                        _UserLocation = value.ToEnum<Location>();
                        break;
                    case "SweepPool":
                        _SweepPool = ConvertCustomField<SweepPoolInfo>(value, index);
                        break;
                    case "ExtGold":
                        _ExtGold = value.ToInt();
                        break;
                    case "LoginTime":
                        _LoginTime = value.ToDateTime();
                        break;
                    case "SurplusEnergy":
                        _SurplusEnergy = value.ToShort();
                        break;
                    case "UserExtend":
                        _UserExtend = ConvertCustomField<GameUserExtend>(value, index);
                        break;
                    case "CardID":
                        _CardID = value.ToNotNullString();
                        break;
                    case "CardTimes":
                        _CardTimes = value.ToInt();
                        break;
                    case "VictoryNum":
                        _VictoryNum = value.ToInt();
                        break;
                    case "CombatNum":
                        _CombatNum = value.ToInt();
                        break;
                    case "Leadership":
                        _Leadership = value.ToInt();
                        break;
                    case "AbilityExperienceNum":
                        _AbilityExperienceNum = value.ToInt();
                        break;
                    case "HonourNum":
                        _HonourNum = value.ToInt();
                        break;
                    case "IsLv":
                        _IsLv = value.ToBool();
                        break;
                    case "SportsIntegral":
                        _SportsIntegral = value.ToDecimal();
                        break;
                    case "RankDate":
                        _RankDate = value.ToDateTime();
                        break;
                    case "WizardDate":
                        _WizardDate = value.ToDateTime();
                        break;
                    case "WizardNum":
                        _WizardNum = value.ToInt();
                        break;
                    default: throw new ArgumentException(string.Format("GameUser index[{0}] isn't exist.", index));
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

        /// <summary>
        /// �Ƿ������
        /// </summary>
        [ProtoMember(44)]
        public bool IsRefreshing { get; set; }

        private string _sessionID;
        /// <summary>
        /// �ڻ�������UserID��,�����浽Redis�У�����ʱ������ߣ�
        /// </summary>
        //[ProtoMember(45)]
        public string SessionID
        {
            get { return _sessionID; }
            set
            {
                _sessionID = value;
            }
        }

        [ProtoMember(46)]
        public int GameId { get; set; }
        /// <summary>
        /// ѡ��ID
        /// </summary>
        [ProtoMember(47)]
        public int ServerId { get; set; }

        /// <summary>
        /// �򸱱�Ԥ�ȿ۵ľ���
        /// </summary>
        [ProtoMember(48)]
        public int TempEnergyNum { get; set; }

        [ProtoMember(49)]
        public bool IsUseupItem { get; set; }

        public Int16 GeneralMaxNum
        {
            get
            {
                short result = 0;
                string[] generalNumList = ConfigEnvSet.GetString("UserGeneral.MaxGeneralNum").Split(new char[] { ',' });

                foreach (var str in generalNumList)
                {
                    string[] valueList = str.Split(new[] { '=' });
                    if (valueList.Length == 2)
                    {
                        if (UserLv >= valueList[0].ToInt())
                        {
                            result = valueList[1].ToShort();
                            break;
                        }
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        [ProtoMember(50)]
        public bool IsOnline
        {
            get;
            set;
        }
        
        /// <summary>
        /// �������ʱ��,�ų���ˢ�½ӿ�
        /// </summary>
        [ProtoMember(51)]
        public override DateTime OnlineDate
        {
            get;
            set;
        }

        /// <summary>
        /// �������ʱ��
        /// </summary>
        [ProtoMember(52)]
        public DateTime ChatDate
        {
            get;
            set;
        }

        /// <summary>
        /// ���븱��ʱ�䣬����������
        /// </summary>
        [ProtoMember(53)]
        public DateTime InPlotDate
        {
            get;
            set;
        }

        private int _ChatVesion;

        /// <summary>
        /// [��ʱ����]����汾
        /// </summary>
        [ProtoMember(54)]
        public int ChatVesion
        {
            get
            {
                return _ChatVesion;
            }
            set
            {
                _ChatVesion = value;
            }
        }

        /// <summary>
        /// [��ʱ����]�㲥�汾
        /// </summary>
        [ProtoMember(55)]
        public int BroadcastVesion
        {
            get;
            set;
        }

        /// <summary>
        /// ÿ��ĵ�һ�ε�¼ʱ��
        /// </summary>
        [ProtoMember(56)]
        public DateTime DailyLoginTime { get; set; }


        /// <summary>
        /// ս��Ӷ������
        /// </summary>
        public int GeneralAllCount { get; set; }
        /// <summary>
        /// ս����ɱӶ������
        /// </summary>
        public int GeneralKillCount { get; set; }

        /// <summary>
        /// [��ʱ����] ��¼ʱ��
        /// </summary>
        public int DayTime
        {
            get { return (int)(LoginTime - DateTime.Now).TotalSeconds; }
        }

        /// <summary>
        /// [ֻ��]��ǰԪ��
        /// </summary>
        public int GoldNum
        {
            get
            {
                var val = MathUtils.Addition(GiftGold, PayGold, int.MaxValue);
                val = MathUtils.Addition(val, ItemGold, int.MaxValue);
                val = MathUtils.Addition(val, ExtGold, int.MaxValue);
                val = MathUtils.Subtraction(val, UseGold, 0);
                return val;
            }
        }

        /// <summary>
        /// [��ʱ����]��������
        /// </summary>
        [ProtoMember(57)]
        public int GeneralID
        {
            get;
            set;
        }

        /// <summary>
        /// [��ʱ����]��������
        /// </summary>
        [ProtoMember(58)]
        public Int16 TrainingPower
        {
            get;
            set;
        }

        /// <summary>
        /// [��ʱ����]��������
        /// </summary>
        [ProtoMember(59)]
        public Int16 TrainingSoul
        {
            get;
            set;
        }

        /// <summary>
        /// [��ʱ����]��������
        /// </summary>
        [ProtoMember(60)]
        public Int16 TrainingIntellect
        {
            get;
            set;
        }
        /// <summary>
        /// �����Ӫ��1�ȹ��ţ�2��������
        /// </summary>
        [ProtoMember(61)]
        public CountryType GroupType { get; set; }

        /// <summary>
        /// ��ɫˮ��������ʱ��������DB
        /// </summary>
        [ProtoMember(62)]
        public CacheList<GrayCrystal> GrayCrystalList { get; set; }

        /// <summary>
        /// ������ս����־
        /// </summary>
        [ProtoMember(63)]
        public CacheQueue<SportsCombat> SportsCombatQueue { get; set; }
        /// <summary>
        /// ���Ἴ�ܼӳ�
        /// </summary>
        [ProtoMember(64)]
        public CacheList<GuildAbility> PropertyInfo { get; set; }

        /// <summary>
        /// ����Ӷ��
        /// </summary>
        [ProtoMember(65)]
        public CacheList<GeneralHeritage> HeritageList { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [ProtoMember(66)]
        public Int16 PotenceNum { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [ProtoMember(202)]
        public Int16 ThoughtNum { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        [ProtoMember(203)]
        public Int16 IntelligenceNum { get; set; }
        public List<SportsCombat> GetSportsCombat()
        {
            while (SportsCombatQueue.Count > SportsCombatMax)
            {
                SportsCombat item;
                SportsCombatQueue.TryDequeue(out item);
            }
            SportsCombat[] tempList = SportsCombatQueue.ToArray();
            return new List<SportsCombat>(tempList);
        }

        /// <summary>
        /// �Ƿ����͵ľ���
        /// </summary>
        [ProtoMember(204)]
        public bool IsSurplus { get; set; }

        /// <summary>
        /// ��������սƣ��ֵ
        /// </summary>
        [ProtoMember(205)]
        public int Fatigue { get; set; }

        /// <summary>
        /// Ӷ��������Ƭ����
        /// </summary>
        [ProtoMember(206)]
        public string GeneralCard { get; set; }
        /// <summary>
        /// Ӷ��������Ƭ���������
        /// </summary>
        [ProtoMember(207)]
        public string GeneralCardNum { get; set; }         //Ӷ��������Ƭ���������
        /// <summary>
        /// Ӷ��������Ƭ����
        /// </summary>
        [ProtoMember(208)]
        public List<UserFunction> OpenFun { get; set; }
        /// <summary>
        /// ʥ�����Ѷ�ϵ��
        /// </summary>
        [ProtoMember(209)]
        public decimal DifficultyNum { get; set; }

        /// <summary>
        /// 360Token
        /// </summary>
        [ProtoMember(210)]
        public string AccessToken { get; set; }
        /// <summary>
        /// 360Token����ʱ����
        /// </summary>
        [ProtoMember(211)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// �������俨һ��
        /// </summary>
        [ProtoMember(212)]
        public bool IsItem { get; set; }

        public void RemoveEnergyNum(short energyNum)
        {
            if (SurplusEnergy > 0)
            {
                IsSurplus = true;
                short subEnergy = 0;
                if (SurplusEnergy < energyNum)
                {
                    subEnergy = MathUtils.Subtraction(energyNum, SurplusEnergy);
                    SurplusEnergy = 0;
                    EnergyNum = MathUtils.Subtraction(EnergyNum, subEnergy, (short)0);
                }
                else
                {
                    SurplusEnergy = MathUtils.Subtraction(SurplusEnergy, energyNum);
                }
            }
            else
            {
                IsSurplus = false;
                EnergyNum = MathUtils.Subtraction(EnergyNum, (short)energyNum, (short)0);
            }
        }


        public void ResetSweepPool(int plotID)
        {
            if (SweepPool != null)
            {
                SweepPool.UpdateNotify(o =>
                {
                    SweepPoolInfo obj = o as SweepPoolInfo ?? new SweepPoolInfo();
                    obj.PlotID = plotID;
                    obj.TurnsNum = 0;
                    obj.BattleNum = 0;
                    return true;
                });
            }
        }

        /// <summary>
        /// ����Ƿ��������ǳ�
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsNickName(string name)
        {
            //return new PersonalCacheStruct<GameUser>().IsExist(u => u.NickName.ToLower() == name.ToLower().Trim());
            bool bl = false;
            bl = new PersonalCacheStruct<GameUser>().IsExist(u => u.NickName.ToLower() == name.ToLower().Trim());
            if (!bl)
            {
                var dbProvider = DbConnectionProvider.CreateDbProvider(DbConfig.Data);

                var command = dbProvider.CreateCommandStruct("GameUser", CommandMode.Inquiry, "NickName");
                command.Filter = dbProvider.CreateCommandFilter();
                command.Filter.Condition = command.Filter.FormatExpression("NickName");
                command.Filter.AddParam("NickName", name);
                command.Parser();
                using (var reader = dbProvider.ExecuteReader(CommandType.Text, command.Sql, command.Parameters))
                {
                    while (reader.Read())
                    {
                        bl = true;
                    }
                }
            }

            return bl;
        }


        public void AppendSparePart(UserSparePart sparePart)
        {
            var cacheSet = new PersonalCacheStruct<UserSparePackage>();
            UserSparePackage package = null;
            if (cacheSet.FindKey(UserID) == null)
            {
                package = new UserSparePackage() { UserID = UserID };
                cacheSet.Add(package);
            }
            package = cacheSet.FindKey(UserID);
            package.SparePackage.Add(sparePart);

            //package.Update();
        }

        public CacheList<UserSparePart> SparePartList
        {
            get
            {
                var cacheSet = new PersonalCacheStruct<UserSparePackage>();
                UserSparePackage package = cacheSet.FindKey(UserID);
                if (package != null)
                {
                    return package.SparePackage;
                }
                BaseLog log = new BaseLog();
                log.SaveLog(new NullReferenceException(string.Format("User:{0} spare package is null.", UserID)));
                return new CacheList<UserSparePart>();
                //return package != null ? package.SparePackage : new CacheList<UserSparePart>();
            }
        }

        public bool EnableSpareProperty(string sparepartId, out UserSparePart sparePart)
        {
            sparePart = null;
            var cacheSet = new PersonalCacheStruct<UserSparePackage>();
            UserSparePackage package = cacheSet.FindKey(UserID);
            if (package == null) return false;

            sparePart = package.SparePackage.Find(m => m.UserSparepartID.Equals(sparepartId));
            if (sparePart == null) return false;
            //[������]
            foreach (var property in sparePart.Propertys)
            {
                if (!property.IsEnable)
                {
                    var sparePartInfo = new ShareCacheStruct<SparePartInfo>().FindKey(sparePart.SparePartId) ?? new SparePartInfo();
                    var tempProperty = UserSparePart.RandomProperty(sparePartInfo, true, sparePart.Propertys);

                    property.UpdateNotify(obj =>
                    {
                        property.DefNum = tempProperty.DefNum;
                        property.NumRange = tempProperty.NumRange;
                        property.Rate = tempProperty.Rate;
                        property.ValueIndex = tempProperty.ValueIndex;
                        property.AbilityType = tempProperty.AbilityType;
                        property.Num = tempProperty.Num;
                        property.IsEnable = tempProperty.IsEnable;
                        //sparePart.OnChange();
                        return true;
                    });
                    break;
                }
            }

            return true;
        }

        public void RemoveSparePart(UserSparePart sparePart)
        {
            var cacheSet = new PersonalCacheStruct<UserSparePackage>();
            UserSparePackage package = cacheSet.FindKey(UserID);
            if (package == null)
            {
                return;
            }
            package.SparePackage.Remove(sparePart);
            //package.DelayChange();
        }

        public override string GetNickName()
        {
            return NickName;
        }

        public override string GetPassportId()
        {
            return Pid;
        }

        public override string GetRetailId()
        {
            return RetailID;
        }

        public override int GetUserId()
        {
            return UserID.ToInt();
        }

        public override bool IsLock
        {
            get { return UserStatus == UserStatus.FengJin; }
        }
    }
}