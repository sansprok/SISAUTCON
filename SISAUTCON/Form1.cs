using MetroFramework;
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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            formConsultas.Show();
        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            FormEstadosCuenta formEstadosCuenta = new FormEstadosCuenta();
            formEstadosCuenta.Show();
        }

        private void btnPagoParcial_Click(object sender, EventArgs e)
        {
            FormPagoParcial formPagoParcial = new FormPagoParcial();
            formPagoParcial.Show();
        }

        private void btnCerrar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
