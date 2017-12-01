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
        public DataTable processtable;
        public jobcontrol()
        {
            InitializeComponent();
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();
            processtable = FunctionsList.ProcessIDAutoComplete();
            uxProcessName.DataSource = processtable;
            uxProcessName.DisplayMember = "description";
            uxPartProduced.DataSource = processtable;
            uxPartProduced.DisplayMember = "n";

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
                    uxJobID.Text = Convert.ToString(jobfinder.jobid);
                    uxProcessName.Text = jobfinder.processid;
                    uxProcessName.Enabled = false;
                    uxdateTimePicker1.Value = jobfinder.date;
                    uxqty.Value = jobfinder.qty;
                    uxqty.Enabled = false;
                    uxPartProduced.Enabled = false;
                    uxcompleted.Checked = jobfinder.complete;
                    uxSubmit.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uxProcessName.Enabled = true;
            uxPartProduced.Enabled = true;
            uxqty.Enabled = true;
            uxcompleted.Checked = false;
            uxJobID.Text = FunctionsList.newJobID().ToString();
            uxSubmit.Enabled = true;
        }

        private void uxSubmit_Click(object sender, EventArgs e)
        {
            if (uxqty.Value < 0)
            {
                MessageBox.Show("Please enter a quantity");
                return;
            }
            MessageBox.Show(FunctionsList.insertUpdateJob(Convert.ToInt32(uxJobID.Text), (int) processtable.Rows[uxProcessName.SelectedIndex][0], uxdateTimePicker1.Value.ToString("yyyy-MM-dd"), (int) uxqty.Value, uxcompleted.Checked));
            
        }

        private void uxPartProduced_Leave(object sender, EventArgs e)
        {
            uxProcessName.SelectedIndex = uxPartProduced.SelectedIndex;
        }

        private void uxProcessName_Leave(object sender, EventArgs e)
        {
            uxPartProduced.SelectedIndex = uxProcessName.SelectedIndex;
        }
    }
}
