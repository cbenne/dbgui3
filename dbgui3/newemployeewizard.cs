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
    public partial class newemployeewizard : Form
    {
        public newemployeewizard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add employee function
            MessageBox.Show(FunctionsList.insertEmployee(uxTitle.Text, uxSalary.Value.ToString(), uxName.Text, uxAddress.Text));
        }
    }
}
