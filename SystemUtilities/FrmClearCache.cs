﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemUtilities
{
    public partial class FrmClearCache : Form
    {
        public FrmClearCache()
        {
            InitializeComponent();
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr.exe");
        }
    }
}
