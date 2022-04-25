namespace SISAUTCON
{
    partial class FormEstadosCuentaCodigoDocIdentidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btnImprimir = new MetroFramework.Controls.MetroTile();
            this.btnBorrar = new MetroFramework.Controls.MetroTile();
            this.btnCero = new MetroFramework.Controls.MetroTile();
            this.btnUno = new MetroFramework.Controls.MetroTile();
            this.btnDos = new MetroFramework.Controls.MetroTile();
            this.btnTres = new MetroFramework.Controls.MetroTile();
            this.btnCuatro = new MetroFramework.Controls.MetroTile();
            this.btnCinco = new MetroFramework.Controls.MetroTile();
            this.btnSeis = new MetroFramework.Controls.MetroTile();
            this.btnSiete = new MetroFramework.Controls.MetroTile();
            this.btnOcho = new MetroFramework.Controls.MetroTile();
            this.btnNueve = new MetroFramework.Controls.MetroTile();
            this.btnBuscar = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.FACODCONTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FANOMCONTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FANRODOCUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTitulo.Location = new System.Drawing.Point(320, 115);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(711, 49);
            this.labelTitulo.TabIndex = 53;
            this.labelTitulo.Text = "INGRESE SU CODIGO DE CONTRIBUYENTE";
            // 
            // labelNumero
            // 
            this.labelNumero.Font = new System.Drawing.Font("Calibri", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelNumero.Location = new System.Drawing.Point(29, 194);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(390, 60);
            this.labelNumero.TabIndex = 78;
            this.labelNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeight = 50;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FACODCONTR,
            this.FANOMCONTR,
            this.FANRODOCUM});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(425, 194);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGrid1.RowTemplate.Height = 50;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(927, 422);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 103;
            this.metroGrid1.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.ActiveControl = null;
            this.btnImprimir.Location = new System.Drawing.Point(425, 636);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(256, 100);
            this.btnImprimir.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnImprimir.TabIndex = 104;
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TileImage = global::SISAUTCON.Properties.Resources.imprimir;
            this.btnImprimir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnImprimir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnImprimir.UseSelectable = true;
            this.btnImprimir.UseTileImage = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ActiveControl = null;
            this.btnBorrar.Location = new System.Drawing.Point(175, 636);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 100);
            this.btnBorrar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnBorrar.TabIndex = 102;
            this.btnBorrar.TileImage = global::SISAUTCON.Properties.Resources.del;
            this.btnBorrar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBorrar.UseSelectable = true;
            this.btnBorrar.UseTileImage = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCero
            // 
            this.btnCero.ActiveControl = null;
            this.btnCero.Location = new System.Drawing.Point(55, 636);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(100, 100);
            this.btnCero.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnCero.TabIndex = 101;
            this.btnCero.TileImage = global::SISAUTCON.Properties.Resources.cero;
            this.btnCero.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCero.UseSelectable = true;
            this.btnCero.UseTileImage = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnUno
            // 
            this.btnUno.ActiveControl = null;
            this.btnUno.Location = new System.Drawing.Point(295, 516);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(100, 100);
            this.btnUno.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnUno.TabIndex = 100;
            this.btnUno.TileImage = global::SISAUTCON.Properties.Resources.uno;
            this.btnUno.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUno.UseSelectable = true;
            this.btnUno.UseTileImage = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.ActiveControl = null;
            this.btnDos.Location = new System.Drawing.Point(175, 516);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(100, 100);
            this.btnDos.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnDos.TabIndex = 99;
            this.btnDos.TileImage = global::SISAUTCON.Properties.Resources.dos;
            this.btnDos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDos.UseSelectable = true;
            this.btnDos.UseTileImage = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.ActiveControl = null;
            this.btnTres.Location = new System.Drawing.Point(55, 516);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(100, 100);
            this.btnTres.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnTres.TabIndex = 98;
            this.btnTres.TileImage = global::SISAUTCON.Properties.Resources.tres;
            this.btnTres.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTres.UseSelectable = true;
            this.btnTres.UseTileImage = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.ActiveControl = null;
            this.btnCuatro.Location = new System.Drawing.Point(295, 396);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(100, 100);
            this.btnCuatro.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnCuatro.TabIndex = 97;
            this.btnCuatro.TileImage = global::SISAUTCON.Properties.Resources.cuatro;
            this.btnCuatro.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCuatro.UseSelectable = true;
            this.btnCuatro.UseTileImage = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.ActiveControl = null;
            this.btnCinco.Location = new System.Drawing.Point(175, 396);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(100, 100);
            this.btnCinco.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnCinco.TabIndex = 96;
            this.btnCinco.TileImage = global::SISAUTCON.Properties.Resources.cinco;
            this.btnCinco.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCinco.UseSelectable = true;
            this.btnCinco.UseTileImage = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.ActiveControl = null;
            this.btnSeis.Location = new System.Drawing.Point(55, 396);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(100, 100);
            this.btnSeis.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSeis.TabIndex = 95;
            this.btnSeis.TileImage = global::SISAUTCON.Properties.Resources.seis;
            this.btnSeis.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeis.UseSelectable = true;
            this.btnSeis.UseTileImage = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.ActiveControl = null;
            this.btnSiete.Location = new System.Drawing.Point(295, 276);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(100, 100);
            this.btnSiete.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSiete.TabIndex = 94;
            this.btnSiete.TileImage = global::SISAUTCON.Properties.Resources.siete;
            this.btnSiete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiete.UseSelectable = true;
            this.btnSiete.UseTileImage = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.ActiveControl = null;
            this.btnOcho.Location = new System.Drawing.Point(175, 276);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(100, 100);
            this.btnOcho.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnOcho.TabIndex = 93;
            this.btnOcho.TileImage = global::SISAUTCON.Properties.Resources.ocho;
            this.btnOcho.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOcho.UseSelectable = true;
            this.btnOcho.UseTileImage = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.ActiveControl = null;
            this.btnNueve.Location = new System.Drawing.Point(55, 276);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(100, 100);
            this.btnNueve.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnNueve.TabIndex = 92;
            this.btnNueve.TileImage = global::SISAUTCON.Properties.Resources.nueve;
            this.btnNueve.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNueve.UseSelectable = true;
            this.btnNueve.UseTileImage = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveControl = null;
            this.btnBuscar.Location = new System.Drawing.Point(295, 636);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 100);
            this.btnBuscar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnBuscar.TabIndex = 79;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TileImage = global::SISAUTCON.Properties.Resources.buscar11;
            this.btnBuscar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnBuscar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.UseTileImage = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SISAUTCON.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(1283, 742);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 106;
            this.label7.Text = "INICIO";
            // 
            // btnInicio
            // 
            this.btnInicio.Image = global::SISAUTCON.Properties.Resources.start;
            this.btnInicio.Location = new System.Drawing.Point(1272, 671);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(80, 80);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInicio.TabIndex = 105;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // FACODCONTR
            // 
            this.FACODCONTR.DataPropertyName = "FACODCONTR";
            this.FACODCONTR.HeaderText = "CODIGO";
            this.FACODCONTR.Name = "FACODCONTR";
            this.FACODCONTR.ReadOnly = true;
            this.FACODCONTR.Width = 135;
            // 
            // FANOMCONTR
            // 
            this.FANOMCONTR.DataPropertyName = "FANOMCONTR";
            this.FANOMCONTR.HeaderText = "NOMBRE";
            this.FANOMCONTR.Name = "FANOMCONTR";
            this.FANOMCONTR.ReadOnly = true;
            this.FANOMCONTR.Width = 560;
            // 
            // FANRODOCUM
            // 
            this.FANRODOCUM.DataPropertyName = "FANRODOCUM";
            this.FANRODOCUM.HeaderText = "NUMERO DOC.";
            this.FANRODOCUM.Name = "FANRODOCUM";
            this.FANRODOCUM.ReadOnly = true;
            this.FANRODOCUM.Width = 200;
            // 
            // FormEstadosCuentaCodigoDocIdentidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEstadosCuentaCodigoDocIdentidad";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormEstadosCuentaCodigoDocIdentidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNumero;
        private MetroFramework.Controls.MetroTile btnBuscar;
        private MetroFramework.Controls.MetroTile btnNueve;
        private MetroFramework.Controls.MetroTile btnOcho;
        private MetroFramework.Controls.MetroTile btnSiete;
        private MetroFramework.Controls.MetroTile btnSeis;
        private MetroFramework.Controls.MetroTile btnCinco;
        private MetroFramework.Controls.MetroTile btnCuatro;
        private MetroFramework.Controls.MetroTile btnTres;
        private MetroFramework.Controls.MetroTile btnDos;
        private MetroFramework.Controls.MetroTile btnUno;
        private MetroFramework.Controls.MetroTile btnCero;
        private MetroFramework.Controls.MetroTile btnBorrar;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTile btnImprimir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACODCONTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FANOMCONTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FANRODOCUM;
    }
}