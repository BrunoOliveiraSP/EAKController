using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("tb_professor")]
    public partial class TbProfessor
    {
        public TbProfessor()
        {
            TbPonto = new HashSet<TbPonto>();
        }

        [Required]
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_senha", TypeName = "varchar(20)")]
        public string DsSenha { get; set; }
        [Key]
        [Column("id_professor")]
        public int IdProfessor { get; set; }
        [Required]
        [Column("nm_professor", TypeName = "varchar(100)")]
        public string NmProfessor { get; set; }

        [InverseProperty("IdProfessorNavigation")]
        public virtual ICollection<TbPonto> TbPonto { get; set; }
    }
}
