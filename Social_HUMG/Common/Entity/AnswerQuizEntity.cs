using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("anser_quiz")]
    public class AnswerQuizEntity : BaseEntity
    {
        [Column("QuizId")]
        public Guid QuizId { get; set; }

        [Column("anser")]
        public string? Answer { get; set; }

        [Column("point")]
        public float? Point { get; set; }

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
