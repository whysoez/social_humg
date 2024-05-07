using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{
    [Table("user_login")]
    public class UserLoginEntity : BaseEntity
    {
        [Column("user")]
        public string? User { get; set; }
        [Column("password")]
        public string? Password { get; set; }
        [Column("password_hash")]
        public string? PasswordHash { get; set; }
    }
}
