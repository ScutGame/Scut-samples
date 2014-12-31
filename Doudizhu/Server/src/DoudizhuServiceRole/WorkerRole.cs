using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Game.Runtime;
using ZyGames.Framework.Script;

namespace DoudizhuServiceRole
{
    public class WorkerRole : RoleEntryPoint
    {
        private RuntimeHost runtimeHost = new RuntimeHost();

        public override void Run()
        {
            runtimeHost.Run();
        }

        public override bool OnStart()
        {
            //设置最大并发连接数
            ServicePointManager.DefaultConnectionLimit = 12;

            // 有关处理配置更改的信息，
            // 请参见 http://go.microsoft.com/fwlink/?LinkId=166357 上的 MSDN 主题。

            runtimeHost.OnStart();
            return base.OnStart();
        }


        public override void OnStop()
        {
            runtimeHost.Stop();
            base.OnStop();
        }

    }
}
