using Social_HUMG.Common.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Data.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        [Column("description")]
        public string Description { get; set; }
        [Column("phone")]
        public string Phone {  get; set; }
    }
}
