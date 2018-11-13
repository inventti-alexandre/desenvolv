using Frei.Projeto.VemProFut.DB.Time;
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

namespace Frei.Projeto.VemProFut.Telas.ModeloDeClubes
{
    public partial class FrmAlterar : Form
    {
        public FrmAlterar()
        {
            InitializeComponent();
        }

        private void FrmAlterar_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            TimeDTO dto = new TimeDTO();
            dto.br_bairro = txtbairro.Text;
            dto.cd_cidade = txtcidade.Text;
            dto.cp_cep = Convert.ToInt32(mktcep.Text);
            dto.cn_cnpj = Convert.ToInt32(mktrg.Text);
            dto.cp_complemento_endereco = txtcomplemento.Text;
            dto.dt_data_cadastro = dtpdatacadastro.Text;
            dto.em_email = txtapelido.Text;
            dto.so_site_oficial = txtaltura.Text;
            dto.tf_telefone_fixo = mkttelefone.Text;
            dto.tl_celular = Convert.ToInt32(mktcelular.Text);
            dto.fd_fundadores = txtposicao.Text;
            dto.lg_logo = ImagemPlugin.ConverterParaString(pbfotoTime.Image);
            dto.nm_estadio = txtpedo.Text;
            dto.nm_nomeclube = txtnome.Text;
            dto.nm_nome_mascara = txtcidade.Text;
            dto.nr_numero = txtnumerocasa.Text;
            dto.obs_onservacoes = txtobservacoes.Text;
            dto.ps_pais = txtpais.Text;
            dto.ra_rua = txtrua.Text;

            TimeBusiness business = new TimeBusiness();
            business.Alterar(dto);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmPrincipal tela = new frmPrincipal();
            tela.Show();
            ActiveControl.Hide();
        }
    }
}
