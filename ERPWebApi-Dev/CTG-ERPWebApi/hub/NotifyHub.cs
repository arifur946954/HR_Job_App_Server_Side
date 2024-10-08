using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTG_ERPWebApi
{
    public class NotifyHub:Hub<ITypedHubClient>
    {
    }
}
