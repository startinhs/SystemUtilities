
namespace SystemUtilities
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HenGioTatMay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NhacLichLamViec = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TaoBanGhiChu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.XoaBoNhoTam = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.QuanLyMayTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ChuyenDoiDuoiAnh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btBackGR = new System.Windows.Forms.Button();
            this.btFunc = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.listHistory = new System.Windows.Forms.ListView();
            this.listChucNang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listThoiGian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HenGioTatMay,
            this.toolStripSeparator1,
            this.NhacLichLamViec,
            this.toolStripSeparator2,
            this.TaoBanGhiChu,
            this.toolStripSeparator4,
            this.XoaBoNhoTam,
            this.toolStripSeparator5,
            this.QuanLyMayTinh,
            this.toolStripSeparator6,
            this.ChuyenDoiDuoiAnh,
            this.toolStripSeparator7});
            this.functionsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.functionsToolStripMenuItem.MergeIndex = 0;
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            resources.ApplyResources(this.functionsToolStripMenuItem, "functionsToolStripMenuItem");
            // 
            // HenGioTatMay
            // 
            this.HenGioTatMay.Name = "HenGioTatMay";
            resources.ApplyResources(this.HenGioTatMay, "HenGioTatMay");
            this.HenGioTatMay.Click += new System.EventHandler(this.HenGioTatMay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // NhacLichLamViec
            // 
            this.NhacLichLamViec.Name = "NhacLichLamViec";
            resources.ApplyResources(this.NhacLichLamViec, "NhacLichLamViec");
            this.NhacLichLamViec.Click += new System.EventHandler(this.NhacLichLamViec_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // TaoBanGhiChu
            // 
            this.TaoBanGhiChu.Name = "TaoBanGhiChu";
            resources.ApplyResources(this.TaoBanGhiChu, "TaoBanGhiChu");
            this.TaoBanGhiChu.Click += new System.EventHandler(this.TaoBanGhiChu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // XoaBoNhoTam
            // 
            this.XoaBoNhoTam.Name = "XoaBoNhoTam";
            resources.ApplyResources(this.XoaBoNhoTam, "XoaBoNhoTam");
            this.XoaBoNhoTam.Click += new System.EventHandler(this.XoaBoNhoTam_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // QuanLyMayTinh
            // 
            this.QuanLyMayTinh.Name = "QuanLyMayTinh";
            resources.ApplyResources(this.QuanLyMayTinh, "QuanLyMayTinh");
            this.QuanLyMayTinh.Click += new System.EventHandler(this.QuanLyMayTinh_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // ChuyenDoiDuoiAnh
            // 
            this.ChuyenDoiDuoiAnh.Name = "ChuyenDoiDuoiAnh";
            resources.ApplyResources(this.ChuyenDoiDuoiAnh, "ChuyenDoiDuoiAnh");
            this.ChuyenDoiDuoiAnh.Click += new System.EventHandler(this.ChuyenDoiDuoiAnh_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.helpToolStripMenuItem.MergeIndex = 1;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // btBackGR
            // 
            resources.ApplyResources(this.btBackGR, "btBackGR");
            this.btBackGR.BackColor = System.Drawing.Color.Transparent;
            this.btBackGR.Name = "btBackGR";
            this.btBackGR.UseVisualStyleBackColor = false;
            this.btBackGR.Click += new System.EventHandler(this.btBackGR_Click);
            // 
            // btFunc
            // 
            resources.ApplyResources(this.btFunc, "btFunc");
            this.btFunc.BackColor = System.Drawing.Color.Transparent;
            this.btFunc.Name = "btFunc";
            this.btFunc.UseVisualStyleBackColor = false;
            this.btFunc.Click += new System.EventHandler(this.btFunc_Click);
            // 
            // btHome
            // 
            resources.ApplyResources(this.btHome, "btHome");
            this.btHome.BackColor = System.Drawing.Color.Transparent;
            this.btHome.Name = "btHome";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // bt1
            // 
            resources.ApplyResources(this.bt1, "bt1");
            this.bt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt1.Name = "bt1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.HenGioTatMay_Click);
            // 
            // bt7
            // 
            resources.ApplyResources(this.bt7, "bt7");
            this.bt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bt7.Name = "bt7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.ChuyenDoiDuoiAnh_Click);
            // 
            // bt6
            // 
            resources.ApplyResources(this.bt6, "bt6");
            this.bt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt6.Name = "bt6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.QuanLyMayTinh_Click);
            // 
            // bt5
            // 
            resources.ApplyResources(this.bt5, "bt5");
            this.bt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt5.Name = "bt5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.XoaBoNhoTam_Click);
            // 
            // bt4
            // 
            resources.ApplyResources(this.bt4, "bt4");
            this.bt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt4.Name = "bt4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.TaoBanGhiChu_Click);
            // 
            // bt2
            // 
            resources.ApplyResources(this.bt2, "bt2");
            this.bt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt2.Name = "bt2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.NhacLichLamViec_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Name = "label9";
            // 
            // panelHome
            // 
            resources.ApplyResources(this.panelHome, "panelHome");
            this.panelHome.BackColor = System.Drawing.SystemColors.Control;
            this.panelHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHome.Controls.Add(this.listHistory);
            this.panelHome.Controls.Add(this.label9);
            this.panelHome.Controls.Add(this.label8);
            this.panelHome.Controls.Add(this.label7);
            this.panelHome.Controls.Add(this.label6);
            this.panelHome.Controls.Add(this.label4);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.bt2);
            this.panelHome.Controls.Add(this.bt4);
            this.panelHome.Controls.Add(this.bt5);
            this.panelHome.Controls.Add(this.bt6);
            this.panelHome.Controls.Add(this.bt7);
            this.panelHome.Controls.Add(this.bt1);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelHome.Name = "panelHome";
            // 
            // listHistory
            // 
            resources.ApplyResources(this.listHistory, "listHistory");
            this.listHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listChucNang,
            this.listThoiGian});
            this.listHistory.HideSelection = false;
            this.listHistory.Name = "listHistory";
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.View = System.Windows.Forms.View.Details;
            // 
            // listChucNang
            // 
            resources.ApplyResources(this.listChucNang, "listChucNang");
            // 
            // listThoiGian
            // 
            resources.ApplyResources(this.listThoiGian, "listThoiGian");
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btBackGR);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.btFunc);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Click += new System.EventHandler(this.HenGioTatMay_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HenGioTatMay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NhacLichLamViec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TaoBanGhiChu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoaBoNhoTam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem QuanLyMayTinh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ChuyenDoiDuoiAnh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btFunc;
        private System.Windows.Forms.Button btBackGR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.ListView listHistory;
        private System.Windows.Forms.ColumnHeader listChucNang;
        private System.Windows.Forms.ColumnHeader listThoiGian;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

