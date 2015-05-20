using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using System.Web;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;

namespace personremainer
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoSize(this);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           

            if (false == show_PerFor)
                show_PerFor = true;
            else if(true == show_PerFor)
                show_PerFor = false;
            
            if (true == show_PerFor)
            {
                splitContainer1.SplitterDistance = 200;
            }
            else if(false == show_PerFor)
                splitContainer1.SplitterDistance = 0;
        }




        private void 導入數據ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

 
        //持倉
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NotDisplay();
          

            if (false == show_TakSto)
                show_TakSto = true;
            else if(true == show_TakSto)
                show_TakSto = false;
            if (true == show_TakSto)
            {
                //清掉舊記錄的顯示
                while (TaStodataView.Rows.Count != 0)
                {
                    TaStodataView.Rows.Clear();
                }
                if (TaStochart.Series.Count != 0)
                {
                    TaStochart.Series.Clear();
                }


                DataSet DS = new DataSet();
                DataBase DB = new DataBase();

                DS = DB.ReadDB("userop", "id", 0);
                int ROWS = int.Parse(DS.Tables[0].Rows.Count.ToString());
                for (int row = 0; row < ROWS; row++)
                {
                    show_take_sto(DS.Tables[0].Rows[row][0].ToString(),1);
                    Draw_takchart(DS.Tables[0].Rows[row][0].ToString());
                }

                //顯示準備完後 顯示
                Display(panel1);
            }
            else if (false == show_TakSto)
                NotDisplay();
              
        }
 
        //股票資訊
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            NotDisplay();
            if (StoGrachart.Series.Count != 0)
            {
                StoGrachart.Series.Clear();
            }
            if (false == show_StoInf)
                show_StoInf = true;
            else if(true == show_StoInf)
                show_StoInf = false;
            if (true == show_StoInf)
            {
                Display(panel2);
                if (personremainer.commo_data.stockcode != null)
                {
                    show_stock_data(personremainer.commo_data.stockcode);
                    show_take_sto_textbox(personremainer.commo_data.stockcode);
                    show_take_kgraph(personremainer.commo_data.stockcode);
                }
            }
            else if (false == show_StoInf)
                NotDisplay();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //test
        
        }
        //搜索
        private void button1_Click(object sender, EventArgs e)
        {
            NotDisplay();
            string StockNum = textBox1.Text;
              personremainer.commo_data.stockcode = textBox1.Text;          
            //跳轉到股票資訊界面
              NotDisplay();
            show_StoInf = true;
            Display(panel2);
            show_stock_data(StockNum);
            show_take_sto_textbox(StockNum);
            show_take_kgraph(StockNum);
        }
          

        //搜索TEXT
        private void textBox1_TextChanged(object sender, EventArgs e)
        {      
 
        }

 
        //增加交易記錄後
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.label1.Text = personremainer.commo_data.StoName;
            frm2.ShowDialog();
            show_stock_data(personremainer.commo_data.stockcode);
           // personremainer.create_form.create_changeOpData();   
            //重算個人信息
            DataBase DB = new DataBase();
            DataSet DS = new DataSet();
            ClearPerData();
            DS = DB.ReadDB("userop", "id", 0);
            int ROWS = int.Parse(DS.Tables[0].Rows.Count.ToString());
            for (int row = 0; row < ROWS; row++)
            {
                show_take_sto(DS.Tables[0].Rows[row][0].ToString(),0);
            }
            CalPerData();
        }

        private void change_data_Load(object sender, EventArgs e)
        {

        }
        //導入EXECL
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            personremainer.commo_data.filename = openFileDialog1.FileName;

            //導入文件代碼
            OptExcel optExcel = new OptExcel();
            if (true == optExcel.Open_Excel(personremainer.commo_data.filename))
            {

                OptrecordNode recordnode = new OptrecordNode();
                OptrecordNode recordnode_hand = recordnode;
                //找总行数
                int ROW = 1;

                while (true)
                {
                    if (optExcel.Read_ExData(ROW, 0) == "" && optExcel.Read_ExData(ROW + 1, 0) == "")
                    {
                        break;
                    }
                    else
                    {
                        ROW++;
                    }
                }
                for (int rowi = 0; rowi < ROW; rowi++)
                {
                    if (optExcel.Read_ExData(rowi, 1) != "")
                    {
                        recordnode.stockname = optExcel.Read_ExData(rowi, 0);
                        recordnode.stockcode = optExcel.Read_ExData(rowi, 1);
                        recordnode.optdate = optExcel.Read_ExData(rowi, 2);
                        recordnode.opttype = optExcel.Read_ExData(rowi, 3);
                        recordnode.stockprice = optExcel.Read_ExData(rowi, 4);
                        recordnode.stocknumber = optExcel.Read_ExData(rowi, 5);
                        recordnode.rate = optExcel.Read_ExData(rowi, 6);
                        recordnode.commission = optExcel.Read_ExData(rowi, 7);
                        //recordnode.next = new OptrecordNode();
                        // recordnode = recordnode.next;
                        if (recordnode != null)
                        {
                            recordnode.next = new OptrecordNode();
                            recordnode = recordnode.next;
                        }
                    }
                }
                
                DataBase opdata = new DataBase();
                DataSet DS = new DataSet();
                GetNetStockData GNS = new GetNetStockData();
                opdata.CreateTable();
                opdata.AddUserOp(recordnode_hand);
              /*  DS = opdata.ReadDB("UserOp", "id");


                ROW = int.Parse(DS.Tables[0].Rows.Count.ToString());
                for (int row = 0; row < ROW; row++)
                {
                    string getstocaode = DS.Tables[0].Rows[row][0].ToString();

                    //新增股票記錄
                    string stockdata = GNS.GetNetData(getstocaode);
                    string[] temp = GNS.TreatmentString(stockdata);
                    opdata.AddStockData(temp, getstocaode);
                }
                */
                toolStripMenuItem3.Enabled = true;
                toolStripMenuItem4.Enabled = true;
                toolStripMenuItem5.Enabled = true;

            }
        }


        

            
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stockdataView[e.ColumnIndex, e.RowIndex].Value == "修改")
            {
              Form4 frm4 = new Form4();
              

                //先傳數據給STATIC 再傳給文本
              personremainer.commo_data.opt = stockdataView[1, e.RowIndex].Value.ToString();
              personremainer.commo_data.qty = int.Parse( stockdataView[3, e.RowIndex].Value.ToString());
              personremainer.commo_data.DATE = stockdataView[0, e.RowIndex].Value.ToString();
              personremainer.commo_data.price = float.Parse( stockdataView[2, e.RowIndex].Value.ToString());

              frm4.textBox1.Text = personremainer.commo_data.qty.ToString();
              frm4.comboBox1.Text = personremainer.commo_data.opt;
              frm4.monthCalendar1.SelectionStart = Convert.ToDateTime(personremainer.commo_data.DATE);
              frm4.monthCalendar1.SelectionEnd =Convert.ToDateTime( personremainer.commo_data.DATE);
              frm4.textBox2.Text = personremainer.commo_data.price.ToString();
              frm4.ShowDialog();

                  show_stock_data(personremainer.commo_data.stockcode);

                  //重算個人信息
                  DataBase DB = new DataBase();
                  DataSet DS = new DataSet();
                  ClearPerData();
                  DS = DB.ReadDB("userop", "id", 0);
                  int ROWS = int.Parse(DS.Tables[0].Rows.Count.ToString());
                  for (int row = 0; row < ROWS; row++)
                  {
                      show_take_sto(DS.Tables[0].Rows[row][0].ToString(), 0);
                  }
                  CalPerData();

            }
            else if (stockdataView[e.ColumnIndex, e.RowIndex].Value == "刪除")
            {

                if (MessageBox.Show("你希望刪除此條記錄嗎", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    DataBase DB = new DataBase();
                    string[] Date = new string[4];
                    string[] Type = new string[4];
                    Type[0] = "date";
                    Type[1] = "type";
                    Type[2] = "quantity";
                    Type[3] = "name";
                    Date[0] = stockdataView[0, e.RowIndex].Value.ToString();
                    Date[1] = stockdataView[1, e.RowIndex].Value.ToString();
                    Date[2] = stockdataView[3, e.RowIndex].Value.ToString();
                    //待改
                    if (true == CanChange(personremainer.commo_data.stockcode, Convert.ToDateTime(Date[0]), Date[0].ToString(), int.Parse(Date[2])))
                    {
                        Date[3] = personremainer.commo_data.StoName;
                        DB.changeDB(1, Type, Date);
                        show_stock_data(personremainer.commo_data.stockcode);
                        //重算個人信息
                        DataSet DS = new DataSet();
                        ClearPerData();
                        DS = DB.ReadDB("userop", "id", 0);
                        int ROWS = int.Parse(DS.Tables[0].Rows.Count.ToString());
                        for (int row = 0; row < ROWS; row++)
                        {
                            show_take_sto(DS.Tables[0].Rows[row][0].ToString(), 0);
                        }
                        CalPerData();
                    }
                    else
                    {
                        MessageBox.Show("非法操作");
                    }
                }
            }

           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            personremainer.create_form.create_cash();

            DataBase DB = new DataBase();
            DataSet DS = new DataSet();
            ClearPerData();
            DS = DB.ReadDB("userop", "id", 0);
            int ROWS = int.Parse(DS.Tables[0].Rows.Count.ToString());
            for (int row = 0; row < ROWS; row++)
            {
                show_take_sto(DS.Tables[0].Rows[row][0].ToString(),0);
            }
            CalPerData();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }



        //股票信息
        public void show_stock_data(string stockcode)
        {
            
            DataBase DB = new DataBase();
            DataSet DS =new DataSet();
            DS = DB.ReadDB("UserOp","*","id",stockcode,1);
            if (DS.Tables[0].Rows.Count != 0)
            {
                personremainer.commo_data.StoName = DS.Tables[0].Rows[0][0].ToString();
            }
            if (stockdataView.Rows.Count != 0)
            {
                stockdataView.Rows.Clear();
            }

            int ROWS = int.Parse(DS.Tables[0].Rows.Count.ToString());
            for (int row = 0; row < ROWS; row++)
            {
               
                stockdataView.Rows.Add(DS.Tables[0].Rows[row][2].ToString(), DS.Tables[0].Rows[row][3].ToString(), DS.Tables[0].Rows[row][4].ToString(), DS.Tables[0].Rows[row][5].ToString(), DS.Tables[0].Rows[row][6].ToString(), DS.Tables[0].Rows[row][7].ToString());
            }
            if (DS.Tables[0].Rows.Count != 0)
            {
                personremainer.commo_data.StoName = DS.Tables[0].Rows[0][0].ToString();
            }
        }

        //股票信息 文本框內容
        public void show_take_sto_textbox(string stockcode)
        {
            if (stockcode.Length > 5) 
            stockcode = stockcode.Substring(0, 6);
            GetNetStockData GNSD =new GetNetStockData();
            DataBase DB =new DataBase();
            DataSet DS =new DataSet();
            try
            {
                string d = GNSD.GetNetData(stockcode);
                string[] stoinf = GNSD.TreatmentString(d);

                if (stoinf[0].Length < 2)
                {
                    MessageBox.Show("查無此股");

                }
                else
                {

                    string T = stoinf[1];
                    string N = stoinf[3];
                    float Increase, priceT, priceN;
                    priceT = float.Parse(T);
                    priceN = float.Parse(N);
                    Increase = priceN - priceT;
                    StoDataName.Text = stoinf[0].ToString();
                    StoInc.Text = stoinf[3].ToString();
                    StockDataInf.Text = "股票名:" + stoinf[0] + "\r\n" + "股票編號:" + stockcode + "\r\n" + "今日開盤價:" + stoinf[1] + "\r\n" + "昨日收盤價:" + stoinf[2] + "\r\n" + "今日最高價:" + stoinf[4] + "\r\n" + "今日最低價:" + stoinf[5] + "\r\n" + "漲幅:" + Math.Round(Increase, 2) + "元";
                }

                //設數據
                personremainer.commo_data.StoName = stoinf[0];
                personremainer.commo_data.stockcode = stockcode;
            }
            catch (Exception err)
            {
                MessageBox.Show("連网失敗");
            }
         
        }

        //持倉信息 K圖
        public void show_take_kgraph(string stockcode)
        {
            GetNetStockData LoadGraph = new GetNetStockData();
            KLineGraph.ImageLocation = @LoadGraph.GetNetGraph(stockcode, 0);
        }

        //收益信息  需重新實現
        public void show_sto_gra(string stockcode)
        {

        }

        public void show_gra_listbox()
        {
            DataSet DS =new DataSet();
            DataBase DB=new DataBase();
          
            DS = DB.ReadDB("userop", "name",0);
            DataTable DT = DS.Tables[0];
            StoGralistBox.DataSource = DT;
            StoGralistBox.ValueMember = "name";
            StoGralistBox.DisplayMember = "name";
        }


        private void StoGralistBox_DoubleClick(object sender, EventArgs e)
        {
            string stockname = StoGralistBox.SelectedValue.ToString();
            DataBase DB = new DataBase();
            DataSet DS = new DataSet();
          //  DS = DB.ReadDB("stockinf", "id", "name", stockname);
            if (DS.Tables[0].Rows.Count != 0)
            {
                personremainer.commo_data.stockcode = DS.Tables[0].Rows[0][0].ToString();
            }

            show_sto_gra(personremainer.commo_data.stockcode);
            
            
        }

        public void addtastoser(string name)
        {

            //设置图案颜色

            TaStochart.Series.Add(name);
            TaStochart.Series[name].BorderWidth = 3;
            TaStochart.Series[name].ChartType = SeriesChartType.Line;
            TaStochart.Series[name].IsValueShownAsLabel = false;//是否顯示點的值
            TaStochart.Series[name].XValueType = ChartValueType.Date; 
        }
