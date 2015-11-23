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
using System.Collections.Generic;
using System.Linq;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Common;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Game.Service;
using ZyGames.Tianjiexing.Model.Config;
using ZyGames.Tianjiexing.Model.DataModel;
using ZyGames.Tianjiexing.BLL.Base;

namespace ZyGames.Tianjiexing.BLL.Action
{

    /// <summary>
    /// 12002_我的宝藏列表接口
    /// </summary>
    public class Action12002 : BaseAction
    {
        private string rewardName;
        private List<TreasureInfo> treasureList = new List<TreasureInfo>();

        public Action12002(ZyGames.Framework.Game.Contract.HttpGet httpGet)
            : base(ActionIDDefine.Cst_Action12002, httpGet)
        {

        }

        public override void BuildPacket()
        {
            this.PushIntoStack(treasureList.Count);
            foreach (var treasure in treasureList)
            {
                rewardName = DialHelper.PrizeItemName(treasure);
                DataStruct dsItem = new DataStruct();
                dsItem.PushIntoStack((short)treasure.Type);
                dsItem.PushIntoStack(rewardName.ToNotNullString());
                dsItem.PushIntoStack((int)treasure.Num);

                this.PushIntoStack(dsItem);
            }
        }

        public override bool GetUrlElement()
        {
            if (true)
            {
                return true;
            }
        }

        public override bool TakeAction()
        {
            DialHelper.CheckDialNum(ContextUser.UserID);
            var userDial = new PersonalCacheStruct<UserDial>().FindKey(ContextUser.UserID);
            if (userDial != null && userDial.Treasure.Count > 0)
            {
                treasureList = (userDial.Treasure.Reverse()).ToList();
            }
            return true;
        }
    }
}