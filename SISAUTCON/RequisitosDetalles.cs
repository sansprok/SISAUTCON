﻿using System;
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
    public partial class RequisitosDetalles : MetroFramework.Forms.MetroForm
    {
        public RequisitosDetalles()
        {
            InitializeComponent();
        }

        private void btnReqDetInscripcion_Click(object sender, EventArgs e)
        {
            RequisitosDetallesVistaPrevia rdv = new RequisitosDetallesVistaPrevia();
            rdv.Show();
        }

        private void RequisitosDetalles_Load(object sender, EventArgs e)
        {

        }
    }
}
