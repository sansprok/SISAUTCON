using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISAUTCON
{
    public partial class RequisitosDetallesVistaPrevia : MetroFramework.Forms.MetroForm
    {
        TributosedmxDataContext ConexionBD = new TributosedmxDataContext();
        public RequisitosDetallesVistaPrevia()
        {
            InitializeComponent();
        }

        private void RequisitosDetallesVistaPrevia_Load(object sender, EventArgs e)
        {
            //dgvRequerimientos.RowHeadersVisible = true;
            //dgvRequerimientos.DataSource = from R in ConexionBD.REQTUPA where R.FACODTRIBU == "IP" && R.FATIPOPERA == "INSCRIPCION" select new { DESCRIPCION= R.FADESCRIPCION };
            var texto= (from R in ConexionBD.REQTUPA where R.FACODTRIBU == "IP" && R.FATIPOPERA == "INSCRIPCION" select new { DESCRIPCION = R.FADESCRIPCION });
            foreach (var item in texto)
            {
                txtVistaPrevia.Text = txtVistaPrevia.Text + ""+ String.Format(Environment.NewLine) + item.DESCRIPCION.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaPreviaTicket vista = new VistaPreviaTicket();
            vista.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
