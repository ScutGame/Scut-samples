using GameServer.Script.CsScript.JsonProtocol;
using ZyGames.Framework.Common;
using ZyGames.Framework.Game.Contract.Action;
using ZyGames.Framework.Game.Service;

namespace GameServer.Script.CsScript.Action
{
    public abstract class BaseAction : JsonAuthorizeAction
    {
        private ResultData _resultData;

        protected BaseAction(int aActionId, ActionGetter actionGetter)
            : base(aActionId, actionGetter)
        {
            _resultData = new ResultData()
            {
                MsgId = actionGetter.GetMsgId(),
                ActionId = actionGetter.GetActionId(),
                ErrorInfo = ""
            };
        }

        public object Body
        {
            set { _resultData.Data = value; }
        }

        protected override string BuildResponsePack()
        {
            return MathUtils.ToJson(_resultData);
        }
    }
}
