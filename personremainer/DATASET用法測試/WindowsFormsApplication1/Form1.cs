using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


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

            DateTime A = Convert.ToDateTime( dateTimePicker1.Text.ToString());
            DateTime B = Convert.ToDateTime(dateTimePicker2.Text.ToString());
            if (B > A)
            {
                MessageBox.Show(A.ToString() + B.ToString());
                int BA = int.Parse((B - A).TotalDays.ToString());

                MessageBox.Show(BA.ToString());
            }
            DataSet DS = new DataSet("my");
            //創表
            DS.Tables.Add("my");
            DS.Tables.Add("my1");
            DS.Tables["my1"].Columns.Add("UserName");
            DS.Tables["my1"].Columns.Add("ReMark",typeof(DateTime));
            DS.Tables["my1"].Columns.Add("Comment");
            MessageBox.Show(DS.Tables[0].Rows.Count.ToString());
            DataRow dr = DS.Tables["my1"].NewRow();

            dr["UserName"] = "周讯";
            dr["ReMark"] = "2015-1-22";
            dr["Comment"] = "漂亮MM";
            DS.Tables["my1"].Rows.Add(dr);
            //每一行都要NEWROW一次
            dr = DS.Tables["my1"].NewRow();
            dr["UserName"] = "2";
            dr["ReMark"] = "2015-3-02";
            dr["Comment"] = "2漂亮MM";
            DS.Tables["my1"].Rows.Add(dr);
            dr = DS.Tables["my1"].NewRow();
            dr["UserName"] = "2";
            dr["ReMark"] = "2015-3-21";
            dr["Comment"] = "2漂亮MM";
            DS.Tables["my1"].Rows.Add(dr);

            dr = DS.Tables["my1"].NewRow();
            dr["UserName"] = "2";
            dr["ReMark"] = "2015-2-2";
            dr["Comment"] = "2漂亮MM";
            DS.Tables["my1"].Rows.Add(dr);
            dr = DS.Tables["my1"].NewRow();
            dr["UserName"] = "2";
            dr["ReMark"] = "2015-3-2";
            dr["Comment"] = "2漂亮MM";
            DS.Tables["my1"].Rows.Add(dr);
            MessageBox.Show(DS.Tables["my1"].Rows[0][1].ToString());

            //將DS 某表 賦給DT
            //DS排序 FILL回DS

/*

            DataRow[] rows = DS.Tables["my1"].Select("", "ReMark Asc");
            DataTable table = DS.Tables["my1"].Clone();
            for (int i = 0; i < rows.Length; i++)
            {
                DataRow row = table.NewRow();
                row.ItemArray = rows[i].ItemArray;
                table.Rows.Add(row);
            }

            for (int a = 0; a < rows.Length;a++ )
                MessageBox.Show(table.Rows[a][1].ToString());

            MessageBox.Show(table.Rows[0][1].ToString());

            DateTime dt = Convert.ToDateTime( table.Rows[0][1].ToString());
            MessageBox.Show(dt.ToString());
            dt.AddDays(1);
            MessageBox.Show(dt.ToString());
            dt = dt.AddDays(1);
            MessageBox.Show(dt.ToString());
            DS.Tables.Remove("my1");
            DS.Tables.Add(table);
            MessageBox.Show(DS.Tables[0].ToString());
            MessageBox.Show(DS.Tables["my1"].Columns.Count.ToString());
            MessageBox.Show(DS.Tables["my1"].Rows[0][0].ToString());
           // MessageBox.Show(DS.Tables[0].Rows[0][1].ToString());*/
        }
    }
}
