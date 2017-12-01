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
    public partial class supplierwizard : Form
    {
        public supplierwizard()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void supplierwizard_Load(object sender, EventArgs e)
        {
            textBox3.Text = "12314q3513254";
        }
    }
}
