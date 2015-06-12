namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckTotMark = new System.Windows.Forms.CheckBox();
            this.CheckTotStockCost = new System.Windows.Forms.CheckBox();
            this.CheckPettm = new System.Windows.Forms.CheckBox();
            this.CheckPelyr = new System.Windows.Forms.CheckBox();
            this.CheckEPS = new System.Windows.Forms.CheckBox();
            this.CheckPB = new System.Windows.Forms.CheckBox();
            this.CheckRoediluted = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.CheckDY = new System.Windows.Forms.CheckBox();
            this.CheckBPS = new System.Windows.Forms.CheckBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.EditToChoose = new System.Windows.Forms.Button();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TotatalCount = new System.Windows.Forms.TextBox();
            this.ChangeDataSource = new System.Windows.Forms.ComboBox();
            this.XueQiupanel = new System.Windows.Forms.Panel();
            this.Iwencaipanel = new System.Windows.Forms.Panel();
            this.PCTCheckBox = new System.Windows.Forms.CheckBox();
            this.LYRCheckBox = new System.Windows.Forms.CheckBox();
            this.PBCheckBox = new System.Windows.Forms.CheckBox();
            this.MCCheckBox = new System.Windows.Forms.CheckBox();
            this.MinPCT = new System.Windows.Forms.TextBox();
            this.MaxPCT = new System.Windows.Forms.TextBox();
            this.MinLYR = new System.Windows.Forms.TextBox();
            this.MaxLYR = new System.Windows.Forms.TextBox();
            this.MinPB = new System.Windows.Forms.TextBox();
            this.MaxPB = new System.Windows.Forms.TextBox();
            this.MinMC = new System.Windows.Forms.TextBox();
            this.MaxMC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.XueQiupanel.SuspendLayout();
            this.Iwencaipanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckTotMark
            // 
            this.CheckTotMark.AutoSize = true;
            this.CheckTotMark.Location = new System.Drawing.Point(11, 19);
            this.CheckTotMark.Name = "CheckTotMark";
            this.CheckTotMark.Size = new System.Drawing.Size(60, 16);
            this.CheckTotMark.TabIndex = 0;
            this.CheckTotMark.Text = "總市值";
            this.CheckTotMark.UseVisualStyleBackColor = true;
            this.CheckTotMark.CheckedChanged += new System.EventHandler(this.basetest_CheckedChanged);
            // 
            // CheckTotStockCost
            // 
            this.CheckTotStockCost.AutoSize = true;
            this.CheckTotStockCost.Location = new System.Drawing.Point(9, 51);
            this.CheckTotStockCost.Name = "CheckTotStockCost";
            this.CheckTotStockCost.Size = new System.Drawing.Size(72, 16);
            this.CheckTotStockCost.TabIndex = 1;
            this.CheckTotStockCost.Text = "流動市值";
            this.CheckTotStockCost.UseVisualStyleBackColor = true;
            this.CheckTotStockCost.CheckedChanged += new System.EventHandler(this.CheckTotStockCost_CheckedChanged);
            // 
            // CheckPettm
            // 
            this.CheckPettm.AutoSize = true;
            this.CheckPettm.Location = new System.Drawing.Point(8, 84);
            this.CheckPettm.Name = "CheckPettm";
            this.CheckPettm.Size = new System.Drawing.Size(108, 16);
            this.CheckPettm.TabIndex = 2;
            this.CheckPettm.Text = "动态市盈率(倍)";
            this.CheckPettm.UseVisualStyleBackColor = true;
            this.CheckPettm.CheckedChanged += new System.EventHandler(this.CheckPettm_CheckedChanged);
            // 
            // CheckPelyr
            // 
            this.CheckPelyr.AutoSize = true;
            this.CheckPelyr.Location = new System.Drawing.Point(7, 113);
            this.CheckPelyr.Name = "CheckPelyr";
            this.CheckPelyr.Size = new System.Drawing.Size(108, 16);
            this.CheckPelyr.TabIndex = 3;
            this.CheckPelyr.Text = "静态市盈率(倍)";
            this.CheckPelyr.UseVisualStyleBackColor = true;
            this.CheckPelyr.CheckedChanged += new System.EventHandler(this.CheckPelyr_CheckedChanged);
            // 
            // CheckEPS
            // 
            this.CheckEPS.AutoSize = true;
            this.CheckEPS.Location = new System.Drawing.Point(9, 139);
            this.CheckEPS.Name = "CheckEPS";
            this.CheckEPS.Size = new System.Drawing.Size(72, 16);
            this.CheckEPS.TabIndex = 4;
            this.CheckEPS.Text = "每股收益";
            this.CheckEPS.UseVisualStyleBackColor = true;
            this.CheckEPS.CheckedChanged += new System.EventHandler(this.CheckEPS_CheckedChanged);
            // 
            // CheckPB
            // 
            this.CheckPB.AutoSize = true;
            this.CheckPB.Location = new System.Drawing.Point(8, 162);
            this.CheckPB.Name = "CheckPB";
            this.CheckPB.Size = new System.Drawing.Size(84, 16);
            this.CheckPB.TabIndex = 5;
            this.CheckPB.Text = "市净率(倍)";
            this.CheckPB.UseVisualStyleBackColor = true;
            this.CheckPB.CheckedChanged += new System.EventHandler(this.CheckPB_CheckedChanged);
            // 
            // CheckRoediluted
            // 
            this.CheckRoediluted.AutoSize = true;
            this.CheckRoediluted.Font = new System.Drawing.Font("宋体", 8F);
            this.CheckRoediluted.Location = new System.Drawing.Point(8, 193);
            this.CheckRoediluted.Name = "CheckRoediluted";
            this.CheckRoediluted.Size = new System.Drawing.Size(108, 15);
            this.CheckRoediluted.TabIndex = 8;
            this.CheckRoediluted.Text = "净资产收益率(%)";
            this.CheckRoediluted.UseVisualStyleBackColor = true;
            this.CheckRoediluted.CheckedChanged += new System.EventHandler(this.CheckRoediluted_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(297, 363);
            this.dataGridView1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(224, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(226, 89);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(120, 118);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(226, 117);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(120, 144);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(225, 146);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 21);
            this.textBox10.TabIndex = 21;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(122, 172);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 21);
            this.textBox11.TabIndex = 22;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(228, 176);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 21);
            this.textBox12.TabIndex = 23;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(120, 200);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 21);
            this.textBox17.TabIndex = 28;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(226, 200);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 21);
            this.textBox18.TabIndex = 29;
            // 
            // CheckDY
            // 
            this.CheckDY.AutoSize = true;
            this.CheckDY.Location = new System.Drawing.Point(8, 220);
            this.CheckDY.Name = "CheckDY";
            this.CheckDY.Size = new System.Drawing.Size(60, 16);
            this.CheckDY.TabIndex = 32;
            this.CheckDY.Text = "股息率";
            this.CheckDY.UseVisualStyleBackColor = true;
            this.CheckDY.CheckedChanged += new System.EventHandler(this.CheckDY_CheckedChanged);
            // 
            // CheckBPS
            // 
            this.CheckBPS.AutoSize = true;
            this.CheckBPS.Location = new System.Drawing.Point(7, 254);
            this.CheckBPS.Name = "CheckBPS";
            this.CheckBPS.Size = new System.Drawing.Size(84, 16);
            this.CheckBPS.TabIndex = 33;
            this.CheckBPS.Text = "每股淨資產";
            this.CheckBPS.UseVisualStyleBackColor = true;
            this.CheckBPS.CheckedChanged += new System.EventHandler(this.CheckBPS_CheckedChanged);
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(122, 227);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 21);
            this.textBox21.TabIndex = 34;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(120, 260);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 21);
            this.textBox23.TabIndex = 36;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(225, 263);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 21);
            this.textBox24.TabIndex = 37;
            // 
            // EditToChoose
            // 
            this.EditToChoose.Location = new System.Drawing.Point(519, 16);
            this.EditToChoose.Name = "EditToChoose";
            this.EditToChoose.Size = new System.Drawing.Size(75, 23);
            this.EditToChoose.TabIndex = 38;
            this.EditToChoose.Text = "篩選";
            this.EditToChoose.UseVisualStyleBackColor = true;
            this.EditToChoose.Click += new System.EventHandler(this.EditToChoose_Click);
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(225, 229);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 21);
            this.textBox22.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(527, 409);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(40, 20);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TotatalCount
            // 
            this.TotatalCount.Enabled = false;
            this.TotatalCount.Location = new System.Drawing.Point(371, 16);
            this.TotatalCount.Name = "TotatalCount";
            this.TotatalCount.Size = new System.Drawing.Size(121, 21);
            this.TotatalCount.TabIndex = 43;
            // 
            // ChangeDataSource
            // 
            this.ChangeDataSource.FormattingEnabled = true;
            this.ChangeDataSource.Items.AddRange(new object[] {
            "雪球源",
            "同花順源"});
            this.ChangeDataSource.Location = new System.Drawing.Point(285, 17);
            this.ChangeDataSource.Name = "ChangeDataSource";
            this.ChangeDataSource.Size = new System.Drawing.Size(60, 20);
            this.ChangeDataSource.TabIndex = 44;
            this.ChangeDataSource.SelectedIndexChanged += new System.EventHandler(this.ChangeDataSource_SelectedIndexChanged);
            // 
            // XueQiupanel
            // 
            this.XueQiupanel.Controls.Add(this.textBox1);
            this.XueQiupanel.Controls.Add(this.CheckTotMark);
            this.XueQiupanel.Controls.Add(this.CheckTotStockCost);
            this.XueQiupanel.Controls.Add(this.CheckPettm);
            this.XueQiupanel.Controls.Add(this.CheckPelyr);
            this.XueQiupanel.Controls.Add(this.textBox22);
            this.XueQiupanel.Controls.Add(this.CheckEPS);
            this.XueQiupanel.Controls.Add(this.CheckPB);
            this.XueQiupanel.Controls.Add(this.textBox24);
            this.XueQiupanel.Controls.Add(this.CheckRoediluted);
            this.XueQiupanel.Controls.Add(this.textBox23);
            this.XueQiupanel.Controls.Add(this.textBox2);
            this.XueQiupanel.Controls.Add(this.textBox21);
            this.XueQiupanel.Controls.Add(this.textBox3);
            this.XueQiupanel.Controls.Add(this.CheckBPS);
            this.XueQiupanel.Controls.Add(this.textBox4);
            this.XueQiupanel.Controls.Add(this.CheckDY);
            this.XueQiupanel.Controls.Add(this.textBox5);
            this.XueQiupanel.Controls.Add(this.textBox18);
            this.XueQiupanel.Controls.Add(this.textBox6);
            this.XueQiupanel.Controls.Add(this.textBox17);
            this.XueQiupanel.Controls.Add(this.textBox7);
            this.XueQiupanel.Controls.Add(this.textBox12);
            this.XueQiupanel.Controls.Add(this.textBox8);
            this.XueQiupanel.Controls.Add(this.textBox11);
            this.XueQiupanel.Controls.Add(this.textBox9);
            this.XueQiupanel.Controls.Add(this.textBox10);
            this.XueQiupanel.Location = new System.Drawing.Point(7, 63);
            this.XueQiupanel.Name = "XueQiupanel";
            this.XueQiupanel.Size = new System.Drawing.Size(341, 309);
            this.XueQiupanel.TabIndex = 45;
            // 
            // Iwencaipanel
            // 
            this.Iwencaipanel.Controls.Add(this.MaxMC);
            this.Iwencaipanel.Controls.Add(this.MinMC);
            this.Iwencaipanel.Controls.Add(this.MaxPB);
            this.Iwencaipanel.Controls.Add(this.MinPB);
            this.Iwencaipanel.Controls.Add(this.MaxLYR);
            this.Iwencaipanel.Controls.Add(this.MinLYR);
            this.Iwencaipanel.Controls.Add(this.MaxPCT);
            this.Iwencaipanel.Controls.Add(this.MinPCT);
            this.Iwencaipanel.Controls.Add(this.MCCheckBox);
            this.Iwencaipanel.Controls.Add(this.PBCheckBox);
            this.Iwencaipanel.Controls.Add(this.LYRCheckBox);
            this.Iwencaipanel.Controls.Add(this.PCTCheckBox);
            this.Iwencaipanel.Location = new System.Drawing.Point(8, 62);
            this.Iwencaipanel.Name = "Iwencaipanel";
            this.Iwencaipanel.Size = new System.Drawing.Size(341, 193);
            this.Iwencaipanel.TabIndex = 46;
            // 
            // PCTCheckBox
            // 
            this.PCTCheckBox.AutoSize = true;
            this.PCTCheckBox.Location = new System.Drawing.Point(12, 9);
            this.PCTCheckBox.Name = "PCTCheckBox";
            this.PCTCheckBox.Size = new System.Drawing.Size(60, 16);
            this.PCTCheckBox.TabIndex = 0;
            this.PCTCheckBox.Text = "涨跌幅";
            this.PCTCheckBox.UseVisualStyleBackColor = true;
            this.PCTCheckBox.CheckedChanged += new System.EventHandler(this.PCTCheckBox_CheckedChanged);
            // 
            // LYRCheckBox
            // 
            this.LYRCheckBox.AutoSize = true;
            this.LYRCheckBox.Location = new System.Drawing.Point(12, 36);
            this.LYRCheckBox.Name = "LYRCheckBox";
            this.LYRCheckBox.Size = new System.Drawing.Size(60, 16);
            this.LYRCheckBox.TabIndex = 1;
            this.LYRCheckBox.Text = "市盈率";
            this.LYRCheckBox.UseVisualStyleBackColor = true;
            this.LYRCheckBox.CheckedChanged += new System.EventHandler(this.LYRCheckBox_CheckedChanged);
            // 
            // PBCheckBox
            // 
            this.PBCheckBox.AutoSize = true;
            this.PBCheckBox.Location = new System.Drawing.Point(12, 62);
            this.PBCheckBox.Name = "PBCheckBox";
            this.PBCheckBox.Size = new System.Drawing.Size(60, 16);
            this.PBCheckBox.TabIndex = 2;
            this.PBCheckBox.Text = "市净率";
            this.PBCheckBox.UseVisualStyleBackColor = true;
            this.PBCheckBox.CheckedChanged += new System.EventHandler(this.PBCheckBox_CheckedChanged);
            // 
            // MCCheckBox
            // 
            this.MCCheckBox.AutoSize = true;
            this.MCCheckBox.Location = new System.Drawing.Point(12, 93);
            this.MCCheckBox.Name = "MCCheckBox";
            this.MCCheckBox.Size = new System.Drawing.Size(60, 16);
            this.MCCheckBox.TabIndex = 3;
            this.MCCheckBox.Text = "总股本";
            this.MCCheckBox.UseVisualStyleBackColor = true;
            this.MCCheckBox.CheckedChanged += new System.EventHandler(this.MCCheckBox_CheckedChanged);
            // 
            // MinPCT
            // 
            this.MinPCT.Location = new System.Drawing.Point(108, 9);
            this.MinPCT.Name = "MinPCT";
            this.MinPCT.Size = new System.Drawing.Size(100, 21);
            this.MinPCT.TabIndex = 4;
            // 
            // MaxPCT
            // 
            this.MaxPCT.Location = new System.Drawing.Point(219, 9);
            this.MaxPCT.Name = "MaxPCT";
            this.MaxPCT.Size = new System.Drawing.Size(100, 21);
            this.MaxPCT.TabIndex = 5;
            // 
            // MinLYR
            // 
            this.MinLYR.Location = new System.Drawing.Point(109, 36);
            this.MinLYR.Name = "MinLYR";
            this.MinLYR.Size = new System.Drawing.Size(100, 21);
            this.MinLYR.TabIndex = 6;
            // 
            // MaxLYR
            // 
            this.MaxLYR.Location = new System.Drawing.Point(220, 37);
            this.MaxLYR.Name = "MaxLYR";
            this.MaxLYR.Size = new System.Drawing.Size(100, 21);
            this.MaxLYR.TabIndex = 7;
            // 
            // MinPB
            // 
            this.MinPB.Location = new System.Drawing.Point(109, 64);
            this.MinPB.Name = "MinPB";
            this.MinPB.Size = new System.Drawing.Size(100, 21);
            this.MinPB.TabIndex = 8;
            // 
            // MaxPB
            // 
            this.MaxPB.Location = new System.Drawing.Point(219, 63);
            this.MaxPB.Name = "MaxPB";
            this.MaxPB.Size = new System.Drawing.Size(100, 21);
            this.MaxPB.TabIndex = 9;
            // 
            // MinMC
            // 
            this.MinMC.Location = new System.Drawing.Point(110, 91);
            this.MinMC.Name = "MinMC";
            this.MinMC.Size = new System.Drawing.Size(100, 21);
            this.MinMC.TabIndex = 10;
            // 
            // MaxMC
            // 
            this.MaxMC.Location = new System.Drawing.Point(220, 91);
            this.MaxMC.Name = "MaxMC";
            this.MaxMC.Size = new System.Drawing.Size(100, 21);
            this.MaxMC.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 465);
            this.Controls.Add(this.Iwencaipanel);
            this.Controls.Add(this.XueQiupanel);
            this.Controls.Add(this.ChangeDataSource);
            this.Controls.Add(this.TotatalCount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditToChoose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "幫你選股票";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.XueQiupanel.ResumeLayout(false);
            this.XueQiupanel.PerformLayout();
            this.Iwencaipanel.ResumeLayout(false);
            this.Iwencaipanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckTotMark;
        private System.Windows.Forms.CheckBox CheckTotStockCost;
        private System.Windows.Forms.CheckBox CheckPettm;
        private System.Windows.Forms.CheckBox CheckPelyr;
        private System.Windows.Forms.CheckBox CheckEPS;
        private System.Windows.Forms.CheckBox CheckPB;
        private System.Windows.Forms.CheckBox CheckRoediluted;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.CheckBox CheckDY;
        private System.Windows.Forms.CheckBox CheckBPS;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Button EditToChoose;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TotatalCount;
        private System.Windows.Forms.ComboBox ChangeDataSource;
        private System.Windows.Forms.Panel XueQiupanel;
        private System.Windows.Forms.Panel Iwencaipanel;
        private System.Windows.Forms.CheckBox MCCheckBox;
        private System.Windows.Forms.CheckBox PBCheckBox;
        private System.Windows.Forms.CheckBox LYRCheckBox;
        private System.Windows.Forms.CheckBox PCTCheckBox;
        private System.Windows.Forms.TextBox MaxMC;
        private System.Windows.Forms.TextBox MinMC;
        private System.Windows.Forms.TextBox MaxPB;
        private System.Windows.Forms.TextBox MinPB;
        private System.Windows.Forms.TextBox MaxLYR;
        private System.Windows.Forms.TextBox MinLYR;
        private System.Windows.Forms.TextBox MaxPCT;
        private System.Windows.Forms.TextBox MinPCT;
    }
}

