using Social_HUMG.Models;

namespace Social_HUMG.SignalR
{
    public interface IHubClient
    {
        Task PostMessage(List<PostDto> postDtos);
    }
}
