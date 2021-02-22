using ChatAppWithAngular.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ChatAppWithAngular.ReqDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWithAngular.Controllers
{
    [Route("api/chat")]
    [ApiController]
    public class ChatController : Controller
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public ChatController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [Route("send")]                                           //path looks like this: https://localhost:44379/api/chat/send
        [HttpPost]
        public IActionResult SendRequest([FromBody] MessageDTO msg)
        {
            _hubContext.Clients.All.SendAsync("ReceiveOne", msg.user, msg.msgText);
            return Ok();
        }
    }
}
