using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xamillionaire.Web.Models;

namespace Xamillionaire.Web
{
    public class MyHub : Hub
    {
        public void ShowVote(VoteAnswer ans)
        {
            Clients.All.ShowVote(ans);
        }
    }
}