using System;
using System.Collections.Generic;
using GameServer.Script.Model;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Game.Context;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Contract.Action;
using ZyGames.Framework.Game.Service;

namespace GameServer.Script.CsScript.Action
{

    /// <summary>
    /// 1004_用户登录
    /// </summary>
    public class Action1004 : LoginExtendAction
    {
        public Action1004(ActionGetter actionGetter)
            : base((short)ActionType.Login, actionGetter)
        {
        }

        protected override bool DoSuccess(int userId, out IUser user)
        {
            user = null;
            var cacheSet = new PersonalCacheStruct<GameUser>();
            var roleCache = new PersonalCacheStruct<UserRole>();
            var roleList = roleCache.FindAll(Uid);
            GameUser gameUser = cacheSet.FindKey(Uid);
            if (gameUser == null || roleList.Count == 0)
            {
                //通知客户跳转到创建角色接口
                GuideId = 1005;
                return true;
            }
            user = new SessionUser(gameUser);
            if (gameUser.CurrRoleId == 0)
            {
                gameUser.CurrRoleId = roleList[0].RoleId;
            }

            return true;
        }

        public override void TakeActionAffter(bool state)
        {
            Console.WriteLine("1004>发送World通知...");
            var notifyUsers = new List<IUser>();
            notifyUsers.Add(Current.User);
            ActionFactory.SendAsyncAction(notifyUsers, (int)ActionType.World, null, t =>
            {
                Console.WriteLine("1004>发送World通知结果:{0}", t.Result.ToString());
            });
            base.TakeActionAffter(state);
        }
    }
}
