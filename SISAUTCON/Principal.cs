using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISAUTCON
{
    public partial class Principal : MetroFramework.Forms.MetroForm
    {
        public Principal()
        {
            InitializeComponent();
            metroTile1.Padding = new Padding(10);
        }

        private void btnRequisitosTUPA_Click(object sender, EventArgs e)
        {
            Requisitos R = new Requisitos();
            R.ShowDialog();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaFiltro C = new ConsultaFiltro();
            C.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe");
        }
       
    }
}
