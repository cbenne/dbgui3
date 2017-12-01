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
    public partial class homecontrol : UserControl
    {
        public homecontrol()
        {
            InitializeComponent();
            uxPartsLabel.Text = FunctionsList.totalParts().ToString();
            uxEmployeesLabel.Text = FunctionsList.totalEmployees().ToString();
            uxActiveJobsLabel.Text = FunctionsList.totalJobs().ToString();
        }
    }
}
