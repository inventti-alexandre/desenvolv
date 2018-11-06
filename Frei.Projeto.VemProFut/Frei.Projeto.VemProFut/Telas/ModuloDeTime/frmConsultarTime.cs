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
using Frei.Projeto.VemProFut.Utilitarios.ImagenPlugin;

namespace Frei.Projeto.VemProFut.Telas.ModuloDeTime
{
    public partial class frmConsultarTime : UserControl
    {
        public void CarregardadosTime()
        {
            TimeBusiness Times = new TimeBusiness();
            List<TimeViewDTO> View = Times.ConsultarporNome(txtnome.Text);
            TimeViewDTO dto = View[0];
            pbTime.Image = ImagemPlugin.ConverterParaImagem(dto.lg_logo);
            dgvTime.DataSource = View;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregardadosTime();
        }

        private void dgvTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6){
                AlterarTime AlterarTime = new AlterarTime();
                TimeViewDTO dto = dgvTime.CurrentRow.DataBoundItem as TimeViewDTO;

                AlterarTime.CarregarCampos(dto.id_clubes.ToString());
                AlterarTime.Show();
            }
            if(e.ColumnIndex == 7)
            {
                TimeBusiness Time = new TimeBusiness();
                TimeViewDTO dto = dgvTime.CurrentRow.DataBoundItem as TimeViewDTO;
                Time.Remover(dto.id_clubes);
                CarregardadosTime();
            }
        }
    }
}
