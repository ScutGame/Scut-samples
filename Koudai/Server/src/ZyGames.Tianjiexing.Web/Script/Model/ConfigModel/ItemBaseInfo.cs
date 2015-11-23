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
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Tianjiexing.Model.Enum;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.Model
{
    /// <summary>
    /// ��Ʒ������Ϣ��
    /// </summary>
    [Serializable, ProtoContract, EntityTable(AccessLevel.ReadOnly, DbConfig.Config)]
    public class ItemBaseInfo : ShareEntity
    {

        public const string Index_ItemType = "Index_ItemType";

        public ItemBaseInfo()
            : base(AccessLevel.ReadOnly)
        {
            ItemPack = new CacheList<PrizeInfo>(0, true);
        }

        #region auto-generated Property
        private Int32 _ItemID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemID", IsKey = true)]
        public Int32 ItemID
        {
            get
            {
                return _ItemID;
            }
            private set
            {
                SetChange("ItemID", value);
            }
        }
        private String _ItemName;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemName")]
        public String ItemName
        {
            get
            {
                return _ItemName;
            }
            private set
            {
                SetChange("ItemName", value);
            }
        }
        private String _HeadID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("HeadID")]
        public String HeadID
        {
            get
            {
                return _HeadID;
            }
            private set
            {
                SetChange("HeadID", value);
            }
        }
        private ItemType _ItemType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemType")]
        public ItemType ItemType
        {
            get
            {
                return _ItemType;
            }
            private set
            {
                SetChange("ItemType", value);
            }
        }
        private EquParts _EquParts;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EquParts")]
        public EquParts EquParts
        {
            get
            {
                return _EquParts;
            }
            private set
            {
                SetChange("EquParts", value);
            }
        }
        private QualityType _QualityType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("QualityType")]
        public QualityType QualityType
        {
            get
            {
                return _QualityType;
            }
            private set
            {
                SetChange("QualityType", value);
            }
        }
        private String _CareerRange;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("CareerRange")]
        public String CareerRange
        {
            get
            {
                return _CareerRange;
            }
            private set
            {
                SetChange("CareerRange", value);
            }
        }
        private Int16 _DemandLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("DemandLv")]
        public Int16 DemandLv
        {
            get
            {
                return _DemandLv;
            }
            private set
            {
                SetChange("DemandLv", value);
            }
        }
        private Int16 _MedicineType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MedicineType")]
        public Int16 MedicineType
        {
            get
            {
                return _MedicineType;
            }
            private set
            {
                SetChange("MedicineType", value);
            }
        }
        private Int16 _MedicineLv;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MedicineLv")]
        public Int16 MedicineLv
        {
            get
            {
                return _MedicineLv;
            }
            private set
            {
                SetChange("MedicineLv", value);
            }
        }
        private Int16 _MedicineNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MedicineNum")]
        public Int16 MedicineNum
        {
            get
            {
                return _MedicineNum;
            }
            private set
            {
                SetChange("MedicineNum", value);
            }
        }
        private Int16 _PropType;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PropType")]
        public Int16 PropType
        {
            get
            {
                return _PropType;
            }
            private set
            {
                SetChange("PropType", value);
            }
        }
        private Int32 _EffectNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EffectNum")]
        public Int32 EffectNum
        {
            get
            {
                return _EffectNum;
            }
            private set
            {
                SetChange("EffectNum", value);
            }
        }
        private Int32 _SalePrice;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("SalePrice")]
        public Int32 SalePrice
        {
            get
            {
                return _SalePrice;
            }
            private set
            {
                SetChange("SalePrice", value);
            }
        }
        private Int32 _PackMaxNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PackMaxNum")]
        public Int32 PackMaxNum
        {
            get
            {
                return _PackMaxNum;
            }
            private set
            {
                SetChange("PackMaxNum", value);
            }
        }
        private String _ItemDesc;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("ItemDesc")]
        public String ItemDesc
        {
            get
            {
                return _ItemDesc;
            }
            private set
            {
                SetChange("ItemDesc", value);
            }
        }
        private Int16 _EnableSale;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("EnableSale")]
        public Int16 EnableSale
        {
            get
            {
                return _EnableSale;
            }
            private set
            {
                SetChange("EnableSale", value);
            }
        }
        private Int32 _IsMystery;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("IsMystery")]
        public Int32 IsMystery
        {
            get
            {
                return _IsMystery;
            }
            private set
            {
                SetChange("IsMystery", value);
            }
        }
        private Int32 _DemandEnergy;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("DemandEnergy")]
        public Int32 DemandEnergy
        {
            get
            {
                return _DemandEnergy;
            }
            private set
            {
                SetChange("DemandEnergy", value);
            }
        }
        private Int32 _Version;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("Version")]
        public Int32 Version
        {
            get
            {
                return _Version;
            }
            private set
            {
                SetChange("Version", value);
            }
        }
        private CacheList<PrizeInfo> _ItemPack;
        /// <summary>
        /// 
        /// </summary>
        [EntityField(true, ColumnDbType.LongText)]
        public CacheList<PrizeInfo> ItemPack
        {
            get
            {
                return _ItemPack;
            }
            private set
            {
                SetChange("ItemPack", value);
            }
        }
        private String _PictrueID;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("PictrueID")]
        public String PictrueID
        {
            get
            {
                return _PictrueID;
            }
            private set
            {
                SetChange("PictrueID", value);
            }
        }
        private Int32 _MysteryNum;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MysteryNum")]
        public Int32 MysteryNum
        {
            get
            {
                return _MysteryNum;
            }
            private set
            {
                SetChange("MysteryNum", value);
            }
        }
        private Int32 _MysteryPrice;
        /// <summary>
        /// 
        /// </summary>
        [EntityField("MysteryPrice")]
        public Int32 MysteryPrice
        {
            get
            {
                return _MysteryPrice;
            }
            private set
            {
                SetChange("MysteryPrice", value);
            }
        }

        private bool _IsGold;
        /// <summary>
        /// �Ƿ���þ�ʯ�ϳ�
        /// </summary>
        [EntityField("IsGold")]
        public bool IsGold
        {
            get
            {
                return _IsGold;
            }
            private set
            {
                SetChange("IsGold", value);
            }
        }

        private GiftType _GiftType;
        /// <summary>
        /// �������� ����GiftTypeö��
        /// </summary>
        [EntityField("GiftType")]
        public GiftType GiftType
        {
            get
            {
                return _GiftType;
            }
            private set
            {
                SetChange("GiftType", value);
            }
        }

        private Int16 _SatiationNum;
        /// <summary>
        /// ʹ���������ӵ�Ӷ����ʳ��
        /// </summary>
        [EntityField("SatiationNum")]
        public Int16 SatiationNum
        {
            get
            {
                return _SatiationNum;
            }
            private set
            {
                SetChange("SatiationNum", value);
            }
        }

        private AbilityType _AbilityType;
        /// <summary>
        /// ����������
        /// </summary>
        [EntityField("AbilityType")]
        public AbilityType AbilityType
        {
            get
            {
                return _AbilityType;
            }
            private set
            {
                SetChange("AbilityType", value);
            }
        }

        private Boolean _IsUse;
        /// <summary>
        /// �Ƿ��ʹ��0��False����ʹ��1��True��ʹ��
        /// </summary>
        [EntityField("IsUse")]
        public Boolean IsUse
        {
            get
            {
                return _IsUse;
            }
            private set
            {
                SetChange("IsUse", value);
            }
        }
        private String _MaxHeadID;
        /// <summary>
        /// �Ƿ��ʹ��0��False����ʹ��1��True��ʹ��
        /// </summary>
        [EntityField("MaxHeadID")]
        public String MaxHeadID
        {
            get
            {
                return _MaxHeadID;
            }
            private set
            {
                SetChange("MaxHeadID", value);
            }
        }
        private Boolean _IsCostly;
        /// <summary>
        /// �Ƿ������ƷFALSE:�� TRUE:��
        /// </summary>
        [EntityField("IsCostly")]
        public Boolean IsCostly
        {
            get
            {
                return _IsCostly;
            }
            private set
            {
                SetChange("IsCostly", value);
            }
        }
        private Int32 _Athletics;
        /// <summary>
        /// ����������
        /// </summary>        
        [ProtoMember(31)]
        [EntityField("Athletics")]
        public Int32 Athletics
        {
            get
            {
                return _Athletics;
            }
            private set
            {
                SetChange("Athletics", value);
            }
        }
        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "ItemID": return ItemID;
                    case "ItemName": return ItemName;
                    case "HeadID": return HeadID;
                    case "ItemType": return ItemType;
                    case "EquParts": return EquParts;
                    case "QualityType": return QualityType;
                    case "CareerRange": return CareerRange;
                    case "DemandLv": return DemandLv;
                    case "MedicineType": return MedicineType;
                    case "MedicineLv": return MedicineLv;
                    case "MedicineNum": return MedicineNum;
                    case "PropType": return PropType;
                    case "EffectNum": return EffectNum;
                    case "SalePrice": return SalePrice;
                    case "PackMaxNum": return PackMaxNum;
                    case "ItemDesc": return ItemDesc;
                    case "EnableSale": return EnableSale;
                    case "IsMystery": return IsMystery;
                    case "DemandEnergy": return DemandEnergy;
                    case "Version": return Version;
                    case "ItemPack": return ItemPack;
                    case "PictrueID": return PictrueID;
                    case "MysteryNum": return MysteryNum;
                    case "MysteryPrice": return MysteryPrice;
                    case "IsGold": return IsGold;
                    case "GiftType": return GiftType;
                    case "SatiationNum": return SatiationNum;
                    case "AbilityType": return AbilityType;
                    case "IsUse": return IsUse;
                    case "MaxHeadID": return MaxHeadID;
                    case "IsCostly": return IsCostly;
                    case "Athletics": return Athletics;
                    default: throw new ArgumentException(string.Format("ItemBaseInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "ItemID":
                        _ItemID = value.ToInt();
                        break;
                    case "ItemName":
                        _ItemName = value.ToNotNullString();
                        break;
                    case "HeadID":
                        _HeadID = value.ToNotNullString();
                        break;
                    case "ItemType":
                        _ItemType = value.ToEnum<ItemType>();
                        break;
                    case "EquParts":
                        _EquParts = value.ToEnum<EquParts>();
                        break;
                    case "QualityType":
                        _QualityType = value.ToEnum<QualityType>();
                        break;
                    case "CareerRange":
                        _CareerRange = value.ToNotNullString();
                        break;
                    case "DemandLv":
                        _DemandLv = value.ToShort();
                        break;
                    case "MedicineType":
                        _MedicineType = value.ToShort();
                        break;
                    case "MedicineLv":
                        _MedicineLv = value.ToShort();
                        break;
                    case "MedicineNum":
                        _MedicineNum = value.ToShort();
                        break;
                    case "PropType":
                        _PropType = value.ToShort();
                        break;
                    case "EffectNum":
                        _EffectNum = value.ToInt();
                        break;
                    case "SalePrice":
                        _SalePrice = value.ToInt();
                        break;
                    case "PackMaxNum":
                        _PackMaxNum = value.ToInt();
                        break;
                    case "ItemDesc":
                        _ItemDesc = value.ToNotNullString();
                        break;
                    case "EnableSale":
                        _EnableSale = value.ToShort();
                        break;
                    case "IsMystery":
                        _IsMystery = value.ToInt();
                        break;
                    case "DemandEnergy":
                        _DemandEnergy = value.ToInt();
                        break;
                    case "Version":
                        _Version = value.ToInt();
                        break;
                    case "ItemPack":
                        _ItemPack =ConvertCustomField<CacheList<PrizeInfo>>(value, index); 
                        break;
                    case "PictrueID":
                        _PictrueID = value.ToNotNullString();
                        break;
                    case "MysteryNum":
                        _MysteryNum = value.ToInt();
                        break;
                    case "MysteryPrice":
                        _MysteryPrice = value.ToInt();
                        break;
                    case "IsGold":
                        _IsGold = value.ToBool();
                        break;
                    case "GiftType":
                        _GiftType = value.ToEnum<GiftType>();
                        break;
                    case "SatiationNum":
                        _SatiationNum = value.ToShort();
                        break;
                    case "AbilityType":
                        _AbilityType = value.ToEnum<AbilityType>();
                        break;
                    case "IsUse":
                        _IsUse = value.ToBool();
                        break;
                    case "MaxHeadID":
                        _MaxHeadID = value.ToNotNullString();
                        break;
                    case "IsCostly":
                        _IsCostly = value.ToBool();
                        break;
                    case "Athletics":
                        _Athletics = value.ToInt();
                        break; 
                    default: throw new ArgumentException(string.Format("ItemBaseInfo index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //allow modify return value
            return DefIdentityId;
        } /// <summary>
        /// �Ƿ����
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public static bool IsExist(int itemId)
        {
            return new ShareCacheStruct<ItemBaseInfo>().FindKey(itemId) != null;
        }

        /// <summary>
        /// ���ְҵ
        /// </summary>
        /// <param name="careerId"></param>
        /// <returns></returns>
        public bool CheckCareer(int careerId)
        {
            return CareerRange.IndexOf(careerId.ToString()) != -1;
        }
    }
}