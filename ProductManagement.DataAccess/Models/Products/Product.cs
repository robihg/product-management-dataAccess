using ProductManagement.DataAccess.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.Models.Products
{
    [Table("product")]
    public class Product : BaseEntity
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

        [Required]
        [Column("description", TypeName = "text")]
        public string Description { get; set; }

        [Required]
        [Column("price", TypeName = "decimal(17,2)")]
        public decimal Price { get; set; }
    }
}
