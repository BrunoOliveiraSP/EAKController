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
    public partial class frmMenuProfessor : Form
    {
        public frmMenuProfessor()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMelhoresAlunos tela = new frmMelhoresAlunos();
            tela.Show();

            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmMelhoresAlunos tela = new frmMelhoresAlunos();
            tela.Show();

            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmRankingTurmas tela = new frmRankingTurmas();
            tela.Show();

            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmRankingTurmas tela = new frmRankingTurmas();
            tela.Show();

            Hide();
        }
    }
}
