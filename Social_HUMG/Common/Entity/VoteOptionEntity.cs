using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("vote_option")]
    public class VoteOptionEntity : BaseEntity
    {
        [Column("vote_id")]
        public Guid VoteId { get; set; }

        [Column("data")]
        public string? Data { get; set; }
    }
}
