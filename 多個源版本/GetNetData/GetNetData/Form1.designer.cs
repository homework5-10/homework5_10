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
            this.CheckCurrent = new System.Windows.Forms.CheckBox();
            this.CheckPCT = new System.Windows.Forms.CheckBox();
            this.CheckRoediluted = new System.Windows.Forms.CheckBox();
            this.CheckBetprcfit = new System.Windows.Forms.CheckBox();
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
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.CheckDY = new System.Windows.Forms.CheckBox();
            this.CheckBPS = new System.Windows.Forms.CheckBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.EditToChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckTotMark
            // 
            this.CheckTotMark.AutoSize = true;
            this.CheckTotMark.Location = new System.Drawing.Point(15, 19);
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
            this.CheckTotStockCost.Location = new System.Drawing.Point(15, 52);
            this.CheckTotStockCost.Name = "CheckTotStockCost";
            this.CheckTotStockCost.Size = new System.Drawing.Size(60, 16);
            this.CheckTotStockCost.TabIndex = 1;
            this.CheckTotStockCost.Text = "總股本";
            this.CheckTotStockCost.UseVisualStyleBackColor = true;
            // 
            // CheckPettm
            // 
            this.CheckPettm.AutoSize = true;
            this.CheckPettm.Location = new System.Drawing.Point(12, 90);
            this.CheckPettm.Name = "CheckPettm";
            this.CheckPettm.Size = new System.Drawing.Size(78, 16);
            this.CheckPettm.TabIndex = 2;
            this.CheckPettm.Text = "市盈率TTM";
            this.CheckPettm.UseVisualStyleBackColor = true;
            // 
            // CheckPelyr
            // 
            this.CheckPelyr.AutoSize = true;
            this.CheckPelyr.Location = new System.Drawing.Point(13, 123);
            this.CheckPelyr.Name = "CheckPelyr";
            this.CheckPelyr.Size = new System.Drawing.Size(78, 16);
            this.CheckPelyr.TabIndex = 3;
            this.CheckPelyr.Text = "市盈率LYR";
            this.CheckPelyr.UseVisualStyleBackColor = true;
            // 
            // CheckEPS
            // 
            this.CheckEPS.AutoSize = true;
            this.CheckEPS.Location = new System.Drawing.Point(14, 165);
            this.CheckEPS.Name = "CheckEPS";
            this.CheckEPS.Size = new System.Drawing.Size(72, 16);
            this.CheckEPS.TabIndex = 4;
            this.CheckEPS.Text = "每股收益";
            this.CheckEPS.UseVisualStyleBackColor = true;
            // 
            // CheckPB
            // 
            this.CheckPB.AutoSize = true;
            this.CheckPB.Location = new System.Drawing.Point(15, 197);
            this.CheckPB.Name = "CheckPB";
            this.CheckPB.Size = new System.Drawing.Size(60, 16);
            this.CheckPB.TabIndex = 5;
            this.CheckPB.Text = "市淨率";
            this.CheckPB.UseVisualStyleBackColor = true;
            // 
            // CheckCurrent
            // 
            this.CheckCurrent.AutoSize = true;
            this.CheckCurrent.Location = new System.Drawing.Point(14, 236);
            this.CheckCurrent.Name = "CheckCurrent";
            this.CheckCurrent.Size = new System.Drawing.Size(48, 16);
            this.CheckCurrent.TabIndex = 6;
            this.CheckCurrent.Text = "現價";
            this.CheckCurrent.UseVisualStyleBackColor = true;
            // 
            // CheckPCT
            // 
            this.CheckPCT.AutoSize = true;
            this.CheckPCT.Location = new System.Drawing.Point(12, 274);
            this.CheckPCT.Name = "CheckPCT";
            this.CheckPCT.Size = new System.Drawing.Size(60, 16);
            this.CheckPCT.TabIndex = 7;
            this.CheckPCT.Text = "日升幅";
            this.CheckPCT.UseVisualStyleBackColor = true;
            // 
            // CheckRoediluted
            // 
            this.CheckRoediluted.AutoSize = true;
            this.CheckRoediluted.Location = new System.Drawing.Point(12, 309);
            this.CheckRoediluted.Name = "CheckRoediluted";
            this.CheckRoediluted.Size = new System.Drawing.Size(96, 16);
            this.CheckRoediluted.TabIndex = 8;
            this.CheckRoediluted.Text = "淨資產狀益率";
            this.CheckRoediluted.UseVisualStyleBackColor = true;
            // 
            // CheckBetprcfit
            // 
            this.CheckBetprcfit.AutoSize = true;
            this.CheckBetprcfit.Location = new System.Drawing.Point(13, 344);
            this.CheckBetprcfit.Name = "CheckBetprcfit";
            this.CheckBetprcfit.Size = new System.Drawing.Size(60, 16);
            this.CheckBetprcfit.TabIndex = 9;
            this.CheckBetprcfit.Text = "淨利潤";
            this.CheckBetprcfit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(297, 363);
            this.dataGridView1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(211, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(96, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(213, 89);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(97, 118);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(213, 117);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(101, 165);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(212, 165);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 21);
            this.textBox10.TabIndex = 21;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(102, 191);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 21);
            this.textBox11.TabIndex = 22;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(215, 193);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 21);
            this.textBox12.TabIndex = 23;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(103, 236);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 21);
            this.textBox13.TabIndex = 24;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(217, 236);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 21);
            this.textBox14.TabIndex = 25;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(102, 274);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 21);
            this.textBox15.TabIndex = 26;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(220, 275);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 21);
            this.textBox16.TabIndex = 27;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(103, 305);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 21);
            this.textBox17.TabIndex = 28;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(220, 305);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 21);
            this.textBox18.TabIndex = 29;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(104, 344);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 21);
            this.textBox19.TabIndex = 30;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(219, 343);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 21);
            this.textBox20.TabIndex = 31;
            // 
            // CheckDY
            // 
            this.CheckDY.AutoSize = true;
            this.CheckDY.Location = new System.Drawing.Point(14, 380);
            this.CheckDY.Name = "CheckDY";
            this.CheckDY.Size = new System.Drawing.Size(60, 16);
            this.CheckDY.TabIndex = 32;
            this.CheckDY.Text = "股息率";
            this.CheckDY.UseVisualStyleBackColor = true;
            // 
            // CheckBPS
            // 
            this.CheckBPS.AutoSize = true;
            this.CheckBPS.Location = new System.Drawing.Point(14, 411);
            this.CheckBPS.Name = "CheckBPS";
            this.CheckBPS.Size = new System.Drawing.Size(84, 16);
            this.CheckBPS.TabIndex = 33;
            this.CheckBPS.Text = "每股淨資產";
            this.CheckBPS.UseVisualStyleBackColor = true;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(104, 380);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 21);
            this.textBox21.TabIndex = 34;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(220, 380);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 21);
            this.textBox22.TabIndex = 35;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(104, 409);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 21);
            this.textBox23.TabIndex = 36;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(218, 408);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 21);
            this.textBox24.TabIndex = 37;
            // 
            // EditToChoose
            // 
            this.EditToChoose.Location = new System.Drawing.Point(562, 27);
            this.EditToChoose.Name = "EditToChoose";
            this.EditToChoose.Size = new System.Drawing.Size(75, 23);
            this.EditToChoose.TabIndex = 38;
            this.EditToChoose.Text = "篩選";
            this.EditToChoose.UseVisualStyleBackColor = true;
            this.EditToChoose.Click += new System.EventHandler(this.EditToChoose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 465);
            this.Controls.Add(this.EditToChoose);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.CheckBPS);
            this.Controls.Add(this.CheckDY);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CheckBetprcfit);
            this.Controls.Add(this.CheckRoediluted);
            this.Controls.Add(this.CheckPCT);
            this.Controls.Add(this.CheckCurrent);
            this.Controls.Add(this.CheckPB);
            this.Controls.Add(this.CheckEPS);
            this.Controls.Add(this.CheckPelyr);
            this.Controls.Add(this.CheckPettm);
            this.Controls.Add(this.CheckTotStockCost);
            this.Controls.Add(this.CheckTotMark);
            this.Name = "Form1";
            this.Text = "幫你選股票";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.CheckBox CheckCurrent;
        private System.Windows.Forms.CheckBox CheckPCT;
        private System.Windows.Forms.CheckBox CheckRoediluted;
        private System.Windows.Forms.CheckBox CheckBetprcfit;
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
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.CheckBox CheckDY;
        private System.Windows.Forms.CheckBox CheckBPS;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Button EditToChoose;
    }
}

