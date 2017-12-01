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
            //part_id, p_date, price_per, base_cost
            ColumnSeries col1 = new ColumnSeries() { DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
            
            ColumnSeries col2 = new ColumnSeries() { DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString() };
            Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
            ax.Labels = new List<string>();
            foreach(DataRow purchase in dt.Rows)
            {
                double sum = (double)purchase[2] * (double)purchase[3];
                DateTime x = DateTime.Parse(purchase[1].ToString());
                int a = ax.Labels.IndexOf(x.Month.ToString() + "-" + x.Year.ToString());
                if (a == -1)
                {
                     ax.Labels.Add(x.Month.ToString() + "-" + x.Year.ToString());
                    col1.Values.Add(sum);
                }
                else
                {
                    col1.Values[a] = (double)col1.Values[a] + sum;
                }
            }
            foreach (DataRow sale in dt.Rows)
            {
                double sum2 = (double)sale[2] * (double)sale[4];
                DateTime x = DateTime.Parse(sale[1].ToString());
                int a = ax.Labels.IndexOf(x.Month.ToString() + "-" + x.Year.ToString());
                if (a == -1)
                {
                    ax.Labels.Add(x.Month.ToString() + "-" + x.Year.ToString());
                    col2.Values.Add(sum2);
                }
                else
                {
                    col2.Values[a] = (double)col2.Values[a] + sum2;
                }
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
