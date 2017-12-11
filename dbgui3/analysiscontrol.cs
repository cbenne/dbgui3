using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;

namespace dbgui3
{
    public partial class analysiscontrol : UserControl
    {
        public analysiscontrol()
        {
            InitializeComponent();
            DataTable dt = FunctionsList.analysisdata();
            foreach (DataRow r in dt.Rows)
            {
                chart1.Series["Sales Results"].Points.AddXY(r[0], r[1]);
                chart1.Series["Base Cost"].Points.AddXY(r[0], r[2]);
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
            
        
    }
}
