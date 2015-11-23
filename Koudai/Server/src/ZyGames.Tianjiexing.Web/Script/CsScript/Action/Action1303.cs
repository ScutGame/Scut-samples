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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Common;
using ZyGames.Tianjiexing.Model;
using ZyGames.Tianjiexing.BLL.Base;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.BLL.Action
{

    /// <summary>
    /// 1303_猎取命运水晶列表接口
    /// </summary>
    public class Action1303 : BaseAction
    {
        private int freeNum = 0;
        private int isSale = 0;
        private int issTelegrams = 0;
        //private List<UserCrystal> userCrystalArray = new UserCrystal[0];
        private List<GrayCrystal> grayCrystalArray = new List<GrayCrystal>();
        private List<UserLight> userLightArray = new List<UserLight>();

        public Action1303(ZyGames.Framework.Game.Contract.HttpGet httpGet)
            : base(ActionIDDefine.Cst_Action1303, httpGet)
        {

        }

        public override void BuildPacket()
        {
            PushIntoStack(ContextUser.GoldNum);
            PushIntoStack(ContextUser.GameCoin);
            PushIntoStack(freeNum);
            PushIntoStack(isSale);
            PushIntoStack(issTelegrams);
            PushIntoStack(grayCrystalArray.Count);
            foreach (GrayCrystal crystal in grayCrystalArray)
            {
                CrystalInfo crystalInfo = new ShareCacheStruct<CrystalInfo>().FindKey(crystal.CrystalID) ?? new CrystalInfo();
                DataStruct dsItem = new DataStruct();
                dsItem.PushIntoStack(crystal.UserCrystalID);
                dsItem.PushIntoStack(crystalInfo.CrystalID);
                dsItem.PushIntoStack(crystalInfo.CrystalName.ToNotNullString());
                dsItem.PushIntoStack(crystalInfo.HeadID.ToNotNullString());
                dsItem.PushIntoStack((short)crystalInfo.CrystalQuality);
                PushIntoStack(dsItem);
            }
            PushIntoStack(userLightArray.Count);
            foreach (UserLight light in userLightArray)
            {
                ProbabilityInfo probabilityInfo = new ShareCacheStruct<ProbabilityInfo>().FindKey(light.HuntingID);
                DataStruct dsItem = new DataStruct();
                dsItem.PushIntoStack(light.HuntingID);
                dsItem.PushIntoStack(probabilityInfo == null ? 0 : probabilityInfo.Price);
                dsItem.PushIntoStack(light.IsLight);
                PushIntoStack(dsItem);
            }
        }

        public override bool GetUrlElement()
        {
            return true;
        }

        public override bool TakeAction()
        {
            UserHelper.GetUserLightOpen(ContextUser.UserID);
            DailyRestrainSet dailyRestrainSet = new ShareCacheStruct<DailyRestrainSet>().FindKey(RestrainType.MianFeiLieMing);
            UserDailyRestrain userRestrain = new PersonalCacheStruct<UserDailyRestrain>().FindKey(ContextUser.UserID);
            if (dailyRestrainSet != null && userRestrain != null)
            {
                if (DateTime.Now.Date == userRestrain.RefreshDate.Date)
                {
                    freeNum = VipHelper.GetVipUseNum(ContextUser.VipLv, RestrainType.MianFeiLieMing);
                    freeNum = MathUtils.Subtraction(freeNum, userRestrain.Funtion2, 0);
                }
                else
                {
                    freeNum = VipHelper.GetVipUseNum(ContextUser.VipLv, RestrainType.MianFeiLieMing);
                }
            }

            userLightArray = new PersonalCacheStruct<UserLight>().FindAll(ContextUser.UserID);
            userLightArray.QuickSort((x, y) =>
            {
                if (x == null && y == null) return 0;
                if (x != null && y == null) return 1;
                if (x == null) return -1;
                return x.HuntingID.CompareTo(y.HuntingID);
            });
            bool allowSale;
            bool allowTake;
            grayCrystalArray = CrystalHelper.GetNotSaleCrystalNum(ContextUser, out allowSale, out allowTake);
            grayCrystalArray.QuickSort((x, y) =>
            {
                if (x == null && y == null) return 0;
                if (x != null && y == null) return 1;
                if (x == null) return -1;
                return x.CreateDate.CompareTo(y.CreateDate);
            });
            isSale = allowSale ? 1 : 2;
            issTelegrams = allowTake ? 1 : 2;
            return true;
        }
    }
}