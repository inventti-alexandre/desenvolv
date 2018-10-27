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
    public partial class frmAlterarJogadores : Form
    {
        int idjogadores, idclubes;
        string nomeclube;
        public frmAlterarJogadores()
        {
            InitializeComponent();
        }

        public void LoadScreen(int idjogador,int idclube, string clube)
        {
            lblidjogador.Text = idjogador.ToString();
            lblclube.Text = clube;
            idjogadores = idjogador;
            idclubes = idclube;
            nomeclube = clube;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarregarJogar();
        }

        private void CarregarImagem()
        {
            try
            {

                OpenFileDialog openFile = new OpenFileDialog();
                DialogResult result = openFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pbjogador.ImageLocation = openFile.FileName;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!\n " + erro.Message,
                                "Back's",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }


        }

        private void CarregarJogar()
        {
            JogadoresBusiness business = new JogadoresBusiness();
            List<JogadoresDTO> lista = business.ConsultarpoId(idjogadores);
            JogadoresDTO dto = lista[0];

            txtnome.Text = dto.Nome;
            txtidade.Text = dto.Idade.ToString();
            txtnacionalidade.Text = dto.Nacionalidade;
            txtpeso.Text = dto.Peso.ToString();
            txtaltura.Text = dto.Altura.ToString();
            txtcor.Text = dto.Cor;
            mktnascimento.Text = dto.DataNascimento.ToString();
            txtapelido.Text = dto.Apelido;
            txtemail.Text = dto.Email;
            mktcep.Text = dto.CEP;
            mktrg.Text = dto.RG;
            mkttelefone.Text = dto.TelefoneFixo;
            mktcelular.Text = dto.Celular;
            dtpdatacadastro.Text = dto.DataCadastro.ToString();
            txtposicao.Text = dto.Posicao;
            txtnumerocamisa.Text = dto.NumeroCamisa.ToString();
            lblclube.Text = nomeclube;
            txtobservacoes.Text = dto.Observacoes;
            pbjogador.Image = ImagemPlugin.ConverterParaImagem(dto.Foto);
            txtpais.Text = dto.Pais;
            mktcpf.Text = dto.CPF;
            txtuf.Text = dto.EstadoUf;
            txtcidade.Text = dto.Cidade;
            txtbairro.Text = dto.Bairro;
            txtrua.Text = dto.Rua;
            txtnumerocasa.Text = dto.NumeroCasa;
            txtcomplemento.Text = dto.Complementoendereco;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalvarDadosdoJogador();
            MessageBox.Show("Dados alterados com sucesso", "Futebol", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarImagem();
        }

        private void SalvarDadosdoJogador()
        {
            JogadoresBusiness jogadores = new JogadoresBusiness();
            JogadoresDTO dto = new JogadoresDTO();

            dto.Idjogador = int.Parse(lblidjogador.Text);
            dto.Nome = txtnome.Text;
            dto.Idade = int.Parse(txtidade.Text);
            dto.Nacionalidade = txtnacionalidade.Text;
            dto.Foto = ImagemPlugin.ConverterParaString(pbjogador.Image);
            dto.Cor = txtcor.Text;
            dto.NumeroCamisa = int.Parse(txtnumerocamisa.Text);
            dto.Posicao = txtposicao.Text;
            dto.Peso = decimal.Parse(txtpeso.Text);
            dto.Altura = decimal.Parse(txtaltura.Text);
            dto.Pais = txtpais.Text;
            dto.EstadoUf = txtuf.Text;
            dto.Cidade = txtcidade.Text;
            dto.Bairro = txtbairro.Text;
            dto.Rua = txtrua.Text;
            dto.NumeroCasa = txtnumerocasa.Text;
            dto.CEP = mktcep.Text;
            dto.Complementoendereco = txtcomplemento.Text;
            dto.TelefoneFixo = mkttelefone.Text;
            dto.Celular = mktcelular.Text;
            dto.Email = txtemail.Text;
            dto.RG = mktrg.Text;
            dto.CPF = mktcpf.Text;
            dto.DataNascimento = DateTime.Parse(mktnascimento.Text);
            dto.DataCadastro = dtpdatacadastro.Value;
            dto.Apelido = txtapelido.Text;
            dto.Observacoes = txtobservacoes.Text;
            dto.FKClube = 1;

            jogadores.Alterar(dto);
            //fkclube está constante tem que mudar isso assim que o luiz fizer a parte dele, ela também está
            //constante na tela de cadastrar, e também adicionar o clube na tela para poder alterar o combo box 
            //já está lá só programar


        }
    }
}
