using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemUtilities
{
    public partial class FrmRemind : Form
    {
        public FrmRemind()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer aTimer;
        private int counter;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.DayOfWeek.ToString() + ", " + (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "/" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "/" + DateTime.Now.Year;
            lbTime.Text =
                            (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" +
                            (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" +
                            (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
        }

        private int convertTime(string h, string m, string s)
        {
            int hour = 0, minute = 0, second = 0;
            hour = int.Parse(h);
            minute = int.Parse(m);
            second = int.Parse(s);
            int ss = hour * 3600 + minute * 60 + second;
            return ss;
        }
        private void btCreateRemind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInputHour.Text == "" || txtInputMinute.Text == "" || txtInputSecond.Text == "")
                    throw new Exception("Vui lòng không để trống ô nhập!");

                if (int.Parse(txtInputHour.Text) > 23 || int.Parse(txtInputHour.Text) < 0 ||
                    int.Parse(txtInputMinute.Text) > 60 || int.Parse(txtInputMinute.Text) < 0 ||
                    int.Parse(txtInputSecond.Text) > 60 || int.Parse(txtInputSecond.Text) < 0)
                    throw new Exception("Vui lòng nhập đúng khoảng giờ quy định!");

                //string dateCurrent = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                //if (InputDate.Value.ToShortDateString() == dateCurrent)
                //{
                    lbSystemTime.Text = InputDate.Value.ToShortDateString();
                    aTimer = new System.Windows.Forms.Timer();
                    aTimer.Tick += new EventHandler(aTimer_Tick);
                    aTimer.Interval = 1000;
                    aTimer.Start();
                    

                int input = convertTime(txtInputHour.Text, txtInputMinute.Text, txtInputSecond.Text);
                    int now = convertTime(DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString(), DateTime.Now.Second.ToString());
                    counter = input - now;
                //}

                MessageBox.Show("Tạo lời nhắc thành công! Đợi đến " + InputDate.Value.ToShortDateString() + " lúc "+ txtInputHour.Text+":"+ txtInputMinute.Text+":"+ txtInputSecond.Text+" nhé!");


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

        private void aTimer_Tick(object sender, EventArgs e)
        {
            
            counter--;
            if (counter <= 0)
            {
                SystemSounds.Hand.Play();
                txtContent.Text = "Bạn có lời nhắc cần thực hiện: \n"+txtContent.Text;
                if (counter <= -10)
                    aTimer.Stop();
            }
        }

        private void btUndo_Click(object sender, EventArgs e)
        {
            aTimer.Stop();
        }
    }
}
