using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_serie_aluno")]
    public partial class TbSerieAluno
    {
        public TbSerieAluno()
        {
            TbPonto = new HashSet<TbPonto>();
        }

        [Column("id_aluno")]
        public int? IdAluno { get; set; }
        [Key]
        [Column("id_serie_aluno")]
        public int IdSerieAluno { get; set; }
        [Column("nr_ano")]
        public int NrAno { get; set; }
        [Column("nr_chamada")]
        public int NrChamada { get; set; }

        [ForeignKey(nameof(IdAluno))]
        [InverseProperty(nameof(TbAluno.TbSerieAluno))]
        public virtual TbAluno IdAlunoNavigation { get; set; }
        [InverseProperty("IdSerieAlunoNavigation")]
        public virtual ICollection<TbPonto> TbPonto { get; set; }
    }
}
