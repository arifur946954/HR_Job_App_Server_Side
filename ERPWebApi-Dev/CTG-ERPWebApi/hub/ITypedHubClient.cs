using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTG_ERPWebApi
{
    public interface ITypedHubClient
    {
        Task BroadcastMessage(string jsonString);
    }
}
