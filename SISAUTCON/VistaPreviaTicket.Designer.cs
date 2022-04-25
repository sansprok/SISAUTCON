namespace SISAUTCON
{
    partial class VistaPreviaTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.REQTUPABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prueba_tupa = new SISAUTCON.prueba_tupa();
            this.ticketPrueba = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSetPueba1 = new SISAUTCON.DataSetPueba();
            this.REQTUPATableAdapter = new SISAUTCON.prueba_tupaTableAdapters.REQTUPATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.REQTUPABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_tupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPueba1)).BeginInit();
            this.SuspendLayout();
            // 
            // REQTUPABindingSource
            // 
            this.REQTUPABindingSource.DataMember = "REQTUPA";
            this.REQTUPABindingSource.DataSource = this.prueba_tupa;
            // 
            // prueba_tupa
            // 
            this.prueba_tupa.DataSetName = "prueba_tupa";
            this.prueba_tupa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketPrueba
            // 
            this.ticketPrueba.Location = new System.Drawing.Point(0, 0);
            this.ticketPrueba.Name = "ticketPrueba";
            this.ticketPrueba.ServerReport.BearerToken = null;
            this.ticketPrueba.Size = new System.Drawing.Size(396, 246);
            this.ticketPrueba.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REQTUPABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISAUTCON.reporte_prueba.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 132);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1217, 381);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 22);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Recuperar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSetPueba1
            // 
            this.dataSetPueba1.DataSetName = "DataSetPueba";
            this.dataSetPueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REQTUPATableAdapter
            // 
            this.REQTUPATableAdapter.ClearBeforeFill = true;
            // 
            // VistaPreviaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VistaPreviaTicket";
            this.Text = "VistaPreviaTicket";
            this.Load += new System.EventHandler(this.VistaPreviaTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REQTUPABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prueba_tupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPueba1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ticketPrueba;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource REQTUPABindingSource;
        private prueba_tupa prueba_tupa;
        private DataSetPueba dataSetPueba1;
        private prueba_tupaTableAdapters.REQTUPATableAdapter REQTUPATableAdapter;
    }
}