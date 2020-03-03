using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_aluno")]
    public partial class TbAluno
    {
        public TbAluno()
        {
            TbSerieAluno = new HashSet<TbSerieAluno>();
        }

        [Required]
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_senha", TypeName = "varchar(20)")]
        public string DsSenha { get; set; }
        [Key]
        [Column("id_aluno")]
        public int IdAluno { get; set; }
        [Required]
        [Column("nm_aluno", TypeName = "varchar(100)")]
        public string NmAluno { get; set; }

        [InverseProperty("IdAlunoNavigation")]
        public virtual ICollection<TbSerieAluno> TbSerieAluno { get; set; }
    }
}