/*
        public void addstogrser(string name)
        {

            //设置图案颜色
            StoGrachart.Series.Add(name);
            StoGrachart.Series[name].BorderWidth = 3;
            StoGrachart.Series[name].ChartType = SeriesChartType.Line;
            StoGrachart.Series[name].IsValueShownAsLabel = false;//是否顯示點的值
            StoGrachart.Series[name].XValueType = ChartValueType.Date;
        }
        */



        private void TaStochart_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }






        //持倉信息  
        public void show_take_sto(string stockcode,int i)
        {
            //提取數據
            DataBase DB = new DataBase();
            GetNetStockData GNSD = new GetNetStockData();
            DataSet DS = new DataSet();

            float price = 0;
            int quantity = 0, holdquan = 0;
            //浮動盈虧 盈虧
            float chagra = 0, totgra = 0;
            float tax = 0, comm = 0, tcost = 0, cost = 0;
            float temgra = 0;
            string ttax, tcomm;

            DS = DB.ReadDB("UserOp", "*", "id", stockcode,1);
            int ROWS = int.Parse(DS.Tables[0].Rows.Count.ToString());
            //因為要計算持倉成本所以 由舊的記錄算起
            for (int row = 0; row <ROWS; row++)
            {
                ttax = DS.Tables[0].Rows[row][6].ToString();
                tcomm = DS.Tables[0].Rows[row][7].ToString();
                tax = float.Parse(ttax.Substring(0, ttax.Length - 1)) / 100;
                comm = float.Parse(tcomm.Substring(0, tcomm.Length - 1)) / 100;
                quantity = int.Parse(DS.Tables[0].Rows[row][5].ToString());
                price = float.Parse(DS.Tables[0].Rows[row][4].ToString());

                if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "买入")
                {
                    //买入
                    tcost = (holdquan * cost + (quantity * price * (1 + tax) * (1 + comm))) / (quantity + holdquan);
                    temgra = temgra - (quantity * price * (1 + tax) * (1 + comm));
                    holdquan += quantity;
                    cost = tcost;
                    if (holdquan == 0)
                    {
                        cost = 0;
                    }
                }
                else if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "卖出")
                {
                    //卖出
                    tcost = (holdquan * cost - (quantity * price * (1 - tax) * (1 - comm))) / (quantity - holdquan);
                    temgra = temgra +  (quantity * price * (1 - tax) * (1 - comm)); 
                    holdquan = holdquan - quantity;
                    cost = tcost;
                    if (holdquan == 0)
                    {
                        cost = 0;
                    }
                }
                else if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "补仓")
                {
                    //补仓
                    tcost = (holdquan * cost - (quantity * price * (1 + tax) * (1 + comm))) / (quantity + holdquan);
                    temgra = temgra - (quantity * price * (1 + tax) * (1 + comm));
               
                    holdquan = holdquan + quantity;
                    cost = tcost;
                    if (holdquan == 0)
                    {
                        cost = 0;
                    }
                }
                else if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "卖空")
                {
                    //卖空 
                    tcost = (holdquan * cost + (quantity * price * (1 - tax) * (1 - comm))) / (quantity - holdquan);
                    temgra = temgra + (quantity * price * (1 - tax) * (1 - comm));
                    holdquan = holdquan - quantity;
                    cost = tcost;
                    if (holdquan == 0)
                    {
                        cost = 0;
                    }
                }
            }

            float markprice = 0;
            try
            {
                string d = GNSD.GetNetData(stockcode);
                string[] nowprice = GNSD.TreatmentString(d);
                if (holdquan > 0)
                {
                    markprice = float.Parse(nowprice[6]) * holdquan;
                    chagra = (float.Parse(nowprice[6]) - cost) / cost;
                    totgra = chagra * holdquan;
                }
                else if (holdquan < 0)
                {
                    markprice = float.Parse(nowprice[6]) * holdquan;
                    chagra = -(float.Parse(nowprice[6]) - cost) / cost;
                    totgra = chagra * holdquan;
                }
                else if (holdquan == 0)
                {
                    markprice = 0;
                    chagra = 0;
                    totgra = temgra;
                }
                personremainer.commo_data.marketprice += markprice;
                personremainer.commo_data.chagra += chagra;
                personremainer.commo_data.grain += totgra;
                personremainer.commo_data.dailygrain += holdquan * (float.Parse(nowprice[6]) - float.Parse(nowprice[2]));
                if (1 == i)
                    TaStodataView.Rows.Add(DS.Tables[0].Rows[0][0].ToString(), nowprice[6], cost, holdquan, markprice, totgra, chagra);
            }
            catch (Exception err)
            {
                MessageBox.Show("連网失敗");
            }
        }


        //畫持倉圖
        public void Draw_takchart(string stockcode)
        {
            //提取數據
            DataBase DB = new DataBase();
            GetNetStockData GNSD = new GetNetStockData();
            DataSet DS = new DataSet();
            DS = DB.ReadDB("UserOp", "*", "id", stockcode,1);
            string StrDate;
            string stoname = null;
            int holdquan = 0, quantity = 0;
            //畫圖
            if (DS.Tables[0].Rows.Count != 0)
            {
                stoname = DS.Tables[0].Rows[0][0].ToString();
                addtastoser(stoname);
            }
            int ROWS = int.Parse(DS.Tables[0].Rows.Count.ToString());
            //因為要順序畫圖 所以由舊記錄畫起
            for (int row = 0; row <ROWS; row++)
            {
                quantity =int.Parse( DS.Tables[0].Rows[row][5].ToString());

                if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "买入")
                {
                    //买入
                    holdquan += quantity;
                }
                else if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "卖出")
                {
                    //卖出
                    holdquan = holdquan - quantity;
                }
                else if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "补仓")
                {
                    //补仓
                    holdquan = holdquan + quantity;
                }
                else if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "卖空")
                {
                    //卖空 
                    holdquan = holdquan - quantity;
                }  
                //畫持倉圖

                if (DS.Tables[0].Rows.Count != 0)
                {
                    StrDate = DS.Tables[0].Rows[row][2].ToString();
                    DateTime Date = Convert.ToDateTime(StrDate);
                    TaStochart.Series[stoname].Points.AddXY(Date, holdquan);
                }
            }
        }



        public void CalPerData()
        {
            

            personremainer.commo_data.acctocash = float.Parse(personremainer.commo_data.capital) + personremainer.commo_data.grain;
            personremainer.commo_data.cash = personremainer.commo_data.acctocash - personremainer.commo_data.marketprice;
            label1.Text = "本金:" + Math.Round( float.Parse(personremainer.commo_data.capital),2);
            label7.Text = "現金:" + Math.Round( personremainer.commo_data.cash,2);
            label3.Text = "浮動盈虧(%):" + Math.Round( personremainer.commo_data.chagra,2);
            label4.Text = "盈虧:" + Math.Round( personremainer.commo_data.grain,2);
            label5.Text = "帳戶總資產" + Math.Round( personremainer.commo_data.acctocash,2);
            label6.Text = "市值:" + Math.Round(personremainer.commo_data.marketprice, 2);
            label2.Text = "日盈虧:" +Math.Round( personremainer.commo_data.dailygrain,2); 
        }

        public void ClearPerData()
        {
            personremainer.commo_data.chagra = 0;
            personremainer.commo_data.marketprice = 0;
            personremainer.commo_data.grain = 0;
            personremainer.commo_data.dailygrain = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
         GetNetStockData GNDS =  new GetNetStockData();
         KLineGraph.ImageLocation = @GNDS.GetNetGraph(personremainer.commo_data.stockcode, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetNetStockData GNDS = new GetNetStockData();
            if(personremainer.commo_data.stockcode!=null)
            KLineGraph.ImageLocation = @GNDS.GetNetGraph(personremainer.commo_data.stockcode, 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetNetStockData GNDS = new GetNetStockData();
            if (personremainer.commo_data.stockcode != null)
            KLineGraph.ImageLocation = @GNDS.GetNetGraph(personremainer.commo_data.stockcode, 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetNetStockData GNDS = new GetNetStockData();
            if (personremainer.commo_data.stockcode != null)
            KLineGraph.ImageLocation = @GNDS.GetNetGraph(personremainer.commo_data.stockcode, 3);
        }



        private void TaStodataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = TaStodataView.CurrentRow.Index;
            string stockname = TaStodataView[0,row].Value.ToString();
            DataBase DB = new DataBase();
            DataSet DS = new DataSet();
            DS = DB.ReadDB("UserOp", "id", "name", stockname,1);
            if (DS.Tables[0].Rows.Count != 0)
            {
                personremainer.commo_data.stockcode = DS.Tables[0].Rows[0][0].ToString();
            }
            NotDisplay();
            show_StoInf = true;
            Display(panel2);
            show_stock_data(personremainer.commo_data.stockcode);
            show_take_sto_textbox(personremainer.commo_data.stockcode);
            show_take_kgraph(personremainer.commo_data.stockcode);
        }
        
        //放大控件
        public  void AutoSize(Form frm)
        {
            frm.Tag = frm.Width.ToString() + "," + frm.Height.ToString();
            frm.SizeChanged += new EventHandler(frm_SizeChanged);

        }
        void frm_SizeChanged(object sender, EventArgs e)
        {
          
            string[] tmp = ((Form)sender).Tag.ToString().Split(',');
            float width = (float)((Form)sender).Width / (float)Convert.ToInt16(tmp[0]);
            float heigth = (float)((Form)sender).Height / (float)Convert.ToInt16(tmp[1]);

            ((Form)sender).Tag = ((Form)sender).Width.ToString() + "," + ((Form)sender).Height;

            foreach (Control control in ((Form)sender).Controls)
            {
                control.Scale(new SizeF(width, heigth));

            }
        }

        private void StoGralistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 
        public bool CanChange(string stockcode, DateTime Date, string type, int quan)
        {
            //讀DB
            //計算修改後 股票量
            //分四種操作 進行判斷
            //分別對應返回真假
            DataBase DB = new DataBase();
            DataSet DS = new DataSet();
            int holdquan = 0, quantity = 0;
            DS = DB.ReadDB("UserOp", "*", "id", stockcode, 1);
            int ROWS = DS.Tables[0].Rows.Count;
            for (int row = 0; row < ROWS; row++)
            {
                quantity = int.Parse(DS.Tables[0].Rows[row][5].ToString());

            if (Date == (DateTime)DS.Tables[0].Rows[row][2])
                {         
                }
                else if (Date != (DateTime)DS.Tables[0].Rows[row][2])
                {
                    
                    if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "买入")
                    {
                        //买入
                        holdquan += quantity;
                    }
                    else if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "卖出")
                    {
                        //卖出
                        holdquan = holdquan - quantity;
                    }
                    else if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "补仓")
                    {
                        //补仓
                        holdquan = holdquan + quantity;
                    }
                    else if (DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "卖空")
                    {
                        //卖空 
                        holdquan = holdquan - quantity;
                    }
                }

            if ((DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "卖出" || DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "买入") && holdquan < 0)
            {
                return false;
            }
            else if ((DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "卖空" || DS.Tables[0].Rows[row][3].ToString().Substring(0, 2) == "补仓") && holdquan > 0)
            {
                return false;
            }

            }
            return true;
        }

        private void StockDataInf_TextChanged(object sender, EventArgs e)
        {

        }


        //計算收益率
        public DataSet CalGraPer(DateTime start,int ConDay)
        {
            //讀記錄
            //計算每天收益
            //維護 DATASET  /  DATATABLE 集合
            DataBase DB = new DataBase();
            GetNetStockData GNDS = new GetNetStockData();


        }

    }
 }
 




