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
        public orderwizard()
        {
            InitializeComponent();
        }

        private void orderwizard_Load(object sender, EventArgs e)
        {
            textBox4.Text = "77";
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
