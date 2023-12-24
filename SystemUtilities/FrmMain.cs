using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemUtilities
{
    public partial class FrmMain : Form
    {
        Random rand = new Random();
        string []arrBackGR;
        public static string tenDangNhap = "";
        public FrmMain()
        {
            InitializeComponent();
        }
        private void changeImage()
        {
            arrBackGR = Directory.GetFiles(Application.StartupPath + @"\assets\wallpapers");
            String f = arrBackGR[rand.Next(arrBackGR.Length)];
            Image img = Image.FromFile(f);
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.changeImage();
            btHome.Visible = false;
        }
        private void HenGioTatMay_Click(object sender, EventArgs e)
        {
            FrmShutdownTimer frm = new FrmShutdownTimer();
            frm.MdiParent = this;
            frm.Show();
            panelHome.Visible = false;

            ListViewItem item = new ListViewItem(HenGioTatMay.Text);
            item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
            listHistory.Items.Add(item);
            btFunc.Visible = false;
            btHome.Visible = true;


        }
        private void NhacLichLamViec_Click(object sender, EventArgs e)
        {
            FrmRemind frm = new FrmRemind();
            frm.MdiParent = this;
            frm.Show();
            panelHome.Visible = false;

            ListViewItem item = new ListViewItem(NhacLichLamViec.Text);
            item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
            listHistory.Items.Add(item);
            btFunc.Visible = false;
            btHome.Visible = true;
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            btHome.Visible = false;
            btFunc.Visible = true;

        }

        private void btFunc_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            btHome.Visible = true;
            btFunc.Visible = false;
        }

        private void btBackGR_Click(object sender, EventArgs e)
        {
            this.changeImage();
        }

        private void createNote()
        {
            FrmNote frm = new FrmNote();
            frm.MdiParent = this;
            frm.Show();
            panelHome.Visible = false;

            ListViewItem item = new ListViewItem(TaoBanGhiChu.Text);
            item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
            listHistory.Items.Add(item);
            btFunc.Visible = false;
            btHome.Visible = true;
        }
        private void TaoBanGhiChu_Click(object sender, EventArgs e)
        {
            createNote();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNote();
        }
        private void ChuyenDoiDuoiAnh_Click(object sender, EventArgs e)
        {
            FrmImageFormat frm = new FrmImageFormat();
            frm.MdiParent = this;
            frm.Show();
            panelHome.Visible = false;

            ListViewItem item = new ListViewItem(ChuyenDoiDuoiAnh.Text);
            item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
            listHistory.Items.Add(item);
            btFunc.Visible = false;
            btHome.Visible = true;
        }

        private void XoaBoNhoTam_Click(object sender, EventArgs e)
        {
            FrmClearCache frm = new FrmClearCache();
            frm.MdiParent = this;
            frm.Show();
            panelHome.Visible = false;

            ListViewItem item = new ListViewItem(XoaBoNhoTam.Text);
            item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
            listHistory.Items.Add(item);
            btFunc.Visible = false;
            btHome.Visible = true;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chương trình?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void QuanLyMayTinh_Click(object sender, EventArgs e)
        {
            FrmTaskManager frm = new FrmTaskManager();
            frm.MdiParent = this;
            frm.Show();
            panelHome.Visible = false;

            ListViewItem item = new ListViewItem(QuanLyMayTinh.Text);
            item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
            listHistory.Items.Add(item);
            btFunc.Visible = false;
            btHome.Visible = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.MdiParent = this;
            frm.Show();
            panelHome.Visible = false;
        }
    }
}
