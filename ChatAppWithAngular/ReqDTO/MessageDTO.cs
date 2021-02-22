using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWithAngular.ReqDTO
{
    public class MessageDTO             // Data Transfer Object
    {
        public string user { get; set; }
        public string msgText { get; set; }
    }
}
