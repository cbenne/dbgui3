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
    public partial class jobform : Form
    {
        public int jobid;
        public string processid;
        public DateTime date;
        public int qty;
        public bool complete;

        public jobform()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            uxBeginDate.Visible = false;
            uxEndDate.Visible = false;
            uxDateLabel.Visible = false;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString().Equals("Date Range:"))
            {
                uxSearchBox.Visible = false;
                uxBeginDate.Visible = true;
                uxEndDate.Visible = true;
                uxDateLabel.Visible = true;
                button1.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString().Equals(""))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                uxSearchBox.Visible = true;
                uxBeginDate.Visible = false;
                uxEndDate.Visible = false;
                uxDateLabel.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (comboBox1.SelectedItem.ToString().Equals("Date Range:"))
            {
                dataGridView1.DataSource = FunctionsList.findJobDate(uxBeginDate.Value.ToString("yyyy-MM-dd"), uxEndDate.Value.ToString("yyyy-MM-dd"));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("ID:"))
            {
                dataGridView1.DataSource = FunctionsList.findJobID(Convert.ToInt32(uxSearchBox.Text));
            }
            else
            {
                dataGridView1.DataSource = FunctionsList.findProcessIDint(uxSearchBox.Text);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Enabled == true)
            {
                button2.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jobid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            processid = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            date = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            qty = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            complete = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Equals("True");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
