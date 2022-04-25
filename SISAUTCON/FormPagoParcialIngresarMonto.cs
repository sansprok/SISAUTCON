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
    public partial class FormPagoParcialIngresarMonto : MetroFramework.Forms.MetroForm
    {
        private LocalReport report = new LocalReport();
        EntitiesConsultas db = new EntitiesConsultas();
        public String tipoImpuesto;
        public String codigo;
        public String nombre;
        public String nroDocumento;
        public List<SP_CONSULTA_CTATE_TO_TOUCHSCREEM_Result> consulta;

        private String numero = "";

        public FormPagoParcialIngresarMonto()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormEstadosCuentaCodigoDocIdentidad_Load(object sender, EventArgs e)
        {
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
            switch (tipoImpuesto)
            {
                case "IP":
                    report.ReportEmbeddedResource = "SISAUTCON.reporte_pago_parcial_predial.rdlc";
                    break;
                case "IV":
                    report.ReportEmbeddedResource = "SISAUTCON.reporte_pago_parcial_vehicular.rdlc";
                    break;
                case "AR":
                    report.ReportEmbeddedResource = "SISAUTCON.reporte_pago_parcial_arbitrios_reves.rdlc";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            report.SetParameters(new ReportParameter("CodigoContribuyente", codigo));
            report.SetParameters(new ReportParameter("NombreContribuyente", nombre));
            report.SetParameters(new ReportParameter("NroDocumentoContribuyente", nroDocumento));
            report.SetParameters(new ReportParameter("Monto", numero));
            report.DataSources.Add(new ReportDataSource("DataSetEstadoCuenta", consulta));
            imprimir();
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
