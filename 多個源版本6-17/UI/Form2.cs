﻿using System;
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
    public partial class ConditionNameForm : Form
    {
        public ConditionNameForm()
        {
            InitializeComponent();
        }

        private void 新創ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
