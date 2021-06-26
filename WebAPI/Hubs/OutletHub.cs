using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BLC;

using Microsoft.AspNetCore.SignalR;

namespace WebAPI.Hubs
{
    public class OutletHub : Hub
    {
        public async void SubscribeToOutlet(Outlet[] ChangedOutlets)
        {
            await Clients.All.SendCoreAsync("FetchData", ChangedOutlets);
        }
    }
}
