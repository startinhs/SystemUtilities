
namespace SystemUtilities
{
    partial class FrmShutdownTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShutdownTimer));
            this.lbSystemTime = new System.Windows.Forms.Label();
            this.btShutdown = new System.Windows.Forms.Button();
            this.btRestart = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.btUndo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbTuyChon = new System.Windows.Forms.ComboBox();
            this.txtInputSecond = new System.Windows.Forms.TextBox();
            this.lbInputTime = new System.Windows.Forms.Label();
            this.txtInputHour = new System.Windows.Forms.TextBox();
            this.txtInputMinute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSystemTime
            // 
            this.lbSystemTime.AutoSize = true;
            this.lbSystemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSystemTime.Location = new System.Drawing.Point(371, 31);
            this.lbSystemTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSystemTime.Name = "lbSystemTime";
            this.lbSystemTime.Size = new System.Drawing.Size(227, 31);
            this.lbSystemTime.TabIndex = 0;
            this.lbSystemTime.Text = "Thời gian hiện tại:";
            // 
            // btShutdown
            // 
            this.btShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShutdown.Location = new System.Drawing.Point(72, 346);
            this.btShutdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btShutdown.Name = "btShutdown";
            this.btShutdown.Size = new System.Drawing.Size(141, 78);
            this.btShutdown.TabIndex = 2;
            this.btShutdown.Text = "Shutdown";
            this.btShutdown.UseVisualStyleBackColor = true;
            this.btShutdown.Click += new System.EventHandler(this.btShutdown_Click);
            // 
            // btRestart
            // 
            this.btRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestart.Location = new System.Drawing.Point(264, 346);
            this.btRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(141, 78);
            this.btRestart.TabIndex = 3;
            this.btRestart.Text = "Restart";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Blue;
            this.lbTime.Location = new System.Drawing.Point(363, 73);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(277, 55);
            this.lbTime.TabIndex = 4;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btUndo
            // 
            this.btUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUndo.Location = new System.Drawing.Point(459, 346);
            this.btUndo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(141, 78);
            this.btUndo.TabIndex = 5;
            this.btUndo.Text = "Undo";
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbTuyChon
            // 
            this.cbTuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuyChon.FormattingEnabled = true;
            this.cbTuyChon.Items.AddRange(new object[] {
            "Hẹn thời gian theo hệ thống",
            "Hẹn giờ | phút | giây đếm ngược"});
            this.cbTuyChon.Location = new System.Drawing.Point(25, 86);
            this.cbTuyChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTuyChon.Name = "cbTuyChon";
            this.cbTuyChon.Size = new System.Drawing.Size(304, 33);
            this.cbTuyChon.TabIndex = 6;
            // 
            // txtInputSecond
            // 
            this.txtInputSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtInputSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSecond.Location = new System.Drawing.Point(440, 223);
            this.txtInputSecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputSecond.Multiline = true;
            this.txtInputSecond.Name = "txtInputSecond";
            this.txtInputSecond.Size = new System.Drawing.Size(95, 73);
            this.txtInputSecond.TabIndex = 7;
            this.txtInputSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbInputTime
            // 
            this.lbInputTime.AutoSize = true;
            this.lbInputTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInputTime.Location = new System.Drawing.Point(244, 172);
            this.lbInputTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInputTime.Name = "lbInputTime";
            this.lbInputTime.Size = new System.Drawing.Size(196, 31);
            this.lbInputTime.TabIndex = 8;
            this.lbInputTime.Text = "Nhập thời gian:";
            // 
            // txtInputHour
            // 
            this.txtInputHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtInputHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputHour.Location = new System.Drawing.Point(139, 223);
            this.txtInputHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputHour.Multiline = true;
            this.txtInputHour.Name = "txtInputHour";
            this.txtInputHour.Size = new System.Drawing.Size(95, 73);
            this.txtInputHour.TabIndex = 9;
            this.txtInputHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInputMinute
            // 
            this.txtInputMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtInputMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputMinute.Location = new System.Drawing.Point(287, 223);
            this.txtInputMinute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputMinute.Multiline = true;
            this.txtInputMinute.Name = "txtInputMinute";
            this.txtInputMinute.Size = new System.Drawing.Size(95, 73);
            this.txtInputMinute.TabIndex = 10;
            this.txtInputMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chọn kiểu tắt máy:";
            // 
            // FrmShutdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputMinute);
            this.Controls.Add(this.txtInputHour);
            this.Controls.Add(this.lbInputTime);
            this.Controls.Add(this.txtInputSecond);
            this.Controls.Add(this.cbTuyChon);
            this.Controls.Add(this.btUndo);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.btShutdown);
            this.Controls.Add(this.lbSystemTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmShutdownTimer";
            this.Text = "Hẹn Giờ Tắt Máy";
            this.Load += new System.EventHandler(this.FrmShutdownTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSystemTime;
        private System.Windows.Forms.Button btShutdown;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbTuyChon;
        private System.Windows.Forms.TextBox txtInputSecond;
        private System.Windows.Forms.Label lbInputTime;
        private System.Windows.Forms.TextBox txtInputHour;
        private System.Windows.Forms.TextBox txtInputMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}