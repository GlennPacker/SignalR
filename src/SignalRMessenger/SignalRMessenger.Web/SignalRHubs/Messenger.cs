using Microsoft.AspNet.SignalR;

namespace SignalRMessenger.Web.SignalRHubs
{
    public class Messenger : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}