using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAK.APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cboTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turma = cboTurma.Text;
            string aluno = cboAluno.Text;
            string disciplina = cboDisciplina.Text;
            int pontos = Convert.ToInt32(txtPontos.Text);
            string observacao = txtObservacao.Text;

            //Business.EakBusiness eakBusiness = new Business.EakBusiness();
            //eakBusiness.AdicionarRemoverPontos(turma, aluno, disciplina, pontos, observacao);
            //
            //if (btnAdd)
            //{
            //    MessageBox.Show("Pontos adicionados com sucesso")
            //} 
            
        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
