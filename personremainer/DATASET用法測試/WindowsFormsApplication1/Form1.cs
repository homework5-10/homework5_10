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
            DataSet DS = new DataSet("my");
            //創表
            DS.Tables.Add("my");
            DS.Tables.Add("my1");
            DS.Tables["my1"].Columns.Add("UserName");
            DS.Tables["my1"].Columns.Add("ReMark");
            DS.Tables["my1"].Columns.Add("Comment");
            DataRow dr = DS.Tables["my1"].NewRow();
           
            MessageBox.Show("ok");
           
            dr["UserName"] = "周讯";
            dr["ReMark"] = "100";
            dr["Comment"] = "漂亮MM";
            DS.Tables["my1"].Rows.Add(dr);
            //每一行都要NEWROW一次
            dr = DS.Tables["my1"].NewRow();
            dr["UserName"] = "2周讯";
            dr["ReMark"] = "2";
            dr["Comment"] = "2漂亮MM";
            DS.Tables["my1"].Rows.Add(dr);
            DS.Tables[1].Rows[1][2] = "new";

            MessageBox.Show(DS.Tables[1].Rows[1][2].ToString());
        }
    }
}
