using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRTutorial
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        [HubMethodName("announceToEverybody")]
        public void Announce(string message)
        {
            Clients.All.Announce(message); // broadcasts to all
            // Clients.Caller.DisplayDateTime(); // broadcasts to the one who called
        }

        public DateTime GetServerDateTime()
        {
            return DateTime.Now;
        }
    }
}