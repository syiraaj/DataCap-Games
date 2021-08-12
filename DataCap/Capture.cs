using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.Integration;
using System.Windows.Interop;
using System.Threading;

namespace DataCap
{
    public partial class Capture : Form
    {
        public Capture()
        {
            InitializeComponent();
        }
        ImageFormat img;
        Bitmap bt;
        Graphics screenShot;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(500);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bt = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                screenShot = Graphics.FromImage(bt);
                screenShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                img = ImageFormat.Jpeg;
            }
            bt.Save(saveFileDialog1.FileName, img);

            this.Close();
        }
    }
}
