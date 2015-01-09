using System.Text;
using GameServer.Script.CsScript.JsonProtocol;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Common;
using ZyGames.Framework.RPC.Sockets;

namespace GameServer.Script.CsScript
{
    public class WebSocketActionDispatcher : ScutActionDispatcher
    {

        public override ActionGetter GetActionGetter(RequestPackage package, GameSession session)
        {
            // 可以实现自定的ActionGetter子类
            return new HttpGet(package, session) { OpCode = OpCode.Text };
        }

        public override void ResponseError(BaseGameResponse response, ActionGetter actionGetter, int errorCode, string errorInfo)
        {
            var result = new ResultData()
            {
                MsgId = actionGetter.GetMsgId(),
                ActionId = actionGetter.GetActionId(),
                ErrorCode = errorCode,
                ErrorInfo = errorInfo,
                Data = null
            };
            //实现出错处理下发
            response.BinaryWrite(Encoding.UTF8.GetBytes(MathUtils.ToJson(result)));
        }
    }
}
