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
            DataTable dt = new DataTable();
            
            //object[] row = { (int)3, (string)"name", (int)3, (double)4.5 };
            //dt.LoadDataRow(row, true);
            dataGridView1.DataSource = dt;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DataGridViewRow r = dataGridView1.SelectedRows[0];
            this.partid = 3; //Convert.ToInt32(r.Cells[0].Value.ToString());
            this.partname = "name"; //r.Cells[1].Value.ToString();
            this.qty = 4; //Convert.ToInt32(r.Cells[2].Value.ToString());
            this.basecost = Convert.ToDecimal(4.5); //Convert.ToDecimal(r.Cells[3].Value.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
