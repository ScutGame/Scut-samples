using GameServer.Script.CsScript.Com;
using GameServer.Script.Model;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.RPC.Sockets;

namespace GameServer.Script.CsScript.Action
{
    /// <summary>
    /// Send chat
    /// </summary>
    public class Action3001 : BaseAction
    {
        private string _message;


        public Action3001(ActionGetter actionGetter)
            : base((short)3001, actionGetter)
        {
            IsNotRespond = true;
        }

        /// <summary>
        /// 客户端请求的参数较验
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool GetUrlElement()
        {
            if (httpGet.GetString("message", ref _message) && !string.IsNullOrEmpty(_message))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 业务逻辑处理
        /// </summary>
        /// <returns>false:中断后面的方式执行并返回Error</returns>
        public override bool TakeAction()
        {
            var chatservice = new MyChatService(Current.User as ChatUser);
            chatservice.Send(_message);
            return true;
        }

        protected override string BuildResponsePack()
        {
            Body = true;
            return base.BuildResponsePack();
        }


        public override void TakeActionAffter(bool state)
        {
            ActionFactory.SendAsyncAction(GameSession.GetOnlineAll(), 3002, null, (s, r) => { }, OpCode.Text, 0).Wait();
            base.TakeActionAffter(state);
        }
    }
}
