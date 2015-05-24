using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  
            chart.Series.Add("1");
            chart.Series.Add("2");
            chart.Series["1"].XValueType = ChartValueType.Date;
            chart.Series["2"].XValueType = ChartValueType.Date;
            chart.Series["1"].BorderWidth = 3;
            chart.Series["1"].ChartType = SeriesChartType.StackedArea;
            chart.Series["2"].ChartType = SeriesChartType.StackedArea;
            chart.Series["2"].BorderWidth = 3;
            chart.Series["1"].IsValueShownAsLabel = false;//是否顯示點的值
            chart.Series["1"].XValueType = ChartValueType.Date;*/
            DateTime DT1 = Convert.ToDateTime("2015-1-12");
            DateTime DT2 =Convert.ToDateTime("2015-3-13");
            DateTime DT3 =Convert.ToDateTime("2015-3-5");
            DateTime DT4 = Convert.ToDateTime("2015-3-11");
            DateTime DT5 = Convert.ToDateTime("2015-3-23");
            DateTime DT6 = Convert.ToDateTime("2015-3-26");
            DateTime DT7 = Convert.ToDateTime("2015-3-27");
         /*   chart.Series["1"].Points.AddXY(DT1, "7");
            chart.Series["1"].Points.AddXY(DT2, "2");
            chart.Series["1"].Points.AddXY(DT3, "9");
            chart.Series["2"].Points.AddXY(DT1, "1");
            chart.Series["2"].Points.AddXY(DT2, "3");
            chart.Series["2"].Points.AddXY(DT3, "3");*/


            add("1");
                chart.Series["1"].Points.AddXY(DT1,"3000");
                chart.Series["1"].Points.AddXY(DT2, "0");

            
                add("2");
                chart.Series["2"].Points.AddXY(DT1, "10000");
                chart.Series["2"].Points.AddXY(DT2, "0");

                add("3");
                chart.Series["3"].Points.AddXY(DT1, "0");
                chart.Series["3"].Points.AddXY(DT2, "-2497");

                add("4");
                chart.Series["4"].Points.AddXY(DT5, "10000");
                chart.Series["4"].Points.AddXY(DT6, "100");

                add("5");
                chart.Series["5"].Points.AddXY(DT5, "5000");
                chart.Series["5"].Points.AddXY(DT7, "6900");
 
            


        }

        public void add(string name)
        {
            chart.Series.Add(name);
            chart.Series[name].XValueType = ChartValueType.Date;
            chart.Series[name].BorderWidth = 3;
            chart.Series[name].ChartType = SeriesChartType.StackedArea;
            chart.Series[name].IsValueShownAsLabel = false;//是否顯示點的值

        }
    }
}
