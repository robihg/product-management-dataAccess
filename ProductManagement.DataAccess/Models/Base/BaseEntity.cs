using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.DataAccess.Models.Base
{
    public abstract class BaseEntity
    {
        [Column("usr_crt")]
        public string UsrCrt { get; set; }

        [Column("usr_upd")]
        public string? UsrUpd { get; set; }

        [Column("dtm_crt")]
        public DateTime DtmCrt { get; set; }

        [Column("dtm_upd")]
        public DateTime? DtmUpd { get; set; }
    }
}
