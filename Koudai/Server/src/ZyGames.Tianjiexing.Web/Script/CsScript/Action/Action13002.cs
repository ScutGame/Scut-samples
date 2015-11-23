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
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Common;
using ZyGames.Tianjiexing.Model;
using ZyGames.Tianjiexing.Model.Config;

namespace ZyGames.Tianjiexing.BLL.Action
{

    /// <summary>
    /// 13002_领取新手礼包接口
    /// </summary>
    public class Action13002 : BaseAction
    {
        private int iD;


        public Action13002(ZyGames.Framework.Game.Contract.HttpGet httpGet)
            : base(ActionIDDefine.Cst_Action13002, httpGet)
        {

        }

        public override void BuildPacket()
        {

        }

        public override bool GetUrlElement()
        {
            if (httpGet.GetInt("ID", ref iD))
            {
                return true;
            }
            return false;
        }

        public override bool TakeAction()
        {
            NoviceActivities noviceActivities = new ShareCacheStruct<NoviceActivities>().FindKey(iD);
            if (noviceActivities != null)
            {
                var rewardArray = noviceActivities.Reward;

                if (rewardArray.Count > 0 && rewardArray[0].Type == 1)
                {
                    ContextUser.EnergyNum = MathUtils.Addition(ContextUser.EnergyNum, (short)rewardArray[0].Num, short.MaxValue);

                }
                else if (rewardArray.Count > 0 && rewardArray[0].Type == 4)
                {
                    ContextUser.GiftGold = MathUtils.Addition(ContextUser.GiftGold, rewardArray[0].Num, int.MaxValue);
                }
                //ContextUser.Update();
            }
            return true;
        }
    }
}