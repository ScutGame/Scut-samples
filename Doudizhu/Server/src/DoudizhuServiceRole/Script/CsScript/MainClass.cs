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
using ZyGames.Doudizhu.Bll;
using ZyGames.Doudizhu.Bll.Base;
using ZyGames.Doudizhu.Model;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Common.Configuration;
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Data;
using ZyGames.Framework.Game.Cache;
using ZyGames.Framework.Game.Com.Rank;
using ZyGames.Framework.Game.Context;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Runtime;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.RPC.Sockets;
using ZyGames.Framework.Script;

namespace Game.Script
{
    public class MainClass : GameSocketHost, IMainScript
    {
        public MainClass()
        {
        }

        protected override void OnConnectCompleted(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine("客户端IP:[{0}]已与服务器连接成功", e.Socket.RemoteEndPoint);
            base.OnConnectCompleted(sender, e);
        }

        protected override void OnDisconnected(GameSession session)
        {
            Console.WriteLine("客户端UserId:[{0}]已与服务器断开", session.EndAddress);
            base.OnDisconnected(session);
        }

        protected override void OnRequested(ActionGetter actionGetter, BaseGameResponse response)
        {
            Console.WriteLine("请求Action:{0}", actionGetter.GetActionId());
            base.OnRequested(actionGetter, response);
        }

        protected override void OnStartAffer()
        {
            try
            {
                ActionFactory.SetActionIgnoreAuthorize(1012, 9001, 9203);

                AppstoreClientManager.Current.InitConfig();
                LoadUnlineUser();
                InitRanking();
            }
            catch (Exception ex)
            {
                TraceLog.WriteError("OnStartAffer error:{0}", ex);
            }
        }

        protected override void OnServiceStop()
        {
            GameEnvironment.Stop();
        }
        private void LoadUnlineUser()
        {
            TraceLog.ReleaseWrite("正在加载玩家数据...");
            int loadUnlineDay = ConfigUtils.GetSetting("LoadUnlineDay", "3").ToInt();
            var ts = new TimeSpan(loadUnlineDay, 0, 0, 0);
            var cacheSet = new GameDataCacheSet<GameUser>();
            cacheSet.LoadFrom(t => MathUtils.DiffDate(t.LoginDate) < ts);
            TraceLog.ReleaseWrite("正在加载玩家结束");
        }

        /// <summary>
        /// 排行榜加载
        /// </summary>
        private static void InitRanking()
        {
            int timeOut = ConfigUtils.GetSetting("Ranking.timeout", "3600").ToInt();
            RankingFactory.Add(new BeansRanking());
            RankingFactory.Add(new WinRanking());

            RankingFactory.Start(timeOut);
        }
    }
}