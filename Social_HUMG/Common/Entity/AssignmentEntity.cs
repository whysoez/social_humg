using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("assignment")]
    public class AssignmentEntity : BaseEntity
    {
        [Column("class_id")]
        public string? ClassId { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("file_name")]
        public string? FileName { get; set; }

        [Column("due_day")]
        public DateTime DueDay { get; set; }
    }
}
