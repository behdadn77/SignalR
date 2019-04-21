using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class ChatRoom : Hub
    {
        public async void SendMessageClientToServer(string userName, string message)
        {
            await Clients.All.SendAsync("SendMessageServerToClient", userName, message);
        }
    }
}
