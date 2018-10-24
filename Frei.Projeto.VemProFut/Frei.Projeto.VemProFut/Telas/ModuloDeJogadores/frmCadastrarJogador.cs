using Frei.Projeto.VemProFut.DB.Jogadores;
using Frei.Projeto.VemProFut.Utilitarios;
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
    public partial class frmCadastrarJogador : Form
    {
        public frmCadastrarJogador()
        {
            InitializeComponent();
        }

        private void CarregarImagem()
        {
            try
            {

                OpenFileDialog openFile = new OpenFileDialog();
                DialogResult result = openFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pbfotojogador.ImageLocation = openFile.FileName;
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

        private void CEPDADOS()
        {
            APICorreios correios = new APICorreios();
            CorreiosDTO dto = correios.CEPDADOS(mktcep.Text);
            txtuf.Text = dto.UF;
            txtcidade.Text = dto.Cidade;
            txtbairro.Text = dto.Bairro;
            txtrua.Text = dto.Rua;
        }

        private void SalvarDados()
        {
            JogadoresDTO dto = new JogadoresDTO();

            dto.Nome = txtnome.Text;
            dto.Idade = int.Parse(txtidade.Text);
            dto.Nacionalidade = txtnacionalidade.Text;
            dto.Foto = ImagemPlugin.ConverterParaString(pbfotojogador.Image);
            dto.Cor = txtcor.Text;
            dto.NumeroCamisa = int.Parse(txtnumerocamisa.Text);
            dto.Posicao = txtposicao.Text;
            dto.Peso = decimal.Parse(txtpedo.Text);
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
            JogadoresBusiness business = new JogadoresBusiness();
            business.Salvar(dto);
            //Não esquecer de trocar a chave de clube quando o luiz terminar a parte dele
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarImagem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEPDADOS();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalvarDados();
           MessageBox.Show("Dados salvos com sucesso", "Futebol", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
