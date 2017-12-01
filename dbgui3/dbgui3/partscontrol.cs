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
    public partial class partscontrol : UserControl
    {
        public partscontrol()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (partform partfinder = new partform())
            {
                var result = partfinder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ux_PartID.Text = Convert.ToString(partfinder.partid);
                    uxPartName.Text = partfinder.partname;
                    uxQty.Value = partfinder.qty;
                    uxBaseCost.Value = partfinder.basecost;
                }
            }
            
            

        }
    }
}
