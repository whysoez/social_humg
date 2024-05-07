using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    public class BaseEntity
    {
        [Key()]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("name")]
        public string? Title { get; set; }
        [Column("create_By")]
        public Guid CreatedBy { get; set; }
        [Column("created_Date")]
        public DateTime CreatedDate { get; set; }
        [Column("modified_By")]
        public Guid ModifiedBy { get; set; }
        [Column("codified_Date")]
        public DateTime ModifiedDate { get; set; }
        [Column("delete")]
        public bool Delete { get; set; }
        [Column("state")]
        public int State { get; set; }
    }
}
