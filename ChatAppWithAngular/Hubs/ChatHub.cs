using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ChatAppWithAngular.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage1(string user, string message)               // Two parameters accepted
        {
            return Clients.All.SendAsync("ReceiveOne", user, message);    // Note this 'ReceiveOne' 
        }
    }
}
