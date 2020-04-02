using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Linq;
namespace Krasivator
{
    public partial class FormFreq : Form
    {
        MyImage img,_img;
        public FormFreq(MyImage image)
        {
            InitializeComponent();

            menuStrip1.BackColor = Color.FromArgb(255, 36, 47, 61);
            this.BackColor = Color.FromArgb(255, 23, 33, 43);
            textBox1.BackColor = Color.FromArgb(255, 23, 33, 43);
            button1.BackColor = Color.FromArgb(255, 42, 83, 120);
            xToolStripMenuItem.ForeColor = Color.FromArgb(255, 87, 102, 115);
            img = image;
            _img = FreqFilter.createDFT(img);
            pictureBox1.Image = _img.bmp;

            int[,] arr = getArr();
            drawFilter(arr);
            //pictureBox1.Image = FreqFilter.deDFT(img).bmp;
        }
        public MyImage getImage()
        {
            return img;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int[,] arr = getArr();
            drawFilter(arr);
            img = FreqFilter.deDFT(img,matrix);
            this.Close();
        }

        private Point mouseOffset;
        private bool isMouseDown = false;
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void FormFreq_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void FormFreq_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        int[,] getArr()
        {
            int m = textBox1.Lines.Length;
            int p = textBox1.Text.IndexOf('\r');
            int n = textBox1.Lines[0].Split(';').Length;

            string k = textBox1.Lines[0];
            int[,] arr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] s = textBox1.Lines[i].Split(';');

                for (int j = 0; j < n; j++)
                {
                    s[j] = s[j].Replace('.', ',');
                    arr[i, j] = Int32.Parse(s[j]);
                }
            }
            return arr;
        }
        int[,] matrix;
        void drawFilter(int[,] arr)
        {
            MyImage img = new MyImage(pictureBox1.Image.Width, pictureBox1.Image.Height);
            img.bmp = (Bitmap)_img.bmp.Clone();
            int imageH, imageW;
            (imageW, imageH) = img.getSize();
            matrix = new int[imageW, imageH];
            int n, m;
            n = imageW / 2;
            m = imageH / 2;
            for (int i=0;i<arr.GetLength(0);i++)
            {
                int radius1, radius2;
                radius1 = (int)arr[i, 2];
                radius2 = (int)arr[i, 3];
                if(radius1>radius2)
                {
                    int c = radius1;
                    radius1 = radius2;
                    radius2 = c;
                }
                for(int y=radius2;y>=0;y--)
                {
                    double a = Math.Cos(Math.Asin((double)y / (double)radius2));
                    int x = (int)(a*radius2);
                    for(int j=-x;j<=x;j++)
                    {
                        int _x, _y;
                        _x = j + n + arr[i, 0];
                        _y = y + m + arr[i, 1];
                        if (_x >= imageW) _x = imageW - 1;
                        if (_y >= imageH) _y = imageH - 1;
                        if (_x < 0) _x = 0;
                        if (_y < 0) _y = 0;
                        matrix[_x,_y] = 1;
                        _y = -y + m + arr[i, 1];
                        if (_y >= imageH) _y = imageH - 1;
                        if (_y < 0) _y = 0;
                        matrix[_x, _y] = 1;
                        if (arr[i,0]!=0 || arr[i,1]!=0)
                        {
                            _x = j + n - arr[i, 0];
                            _y = y + m - arr[i, 1];
                            if (_x >= imageW) _x = imageW - 1;
                            if (_y >= imageH) _y = imageH - 1;
                            if (_x < 0) _x = 0;
                            if (_y < 0) _y = 0;
                            matrix[_x, _y] = 1;
                            _y = -y + m - arr[i, 1];

                            if (_x >= imageW) _x = imageW - 1;
                            if (_y >= imageH) _y = imageH - 1;
                            if (_x < 0) _x = 0;
                            if (_y < 0) _y = 0;
                            matrix[_x, _y] = 1;
                        }
                    }

                }
                if(radius1!=0)
                for (int y = radius1; y >= 0; y--)
                {
                    double a = Math.Cos(Math.Asin((double)y / (double)radius1));
                    int x = (int)(a * radius1);
                    for (int j = -x; j <= x; j++)
                    {
                            int _x, _y;
                            _x = j + n + arr[i, 0];
                            _y = y + m + arr[i, 1];
                            if (_x >= imageW) _x = imageW - 1;
                            if (_y >= imageH) _y = imageH - 1;
                            if (_x < 0) _x = 0;
                            if (_y < 0) _y = 0;
                            matrix[_x, _y] = 0;
                            _y = -y + m + arr[i, 1];
                            if (_y >= imageH) _y = imageH - 1;
                            if (_y < 0) _y = 0;
                            matrix[_x, _y] = 0;
                            if (arr[i, 0] != 0 || arr[i, 1] != 0)
                            {
                                _x = j + n - arr[i, 0];
                                _y = y + m - arr[i, 1];
                                if (_x >= imageW) _x = imageW - 1;
                                if (_y >= imageH) _y = imageH - 1;
                                if (_x < 0) _x = 0;
                                if (_y < 0) _y = 0;
                                matrix[_x, _y] = 0;
                                _y = -y + m - arr[i, 1];

                                if (_x >= imageW) _x = imageW - 1;
                                if (_y >= imageH) _y = imageH - 1;
                                if (_x < 0) _x = 0;
                                if (_y < 0) _y = 0;
                                matrix[_x, _y] = 0;
                            }
                        }

                }

            }
            for(int i=0;i<imageH;i++)
            {
                for(int j=0;j<imageW;j++)
                {
                    if(radioButton2.Checked)
                    {
                        if (matrix[j, i] == 1)
                            matrix[j, i] = 0;
                        else
                            matrix[j, i] = 1;
                    }
                    if(matrix[j,i]==1)
                    {
                        var (r, g, b) = img.getPixel(j, i);
                        int p = Math.Max(Math.Max(r, g), b);
                        p += 100;
                        if (p > 230)
                            p = 230;
                        img.setPixel(j, i, p, p, 0);
                    }
                }
            }
            pictureBox1.Image = img.bmp;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arr = getArr();
            drawFilter(arr);
        }
    }
}
