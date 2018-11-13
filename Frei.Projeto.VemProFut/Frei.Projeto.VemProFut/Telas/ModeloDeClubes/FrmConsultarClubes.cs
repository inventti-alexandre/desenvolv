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
    public partial class FrmConsultarClubes : Form
    {
        public FrmConsultarClubes()
        {
            InitializeComponent();
        }

        private void FrmConsultarClubes_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TimeBusiness Times = new TimeBusiness();
            List<TimeViewDTO> View = Times.ConsultarporNome(txtnome.Text);
            TimeViewDTO dto = View[0];
            pbTime.Image = ImagemPlugin.ConverterParaImagem(dto.lg_logo);
            dgvTime.DataSource = View;
        }
    }
}
