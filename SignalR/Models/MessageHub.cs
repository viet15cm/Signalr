﻿using Microsoft.AspNetCore.SignalR;
using System.Linq;

namespace SignalR.Models
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            if (string.IsNullOrEmpty(user))
                await Clients.All.SendAsync("ReceiveMessageHandler", message);
            else
                await Clients.User(user).SendAsync("ReceiveMessageHandler", message);
        }

        

    }
}
