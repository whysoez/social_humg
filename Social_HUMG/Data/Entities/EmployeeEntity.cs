using System.ComponentModel.DataAnnotations;

namespace Social_HUMG.Data.Entities
{
    public class EmployeeEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone {  get; set; }
    }
}
