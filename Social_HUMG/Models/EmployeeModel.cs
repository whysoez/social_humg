using Social_HUMG.Common.Model;

namespace Social_HUMG.Models
{
    public class EmployeeModel : BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
    }
}
