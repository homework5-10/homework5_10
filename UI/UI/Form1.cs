using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UI
{
    
    public partial class Form1 : Form
    {
        string page = null;
        GetNetData.StockDaTa ST = new GetNetData.StockDaTa();
        public Form1()
        {
            InitializeComponent();
            ReSetTextBox();
        }

        private void basetest_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTotMark.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
              
        }

        private void EditToChoose_Click(object sender, EventArgs e)
        {
            
            ST.SetCookie();
            ST.ReSetUrl();
            string[] TempHold =new string[2];
            string head = "&";
            string space = "_";
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            AddColumn("StockName", "股票名");
            AddColumn("StockPct", "升幅");
            AddColumn("StockCurrent", "現金");


            //&page=1 "; 
            if (CheckTotMark.Checked == true)
            {//&mc=0_22712.9033
                ClearStr(TempHold);
                TempHold[0] =  head + "mc=" +textBox1.Text + space;
                TempHold[1] = textBox2.Text;
                ST.SetUrl(TempHold);


                AddColumn("mc", "總股本");
                
            }

            if (CheckTotStockCost.Checked == true)
            {
              //  &fmc=0_20094.5292
                ClearStr(TempHold);
                TempHold[0] = head + "fmc=" + textBox3.Text + space;
                TempHold[1] = textBox4.Text;
                ST.SetUrl(TempHold);
                AddColumn("fmc", "流通股本");
            }
            if (CheckPettm.Checked == true)
            {
                //  &pettm=0_23356.1131
                ClearStr(TempHold);
                TempHold[0] = head + "pettm=" + textBox5.Text + space;
                TempHold[1] = textBox6.Text;
                ST.SetUrl(TempHold);
                AddColumn("pettm", "动态市盈率(倍)");
            }

            if (CheckPelyr.Checked == true)
            {
                //&pelyr=0_57091.7255
                ClearStr(TempHold);
                TempHold[0] = head + "pelyr=" + textBox7.Text + space;
                TempHold[1] = textBox8.Text;
                ST.SetUrl(TempHold);
                AddColumn("pelyr", "静态市盈率(倍)");
            }

            if (CheckEPS.Checked == true)
            {
                //&eps.20150331=-0.55_3.82
                ClearStr(TempHold);
                TempHold[0] = head + "eps=" + textBox9.Text + space;
                TempHold[1] = textBox10.Text;
                ST.SetUrl(TempHold);
                AddColumn("eps", "每股收益");
            }

            if (CheckPB.Checked == true)
            {
                //&pb=0_8085.71
                ClearStr(TempHold);
                TempHold[0] = head + "pb=" + textBox11.Text + space;
                TempHold[1] = textBox12.Text;
                ST.SetUrl(TempHold);
                AddColumn("pb", "市净率(倍)");
            }

            if (CheckDY.Checked == true)
            {
                // &dy=0_9.65 
                ClearStr(TempHold);
                TempHold[0] = head + "dy=" + textBox21.Text + space;
                TempHold[1] = textBox22.Text;
                ST.SetUrl(TempHold);
                AddColumn("dy", "股息率");
            }

            if (CheckBPS.Checked == true)
            {
                // &bps.20150331=-3.8_50.6
                ClearStr(TempHold);
                TempHold[0] = head + "bps="+ textBox23.Text + space;
                TempHold[1] = textBox24.Text;
                ST.SetUrl(TempHold);
                AddColumn("bps", "每股淨資產");
            }

            if (CheckRoediluted.Checked == true)
            {
                //&roediluted.20150331=-8995.84_38.37
                ClearStr(TempHold);
                TempHold[0] = head + "roediluted=" + textBox17.Text + space;
                TempHold[1] = textBox18.Text;
                ST.SetUrl(TempHold);
                AddColumn("roediluted", "净资产收益率(%)");
            }
            ShowReslut(ST);

        }

        private void ShowReslut(GetNetData.StockDaTa ST)
        {
            try
            {
                string Url = ST.GetUrl();
                Url = Url + "&page=" + page;
                string Data = ST.Get(Url);
                string[] Relut = ST.SpiltStr(Data);
                int row = Relut.Count();
                int RowUpper = row / 12;
                int DataRows = 0;

                for (int i = 0; i < RowUpper; i++)
                {
                    int index = dataGridView1.Rows.Add();
                    if (IsExist("StockName"))
                        dataGridView1.Rows[index].Cells["StockName"].Value = Relut[DataRows + 0];
                    if (IsExist("StockPct"))
                        dataGridView1.Rows[index].Cells["StockPct"].Value = Relut[DataRows + 11];

                    if (IsExist("StockCurrent"))
                        dataGridView1.Rows[index].Cells["StockCurrent"].Value = Relut[DataRows + 10];
                    if (IsExist("mc"))
                        dataGridView1.Rows[index].Cells["mc"].Value = Relut[DataRows + 1];

                    if (IsExist("fmc"))
                        dataGridView1.Rows[index].Cells["fmc"].Value = Relut[DataRows + 2];

                    if (IsExist("pettm"))
                        dataGridView1.Rows[index].Cells["pettm"].Value = Relut[DataRows + 3];

                    if (IsExist("pelyr"))
                        dataGridView1.Rows[index].Cells["pelyr"].Value = Relut[DataRows + 4];

                    if (IsExist("eps"))
                        dataGridView1.Rows[index].Cells["eps"].Value = Relut[DataRows + 5];

                    if (IsExist("pb"))
                        dataGridView1.Rows[index].Cells["pb"].Value = Relut[DataRows + 9];

                    if (IsExist("dy"))
                        dataGridView1.Rows[index].Cells["dy"].Value = Relut[DataRows + 8];

                    if (IsExist("bps"))
                        dataGridView1.Rows[index].Cells["bps"].Value = Relut[DataRows + 6];

                    if (IsExist("roediluted"))
                        dataGridView1.Rows[index].Cells["roediluted"].Value = Relut[DataRows + 7];
                    DataRows += 12;
                }

                comboBox1.Items.Clear();
                int PageUpper = 0;
                if (row % 12 != 0)
                {
                    PageUpper++;
                }
                PageUpper += ST.GetCount() / 30;
                for (int PaperNum = 1; PaperNum <= PageUpper; PaperNum++)
                {
                    comboBox1.Items.Add(PaperNum.ToString());
                }
                if (row > 0 && page ==null)
                    page = "1";
                comboBox1.Text = page;
                TotatalCount.Text = "共有" + ST.GetCount().ToString()+"支股票符合條件";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
   /*     private int i = 0;
        private void basetest_CheckedChanged(object sender, EventArgs e)
        {
          System.Drawing.Point p1 =  basetest.Location;
          MessageBox.Show(p1.ToString());

            i++;
            Button b = new Button();//创建一个新的按钮
            b.Name = "b" + i;//这是我用来区别各个按钮的办法
            System.Drawing.Point p = new Point(12, 13 + i * 30);//创建一个坐标,用来给新的按钮定位
            b.Location = p;//把按钮的位置与刚创建的坐标绑定在一起
            
            panel1.Controls.Add(b);//向panel中添加此按钮

            b.Click += new System.EventHandler(btn_click);
        }
        private void btn_click(object sender, System.EventArgs e)
        {
            Button b1 = (Button)sender;//将触发此事件的对象转换为该Button对象

            MessageBox.Show("" + b1.Name);
            b1.Dispose();
            
        }*/

        public void ClearStr(string[] target)
        {
            int row = target.Count();
            for (int Index = 0; Index < row; Index++)
            {
                target[Index] = null;
            }
        }

        public void AddColumn(string Name, string Header)
        {
            
            DataGridViewTextBoxColumn AddViewCol = new DataGridViewTextBoxColumn();
            AddViewCol.DataPropertyName = Name;
            AddViewCol.Name = Name;
            AddViewCol.ReadOnly = true;
            AddViewCol.HeaderText = Header;
            dataGridView1.Columns.Add(AddViewCol);
        }

        public bool IsExist(string ColumnName)
        {
            int ColumnUpper =dataGridView1.ColumnCount;
            for (int Index = 0; Index < ColumnUpper; Index++)
            {
                if (dataGridView1.Columns[Index].Name == ColumnName)
                {
                    return true;
                }
            }
            return false;
        }

        public void ReSetTextBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = string.Empty;
                    tb.Enabled = false;
                }
            }
            foreach (Control c in this.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            ST.ReSetUrl();
            ReSetTextBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (page != comboBox1.Text)
            {
                dataGridView1.Rows.Clear();
                comboBox1.Items.Clear();
                page = comboBox1.Text;
                ShowReslut(ST);
            }
            
        }

        private void CheckTotStockCost_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTotStockCost.Checked == true)
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void CheckPettm_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPettm.Checked == true)
            {
                textBox5.Enabled = true;
                textBox6.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
                textBox6.Enabled = false;
            }
        }

        private void CheckPelyr_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPelyr.Checked == true)
            {
                textBox7.Enabled = true;
                textBox8.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                textBox8.Enabled = false;
            }
        }

        private void CheckEPS_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckEPS.Checked == true)
            {
                textBox9.Enabled = true;
                textBox10.Enabled = true;
            }
            else
            {
                textBox9.Enabled = false;
                textBox10.Enabled = false;
            }
        }

        private void CheckPB_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPB.Checked == true)
            {
                textBox11.Enabled = true;
                textBox12.Enabled = true;
            }
            else
            {
                textBox11.Enabled = false;
                textBox12.Enabled = false;
            }
        }

        private void CheckRoediluted_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckRoediluted.Checked == true)
            {
                textBox17.Enabled = true;
                textBox18.Enabled = true;
            }
            else
            {
                textBox17.Enabled = false;
                textBox18.Enabled = false;
            }
        }

        private void CheckDY_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDY.Checked == true)
            {
                textBox21.Enabled = true;
                textBox22.Enabled = true;
            }
            else
            {
                textBox21.Enabled = false;
                textBox22.Enabled = false;
            }
        }

        private void CheckBPS_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBPS.Checked == true)
            {
                textBox23.Enabled = true;
                textBox24.Enabled = true;
            }
            else
            {
                textBox23.Enabled = false;
                textBox24.Enabled = false;
            }

        }


    }
}
