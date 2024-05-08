using Microsoft.AspNetCore.SignalR;
using Social_HUMG.Models;

namespace Social_HUMG.SignalR
{
    public class SignalrHub : Hub<IHubClient>
    {
        public async Task HPostMessage(List<PostDto> postDtos)
        {
            await Clients.All.PostMessage(postDtos);
        }
    }
}
