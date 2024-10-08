using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTG_ERPWebApi
{
    public class rglHub : Hub
    {
        //[EnableCors("AppPolicy")]
        public async Task GetNotification()
        {
            int notification = 0;
            await Clients.All.SendAsync("BCastNotification", notification);
        }
    }
}
