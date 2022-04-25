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
    public partial class FormImpuestoVehicular : MetroFramework.Forms.MetroForm
    {
        LocalReport report = new LocalReport();
        EntitiesConsultas db = new EntitiesConsultas();

        public FormImpuestoVehicular()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            report.ReportEmbeddedResource = "SISAUTCON.reporte_prueba2.rdlc";
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("IV", "INSCRIPCION", "TODOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Inscripcion del Impuesto Vehicular"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();
        }

        private void btnDeclaracion_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("IV", "DECLARACION", "TODOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Declaracion del Impuesto Vehicular"));
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

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Solicitar Constancia del Impuesto Vehicular"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();
        }

        private void btnCompensacion_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("TD", "COMPENSACION", "TODOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Solicitar Compensacion del Impuesto Vehicular"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();
        }

        private void imprimir() {
            report.PrintToPrinter();
            Close();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            FormImpuestoVehicularOtros formImpuestoVehicularOtros = new FormImpuestoVehicularOtros();
            formImpuestoVehicularOtros.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formImpuestoVehicularOtros.Show();
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
