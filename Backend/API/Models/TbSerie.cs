using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_serie")]
    public partial class TbSerie
    {
        public TbSerie()
        {
            TbSerieAluno = new HashSet<TbSerieAluno>();
        }

        [Key]
        [Column("id_serie")]
        public int IdSerie { get; set; }
        [Required]
        [Column("nm_serie", TypeName = "varchar(30)")]
        public string NmSerie { get; set; }
        [Required]
        [Column("tp_periodo", TypeName = "varchar(20)")]
        public string TpPeriodo { get; set; }

        [InverseProperty("IdSerieNavigation")]
        public virtual ICollection<TbSerieAluno> TbSerieAluno { get; set; }
    }
}
