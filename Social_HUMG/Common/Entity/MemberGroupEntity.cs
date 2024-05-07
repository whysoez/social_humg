using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("member_group")]
    public class MemberGroupEntity : BaseEntity
    {
        [Column("group_id")]
        public Guid GroupId { get; set; }

        [Column("user_name")]
        public string? Username { get; set; }
    }
}
