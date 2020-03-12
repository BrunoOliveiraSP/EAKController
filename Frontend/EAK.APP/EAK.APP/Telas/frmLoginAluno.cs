using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAK.APP.Telas
{
    public partial class frmLoginAluno : Form
    {
        public frmLoginAluno()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            try
            {  
            Models.AlunoModel aluno = new Models.AlunoModel();
            aluno.DsEmail = txtUsuario.Text;
            aluno.DsSenha = txtSenha.Text;

            string email = aluno.DsEmail;
            string senha = aluno.DsSenha;
            
                if (email == null)
                {
                    throw new ArgumentException("E-mail inválido!!");
                }
                if(senha == null)
                {
                    throw new ArgumentException("Senha inválido!!");
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
