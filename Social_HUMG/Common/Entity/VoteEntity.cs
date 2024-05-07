using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("vote")]
    public class VoteEntity : BaseEntity
    {
        [Column("class_id")]
        public string? ClassId { get; set; }
    }
}
