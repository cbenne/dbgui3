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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            uxHomeButton.BackColor = Color.Silver;
            homecontrol1.BringToFront();
        }

        private void uxHomeButton_Click(object sender, EventArgs e)
        {
            tabchange();
            uxHomeButton.BackColor = Color.Silver;
            homecontrol1.BringToFront();
        }

        private void uxPartsButton_Click(object sender, EventArgs e)
        {
            tabchange();
            uxPartsButton.BackColor = Color.Silver;
            partscontrol1.BringToFront();
        }

        private void uxJobsButton_Click(object sender, EventArgs e)
        {
            tabchange();
            uxJobsButton.BackColor = Color.Silver;
            jobcontrol1.BringToFront();
        }

        private void uxSalesButton_Click(object sender, EventArgs e)
        {
            tabchange();
            uxSalesButton.BackColor = Color.Silver;
            salescontrol1.BringToFront();
        }

        private void uxOrdersButton_Click(object sender, EventArgs e)
        {
            tabchange();
            uxOrdersButton.BackColor = Color.Silver;
            ordercontrol1.BringToFront();
        }

        private void uxEmployeesButton_Click(object sender, EventArgs e)
        {
            tabchange();
            uxEmployeesButton.BackColor = Color.Silver;
            employeecontrol1.BringToFront();
        }

        private void uxAnalysisButton_Click(object sender, EventArgs e)
        {
            tabchange();
            uxAnalysisButton.BackColor = Color.Silver;
        }

        private void tabchange()
        {
            uxHomeButton.BackColor = Color.Transparent;
            uxPartsButton.BackColor = Color.Transparent;
            uxJobsButton.BackColor = Color.Transparent;
            uxSalesButton.BackColor = Color.Transparent;
            uxOrdersButton.BackColor = Color.Transparent;
            uxEmployeesButton.BackColor = Color.Transparent;
            uxAnalysisButton.BackColor = Color.Transparent;
        }
    }
}
