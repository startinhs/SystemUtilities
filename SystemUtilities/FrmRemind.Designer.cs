
namespace SystemUtilities
{
    partial class FrmRemind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemind));
            this.lbTime = new System.Windows.Forms.Label();
            this.lbSystemTime = new System.Windows.Forms.Label();
            this.lbInputTime = new System.Windows.Forms.Label();
            this.txtInputHour = new System.Windows.Forms.TextBox();
            this.txtInputMinute = new System.Windows.Forms.TextBox();
            this.txtInputSecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCreateRemind = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btUndo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Blue;
            this.lbTime.Location = new System.Drawing.Point(200, 0);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(216, 55);
            this.lbTime.TabIndex = 5;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSystemTime
            // 
            this.lbSystemTime.AutoSize = true;
            this.lbSystemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSystemTime.Location = new System.Drawing.Point(73, 47);
            this.lbSystemTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSystemTime.Name = "lbSystemTime";
            this.lbSystemTime.Size = new System.Drawing.Size(227, 31);
            this.lbSystemTime.TabIndex = 6;
            this.lbSystemTime.Text = "Thời gian hiện tại:";
            // 
            // lbInputTime
            // 
            this.lbInputTime.AutoSize = true;
            this.lbInputTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInputTime.Location = new System.Drawing.Point(66, 147);
            this.lbInputTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInputTime.Name = "lbInputTime";
            this.lbInputTime.Size = new System.Drawing.Size(153, 31);
            this.lbInputTime.TabIndex = 9;
            this.lbInputTime.Text = "Chọn ngày:";
            // 
            // txtInputHour
            // 
            this.txtInputHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtInputHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputHour.Location = new System.Drawing.Point(269, 227);
            this.txtInputHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputHour.Multiline = true;
            this.txtInputHour.Name = "txtInputHour";
            this.txtInputHour.Size = new System.Drawing.Size(95, 51);
            this.txtInputHour.TabIndex = 10;
            this.txtInputHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInputMinute
            // 
            this.txtInputMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtInputMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputMinute.Location = new System.Drawing.Point(426, 227);
            this.txtInputMinute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputMinute.Multiline = true;
            this.txtInputMinute.Name = "txtInputMinute";
            this.txtInputMinute.Size = new System.Drawing.Size(95, 51);
            this.txtInputMinute.TabIndex = 11;
            this.txtInputMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInputSecond
            // 
            this.txtInputSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtInputSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSecond.Location = new System.Drawing.Point(589, 227);
            this.txtInputSecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputSecond.Multiline = true;
            this.txtInputSecond.Name = "txtInputSecond";
            this.txtInputSecond.Size = new System.Drawing.Size(95, 51);
            this.txtInputSecond.TabIndex = 12;
            this.txtInputSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = ":";
            // 
            // btCreateRemind
            // 
            this.btCreateRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateRemind.Location = new System.Drawing.Point(688, 303);
            this.btCreateRemind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCreateRemind.Name = "btCreateRemind";
            this.btCreateRemind.Size = new System.Drawing.Size(107, 90);
            this.btCreateRemind.TabIndex = 15;
            this.btCreateRemind.Text = "Tạo lời nhắc";
            this.btCreateRemind.UseVisualStyleBackColor = true;
            this.btCreateRemind.Click += new System.EventHandler(this.btCreateRemind_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Blue;
            this.lbDate.Location = new System.Drawing.Point(0, 0);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(216, 55);
            this.lbDate.TabIndex = 16;
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nhập thời gian:";
            // 
            // InputDate
            // 
            this.InputDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDate.Location = new System.Drawing.Point(268, 142);
            this.InputDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(283, 37);
            this.InputDate.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Location = new System.Drawing.Point(324, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 55);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nội dung lời nhắc:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(305, 337);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(301, 130);
            this.txtContent.TabIndex = 23;
            // 
            // btUndo
            // 
            this.btUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUndo.Location = new System.Drawing.Point(688, 416);
            this.btUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(107, 90);
            this.btUndo.TabIndex = 24;
            this.btUndo.Text = "Huỷ lời nhắc";
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // FrmRemind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 519);
            this.Controls.Add(this.btUndo);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCreateRemind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInputSecond);
            this.Controls.Add(this.txtInputMinute);
            this.Controls.Add(this.txtInputHour);
            this.Controls.Add(this.lbInputTime);
            this.Controls.Add(this.lbSystemTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmRemind";
            this.Text = "Nhắc lịch làm việc";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbSystemTime;
        private System.Windows.Forms.Label lbInputTime;
        private System.Windows.Forms.TextBox txtInputHour;
        private System.Windows.Forms.TextBox txtInputMinute;
        private System.Windows.Forms.TextBox txtInputSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreateRemind;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker InputDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btUndo;
    }
}