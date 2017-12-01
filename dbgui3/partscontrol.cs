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
                    uxPartName.Enabled = false;
                }
            }
            
            

        }

        private void uxSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FunctionsList.insertUpdatePart(Convert.ToInt32(ux_PartID.Text), uxPartName.Text, (int) uxQty.Value, Convert.ToDouble(uxBaseCost.Value)));
            uxPartName.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ux_PartID.Text = FunctionsList.newPartID().ToString();
            uxPartName.Enabled = true;
            uxSubmit.Enabled = true;
        }
    }
}
