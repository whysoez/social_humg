using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Social_HUMG.Common.Entity
{
    public class TokenEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "bigint")]
        public long Id { get; set; }

        [Column("token")]
        public string? Token { get; set; }

        [Column("tokenexpdate")]
        public DateTime TokenExpDate { get; set; }

        [Column("created_user", TypeName = "bigint")]
        public long CreatedUser { get; set; }
    }
}
