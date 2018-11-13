using Frei.Projeto.VemProFut.Telas.ModuloDeJogadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Projeto.VemProFut
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarJogador db = new frmCadastrarJogador();
            db.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarJogadores consultarJogadores = new frmConsultarJogadores();
            consultarJogadores.Show();
            this.Hide();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
