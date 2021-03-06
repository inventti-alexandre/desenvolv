﻿using Frei.Projeto.VemProFut.DB.Time;
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
    public partial class FrmCadastrarClubes : Form
    {
        public FrmCadastrarClubes()
        {
            InitializeComponent();
        }

        private void FrmCadastrarClubes_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void mktrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TimeDTO dto = new TimeDTO();
                dto.br_bairro = txtbairro.Text;
                dto.cd_cidade = txtcidade.Text;
                dto.cp_cep = mktcep.Text;
                dto.cn_cnpj = mktrg.Text;
                dto.cp_complemento_endereco = txtcomplemento.Text;
                dto.dt_data_cadastro = dtpdatacadastro.Text;
                dto.em_email = txtapelido.Text;
                dto.so_site_oficial = txtaltura.Text;
                dto.tf_telefone_fixo = mkttelefone.Text;
                dto.tl_celular = mktcelular.Text;
                dto.fd_fundadores = txtposicao.Text;
                dto.lg_logo = ImagemPlugin.ConverterParaString(pbfotoTime.Image);
                dto.nm_estadio = txtpedo.Text;
                dto.nm_nomeclube = txtnome.Text;
                dto.nm_nome_mascara = txtcidade.Text;
                dto.nr_numero = txtnumerocasa.Text;
                dto.obs_onservacoes = txtobservacoes.Text;
                dto.ps_pais = txtpais.Text;
                dto.ra_rua = txtrua.Text;
                dto.tf_telefone_fixo = mkttelefone.Text;

                TimeBusiness business = new TimeBusiness();
                business.Salvar(dto);

                MessageBox.Show("Time cadastrado com sucesso", "vem pro fut", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(ArgumentException ex)
            {
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
