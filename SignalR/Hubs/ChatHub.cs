using Microsoft.AspNetCore.SignalR;
using SignalR.Contexts;
using SignalR.Models;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ILogger<ChatHub> logger;
        private readonly ChatDbContext context;

        public ChatHub(ILogger<ChatHub> logger, ChatDbContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        public async Task Send(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);

            Message msg = new Message()
            {
                MessageText = message,
                UserName = user
            };

            await context.Messages.AddAsync(msg);
            await context.SaveChangesAsync();

        }

        public async Task JoinGroup(string groupName, string userName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.OthersInGroup(groupName).SendAsync("NewMemberJoin", userName, groupName);
            logger.LogInformation(Context.ConnectionId);
        }

        public async Task SendMessageToGroup(string groupName, string sender, string message)
        {
            await Clients.Group(groupName).SendAsync("ReceiveMessageFromGroup", message, sender);
            Message msg = new Message()
            {
                MessageText = message,
                UserName = sender
            };
            await context.Messages.AddAsync(msg);
            await context.SaveChangesAsync();
        }
    }
}
