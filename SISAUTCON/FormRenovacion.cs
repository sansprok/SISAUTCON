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
    public partial class FormRenovacion : MetroFramework.Forms.MetroForm
    {
        LocalReport report = new LocalReport();
        EntitiesConsultas db = new EntitiesConsultas();

        public FormRenovacion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            report.ReportEmbeddedResource = "SISAUTCON.reporte_prueba2.rdlc";
        }

        private void btnContribuyenteRegular_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("IP", "RENOVACION", "CONTRIBUYENTE REGULAR").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Renovacion del Impuesto Predial para Contribuyente Regular"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();
        }

        private void btnExoneradosInafectos_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("IP", "RENOVACION", "EXONERADOS O INAFECTOS").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Renovacion del Impuesto Predial para Exonerados o Inafectos"));
            report.DataSources.Add(new ReportDataSource("DataSet1", table));
            imprimir();
        }

        private void btnPensionistasAdultoMayor_Click(object sender, EventArgs e)
        {
            var texto = db.SP_CONSULTA_REQTUPA("IP", "RENOVACION", "PENSIONISTA O ADULTO MAYOR").ToList();
            DataTable table = new DataTable();
            table.Columns.Add("FADESCRIPCION");
            foreach (var item in texto)
            {
                table.Rows.Add(item.ToString());
            }

            report.SetParameters(new ReportParameter("TipoRequisito", "Requisitos para Renovacion del Impuesto Predial para Pensionistas o Adulto Mayor"));
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
