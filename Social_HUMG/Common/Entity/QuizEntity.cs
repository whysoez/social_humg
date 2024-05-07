using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("quiz")]
    public class QuizEntity : BaseEntity
    {
        [Column("class_id")]
        public string? ClassId { get; set; }

        [Column("start_time")]
        public DateTime StartTime { get; set; }

        [Column("end_time")]
        public DateTime EndTime { get; set; }
    }
}
