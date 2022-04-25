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
    public partial class FormAlcabala : MetroFramework.Forms.MetroForm
    {
        LocalReport report = new LocalReport();
        EntitiesConsultas db = new EntitiesConsultas();

        public FormAlcabala()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            report.ReportEmbeddedResource = "SISAUTCON.reporte_prueba2.rdlc";
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("AC", "INSCRIPCION", "TODOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            //report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Beneficio Tributario del Impuesto Predial para Pensionistas o Adulto mayor"));
            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Inscripcion por Impuesto de Alcabala"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();

        }

        private void btnConstancia_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("TD", "CONSTANCIA", "TODOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Solicitar Constancia por Impuesto de Alcabala"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
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
    }
}
