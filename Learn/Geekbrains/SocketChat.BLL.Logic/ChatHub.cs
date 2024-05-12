using Microsoft.AspNetCore.SignalR;
using SocketChat.Common.Entities;

namespace SocketChat.BLL.Logic
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("It's okay, you're connected");
        }

        public async Task Send(SignalRMessage message)
        {
            await Clients.All.SendAsync($"message: {message.Message}. From user: {Context.ConnectionId}");
        }

        public async Task SendToUser(SignalRMessage message)
        {
            var client = Clients.Client(message.ConnectionId);
            await client.SendAsync($"message: {message.Message}. From user: {message.FromUser}");
        }
    }
}
