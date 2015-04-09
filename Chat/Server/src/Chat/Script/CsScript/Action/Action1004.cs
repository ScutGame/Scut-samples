using System;
using GameServer.Script.CsScript.JsonProtocol;
using GameServer.Script.Model;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Game.Context;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Contract.Action;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Game.Sns;
using ZyGames.Framework.Redis;
using ZyGames.Framework.RPC.Sockets;

namespace GameServer.Script.CsScript.Action
{
    public class MyLogin : ILogin
    {
        public MyLogin(string userName)
        {
            PassportID = userName;
            Password = string.Empty;
        }

        public string GetRegPassport()
        {
            return PassportID;
        }

        public bool CheckLogin()
        {
            var cache = new MemoryCacheStruct<ChatUser>();
            ChatUser chatUser = cache.Find(t => t.UserName == PassportID);
            if (chatUser != null)
            {
                UserID = chatUser.UserId.ToString();
                return true;
            }
            //not user create it.
            chatUser = new ChatUser()
            {
                UserId = (int)RedisConnectionPool.GetNextNo(typeof(ChatUser).FullName),
                UserName = PassportID,
                AccessTime = DateTime.Now
            };
            if (cache.TryAdd(chatUser.UserId.ToString(), chatUser))
            {
                UserID = chatUser.UserId.ToString();
                return true;
            }
            return false;
        }

        public string PassportID { get; private set; }
        public string UserID { get; private set; }
        public int UserType { get; private set; }
        public string Password { get; set; }
        public string SessionID { get; private set; }
    }

    /// <summary>
    /// login
    /// </summary>
    public class Action1004 : LoginAction
    {
        private string _userName;


        public Action1004(ActionGetter actionGetter)
            : base((short)1004, actionGetter)
        {
            IsWebSocket = true;
            actionGetter.OpCode = OpCode.Text;
        }

        /// <summary>
        /// 客户端请求的参数较验
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool GetUrlElement()
        {
            if (httpGet.GetString("UserName", ref _userName))
            {
                return true;
            }
            return false;
        }

        protected override ILogin CreateLogin()
        {
            return new MyLogin(_userName);
        }


        protected override bool DoSuccess(int userId, out IUser user)
        {
            user = null;
            var cache = new MemoryCacheStruct<ChatUser>();
            ChatUser chatUser = cache.Find(t => t.UserName == _userName);
            if (chatUser != null)
            {
                user = chatUser;
                return true;
            }
            return false;
        }

        protected override string BuildJsonPack()
        {
            ResultData resultData = new ResultData()
            {
                MsgId = actionGetter.GetMsgId(),
                ActionId = actionGetter.GetActionId(),
                ErrorInfo = "",
                Data = new UserData()
                {
                    UserId = Current.UserId,
                    SessionId = Current.SessionId
                }
            };
            return MathUtils.ToJson(resultData);
        }
    }
}
