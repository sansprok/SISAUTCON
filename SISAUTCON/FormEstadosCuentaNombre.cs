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
    public partial class FormEstadosCuentaNombre : MetroFramework.Forms.MetroForm
    {
        BackgroundWorker backgroundWorker;
        FormBuscando formBuscando = new FormBuscando();
        FormRecuperandoInformacion formRecuperando = new FormRecuperandoInformacion();
        DataTable table;
        private int busqueda;

        private LocalReport report = new LocalReport();
        EntitiesConsultas db = new EntitiesConsultas();

        public String tipoImpuesto;
        private String nombre = "";

        public FormEstadosCuentaNombre()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_Completed);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            agregarLetra("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            agregarLetra("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            agregarLetra("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            agregarLetra("D");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            agregarLetra("E");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            agregarLetra("F");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            agregarLetra("G");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            agregarLetra("H");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            agregarLetra("I");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            agregarLetra("J");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            agregarLetra("K");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            agregarLetra("L");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            agregarLetra("M");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            agregarLetra("N");
        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            agregarLetra("Ñ");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            agregarLetra("O");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            agregarLetra("P");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            agregarLetra("Q");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            agregarLetra("R");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            agregarLetra("S");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            agregarLetra("T");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            agregarLetra("U");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            agregarLetra("V");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            agregarLetra("W");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            agregarLetra("X");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            agregarLetra("Y");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            agregarLetra("Z");
        }

        private void btnEspacio_Click(object sender, EventArgs e)
        {
            agregarLetra(" ");
        }

        private void agregarLetra(String letra)
        {
            nombre += letra;
            labelNombre.Text = nombre;
        }        

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (nombre.Length > 0)
            {
                nombre = nombre.Substring(0, nombre.Length - 1);
                labelNombre.Text = nombre;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda = 1;
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
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

            table = new DataTable();
            table.Columns.Add("FACODCONTR", typeof(string));
            table.Columns.Add("FANOMCONTR", typeof(string));
            table.Columns.Add("FANRODOCUM", typeof(string));

            if (busqueda == 1)
            {
                var resultadpCodigo = db.SP_BUSQUEDA_POR_NOMBRE_TOUCHSCREEN(nombre).ToList();
                foreach (SP_BUSQUEDA_POR_NOMBRE_TOUCHSCREEN_Result item in resultadpCodigo)
                {
                    table.Rows.Add(item.FACODCONTR, item.FANOMCONTR, item.FANRODOCUM);
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
            else {
                formRecuperando.Hide();
                Close();
            }
            

        }

        /***
        * fin Metodos asincronos para la busqueda de nombres
       */
    }
}
