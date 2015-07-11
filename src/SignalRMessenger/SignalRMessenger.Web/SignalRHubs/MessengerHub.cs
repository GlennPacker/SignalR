using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using SignalRMessenger.Web.Models;

namespace SignalRMessenger.Web.SignalRHubs
{
    public class MessengerHub : Hub
    {
        private static readonly List<ChatClient> ConnectedClientsList = new List<ChatClient>();

        public void Join(ChatClient chatClient)
        {
            ConnectedClientsList.Add(chatClient);
            Groups.Add(Context.ConnectionId, "groupa");
        }

        public void PushMessegeToClients(string msg)
        {
            Clients.All.addMessage(msg);
        }
    }
}