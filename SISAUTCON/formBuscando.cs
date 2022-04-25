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
    public partial class FormBuscando : Form
    {
        public Action Worker { set; get; }

        /*public formSpinner(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentNullException();
            Worker = worker;
        }*/

        public FormBuscando()
        {
            InitializeComponent();
        }

    }
}
