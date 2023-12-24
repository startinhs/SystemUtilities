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

namespace SystemUtilities
{
    public partial class FrmShutdownTimer : Form
    {
        public FrmShutdownTimer()
        {
            InitializeComponent();
        }
        private void FrmShutdownTimer_Load(object sender, EventArgs e)
        {
            cbTuyChon.SelectedIndex = 0;
        }

        string strCmdText;
        private int convertTime(string h, string m, string s)
        {
            int hour = 0, minute = 0, second = 0;
            hour = int.Parse(h);
            minute = int.Parse(m);
            second = int.Parse(s);
            int ss = hour * 3600 + minute * 60 + second;
            return ss;
        }
        
        private void choose_function(string cmd)
        {
            try
            {
                if (txtInputHour.Text == "" || txtInputMinute.Text == "" || txtInputSecond.Text == "")
                    throw new Exception("Vui lòng không để trống ô nhập!");

                if (int.Parse(txtInputHour.Text) > 23 || int.Parse(txtInputHour.Text) < 0 ||
                    int.Parse(txtInputMinute.Text) > 60 || int.Parse(txtInputMinute.Text) < 0 ||
                    int.Parse(txtInputSecond.Text) > 60 || int.Parse(txtInputSecond.Text) < 0  )
                    throw new Exception("Vui lòng nhập đúng khoảng giờ quy định!");

                switch (cbTuyChon.SelectedIndex)
                {
                    case 0:
                        int input = convertTime(txtInputHour.Text, txtInputMinute.Text, txtInputSecond.Text);
                        int now = convertTime(DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString(), DateTime.Now.Second.ToString());
                        strCmdText = cmd + (input - now);
                        Process.Start("CMD.exe", strCmdText);
                        break;

                    case 1:
                        int time = convertTime(txtInputHour.Text, txtInputMinute.Text, txtInputSecond.Text);
                        strCmdText = cmd + time;
                        Process.Start("CMD.exe", strCmdText);
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số!");
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }
        private void btShutdown_Click(object sender, EventArgs e)
        {
            choose_function("/C Shutdown /s /t ");
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            choose_function("/C Shutdown /r /t ");

        }

        private void btUndo_Click(object sender, EventArgs e)
        {
            strCmdText = "/C Shutdown /a";
            Process.Start("CMD.exe", strCmdText);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = 
                            (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + 
                            (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + 
                            (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
        } 
    }
}
