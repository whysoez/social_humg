using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("WebApiContext"));
        }

        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
