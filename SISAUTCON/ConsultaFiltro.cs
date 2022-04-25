using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISAUTCON
{
    public partial class ConsultaFiltro : MetroFramework.Forms.MetroForm
    {
        public ConsultaFiltro()
        {
            InitializeComponent();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            var keyboardProc = Process.Start(keyboardPath);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            var keyboardProc = Process.Start(keyboardPath);
        }

        private void btnDni_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            var keyboardProc = Process.Start(keyboardPath);
        }
    }
}
