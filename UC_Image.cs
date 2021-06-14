using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputDataApplication
{
    public partial class UC_Image : UserControl
    {
        public UC_Image()
        {
            InitializeComponent();
        }

        public void LoadImage(string strURL, string strFileName)
        {
            PictureBox temp = new PictureBox();
            temp.Load(strURL);
            imageBox1.Image = temp.Image;
            imageBox1.SizeMode = ImageGlass.ImageBoxSizeMode.Normal;
            imageBox1.AllowZoom = false;
            imageBox1.Image.Tag = strFileName;
            imageBox1.Zoom = 70;
        }
        private void btn_Right_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
            {
                return;
            }

            Bitmap bmp = new Bitmap(imageBox1.Image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            imageBox1.Image = bmp;
        }


        private void btn_Left_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
            {
                return;
            }

            Bitmap bmp = new Bitmap(imageBox1.Image);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipXY);
            imageBox1.Image = bmp;
        }

        private void btn_ZoomIn_Click(object sender, EventArgs e)
        {
            imageBox1.ZoomIn();
        }

        private void btn_ZoomOut_Click(object sender, EventArgs e)
        {
            imageBox1.ZoomOut();
        }

        private void UC_Image_Load(object sender, EventArgs e)
        {

        }
    }
}
