using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace simplechat
{
    public class MessageHub : Hub
    {
        public void Hello(string name ,string message)
        {
            Clients.All.Helloo(name , message);
        }
    }
}