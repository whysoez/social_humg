using Microsoft.EntityFrameworkCore;
using Social_HUMG.Common.Entity;
using Social_HUMG.Data.Entities;

namespace Social_HUMG.Data
{
    public class SocialDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public SocialDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            var connectionString = _configuration.GetConnectionString("WebApiContext");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<EmployeeEntity> Employee { get; set; }
        public DbSet<AnswerQuizEntity> AnswerQuiz { get; set; }
        public DbSet<AssignmentEntity> Assignment { get; set; }
        public DbSet<AssignmentStudentEntity> AssignmentStudent { get; set; }
        public DbSet<GroupEntity> Group { get; set; }
        public DbSet<MemberGroupEntity> MemberGroup { get; set; }
        public DbSet<MessageEntity> Message { get; set; }
        public DbSet<QuestionQuizEntity> QuestionQuiz { get; set; }
        public DbSet<QuizEntity> Quiz { get; set; }
        public DbSet<VoteEntity> Vote { get; set; }
        public DbSet<VoteOptionEntity> VoteOption { get; set; }
        public DbSet<PostEntity> Post { get; set; }
    }
}
