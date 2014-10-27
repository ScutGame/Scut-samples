using System;
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Script;

namespace Game.Script
{
    public class MainClass : GameHttpHost
    {
        protected override void OnStartAffer()
        {
            ActionFactory.SetActionIgnoreAuthorize(1000, 1001);
        }

        protected override void OnRequested(ActionGetter actionGetter, BaseGameResponse response)
        {
            Console.WriteLine("url:{0}", actionGetter.ToParamString());
            base.OnRequested(actionGetter, response);
        }
    }
}