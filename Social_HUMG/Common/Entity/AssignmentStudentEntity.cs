using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("assigment_student")]
    public class AssignmentStudentEntity : BaseEntity
    {
        [Column("AssigmentId")]
        public Guid AssigmentId { get; set; }

        [Column("user_name")]
        public string? Username { get; set; }

        [Column("point")]
        public float? Point { get; set; }

        [Column("file_name")]
        public string? FileName { get; set; }

        [Column("gpa")]
        public float Gpa { get; set; }

        public void UpdateGPA()
        {
            if (Point == null)
            {
                Gpa = 0.0f;
            }
            else if (Point >= 8.5)
            {
                Gpa = 4.0f;
            }
            else if (Point >= 8.0)
            {
                Gpa = 3.5f;
            }
            else if (Point >= 7.0)
            {
                Gpa = 3.0f;
            }
            else if (Point >= 6.5)
            {
                Gpa = 2.5f;
            }
            else if (Point >= 5.5)
            {
                Gpa = 2.0f;
            }
            else if (Point >= 5.0)
            {
                Gpa = 1.5f;
            }
            else if (Point >= 4.0)
            {
                Gpa = 1.0f;
            }
            else
            {
                Gpa = 0.0f;
            }
        }
    }
}
