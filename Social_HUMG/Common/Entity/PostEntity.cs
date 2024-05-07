using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    public class PostEntity : BaseEntity
    {
        [Column("post_parent")]
        public Guid PostParentId { set; get; }
        [Column("groupId")]
        public Guid GroupId { get; set; }
        [Column("group_name")]
        public string? GroupName { get; set; }
        [Column("content")]
        public string Content { get; set; }
        [Column("memberId")]
        public Guid MemberId { get; set; }
        [Column("member_name")]
        public string MemberName { get; set; }
    }
}
