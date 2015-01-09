using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.Script.CsScript.JsonProtocol
{
    /// <summary>
    /// Json result data
    /// </summary>
    public class ResultData
    {
        /// <summary>
        /// 
        /// </summary>
        public int MsgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ErrorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ErrorInfo { get; set; }

        /// <summary>
        /// logic data
        /// </summary>
        public object Data { get; set; }
    }
}
