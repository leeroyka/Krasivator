using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krasivator
{
    public partial class FormPipett : Form
    {
        MyImage img;
        public FormPipett(MyImage image)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 23, 33, 43);

            button1.BackColor = Color.FromArgb(255, 39, 105, 153);
            img = image;
            pictureBox1.Image = image.bmp;
            var (w, h) = image.getSize();
            this.Size = new Size(w, h + 56);
            button1.Location = new Point(12, h + 12);
        }
        Point mousePos;
        public (int r,int g,int b) getPixel()
        {

            return img.getPixel(mousePos.X,mousePos.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mousePos = Control.MousePosition;
            mousePos.Offset(0 - this.Location.X, 0 - this.Location.Y);
            this.Close();
        }
    }
}
