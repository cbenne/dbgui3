using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbgui3
{
    public partial class salescontrol : UserControl
    {
        public salescontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saleswizard sw = new saleswizard();
            sw.ShowDialog();
        }
    }
}
