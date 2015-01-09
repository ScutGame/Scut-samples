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
using GameServer.Script.CsScript;
using GameServer.Script.Model;
using ZyGames.Framework.Game.Contract;
using ZyGames.Framework.Game.Runtime;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Redis;
using ZyGames.Framework.RPC.Sockets;

namespace Game.Script
{
    public class MainClass : GameWebSocketHost
    {
        public MainClass()
        {
            GameEnvironment.Setting.ActionDispatcher = new WebSocketActionDispatcher();
        }

        protected override void OnStartAffer()
        {
        }

        protected override void OnServiceStop()
        {
            GameEnvironment.Stop();
        }

        protected override void OnHandshaked(ISocket sender, ConnectionEventArgs e)
        {
            Console.WriteLine("Client {0} connect to server.", e.Socket.RemoteEndPoint);
            base.OnHandshaked(sender, e);
        }

        protected override void OnRequested(ActionGetter actionGetter, BaseGameResponse response)
        {
            Console.WriteLine("Receice actionId:{0}", actionGetter.GetActionId());
            base.OnRequested(actionGetter, response);
        }

        protected override void OnError(ISocket sender, ConnectionEventArgs e)
        {
            Console.WriteLine("Server send to {0} data error.", e.Socket.RemoteEndPoint);
            base.OnError(sender, e);
        }

        protected override void OnClosedStatus(ExSocket socket, int closeStatusCode)
        {
            Console.WriteLine("Receive client {0} close status code {1}.", socket.RemoteEndPoint, closeStatusCode);
        }

        protected override void OnDisconnected(GameSession session)
        {
            var user = session.User as ChatUser;
            if (user != null)
            {
                user.ChatVesion = 0;
            }
            Console.WriteLine("Client {0} is closed.", session.RemoteAddress);
            base.OnDisconnected(session);
        }
    }
}