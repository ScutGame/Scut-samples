using System;
using GameServer.Script.CsScript.Com;
using GameServer.Script.CsScript.JsonProtocol;
using GameServer.Script.Model;
using ZyGames.Framework.Game.Service;
using System.Collections.Generic;
using ZyGames.Framework.Game.Model;
using ZyGames.Framework.Cache.Generic;

namespace GameServer.Script.CsScript.Action
{
    /// <summary>
    /// chat list
    /// </summary>
    public class Action3002 : BaseAction
    {
        private List<ChatMessage> chatList;

        public Action3002(ActionGetter actionGetter)
            : base((short)3002, actionGetter)
        {

        }

        /// <summary>
        /// 客户端请求的参数较验
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool GetUrlElement()
        {
            return true;
        }

        /// <summary>
        /// 业务逻辑处理
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool TakeAction()
        {
            var chatservice = new MyChatService(Current.User as ChatUser);
            chatList = chatservice.PopMessages();
            return true;
        }


        protected override string BuildResponsePack()
        {
            var result = new ChatData[chatList.Count];
            for (int i = 0; i < chatList.Count; i++)
            {
                var chat = chatList[i];
                result[i] = new ChatData()
                {
                    Id = chat.Version,
                    UserId = chat.FromUserID,
                    Message = chat.Content,
                    Sender = GetUserName(chat.FromUserID),
                    SendTime = chat.SendDate.ToString("HH:mm:ss")
                };
            }
            Body = result;
            return base.BuildResponsePack();
        }

        private string GetUserName(int userId)
        {
            var cache = new MemoryCacheStruct<ChatUser>();
            ChatUser user;
            if (cache.TryGet(userId.ToString(), out user))
            {
                return user.UserName;
            }
            return string.Empty;
        }

    }
}

