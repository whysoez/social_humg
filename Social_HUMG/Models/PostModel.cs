
using Social_HUMG.Common.Model;

namespace Social_HUMG.Models
{
    public class PostModel : BaseModel
    {
        public Guid PostParentId { set; get; }
        public Guid GroupId { get; set; }
        public string? GroupName { get; set; }
        public string Content { get; set; }
        public Guid MemberId { get; set; }
        public string MemberName { get; set; }
    }

    public class PostDto
    {
        public List<PostModel>? Posts { get; set; }
    }
}
