using Microsoft.Reporting.WinForms;
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
    public partial class FormPagoParcial : MetroFramework.Forms.MetroForm
    {
        public FormPagoParcial()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnImpuestoPredial_Click(object sender, EventArgs e)
        {
            generarFormulario("IP");
        }

        private void btnArbitrios_Click(object sender, EventArgs e)
        {
            generarFormulario("AR");
        }

        private void btnImpuestoVehicular_Click(object sender, EventArgs e)
        {
            generarFormulario("IV");
        }

        private void btnAlcabala_Click(object sender, EventArgs e)
        {
            generarFormulario("AC");
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            generarFormulario("Otros");
        }

        private void generarFormulario(String tipoImpuesto)
        {
            FormPagoParcialSeleccion formPagoParcialSeleccion = new FormPagoParcialSeleccion();
            formPagoParcialSeleccion.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formPagoParcialSeleccion.tipoImpuesto = tipoImpuesto;
            formPagoParcialSeleccion.Show();
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
