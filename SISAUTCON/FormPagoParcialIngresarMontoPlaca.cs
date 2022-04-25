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
    public partial class FormPagoParcialIngresarMontoPlaca : MetroFramework.Forms.MetroForm
    {
        private LocalReport report = new LocalReport();
        EntitiesConsultas db = new EntitiesConsultas();

        public String tipoDocumento;
        public String tipoImpuesto;
        public int nroCaracteres;
        private String numero = "";

        public FormPagoParcialIngresarMontoPlaca()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormEstadosCuentaCodigoDocIdentidad_Load(object sender, EventArgs e)
        {
            if (nroCaracteres == 11)
                labelTitulo.Text = "INGRESE SU NUMERO DE IDENTIDAD";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            agregarDigito("9");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            agregarDigito("8");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            agregarDigito("7");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            agregarDigito("6");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            agregarDigito("5");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            agregarDigito("4");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            agregarDigito("3");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            agregarDigito("2");
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            agregarDigito("1");
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            agregarDigito("0");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (numero.Length > 0)
            {
                numero = numero.Substring(0, numero.Length - 1);
                labelNumero.Text = "S/ " + numero + ".00";
            }
        }

        private void agregarDigito(String digito)
        {
            numero += digito;
            labelNumero.Text = "S/ " + numero + ".00"; ;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        public void buscar() {
            
        }

        private void imprimir()
        {
            report.PrintToPrinter();
            Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
