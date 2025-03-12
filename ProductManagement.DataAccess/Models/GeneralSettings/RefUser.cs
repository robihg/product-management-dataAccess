using ProductManagement.DataAccess.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.Models.GeneralSettings
{
    [Table("ref_user")]
    public class RefUser : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("guid")]
        public Guid Guid { get; set; } = Guid.NewGuid();

        [Required, StringLength(50)]
        [Column("name", TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required, StringLength(10)]
        [Column("username", TypeName = "varchar(10)")]
        public string Username { get; set; }

        [Required, EmailAddress, StringLength(50)]
        [Column("email")]
        public string Email { get; set; }


        [Required]
        [Column("password")]
        public string Password { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }
    }
}
