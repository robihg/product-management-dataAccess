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

        [Column("name", TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column("username", TypeName = "varchar(10)")]
        public string Username { get; set; }
        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }
    }
}
