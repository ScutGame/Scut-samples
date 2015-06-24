/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using System;
using System.Text;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Runtime;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.RPC.Sockets;
using ZyGames.Framework.Script;

namespace Game.Script
{
    public class MainClass : GameSocketHost, IMainScript
    {
        protected override void OnConnectCompleted(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine("客户端IP:[{0}]已与服务器连接成功", e.Socket.RemoteEndPoint);
            base.OnConnectCompleted(sender, e);
        }

        protected override void OnDisconnected(GameSession session)
        {
            Console.WriteLine("客户端UserId:[{0}]已与服务器断开", session.RemoteAddress);
            base.OnDisconnected(session);
        }

        protected override void OnHeartbeat(GameSession session)
        {
            Console.WriteLine("{0}>>Hearbeat package: {1} session count {2}", DateTime.Now.ToString("HH:mm:ss"), session.RemoteAddress, GameSession.Count);
            base.OnHeartbeat(session);
        }

        protected override void OnReceivedBefore(ConnectionEventArgs e)
        {
            Console.WriteLine(Encoding.UTF8.GetString(e.Data));
            base.OnReceivedBefore(e);
        }

        protected override void OnRequested(ActionGetter actionGetter, BaseGameResponse response)
        {
            Console.WriteLine(actionGetter.ToParamString());
            base.OnRequested(actionGetter, response);
        }

        protected override void OnStartAffer()
        {
        }

        protected override void OnServiceStop()
        {
            GameEnvironment.Stop();
        }
    }
}