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
    public partial class VistaPreviaTicket :  MetroFramework.Forms.MetroForm
    {
        public VistaPreviaTicket()
        {
            InitializeComponent();
        }

        private void VistaPreviaTicket_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String parametro1 = textBox1.Text;
            String parametro2 = textBox2.Text;

            // TODO: esta línea de código carga datos en la tabla 'prueba_tupa.REQTUPA' Puede moverla o quitarla según sea necesario.
            this.REQTUPATableAdapter.Fill(this.prueba_tupa.REQTUPA, parametro1, parametro2);
            //this.ticketPrueba.DataBindings= from 
            this.reportViewer1.RefreshReport();


        }
    }
}
