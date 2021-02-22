using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWithAngular.ReqDTO
{
    public class MessageDto             // Data Transfer Object
    {
        public string User { get; set; }
        public string MsgText { get; set; }
    }
}
