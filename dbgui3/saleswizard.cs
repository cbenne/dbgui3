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
    public partial class saleswizard : Form
    {
        DataTable customers;
        public saleswizard()
        {
            InitializeComponent();
            uxrid.Text = FunctionsList.newSaleID().ToString();
            customers = FunctionsList.CustomerIDAutoComplete();
            comboBox1.DataSource = customers;
            comboBox1.DisplayMember = "email";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (partform partfinder = new partform())
            {
                var result = partfinder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    uxpid.Text = Convert.ToString(partfinder.partid);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             MessageBox.Show(FunctionsList.partSold(Convert.ToInt32(uxpid.Text), Convert.ToInt32(uxqty.Text), Convert.ToInt32(customers.Rows[comboBox1.SelectedIndex][0]), Convert.ToInt32(uxrid.Text), Convert.ToDouble(uxcostper.Text), new DateTime(2017, 12, 1)));
        }
    }
}
