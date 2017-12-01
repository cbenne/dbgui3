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
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value.GetType() == typeof(int))
            {
                button2.Enabled = true;
            }
            
        }
    }
}
