using System;
using System.Collections.Generic;
using GameServer.Script.Model;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Game.Context;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Contract.Action;
using ZyGames.Framework.Game.Lang;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Model;

namespace GameServer.Script.CsScript.Action
{

    /// <summary>
    /// 1005_创建角色接口
    /// </summary>
    public class Action1005 : RegisterAction
    {

        public Action1005(ActionGetter actionGetter)
            : base((short)ActionType.CreateRote, actionGetter)
        {

        }

        protected override bool GetActionParam()
        {
            return true;
        }


        protected override bool CreateUserRole(out IUser user)
        {
            user = null;
            if (UserName.Length < 2 || UserName.Length > 12)
            {
                ErrorCode = Language.Instance.ErrorCode;
                ErrorInfo = Language.Instance.St1005_UserNameNotEnough;
                return false;
            }
            var userCache = new PersonalCacheStruct<GameUser>();
            var roleCache = new PersonalCacheStruct<UserRole>();
            GameUser gameUser;
            if (userCache.TryFindKey(UserId.ToString(), out gameUser) == LoadingStatus.Success)
            {
                if (gameUser == null)
                {
                    gameUser = new GameUser
                    {
                        UserId = UserId,
                        PassportId = Pid,
                        RetailId = RetailID,
                        NickName = Pid
                    };
                    userCache.Add(gameUser);
                }
                user =new SessionUser(gameUser);
                UserRole role;
                if (roleCache.TryFind(gameUser.PersonalId, r => r.RoleName == UserName, out role) == LoadingStatus.Success)
                {
                    if (role == null)
                    {
                        role = new UserRole()
                        {
                            RoleId = (int)roleCache.GetNextNo(),
                            UserId = UserId,
                            RoleName = UserName,
                            HeadImg = HeadID,
                            Sex = Sex.ToBool(),
                            LvNum = 1,
                            ExperienceNum = 0,
                            LifeNum = 100,
                            LifeMaxNum = 100
                        };
                        roleCache.Add(role);
                        gameUser.CurrRoleId = role.RoleId;
                    }
                    return true;
                }
            }
            return false;
        }

        public override void BuildPacket()
        {

        }

        public override void TakeActionAffter(bool state)
        {
            var notifyUsers = new List<IUser>();
            notifyUsers.Add(Current.User);
            ActionFactory.SendAsyncAction(notifyUsers, (int)ActionType.World, null, t => { });
            base.TakeActionAffter(state);
        }
    }
}
