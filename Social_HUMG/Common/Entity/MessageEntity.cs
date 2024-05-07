using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_HUMG.Common.Entity
{

    [Table("message")]
    public class MessageEntity : BaseEntity
    {
        [Column("class_id")]
        public string? ClassId { get; set; }

        [Column("group_id")]
        public Guid GroupId { get; set; }

        [Column("message")]
        public string? MessageContent { get; set; }

        [RegularExpression("^(file|image|text)$", ErrorMessage = "Type must be either 'file', 'image', or 'text'")]
        [Column("type")]
        public string? Type { get; set; }

        [Column("linkFile")]
        public string? LinkFile { get; set; }

        [Column("fileName")]
        public string? FileName { get; set; }

        [Column("createUserId")]
        public string? CreateUserId { get; set; }

        [Column("createUserName")]
        public string? CreateUserName { get; set; }

        [Column("createUserImage")]
        public string? CreateUserImage { get; set; }
    }
}
