using System;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Runtime;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Script;

namespace Game.Script
{
    public class MainClass : GameHttpHost
    {
        public MainClass()
        {
            GameEnvironment.Setting.ActionDispatcher = new CustomActionDispatcher();
        }

        protected override void OnStartAffer()
        {
        }

        protected override void OnRequested(ActionGetter actionGetter, BaseGameResponse response)
        {
            Console.WriteLine("parma action:{0}", actionGetter.GetActionId());
            base.OnRequested(actionGetter, response);
        }

    }
}