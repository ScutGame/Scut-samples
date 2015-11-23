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
using ZyGames.Framework.Common;
using ZyGames.Tianjiexing.Model;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Cache.Generic;

namespace ZyGames.Tianjiexing.BLL.Action
{

    /// <summary>
    /// 1026_可创建佣兵列表接口
    /// </summary>
    public class Action1026 : BaseStruct
    {
        private List<GeneralInfo> generalList = new List<GeneralInfo>();

        public Action1026(ZyGames.Framework.Game.Contract.HttpGet httpGet)
            : base(ActionIDDefine.Cst_Action1026, httpGet)
        {

        }

        public override void BuildPacket()
        {
            PushIntoStack(generalList.Count);
            foreach (var general in generalList)
            {
                AbilityInfo abilityInfo = new ShareCacheStruct<AbilityInfo>().FindKey(general.AbilityID);
                DataStruct dsItem = new DataStruct();
                dsItem.PushIntoStack(general.GeneralID);
                dsItem.PushIntoStack(general.GeneralName.ToNotNullString());
                dsItem.PushIntoStack(general.HeadID.ToNotNullString());
                dsItem.PushIntoStack(abilityInfo == null ? string.Empty : abilityInfo.AbilityName.ToNotNullString());
                dsItem.PushIntoStack(general.Description.ToNotNullString());
                PushIntoStack(dsItem);
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
            generalList = new ShareCacheStruct<GeneralInfo>().FindAll();
            return true;
        }
    }
}