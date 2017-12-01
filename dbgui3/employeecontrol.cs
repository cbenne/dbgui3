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
    public partial class employeecontrol : UserControl
    {
        public employeecontrol()
        {
            InitializeComponent();
            uxSearch.Enabled = false;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            uxSearch.Enabled = true;
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {
            if (uxcomboBox.SelectedIndex == 0)
            {
                dataGridView1.DataSource =  FunctionsList.findEmployee("", "", Convert.ToInt32(uxSearchBox.Text));
            } else if (uxcomboBox.SelectedIndex == 1)
            {
                dataGridView1.DataSource = FunctionsList.findEmployee(uxSearchBox.Text, "", -1);
            }
            else
            {
                dataGridView1.DataSource = FunctionsList.findEmployee("", uxSearchBox.Text, -1);
            }
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
