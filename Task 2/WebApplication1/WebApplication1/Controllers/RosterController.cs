using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.GroupHub;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RosterController : ControllerBase
    {
        public class UserDetails
        {
            public string User { get; set; }
        }
        private IHubContext<ChatHub> HubContext{ get; set; }
        public RosterController(IHubContext<ChatHub> hubcontext)
        {
            HubContext = hubcontext;
        }
        [HttpPost]
        public async Task<IActionResult> AddToRosterGroup([FromBody] UserDetails user)
        {
            await HubContext.Clients.All.SendAsync("ReceiveMessage", user.User);
            return Ok($"{user.User} Has Add To Group");
        }
    }
}
