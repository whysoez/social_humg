using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("group")]
    public class GroupEntity : BaseEntity
    {
        [Column("class_id")]
        public string? ClassId { get; set; }

        [Column("avatar")]
        public string? Avatar { get; set; }

        [Column("description")]
        public string? Description { get; set; }
        [Column("group_number")]
        public int GroupNumber { get; set; }
        [Column("schedule")]
        public string Schedule { get; set; }
        [Column("time_start")]
        public DateTime? TimeStart { get; set; }
        [Column("time_end")]
        public DateTime? TimeEnd { get; set; }
        [Column("teacher")]
        public string? Teacher { get; set; }
        [Column("room")]
        public string? Room { get; set; }
    }
}
