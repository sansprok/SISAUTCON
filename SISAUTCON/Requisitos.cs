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
    public partial class Requisitos : MetroFramework.Forms.MetroForm
    {
        public Requisitos()
        {
            InitializeComponent();
        }

        private void btnRequisitosIP_Click(object sender, EventArgs e)
        {
            RequisitosDetalles RD = new RequisitosDetalles();
            RD.ShowDialog();
        }
    }
}
