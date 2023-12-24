
using System.Windows.Forms;

namespace SystemUtilities
{
    partial class FrmImageFormat
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImageFormat));
            this.btBrowser = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.btSave = new System.Windows.Forms.Button();
            this.TuyChon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBrowser
            // 
            this.btBrowser.Location = new System.Drawing.Point(67, 41);
            this.btBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBrowser.Name = "btBrowser";
            this.btBrowser.Size = new System.Drawing.Size(305, 36);
            this.btBrowser.TabIndex = 0;
            this.btBrowser.Text = "Browser";
            this.btBrowser.UseVisualStyleBackColor = true;
            this.btBrowser.Click += new System.EventHandler(this.btBrowser_Click);
            // 
            // picBox1
            // 
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Location = new System.Drawing.Point(67, 95);
            this.picBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(305, 222);
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(504, 210);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(149, 37);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // TuyChon
            // 
            this.TuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuyChon.FormattingEnabled = true;
            this.TuyChon.Items.AddRange(new object[] {
            "JPG",
            "JPEG",
            "GIF",
            "PNG",
            "SVG"});
            this.TuyChon.Location = new System.Drawing.Point(479, 137);
            this.TuyChon.Margin = new System.Windows.Forms.Padding(4);
            this.TuyChon.Name = "TuyChon";
            this.TuyChon.Size = new System.Drawing.Size(204, 33);
            this.TuyChon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn đuôi ảnh:";
            // 
            // FrmImageFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TuyChon);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.btBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmImageFormat";
            this.Text = "Chuyển đổi đuôi ảnh";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private Button btBrowser;
        private PictureBox picBox1;
        private Button btSave;
        private ComboBox TuyChon;
        private Label label1;
    }
}