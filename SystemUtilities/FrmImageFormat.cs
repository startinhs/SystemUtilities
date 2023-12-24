using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemUtilities
{
    public partial class FrmImageFormat : Form
    {
        public FrmImageFormat()
        {
            InitializeComponent();
        }

        private void btBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picBox1.Image = Image.FromFile(dlg.FileName);
                picBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            String format = TuyChon.SelectedItem.ToString();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "File Format (*." + format + ")|*." + format;
            Bitmap bmp = new Bitmap(picBox1.Image);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(dlg.FileName);
                MessageBox.Show("Lưu ảnh thành công!");
            }
        }
    }
}
