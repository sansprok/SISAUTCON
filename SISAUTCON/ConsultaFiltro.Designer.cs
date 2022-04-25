namespace SISAUTCON
{
    partial class ConsultaFiltro
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
            this.btnDni = new System.Windows.Forms.Button();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnDni
            // 
            this.btnDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDni.ForeColor = System.Drawing.Color.White;
            this.btnDni.Location = new System.Drawing.Point(903, 154);
            this.btnDni.Name = "btnDni";
            this.btnDni.Size = new System.Drawing.Size(295, 266);
            this.btnDni.TabIndex = 3;
            this.btnDni.Text = "NRO DE DOCUMENTO (DNI)";
            this.btnDni.UseVisualStyleBackColor = false;
            this.btnDni.Click += new System.EventHandler(this.btnDni_Click);
            // 
            // btnCodigo
            // 
            this.btnCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.Color.White;
            this.btnCodigo.Location = new System.Drawing.Point(474, 154);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(295, 266);
            this.btnCodigo.TabIndex = 2;
            this.btnCodigo.Text = "CODIGO CONTRIBUYENTE";
            this.btnCodigo.UseVisualStyleBackColor = false;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // ConsultaFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 634);
            this.Controls.Add(this.btnDni);
            this.Controls.Add(this.btnCodigo);
            this.Name = "ConsultaFiltro";
            this.Text = "ConsultaFiltro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDni;
        private System.Windows.Forms.Button btnCodigo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}