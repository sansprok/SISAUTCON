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
    public partial class FormEstadosCuentaSeleccion : MetroFramework.Forms.MetroForm
    {
        public String tipoImpuesto;

        public FormEstadosCuentaSeleccion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            FormEstadosCuentaCodigoDocIdentidad formEstadosCuentaCodigoDocIdentidad = new FormEstadosCuentaCodigoDocIdentidad();
            formEstadosCuentaCodigoDocIdentidad.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formEstadosCuentaCodigoDocIdentidad.tipoDocumento = "Codigo";
            formEstadosCuentaCodigoDocIdentidad.tipoImpuesto = tipoImpuesto;
            formEstadosCuentaCodigoDocIdentidad.nroCaracteres = 7;
            formEstadosCuentaCodigoDocIdentidad.Show();
        }
        
        private void btnDocumentoIdentidad_Click(object sender, EventArgs e)
        {
            FormEstadosCuentaCodigoDocIdentidad formEstadosCuentaCodigoDocIdentidad = new FormEstadosCuentaCodigoDocIdentidad();
            formEstadosCuentaCodigoDocIdentidad.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formEstadosCuentaCodigoDocIdentidad.tipoDocumento = "DocumentoIdentidad";
            formEstadosCuentaCodigoDocIdentidad.tipoImpuesto = tipoImpuesto;
            formEstadosCuentaCodigoDocIdentidad.nroCaracteres = 11;
            formEstadosCuentaCodigoDocIdentidad.Show();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            FormEstadosCuentaNombre formEstadosCuentaNombre = new FormEstadosCuentaNombre();
            formEstadosCuentaNombre.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formEstadosCuentaNombre.tipoImpuesto = tipoImpuesto;
            formEstadosCuentaNombre.Show();
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
