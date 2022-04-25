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
    public partial class FormConsultas : MetroFramework.Forms.MetroForm
    {
        LocalReport report = new LocalReport();
        EntitiesConsultas db = new EntitiesConsultas();

        public FormConsultas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            report.ReportEmbeddedResource = "SISAUTCON.reporte_prueba2.rdlc";
        }

        private void btnPredial_Click(object sender, EventArgs e)
        {
            FormImpuestoPredial formImpuestoPredial = new FormImpuestoPredial();
            formImpuestoPredial.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formImpuestoPredial.Show();
        }

        private void btnVehicular_Click(object sender, EventArgs e)
        {
            FormImpuestoVehicular formImpuestoVehicular = new FormImpuestoVehicular();
            formImpuestoVehicular.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formImpuestoVehicular.Show();
        }

        private void btnAlcabala_Click(object sender, EventArgs e)
        {
            FormAlcabala formAlcabala = new FormAlcabala();
            formAlcabala.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formAlcabala.Show();
        }

        private void btnFraccionamiento_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("FR", "FRACCIONAMIENTO", "TODOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Fraccionamiento de Impuesto"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();
        }

        private void imprimir()
        {
            report.PrintToPrinter();
            Close();
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
