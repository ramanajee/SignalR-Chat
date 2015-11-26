using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRChatDemo.BLL
{
    [HubName("Message")]
    public class MessageHandler:Hub
    {
       static List<string> clients = new List<string>(); 
        public void SendMessage(string clientid,string userName,string message)
        {
            if (!clients.Contains(clientid))
            {
                clients.Add(clientid);
            }
            Clients.Clients(clients).send(userName, message, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture));
        }
    }
}