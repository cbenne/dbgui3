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
    public partial class ordercontrol : UserControl
    {
        public ordercontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (orderwizard ow = new dbgui3.orderwizard())
            {
                ow.ShowDialog();
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(supplierwizard sw = new supplierwizard())
            {
                sw.ShowDialog();
            }
        }
    }
}
