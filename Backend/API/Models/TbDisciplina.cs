using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_disciplina")]
    public partial class TbDisciplina
    {
        public TbDisciplina()
        {
            TbPonto = new HashSet<TbPonto>();
        }

        [Key]
        [Column("id_disciplina")]
        public int IdDisciplina { get; set; }
        [Required]
        [Column("nm_disciplina", TypeName = "varchar(100)")]
        public string NmDisciplina { get; set; }

        [InverseProperty("IdDisciplinaNavigation")]
        public virtual ICollection<TbPonto> TbPonto { get; set; }
    }
}
