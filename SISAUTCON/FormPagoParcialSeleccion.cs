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
    public partial class FormPagoParcialSeleccion : MetroFramework.Forms.MetroForm
    {
        public String tipoImpuesto;

        public FormPagoParcialSeleccion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            FormPagoParcialCodigoDocIdentidad formPagoParcialCodigoDocIdentidad = new FormPagoParcialCodigoDocIdentidad();
            formPagoParcialCodigoDocIdentidad.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formPagoParcialCodigoDocIdentidad.tipoDocumento = "Codigo";
            formPagoParcialCodigoDocIdentidad.nroCaracteres = 7;
            formPagoParcialCodigoDocIdentidad.tipoImpuesto = tipoImpuesto;
            formPagoParcialCodigoDocIdentidad.Show();
        }

        private void btnDocumentoIdentidad_Click(object sender, EventArgs e)
        {
            FormPagoParcialCodigoDocIdentidad formPagoParcialCodigoDocIdentidad = new FormPagoParcialCodigoDocIdentidad();
            formPagoParcialCodigoDocIdentidad.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formPagoParcialCodigoDocIdentidad.tipoDocumento = "DocumentoIdentidad";
            formPagoParcialCodigoDocIdentidad.nroCaracteres = 11;
            formPagoParcialCodigoDocIdentidad.tipoImpuesto = tipoImpuesto;
            formPagoParcialCodigoDocIdentidad.Show();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            FormPagoParcialNombre formPagoParcialNombre = new FormPagoParcialNombre();
            formPagoParcialNombre.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formPagoParcialNombre.tipoImpuesto = tipoImpuesto;
            formPagoParcialNombre.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
