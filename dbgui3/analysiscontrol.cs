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
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

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

        private void cartesianChart1_ChildChanged_1(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            DataTable dt = FunctionsList.analysisdata();

            foreach (DataRow r in dt.Rows)
            {
                
            }
            using ()//database in paranthesis ex. Something db = new Something
            {
                var data1 = db. ;//function from database for purchases of product
                ColumnSeries col1 = new ColumnSeries() { DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                var data2 = db. ; //function from database for sales of product
                ColumnSeries col2 = new ColumnSeries() { DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
                Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
                ax.Labels = new List<string>();
                foreach(var x in data1)
                {
                    col1.Values.Add(x.Total.Value);
                    ax.Labels.Add(x.Month.toString());
                }
                foreach (var x in data2)
                {
                    col2.Values.Add(x.Total.Value);
                    ax.Labels.Add(x.Month.toString());
                }
                cartesianChart1.Series.Add(col1);
                cartesianChart1.Series.Add(col2);
                cartesianChart1.AxisX.Add(ax);
                cartesianChart1.AxisY.Add(new Axis
                {
                    LabelFormatter = value => value.ToString()
                });
            }
        }
    }
}
