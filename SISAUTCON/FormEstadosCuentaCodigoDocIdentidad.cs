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
    public partial class FormEstadosCuentaCodigoDocIdentidad : MetroFramework.Forms.MetroForm
    {
        BackgroundWorker backgroundWorker;
        FormBuscando formBuscando = new FormBuscando();
        FormRecuperandoInformacion formRecuperando = new FormRecuperandoInformacion();
        DataTable table;
        private int busqueda;

        private LocalReport report = new LocalReport();
        EntitiesConsultas db = new EntitiesConsultas();

        public String tipoDocumento;
        public String tipoImpuesto;
        public int nroCaracteres;
        private String numero = "";

        public FormEstadosCuentaCodigoDocIdentidad()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_Completed);
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
                labelNumero.Text = numero;
            }
        }

        private void agregarDigito(String digito)
        {
            if (numero.Length < nroCaracteres)
            {
                numero += digito;
                labelNumero.Text = numero;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        public void buscar() {
            if (numero.Length == nroCaracteres || nroCaracteres == 11)
            {
                labelNumero.Text = numero;
                busqueda = 1;
                if (!backgroundWorker.IsBusy)
                    backgroundWorker.RunWorkerAsync();
            }
            else
            {
                numero = "0" + numero;
                buscar();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
             busqueda = 2;
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }

        /***
         * Metodos asincronos para la busqueda de nombres
        */
        private delegate void showLoading();

        private void loading()
        {
            if (busqueda == 1)
                formBuscando.Show();
            else
                formRecuperando.Show();
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new showLoading(loading));
            //
            table = new DataTable();
            table.Columns.Add("FACODCONTR", typeof(string));
            table.Columns.Add("FANOMCONTR", typeof(string));
            table.Columns.Add("FANRODOCUM", typeof(string));

            if (busqueda == 1)
            {
                if (tipoDocumento == "Codigo")
                {
                    var resultadoCodigo = db.SP_RECUPERAR_POR_CODIGO_TOUCHSCREEN(numero).ToList();
                    foreach (SP_RECUPERAR_POR_CODIGO_TOUCHSCREEN_Result item in resultadoCodigo)
                    {
                        table.Rows.Add(item.FACODCONTR, item.FANOMCONTR, item.FANRODOCUM);
                    }
                }
                else
                {
                    var resultadoCodigo = db.SP_BUSQUEDA_POR_NUMERO_DE_DOCUMENTO_TOUCHSCREEN(numero).ToList();
                    foreach (SP_BUSQUEDA_POR_NUMERO_DE_DOCUMENTO_TOUCHSCREEN_Result item in resultadoCodigo)
                    {
                        table.Rows.Add(item.FACODCONTR, item.FANOMCONTR, item.FANRODOCUM);
                    }
                }
            }
            else
            {
                String codigo = metroGrid1.SelectedCells[0].Value.ToString();
                String nombre = metroGrid1.SelectedCells[1].Value.ToString();
                String nroDocumento = metroGrid1.SelectedCells[2].Value.ToString();

                switch (tipoImpuesto)
                {
                    case "IP":
                        report.ReportEmbeddedResource = "SISAUTCON.reporte_estado_cuenta_predial.rdlc";
                        break;
                    case "IV":
                        report.ReportEmbeddedResource = "SISAUTCON.reporte_estado_cuenta_vehicular.rdlc";
                        break;
                    case "AR":
                        report.ReportEmbeddedResource = "SISAUTCON.reporte_estado_cuenta_arbitrios_reves.rdlc";
                        break;
                    case "AC":

                        report.ReportEmbeddedResource = "SISAUTCON.reporte_estado_cuenta_alcabala.rdlc";
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

                report.SetParameters(new ReportParameter("CodigoContribuyente", codigo));
                report.SetParameters(new ReportParameter("NombreContribuyente", nombre));
                report.SetParameters(new ReportParameter("NroDocumentoContribuyente", nroDocumento));

                var x = db.SP_CONSULTA_CTATE_TO_TOUCHSCREEM(codigo, tipoImpuesto).ToList();
                int count = 0;
                foreach (SP_CONSULTA_CTATE_TO_TOUCHSCREEM_Result item in x)
                {
                    count++;
                }
                if (count > 0)
                {
                    report.DataSources.Add(new ReportDataSource("DataSetEstadoCuenta", x));
                    report.PrintToPrinter();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No se encontraron datos para este contribuyente", "RESULTADOS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }

        }
        private void backgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (busqueda == 1)
            {
                formBuscando.Hide();
                if (table.Rows.Count > 0)
                {
                    metroGrid1.DataSource = table;
                    metroGrid1.Visible = true;
                    btnImprimir.Visible = true;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "La busqueda no generó resultados.", "RESULTADOS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                formRecuperando.Hide();
                Close();
            }

        }

        /***
        * fin Metodos asincronos para la busqueda de nombres
       */
    }
}
