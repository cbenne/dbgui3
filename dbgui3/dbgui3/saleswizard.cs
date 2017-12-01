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
        public saleswizard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (PartIDEntry.Text!="" && PriceEntry.Text!="" && CustomerIDEntry.Text!="" && ReceiptIDEntry.Text!="" && QuantityEntry.Text!="" && DateEntry.Text!="")
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (PartIDEntry.Text != "" && PriceEntry.Text != "" && CustomerIDEntry.Text != "" && ReceiptIDEntry.Text != "" && QuantityEntry.Text != "" && DateEntry.Text != "")
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void CustomerIDEntry_TextChanged(object sender, EventArgs e)
        {
            if (PartIDEntry.Text != "" && PriceEntry.Text != "" && CustomerIDEntry.Text != "" && ReceiptIDEntry.Text != "" && QuantityEntry.Text != "" && DateEntry.Text != "")
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void PriceEntry_TextChanged(object sender, EventArgs e)
        {
            if (PartIDEntry.Text != "" && PriceEntry.Text != "" && CustomerIDEntry.Text != "" && ReceiptIDEntry.Text != "" && QuantityEntry.Text != "" && DateEntry.Text != "")
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void QuantityEntry_TextChanged(object sender, EventArgs e)
        {
            if (PartIDEntry.Text != "" && PriceEntry.Text != "" && CustomerIDEntry.Text != "" && ReceiptIDEntry.Text != "" && QuantityEntry.Text != "" && DateEntry.Text != "")
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void DateEntry_TextChanged(object sender, EventArgs e)
        {
            if (PartIDEntry.Text != "" && PriceEntry.Text != "" && CustomerIDEntry.Text != "" && ReceiptIDEntry.Text != "" && QuantityEntry.Text != "" && DateEntry.Text != "")
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void ReceiptIDEntry_TextChanged(object sender, EventArgs e)
        {
            if (PartIDEntry.Text != "" && PriceEntry.Text != "" && CustomerIDEntry.Text != "" && ReceiptIDEntry.Text != "" && QuantityEntry.Text != "" && DateEntry.Text != "")
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void saleswizard_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Call Insert Function here
        }
    }
}
