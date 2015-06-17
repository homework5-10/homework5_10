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
        GetNetData.XueQiuSocure ST = new GetNetData.XueQiuSocure();
        Panel NowDisplay = null;
        DataSet DS = new DataSet();
        ToolStripMenuItem subitem = null;
        GetNetData.GetNetData GND = null;

        public Form1()
        {
            InitializeComponent();
            subitem = AddContextMenu("已藏條件", menuStrip.Items, null);
            additem();
            ChangeDataSource.Text = ChangeDataSource.Items[0].ToString();
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
            if (ChangeDataSource.Text == "雪球源")
            {
                GND.SetCookie();
                GND.ReSetUrl();
                string[] TempHold = new string[2];
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
                    TempHold[0] = head + "mc=" + textBox1.Text + space;
                    TempHold[1] = textBox2.Text;
                    GND.SetUrl(TempHold);


                    AddColumn("mc", "總股本");

                }

                if (CheckTotStockCost.Checked == true)
                {
                    //  &fmc=0_20094.5292
                    ClearStr(TempHold);
                    TempHold[0] = head + "fmc=" + textBox3.Text + space;
                    TempHold[1] = textBox4.Text;
                    GND.SetUrl(TempHold);
                    AddColumn("fmc", "流通股本");
                }
                if (CheckPettm.Checked == true)
                {
                    //  &pettm=0_23356.1131
                    ClearStr(TempHold);
                    TempHold[0] = head + "pettm=" + textBox5.Text + space;
                    TempHold[1] = textBox6.Text;
                    GND.SetUrl(TempHold);
                    AddColumn("pettm", "动态市盈率(倍)");
                }

                if (CheckPelyr.Checked == true)
                {
                    //&pelyr=0_57091.7255
                    ClearStr(TempHold);
                    TempHold[0] = head + "pelyr=" + textBox7.Text + space;
                    TempHold[1] = textBox8.Text;
                    GND.SetUrl(TempHold);
                    AddColumn("pelyr", "静态市盈率(倍)");
                }

                if (CheckEPS.Checked == true)
                {
                    //&eps.20150331=-0.55_3.82
                    ClearStr(TempHold);
                    TempHold[0] = head + "eps=" + textBox9.Text + space;
                    TempHold[1] = textBox10.Text;
                    GND.SetUrl(TempHold);
                    AddColumn("eps", "每股收益");
                }

                if (CheckPB.Checked == true)
                {
                    //&pb=0_8085.71
                    ClearStr(TempHold);
                    TempHold[0] = head + "pb=" + textBox11.Text + space;
                    TempHold[1] = textBox12.Text;
                    GND.SetUrl(TempHold);
                    AddColumn("pb", "市净率(倍)");
                }

                if (CheckDY.Checked == true)
                {
                    // &dy=0_9.65 
                    ClearStr(TempHold);
                    TempHold[0] = head + "dy=" + textBox21.Text + space;
                    TempHold[1] = textBox22.Text;
                    GND.SetUrl(TempHold);
                    AddColumn("dy", "股息率");
                }

                if (CheckBPS.Checked == true)
                {
                    // &bps.20150331=-3.8_50.6
                    ClearStr(TempHold);
                    TempHold[0] = head + "bps=" + textBox23.Text + space;
                    TempHold[1] = textBox24.Text;
                    GND.SetUrl(TempHold);
                    AddColumn("bps", "每股淨資產");
                }

                if (CheckRoediluted.Checked == true)
                {
                    //&roediluted.20150331=-8995.84_38.37
                    ClearStr(TempHold);
                    TempHold[0] = head + "roediluted=" + textBox17.Text + space;
                    TempHold[1] = textBox18.Text;
                    GND.SetUrl(TempHold);
                    AddColumn("roediluted", "净资产收益率(%)");
                }
                page = null;
                ShowReslut(GND);
            }


            if (ChangeDataSource.Text == "同花順源") 
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                string SelectCondition = "";
                DataTable DT = new DataTable();
                DT.Columns.Add("name", typeof(string));
                DT.Columns.Add("pct", typeof(float));
                DT.Columns.Add("current", typeof(float));
                DT.Columns.Add("lyr", typeof(float));
                DT.Columns.Add("pb", typeof(float));
                DT.Columns.Add("mc", typeof(float));


                GND.SetCookie();
                string URL = GND.SetUrl(null);
                string SourceData = GND.Get(URL);
                string[] result = GND.SpiltStr(SourceData);

                if (PCTCheckBox.Checked == true)
                {
                    SelectCondition += "and pct>" + "'" + MinPCT.Text + "'";
                    SelectCondition += "and pct<" + "'" + MaxPCT.Text + "'";
                }

                if (PBCheckBox.Checked == true)
                {
                    SelectCondition += "and pb>" + "'" + MinPB.Text + "'";
                    SelectCondition += "and pb<" + "'" + MaxPB.Text + "'";
                }


                if (MCCheckBox.Checked == true)
                {
                    SelectCondition += "and mc>" + "'" + MinMC.Text + "'";
                    SelectCondition += "and mc<" + "'" + MaxMC.Text + "'";
                }


                if (LYRCheckBox.Checked == true)
                {
                    SelectCondition += "and lyr>" + "'" + MinLYR.Text + "'";
                    SelectCondition += "and lyr<" + "'" + MaxLYR.Text + "'";
                }

               // MessageBox.Show(SelectCondition);
                //如果開頭是AND 去掉
                if (SelectCondition != "")
                {
                    if (SelectCondition.Substring(0, 3) == "and")
                    {
                        SelectCondition = SelectCondition.Remove(0, 4);
                    }
                }


                //傳值  再查詢
                for(int row=0;row<result.Length;)
                {
                    DataRow DR = DT.NewRow();
                    DR["name"] = result[row++];
                    try
                    {
                        DR["pct"] = float.Parse(result[row++]);
                    }
                    catch (Exception err)
                    {
                        DR["pct"] = 0;
                    }
                    try
                    {
                        DR["current"] = float.Parse(result[row++]);
                    }
                    catch (Exception err)
                    {
                        DR["current"] = 0;
                    }
                    try
                    {
                        DR["lyr"] = float.Parse((result[row++]));
                    }
                    catch
                    {
                        DR["lyr"] = 0;
                    }
                    try
                    {
                        DR["pb"] = float.Parse(result[row++]);
                    }
                    catch (Exception err)
                    {
                        DR["pb"] = 0;
                    } try
                    {
                        //找到E  提取E 後1位到STRING 尾 INT
                        //數據源去掉E後的字符 轉FLOAT * INT

                        long DigitResult = 10;
                        string TempResult = result[row++];
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
                DataRow[] SelectResult = DT.Select(SelectCondition);
                AddColumn("name","股票名");
                AddColumn("pct", "涨跌幅");
                AddColumn("current", "现价元");
                AddColumn("lyr", "市盈率");
                AddColumn("pb", "市净率");
                AddColumn("mc", "总股本");

                foreach (DataRow TempDT in SelectResult)
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells["name"].Value = TempDT["name"].ToString();
                    dataGridView1.Rows[index].Cells["pct"].Value = TempDT["pct"].ToString();
                    dataGridView1.Rows[index].Cells["lyr"].Value = TempDT["lyr"].ToString();
                    dataGridView1.Rows[index].Cells["current"].Value = TempDT["current"].ToString();
                    dataGridView1.Rows[index].Cells["pb"].Value = TempDT["pb"].ToString();
                    dataGridView1.Rows[index].Cells["mc"].Value = TempDT["mc"].ToString();
                }
                comboBox1.Text = "1";
                TotatalCount.Text = "共有" + SelectResult.Count().ToString() + "支股票符合條件";

            }

        }

        private void ShowReslut(GetNetData.GetNetData GND)
        {
            try
            {
                string Url = GND.GetUrl();
                Url = Url + "&page=" + page;
                string Data = GND.Get(Url);
                string[] Relut = GND.SpiltStr(Data);
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
                PageUpper += GND.GetCount() / 30;
                for (int PaperNum = 1; PaperNum <= PageUpper; PaperNum++)
                {
                    comboBox1.Items.Add(PaperNum.ToString());
                }
                if (row > 0 && page ==null)
                    page = "1";
                comboBox1.Text = page;
                TotatalCount.Text = "共有" + GND.GetCount().ToString() + "支股票符合條件";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }


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
            foreach (Control c in XueQiupanel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = string.Empty;
                    tb.Enabled = false;
                }
            }
            foreach (Control c in XueQiupanel.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                }
            }
            foreach (Control c in Iwencaipanel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = string.Empty;
                    tb.Enabled = false;
                }
            }
            foreach (Control c in Iwencaipanel.Controls)
            {
                if (c is CheckBox)
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
            if (ChangeDataSource.Text == "雪球源")
            {
                GND.ReSetUrl();
                page = null;
            }
            ReSetTextBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChangeDataSource.Text == "雪球源")
            {
                if (page != comboBox1.Text)
                {
                    dataGridView1.Rows.Clear();
                    comboBox1.Items.Clear();
                    page = comboBox1.Text;
                    ShowReslut(GND);
                }
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

        private void ChangeDataSource_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ChangeDataSource.Text == "雪球源")
            {
                GND = new GetNetData.XueQiuSocure();
                XueQiupanel.Visible = true;
                Iwencaipanel.Visible = false;
            }
            if (ChangeDataSource.Text == "同花順源")
            {
                GND = new GetNetData.IwencaiSocure();
                XueQiupanel.Visible = false;
                Iwencaipanel.Visible = true;
            }
        }

        private void PCTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PCTCheckBox.Checked == true)
            {
                MinPCT.Enabled = true;
                MaxPCT.Enabled = true;
            }
            else
            {
                MinPCT.Enabled = false;
                MaxPCT.Enabled = false;
            }
        }

        private void LYRCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LYRCheckBox.Checked == true)
            {
                MinLYR.Enabled = true;
                MaxLYR.Enabled = true;
            }
            else
            {
                MinLYR.Enabled = false;
                MaxLYR.Enabled = false;
            }
        }

        private void PBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PBCheckBox.Checked == true)
            {
                MinPB.Enabled = true;
                MaxPB.Enabled = true;
            }
            else
            {
                MinPB.Enabled = false;
                MaxPB.Enabled = false;
            }
        }

        private void MCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MCCheckBox.Checked == true)
            {
                MinMC.Enabled = true;
                MaxMC.Enabled = true;
            }
            else
            {
                MinMC.Enabled = false;
                MaxMC.Enabled = false;
            }

        }




        ToolStripMenuItem AddContextMenu(string text, ToolStripItemCollection cms, EventHandler callback)
        {
            if (text == "-")
            {
                ToolStripSeparator tsp = new ToolStripSeparator();
                cms.Add(tsp);
                return null;
            }
            else if (!string.IsNullOrEmpty(text))
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(text);
                tsmi.Tag = text + "TAG";
                if (callback != null) tsmi.Click += callback;
                cms.Add(tsmi);

                return tsmi;
            }

            return null;
        }

        void MenuClicked(object sender, EventArgs e)
        {
            //以下主要是动态生成事件并打开窗体
            string target = sender.ToString();

            foreach (Control CT in this.Controls)
            {
                if (CT is Panel)
                    CT.Visible = false;
            }

            foreach (DataTable DT in DS.Tables)
            {
               string[] Name = DT.TableName.Split('_');
                if (Name[1] == target)
                {

                    foreach (Control P in this.Controls)
                    {
                        if (P is Panel)
                        {
                            if (P.Name == Name[0])
                            {
                                NowDisplay = (Panel)P;
                                P.Visible = true;
                            }
                        }
                    }
                    string TableName = Name[0]+"_"+Name[1];
                    foreach (Control CT in NowDisplay.Controls)
                    {
                        foreach(DataRow DR in DS.Tables[TableName].Rows)
                        {
                        //    MessageBox.Show(DR["ControlType"].GetType().ToString());
                            if (DR["ControlType"].ToString() ==  "System.Windows.Forms.TextBox")
                            {
                              
                                if (CT.Name == DR["Control"])
                                {
                                    CT.Text =DR["ControlStatus"].ToString();
                                }
                            }
                            if (DR["ControlType"].ToString() == "System.Windows.Forms.CheckBox")
                            {
                                if (CT.Name == DR["Control"])
                                {
                                    CheckBox Temp = (CheckBox)CT;
                               
                                    if (DR["ControlStatus"].ToString() == "True")
                                        Temp.Checked = true;
                                    else
                                        Temp.Checked = false;
                                }
                            }
                        }
                        foreach (Control C in this.Controls)
                        {
                            if (C.Name == ChangeDataSource.Name)
                            {
                                foreach (DataRow DR in DS.Tables[TableName].Rows)
                                {
                                    if (DR["ControlType"].ToString() == "System.Windows.Forms.ComboBox")
                                    {
                                        if (C.Name == DR["Control"])
                                        {
                                            C.Text = DR["ControlStatus"].ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            
        }
        

        private void KeepConditionButton_Click(object sender, EventArgs e)
        {

            ConditionNameForm CNF = new ConditionNameForm();
            string NowDisplayName = null;
            bool CanCreatKeepConditionItem = true;
            CNF.ShowDialog();

            if (CNF.EditButton.DialogResult == DialogResult.OK)
            {
                foreach (DataTable CheckName in DS.Tables)
                {
                    if (CNF.Text == "" && CNF.Text == CheckName.TableName)
                    {
                        CanCreatKeepConditionItem = false;
                    }
                }

                if (CanCreatKeepConditionItem == true)
                {
                    foreach (Control P in this.Controls)
                    {
                        if (P is Panel)
                        {
                            if (P.Visible == true)
                            {
                                NowDisplayName = P.Name;
                            }
                        }
                    }
                    AddContextMenu(CNF.NameTextBox.Text, subitem.DropDownItems, new EventHandler(MenuClicked));
                    DataTable DT = new DataTable();
                    string Name = NowDisplayName + "_" + CNF.NameTextBox.Text;
                    DS.Tables.Add(Name);
                    DS.Tables[Name].Columns.Add("ControlType");
                    DS.Tables[Name].Columns.Add("Control");
                    DS.Tables[Name].Columns.Add("ControlStatus");
                    //記錄 PANEL  PANEL內控件  COMBOX 狀態
                    foreach (Control P in this.Controls)
                    {
                        if (P is Panel)
                        {
                            if (P.Visible == true)
                            {
                                DataRow DR = DS.Tables[Name].NewRow();
                                DR["ControlType"] = P.GetType();
                                DR["Control"] = P.Name;
                                DR["ControlStatus"] = P.Visible;
                                DS.Tables[Name].Rows.Add(DR);
                                NowDisplay = (Panel)P;
                                NowDisplay.Name = P.Name;
                                NowDisplay.Visible = P.Visible;
                            }
                        }
                    }
                    foreach (Control CT in NowDisplay.Controls)
                    {
                        if (CT is TextBox)
                        {
                            DataRow DR = DS.Tables[Name].NewRow();
                            DR["ControlType"] = CT.GetType();
                            DR["Control"] = CT.Name;
                            DR["ControlStatus"] = CT.Text;
                            DS.Tables[Name].Rows.Add(DR);

                        }


                        if (CT is CheckBox)
                        {
                            DataRow DR = DS.Tables[Name].NewRow();
                            CheckBox Temp = (CheckBox)CT;
                            DR["ControlType"] = Temp.GetType();
                            DR["Control"] = Temp.Name;
                            DR["ControlStatus"] = Temp.Checked;
                            DS.Tables[Name].Rows.Add(DR);

                        }

                    }
                    DataRow DR2 = DS.Tables[Name].NewRow();
                    DR2["ControlType"] = ChangeDataSource.GetType();
                    DR2["Control"] = ChangeDataSource.Name;
                    DR2["ControlStatus"] = ChangeDataSource.Text;
                    DS.Tables[Name].Rows.Add(DR2);

                }
            }

        }

        void additem()
        {
            ChangeDataSource.Items.Add("雪球源");
            ChangeDataSource.Items.Add("同花順源");
        }


    }
}
