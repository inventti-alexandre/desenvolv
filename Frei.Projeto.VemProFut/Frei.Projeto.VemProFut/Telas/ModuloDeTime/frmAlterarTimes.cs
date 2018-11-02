using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frei.Projeto.VemProFut.DB.Time;

namespace Frei.Projeto.VemProFut.Telas.ModuloDeTime
{
    public partial class frmAlterarTimes : UserControl
    { 
            int  idclubes;
            string nomeclube;
            public frmAlterarTimes()
            {
                InitializeComponent();
            }

            private void frmAlterarTimes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeDTO dto = new TimeDTO();
            dto.br_bairro = txtbairro.Text;
            dto.cd_cidade = txtcidade.Text;
            dto.cp_cep = Convert.ToInt32(mktcep.Text);
            dto.cn_cnpj = Convert.ToInt32(mktrg.Text);
            dto.cp_complemento_endereco = txtcomplemento.Text;
            dto.dt_data_cadastro = dtpdatacadastro.Value;
            dto.em_email = txtapelido.Text;
            dto.so_site_oficial = txtaltura.Text;
            dto.tf_telefone_fixo = Convert.ToInt32(mkttelefone.Text);
            dto.tl_celular = Convert.ToInt32(mktcelular.Text);
            dto.fd_fundadores = txtposicao.Text;
            dto.lg_logo = ImagemPlugin.ConverterParaString(pbfotoTime.Image);
            dto.nm_estadio = txtpedo.Text;
            dto.nm_nomeclube = txtnome.Text;
            dto.nm_nome_mascara = txtcidade.Text;
            dto.nr_numero = Convert.ToInt32(txtnumerocasa.Text);
            dto.obs_onservacoes = txtobservacoes.Text;
            dto.ps_pais = txtpais.Text;
            dto.ra_rua = txtrua.Text;
            dto.tf_telefone_fixo = Convert.ToInt32(mkttelefone.Text);

            TimeBusiness business = new TimeBusiness();
            business.Alterar(dto);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFile = new OpenFileDialog();
                DialogResult result = openFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pbfotoTime.ImageLocation = openFile.FileName;
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
    }
}
