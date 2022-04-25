namespace SISAUTCON
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRequisitosTUPA = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnPagosParciales = new System.Windows.Forms.Button();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnRequisitosTUPA
            // 
            this.btnRequisitosTUPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRequisitosTUPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequisitosTUPA.ForeColor = System.Drawing.Color.White;
            this.btnRequisitosTUPA.Location = new System.Drawing.Point(303, 207);
            this.btnRequisitosTUPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRequisitosTUPA.Name = "btnRequisitosTUPA";
            this.btnRequisitosTUPA.Size = new System.Drawing.Size(393, 327);
            this.btnRequisitosTUPA.TabIndex = 0;
            this.btnRequisitosTUPA.Text = "REQUISITOS PARA TRAMITES";
            this.btnRequisitosTUPA.UseVisualStyleBackColor = false;
            this.btnRequisitosTUPA.Click += new System.EventHandler(this.btnRequisitosTUPA_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(812, 207);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(393, 327);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "CONSULTA TU ESTADO DE CUENTA";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnPagosParciales
            // 
            this.btnPagosParciales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPagosParciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagosParciales.ForeColor = System.Drawing.Color.White;
            this.btnPagosParciales.Location = new System.Drawing.Point(1314, 207);
            this.btnPagosParciales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagosParciales.Name = "btnPagosParciales";
            this.btnPagosParciales.Size = new System.Drawing.Size(393, 327);
            this.btnPagosParciales.TabIndex = 2;
            this.btnPagosParciales.Text = "PAGO PARCIAL";
            this.btnPagosParciales.UseVisualStyleBackColor = false;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(812, 558);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(393, 327);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 11;
            this.metroTile2.Text = "CONSULTA";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(1314, 558);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(393, 327);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile3.TabIndex = 12;
            this.metroTile3.Text = "PAGOS PARCIALES";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(303, 558);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(393, 341);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 10;
            this.metroTile1.Text = "REQUISITOS TUPA";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::SISAUTCON.Properties.Resources.icon1;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(651, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(274, 65);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "SISTEMA DE CONSULTA";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnPagosParciales);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnRequisitosTUPA);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRequisitosTUPA;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnPagosParciales;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        public MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

