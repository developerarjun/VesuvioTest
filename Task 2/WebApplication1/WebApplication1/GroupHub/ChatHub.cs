using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
    
namespace WebApplication1.GroupHub
{
    public class ChatHub : Hub
    {
        public async Task JoinRoster(string user)
        {
            await Clients.All.SendAsync("ReceiveMessage", user);
        }
    }
}
