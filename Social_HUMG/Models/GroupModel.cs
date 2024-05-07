using Social_HUMG.Common.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Models
{
    public class GroupModel : BaseModel
    {
        public string? ClassId { get; set; }
        public string? Avatar { get; set; }
        public string? Description { get; set; }

        public int GroupNumber { get; set; }
        public string Schedule { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public string? Teacher { get; set; }
        public string? Room { get; set; }
    }
}
