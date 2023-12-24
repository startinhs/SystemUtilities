using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemUtilities
{
    public partial class FrmTaskManager : Form
    {
        public FrmTaskManager()
        {
            InitializeComponent();
        }
        Process[] p;
        void getProcess()
        {
            p = Process.GetProcesses();
            listBox1.Items.Clear();
            for (int i = 0; i < p.Length; i++)
            {
                listBox1.Items.Add(p[i].ProcessName);
            }
            lbTask.Text = p.Length.ToString();
        }
        private void FrmTaskManager_Load(object sender, EventArgs e)
        {
            getProcess();
        }
        private void btRefreshTask_Click(object sender, EventArgs e)
        {
            getProcess();
        }
        private void btEndTask_Click(object sender, EventArgs e)
        {
            try
            {
                p[listBox1.SelectedIndex].Kill();
            }
            catch { }
           
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string keyWord = txtFind.Text.ToLower();
            if (keyWord == "")
            {
                MessageBox.Show("Nhập từ khoá cần tìm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.Clear();
            foreach (Process process in p)
            {
                if (process.ProcessName.ToLower().Contains(keyWord))
                {
                    listBox1.Items.Add(process.ProcessName);
                }
            }
        }
    }

    
}