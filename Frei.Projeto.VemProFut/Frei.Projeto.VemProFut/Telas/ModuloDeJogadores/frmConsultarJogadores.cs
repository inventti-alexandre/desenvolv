using Frei.Projeto.VemProFut.DB.Jogadores;
using Frei.Projeto.VemProFut.Utilitarios.ImagenPlugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Projeto.VemProFut.Telas.ModuloDeJogadores
{
    public partial class frmConsultarJogadores : Form
    {
        public frmConsultarJogadores()
        {
            InitializeComponent();
            ConfigurarGrid();
        }
        private void ConfigurarGrid()
        {
            dgvjogador.AutoGenerateColumns = false;
        }

        private void CarregarDadosJogador()
        {
            JogadoresBusiness jogadores = new JogadoresBusiness();
            List<JogadoresViewDTO> view = jogadores.ConsultarporNome(txtnome.Text);
            JogadoresViewDTO dto = view[0];
            pbjogador.Image = ImagemPlugin.ConverterParaImagem(dto.Foto);
            dgvjogador.DataSource = view;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarDadosJogador();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            frmPrincipal menu = new frmPrincipal();
            menu.Show();
            this.Close();
        }

        private void dgvjogador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex ==27)
            {
                frmAlterarJogadores alterarJogadores = new frmAlterarJogadores();
                JogadoresViewDTO dto = dgvjogador.CurrentRow.DataBoundItem as JogadoresViewDTO;
                int idjogador, idclube;
                string nomeclube;
                idjogador = dto.Idjogador;
                idclube = dto.IDClube;
                nomeclube = dto.NomeClube;
                alterarJogadores.LoadScreen(idjogador, idclube, nomeclube);
                alterarJogadores.Show();
                this.Close();
            }

            if(e.ColumnIndex == 28)
            {
                JogadoresBusiness jogadores= new JogadoresBusiness();
                JogadoresViewDTO dto = dgvjogador.CurrentRow.DataBoundItem as JogadoresViewDTO;
                jogadores.Remover(dto.Idjogador);
                CarregarDadosJogador();
            }
        }
    }
}
