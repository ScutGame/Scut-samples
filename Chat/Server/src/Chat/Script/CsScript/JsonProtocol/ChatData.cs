using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Script.CsScript.JsonProtocol
{
    public class ChatData
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public int UserId { get; set; }

        public string Sender { get; set; }

        public string SendTime { get; set; }
    }
}
