using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Social_HUMG.Common.Model
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Delete { get; set; }
        public int State { get; set; }
    }
}
