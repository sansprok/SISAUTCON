﻿namespace SISAUTCON
{
    partial class FormRenovacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnContribuyenteRegular = new System.Windows.Forms.PictureBox();
            this.btnPensionistasAdultoMayor = new System.Windows.Forms.PictureBox();
            this.btnExoneradosInafectos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnContribuyenteRegular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPensionistasAdultoMayor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExoneradosInafectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(968, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 100);
            this.label1.TabIndex = 30;
            this.label1.Text = "PENSIONISTAS O ADULTO MAYOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(593, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 100);
            this.label2.TabIndex = 29;
            this.label2.Text = "EXONERADOS O INAFECTOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(572, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 49);
            this.label4.TabIndex = 26;
            this.label4.Text = "RENOVACION";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(207, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 100);
            this.label3.TabIndex = 32;
            this.label3.Text = "CONTRIBUYENTE REGULAR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContribuyenteRegular
            // 
            this.btnContribuyenteRegular.Image = global::SISAUTCON.Properties.Resources.regular;
            this.btnContribuyenteRegular.Location = new System.Drawing.Point(183, 296);
            this.btnContribuyenteRegular.Margin = new System.Windows.Forms.Padding(2);
            this.btnContribuyenteRegular.Name = "btnContribuyenteRegular";
            this.btnContribuyenteRegular.Size = new System.Drawing.Size(256, 256);
            this.btnContribuyenteRegular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnContribuyenteRegular.TabIndex = 31;
            this.btnContribuyenteRegular.TabStop = false;
            this.btnContribuyenteRegular.Click += new System.EventHandler(this.btnContribuyenteRegular_Click);
            // 
            // btnPensionistasAdultoMayor
            // 
            this.btnPensionistasAdultoMayor.Image = global::SISAUTCON.Properties.Resources.prescripcion;
            this.btnPensionistasAdultoMayor.Location = new System.Drawing.Point(939, 296);
            this.btnPensionistasAdultoMayor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPensionistasAdultoMayor.Name = "btnPensionistasAdultoMayor";
            this.btnPensionistasAdultoMayor.Size = new System.Drawing.Size(256, 256);
            this.btnPensionistasAdultoMayor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPensionistasAdultoMayor.TabIndex = 28;
            this.btnPensionistasAdultoMayor.TabStop = false;
            this.btnPensionistasAdultoMayor.Click += new System.EventHandler(this.btnPensionistasAdultoMayor_Click);
            // 
            // btnExoneradosInafectos
            // 
            this.btnExoneradosInafectos.Image = global::SISAUTCON.Properties.Resources.reclamacion;
            this.btnExoneradosInafectos.Location = new System.Drawing.Point(564, 296);
            this.btnExoneradosInafectos.Margin = new System.Windows.Forms.Padding(2);
            this.btnExoneradosInafectos.Name = "btnExoneradosInafectos";
            this.btnExoneradosInafectos.Size = new System.Drawing.Size(256, 256);
            this.btnExoneradosInafectos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExoneradosInafectos.TabIndex = 27;
            this.btnExoneradosInafectos.TabStop = false;
            this.btnExoneradosInafectos.Click += new System.EventHandler(this.btnExoneradosInafectos_Click);
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
            this.label7.TabIndex = 45;
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
            this.btnInicio.TabIndex = 44;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // FormRenovacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContribuyenteRegular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPensionistasAdultoMayor);
            this.Controls.Add(this.btnExoneradosInafectos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRenovacion";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.btnContribuyenteRegular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPensionistasAdultoMayor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExoneradosInafectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnPensionistasAdultoMayor;
        private System.Windows.Forms.PictureBox btnExoneradosInafectos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnContribuyenteRegular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnInicio;
    }
}