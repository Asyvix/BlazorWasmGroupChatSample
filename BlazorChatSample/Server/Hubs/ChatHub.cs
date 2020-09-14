using BlazorChatSample.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatSample.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendChat(ChatModel chat)
        {
            await Clients.All.SendAsync("ReceiveMessage", chat);
        }
    }
}
