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
    public partial class jobcontrol : UserControl
    {
        public jobcontrol()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (uxcompleted.Checked)
            {
                uxcompleted.ImageIndex = 3;
            }
            else
            {
                uxcompleted.ImageIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (jobform jobfinder = new jobform())
            {
                var result = jobfinder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Success in search! Congratulations.");
                    uxProcessName.Enabled = false;
                }
            }
        }
    }
}
