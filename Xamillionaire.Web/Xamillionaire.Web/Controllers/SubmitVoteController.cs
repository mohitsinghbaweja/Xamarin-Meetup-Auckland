using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Xamillionaire.Web.Models;

namespace Xamillionaire.Web.Controllers
{
    public class SubmitVoteController : ApiController
    {
        // POST: api/SubmitVote
        public void Post([FromBody]VoteAnswer value)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            context.Clients.All.ShowVote(value);
        }
    }
}
