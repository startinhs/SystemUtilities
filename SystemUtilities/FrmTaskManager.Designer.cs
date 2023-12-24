namespace SystemUtilities
{
    partial class FrmTaskManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaskManager));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btEndTask = new System.Windows.Forms.Button();
            this.btRefreshTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTask = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(532, 356);
            this.listBox1.TabIndex = 0;
            // 
            // btEndTask
            // 
            this.btEndTask.Location = new System.Drawing.Point(386, 440);
            this.btEndTask.Name = "btEndTask";
            this.btEndTask.Size = new System.Drawing.Size(167, 36);
            this.btEndTask.TabIndex = 1;
            this.btEndTask.Text = "End Task";
            this.btEndTask.UseVisualStyleBackColor = true;
            this.btEndTask.Click += new System.EventHandler(this.btEndTask_Click);
            // 
            // btRefreshTask
            // 
            this.btRefreshTask.Location = new System.Drawing.Point(21, 440);
            this.btRefreshTask.Name = "btRefreshTask";
            this.btRefreshTask.Size = new System.Drawing.Size(167, 36);
            this.btRefreshTask.TabIndex = 2;
            this.btRefreshTask.Text = "Refresh Task";
            this.btRefreshTask.UseVisualStyleBackColor = true;
            this.btRefreshTask.Click += new System.EventHandler(this.btRefreshTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tasks:";
            // 
            // lbTask
            // 
            this.lbTask.AutoSize = true;
            this.lbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTask.Location = new System.Drawing.Point(312, 450);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(18, 20);
            this.lbTask.TabIndex = 4;
            this.lbTask.Text = "0";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(110, 16);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(253, 36);
            this.txtFind.TabIndex = 5;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(386, 16);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(167, 36);
            this.btFind.TabIndex = 6;
            this.btFind.Text = "Find Task";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Keyword:";
            // 
            // FrmTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRefreshTask);
            this.Controls.Add(this.btEndTask);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTaskManager";
            this.Text = "Quản lý máy tính";
            this.Load += new System.EventHandler(this.FrmTaskManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btEndTask;
        private System.Windows.Forms.Button btRefreshTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label label2;
    }
}