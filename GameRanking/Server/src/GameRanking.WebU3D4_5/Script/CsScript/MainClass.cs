using System;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Runtime;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Script;

namespace Game.Script
{
    public class MainClass : GameHttpHost, IMainScript
    {
        public override void Start(string[] args)
        {
           GameEnvironment.Setting.ActionDispatcher = new CustomActionDispatcher();
        }

        public override void Stop()
        {

        }

        protected override void OnRequested(ActionGetter actionGetter, BaseGameResponse response)
        {
            base.OnRequested(actionGetter, response);
        }

    }
}