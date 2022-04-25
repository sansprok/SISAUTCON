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
    public partial class FormImpuestoPredial : MetroFramework.Forms.MetroForm
    {
        LocalReport report = new LocalReport();
        EntitiesConsultas db = new EntitiesConsultas();

        public FormImpuestoPredial()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            report.ReportEmbeddedResource = "SISAUTCON.reporte_prueba2.rdlc";
        }

        private void btnbeneficioTributario_Click(object sender, EventArgs e)
        {
            FormBeneficioTributario frmBeneficioTributario = new FormBeneficioTributario();
            frmBeneficioTributario.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frmBeneficioTributario.Show();
        }

        private void btnRenovacion_Click(object sender, EventArgs e)
        {
            FormRenovacion frmRenovacion = new FormRenovacion();
            frmRenovacion.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frmRenovacion.Show();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("IP", "INSCRIPCION", "TODOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Inscripcion del Impuesto Predial"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();
        }

        private void btnRectificacion_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("IP", "RECTIFICACION", "TODOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Rectificacion del Impuesto Predial"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("IP", "BAJA", "TODOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Baja del Impuesto Predial"));
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

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Solicitar Constancia del Impuesto Predial"));
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

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Solicitar Compensacion del Impuesto Predial"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();
        }

        private void imprimir()
        {
            report.PrintToPrinter();
            Close();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            FormImpuestoPredialOtros formImpuestoPredialOtros = new FormImpuestoPredialOtros();
            formImpuestoPredialOtros.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            formImpuestoPredialOtros.Show();
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
