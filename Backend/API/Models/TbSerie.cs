using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_serie")]
    public partial class TbSerie
    {
        [Key]
        [Column("id_serie")]
        public int IdSerie { get; set; }
        [Required]
        [Column("nm_serie", TypeName = "varchar(30)")]
        public string NmSerie { get; set; }
        [Column("nr_serie")]
        public int NrSerie { get; set; }
        [Required]
        [Column("tp_periodo", TypeName = "varchar(20)")]
        public string TpPeriodo { get; set; }
    }
}
