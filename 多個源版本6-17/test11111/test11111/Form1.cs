using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;


namespace test11111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string REG = "\"token\":\"(?<header>[^\"]*)";
            string REG2 = "\"2c20ef4513a42445f7f0820a92a8a6a5\":\"(?<count>[^\"]*)";//count
            string NameREG = "name:\"(?<name>[^\"]*)";
            string header;
            string result;
            WebClient MyClient = new WebClient();

         
                result = MyClient.DownloadString("http://www.iwencai.com/stockpick/search?typed=1&preParams=&ts=1&f=1&qs=1&selfsectsn=&querytype=&searchfilter=&tid=stockpick&w=pe");
                Regex R = new Regex(REG);
                Regex R2 = new Regex(REG2);
                MatchCollection MC = R.Matches(result);
                MatchCollection MC2 = R2.Matches(result);
               header = MC[0].Groups["header"].Value.ToString();
               string count = MC2[0].Groups["count"].Value.ToString();
               string URL = "http://www.iwencai.com/stockpick/cache?token=" + header + "&perpage="+count;
               textBox1.Text = URL;
               string temp = MyClient.DownloadString(URL);
               //股票代码 股票简称 涨跌幅 现价元 市盈率 预测市盈率 ― 市净率 总股本 股所属申万行业
               string Reg = "\\[\"[0-9]+.[A-z]+\",\"(?<name>[^\"]*)\",\"(?<pct>[^\"]*)\",\"(?<current>[^\"]*)\",\"(?<lyr>[^\"]*)\",\"[^\"]*\",\"(?<pb>[^\"]*)\",\"(?<mc>[^\"]*)\",\"[^\"]*\"\\]";
               Regex REG3 = new Regex(Reg);
               MatchCollection MC3 = REG3.Matches(temp);









               DataTable DT = new DataTable();
               DT.Columns.Add("name", typeof(string));
               DT.Columns.Add("pct", typeof(float));
               DT.Columns.Add("current", typeof(float));
               DT.Columns.Add("lyr", typeof(float));
               DT.Columns.Add("pb", typeof(float));
               DT.Columns.Add("mc", typeof(float));
               string[] result2 = new string[(int.Parse(count) * 6)];
               MessageBox.Show(result2.Length.ToString());
               int row = 0;
               for (int i = 0; i <int.Parse(count); i++)
               {
                   string StockName = "";
                   string TempString = MC3[i].Groups["name"].Value.ToString();
                   string[] strlist = TempString.Replace("\\", "").Split('u');
                   
                   for (int tempRow = 1; tempRow < strlist.Length; tempRow++)
                   {
                       //将unicode字符转为10进制整数，然后转为char中文字符             
                       StockName += (char)int.Parse(strlist[tempRow], System.Globalization.NumberStyles.HexNumber);
                   }
                   result2[row++] = StockName;
                   result2[row++] = MC3[i].Groups["pct"].Value.ToString();
                   result2[row++] = MC3[i].Groups["current"].Value.ToString();
                   result2[row++] = MC3[i].Groups["lyr"].Value.ToString();
                   result2[row++] = MC3[i].Groups["pb"].Value.ToString();
                   result2[row++] = MC3[i].Groups["mc"].Value.ToString();
               }
               row = 0;
               for (int i = 0; i < int.Parse(count); i++)
               {
                   DataRow DR = DT.NewRow();
                   DR["name"]=result2[row++];
                   try
                   {
                       DR["pct"] =float.Parse( result2[row++]);
                   }
                   catch (Exception err)
                   {
                       DR["pct"] = 0;
                   }
                   try
                   {
                       DR["current"] = float.Parse(result2[row++]);
                   }
                   catch (Exception err)
                   {
                       DR["current"] = 0;
                   }
                   try
                   {
                       DR["lyr"] =float.Parse(( result2[row++]));
                   }
                   catch
                   {
                       DR["lyr"] = 0;
                   }
                   try
                   {
                       DR["pb"] = float.Parse(result2[row++]);
                   }
                   catch (Exception err)
                   {
                       DR["pb"] = 0;
                   } try
                   {
                       //找到E  提取E 後1位到STRING 尾 INT
                       //數據源去掉E後的字符 轉FLOAT * INT

                       long DigitResult = 10;
                       string TempResult = result2[row++];
                       int b = TempResult.IndexOf("E");
                       int Digit = int.Parse(TempResult.Substring(b + 1, TempResult.Length - 1 - b));
                       for (int DigitCount = 0; DigitCount < Digit - 1; DigitCount++)
                       {
                           DigitResult *= 10;
                       }
                       float AfterTansfewFloat = float.Parse(TempResult.Substring(0, b - 1)) * (DigitResult);

                       DR["mc"] = AfterTansfewFloat;
                   }
                   catch (Exception err)
                   {
                       DR["mc"] = 0;
                   }
                   DT.Rows.Add(DR);
               }
               DataRow[] DR2 = DT.Select("");





               MessageBox.Show(DR2.Count().ToString());
               foreach (DataRow DR3 in DR2)
               {
                   MessageBox.Show(DR3["name"].ToString() + DR3["mc"].ToString() + " " + DR3["lyr"].ToString());
               }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string sad = "12345657";
            sad = sad.Substring(0,3);
            MessageBox.Show(sad);

           /* long  DigitResult = 10;
            string a = "1.372636E15";
            int b = a.IndexOf("E");

            int Digit = int.Parse(a.Substring(b+1,a.Length-1-b));

            for (int DigitCount = 0; DigitCount < Digit-1; DigitCount++)
            {
                DigitResult *= 10;

            }

            long result = float.Parse(a.Substring(0, b - 1)) * (DigitResult);

            MessageBox.Show("E在:"+b.ToString()+ " 位數:"+ Digit.ToString() +" 結果:"+result.ToString());*/
        }

    }
}
