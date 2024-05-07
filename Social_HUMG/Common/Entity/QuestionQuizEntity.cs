using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("question_quiz")]
    public class QuestionQuizEntity : BaseEntity
    {
        [Column("quiz_id")]
        public Guid QuizId { get; set; }

        [Column("question")]
        public string? Question { get; set; }

        [Column("option1")]
        public string? Option1 { get; set; }

        [Column("option2")]
        public string? Option2 { get; set; }

        [Column("option3")]
        public string? Option3 { get; set; }

        [Column("option4")]
        public string? Option4 { get; set; }
    }
}
