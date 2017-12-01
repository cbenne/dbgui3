using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbgui3
{
    public partial class partform : Form
    {
        public int partid;
        public string partname;
        public int qty;
        public decimal basecost;
        public partform()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uxCombobox.SelectedIndex == 0)
            {
                dataGridView1.DataSource = FunctionsList.findPartID(Convert.ToInt32(uxSearchBox.Text));
            }
            else
            {
                dataGridView1.DataSource = FunctionsList.findPartName(uxSearchBox.Text);
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dataGridView1.SelectedRows[0];
            this.partid = Convert.ToInt32(r.Cells[0].Value.ToString());
            this.partname = r.Cells[1].Value.ToString();
            this.qty = Convert.ToInt32(r.Cells[2].Value.ToString());
            this.basecost = Convert.ToDecimal(r.Cells[3].Value.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
