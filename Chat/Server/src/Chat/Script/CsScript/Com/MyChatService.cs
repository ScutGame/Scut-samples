using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer.Script.Model;
using ServiceStack.Redis;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Game.Message;
using ZyGames.Framework.Game.Model;

namespace GameServer.Script.CsScript.Com
{
    public class MyChatService : ChatService
    {
        private readonly ChatUser _user;
        private const int MsgTimeOut = 30;//分钟

        public MyChatService(ChatUser user)
            : base(user.UserId)
        {
            var tempUser = GetUser(user.UserId);
            if (!tempUser.Equals(user))
            {
                Console.WriteLine("user error.");
                _user = tempUser;
            }
            else
            {
                _user = user;
            }
        }

        public void Send(string message)
        {
            Send(new ChatMessage()
            {
                Version = NextVersion,
                Content = FilterMessage(message),
                FromUserID = _user.UserId,
                SendDate = DateTime.Now
            });
        }

        public List<ChatMessage> PopMessages()
        {
            return Receive();
        }

        protected override List<ChatMessage> GetRange(List<ChatMessage> msgList)
        {
            //int index = msgList.Count / 50;
            //int pageCount;
            //return msgList.GetPaging(index, 50, out pageCount);
            return msgList;
        }

        protected override bool HasReceive(ChatMessage message)
        {
            var m = message;
            if (m == null)
                return false;
            if (m.Version <= _user.ChatVesion)
                return false;
            if (m.SendDate.AddMinutes(MsgTimeOut) <= DateTime.Now)
                return false;
            _user.ChatVesion = m.Version;
            Console.WriteLine("user:{0} set chat ver:{1}", _user.UserName, _user.ChatVesion);
            return true;
        }

        private ChatUser GetUser(int userId)
        {
            var cache = new MemoryCacheStruct<ChatUser>();
            ChatUser chatUser;
            if (cache.TryGet(userId.ToString(), out chatUser))
            {
                return chatUser;
            }
            return null;
        }

        protected override string FilterMessage(string message)
        {
            return message;
        }

        protected override void WriteLog(ChatMessage message)
        {
        }
    }
}
