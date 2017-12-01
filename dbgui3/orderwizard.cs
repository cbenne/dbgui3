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
    public partial class orderwizard : Form
    {
        public DataTable suppliers;
        public orderwizard()
        {
            InitializeComponent();
            textBox4.Text = FunctionsList.newOrderID().ToString();
            suppliers = FunctionsList.SupplierIDAutoComplete();
            comboBox1.DataSource = suppliers;
            comboBox1.DisplayMember = "name";
        }

        private void orderwizard_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FunctionsList.insertOrder(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox2.Text), Convert.ToInt32(suppliers.Rows[comboBox1.SelectedIndex][0])));
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void uxselectpart_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (partform partfinder = new partform())
            {
                var result = partfinder.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox1.Text = partfinder.partid.ToString();
                    
                }
            }
        }
    }
}
