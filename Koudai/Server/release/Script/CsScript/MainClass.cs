using System;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Service;
using ZyGames.Tianjiexing.BLL.Base;

namespace Game.Script
{
    public class MainClass : GameHttpHost
    {
        public override void Stop()
        {
            SystemGlobal.Stop();
            base.Stop();
        }

        protected override void OnStartAffer()
        {
            SystemGlobal.Run();
        }

        protected override void OnRequested(ActionGetter actionGetter, BaseGameResponse response)
        {
            Console.WriteLine("actionId:{0}, userId:{1}", actionGetter.GetActionId(), actionGetter.GetUserId());
            base.OnRequested(actionGetter, response);
        }
    }
}