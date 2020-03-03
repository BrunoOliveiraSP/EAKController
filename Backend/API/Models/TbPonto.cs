using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_ponto")]
    public partial class TbPonto
    {
        [Required]
        [Column("ds_observacao", TypeName = "varchar(500)")]
        public string DsObservacao { get; set; }
        [Column("dt_adicionado", TypeName = "datetime")]
        public DateTime DtAdicionado { get; set; }
        [Column("id_disciplina")]
        public int? IdDisciplina { get; set; }
        [Key]
        [Column("id_ponto")]
        public int IdPonto { get; set; }
        [Column("id_professor")]
        public int? IdProfessor { get; set; }
        [Column("id_serie_aluno")]
        public int? IdSerieAluno { get; set; }
        [Column("qt_pontos", TypeName = "decimal(15,2)")]
        public decimal QtPontos { get; set; }

        [ForeignKey(nameof(IdDisciplina))]
        [InverseProperty(nameof(TbDisciplina.TbPonto))]
        public virtual TbDisciplina IdDisciplinaNavigation { get; set; }
        [ForeignKey(nameof(IdProfessor))]
        [InverseProperty(nameof(TbProfessor.TbPonto))]
        public virtual TbProfessor IdProfessorNavigation { get; set; }
        [ForeignKey(nameof(IdSerieAluno))]
        [InverseProperty(nameof(TbSerieAluno.TbPonto))]
        public virtual TbSerieAluno IdSerieAlunoNavigation { get; set; }
    }
}
