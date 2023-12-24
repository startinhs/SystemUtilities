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
    public partial class FrmNote : Form
    {
        public FrmNote()
        {

            InitializeComponent();

        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text File (*.txt)|*.txt" +
            "|All file (*.)|*.";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(dlg.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text File (*.txt)|*.txt" +
            "|All file (*.)|*.";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, textBox1.Text);
                MessageBox.Show("Lưu thành công!");
            }
        }
        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDlg.Font;
            }
        }

        private void centerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void leftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }
    }
}
