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
    public partial class FormCurves : Form
    {
        int[] outputR;
        int[] outputG;
        int[] outputB;
        int[] output;
        MyImage img;
        public FormCurves(MyImage image)
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.FromArgb(255, 36, 47, 61);
            this.BackColor = Color.FromArgb(255, 23, 33, 43);
            pictureBox1.BackColor = Color.FromArgb(255, 14, 22, 33);
            pictureBox2.BackColor = Color.FromArgb(255, 14, 22, 33);
            pictureBox3.BackColor = Color.FromArgb(255, 14, 22, 33);
            xToolStripMenuItem.ForeColor = Color.FromArgb(255, 87, 102, 115);
            button1.BackColor = Color.FromArgb(255, 39, 105, 153);
            Draw(1, btnR1.Location, btnR2.Location, btnR3.Location);
            Draw(2, btnG1.Location, btnG2.Location, btnG3.Location);
            Draw(3, btnB1.Location, btnB2.Location, btnB3.Location);
            img = image;

            frmWait = new FormWait();
        }
        void Draw(int param,Point p1,Point p2,Point p3)
        {
            
            p1.Offset(5, 5);
            p2.Offset(5, 5);
            p3.Offset(5, 5);
            
            output = new int[256];
            for (int i = 0; i < 256; i++)
                output[i] = -1;
            double t = 0;


            for (int i = 0; i <= p1.X; i++)
                output[i] = 255-p1.Y;
            for (int i = p3.X; i < 256; i++)
                output[i] = 255-p3.Y;

            var known = new Dictionary<double, double>
                {
                    { (double)p1.X, (double)p1.Y },
                    { (double)p2.X,(double)p2.Y },
                    { (double)p3.X, (double)p3.Y},
                };
            var scaler = new SplineInterpolator(known);
            var start = known.First().Key;
            var end = known.Last().Key;
            var step = (end - start) / 500;
            Graphics g;
            Bitmap bmp = new Bitmap(256, 256);
            for (var x = start; x <= end; x += step)
            {
                var y = scaler.GetValue(x);
                if (x <= 255 && x >= 0)
                {
                    if (y < 0)
                        y = 0;
                    if (y > 255)
                        y = 255;
                    output[(int)x] = 255 - (int)y;

                    
                }

            }

            g = Graphics.FromImage(bmp);
            //Grid
            for (int i = 0; i < 256; i = i + (256 / 16))
            {
                Pen p = new Pen(Color.FromArgb(52, 52, 52));
                if (i == 256)
                    i = 254;
                g.DrawLine(p, i, 0, i, 255);
            }
            for (int i = 0; i < 256; i = i + (256 / 16))
            {
                Pen p = new Pen(Color.FromArgb(52, 52, 52));
                if (i == 256)
                    i = 254;
                g.DrawLine(p, 0, i, 255, i);
            }

            for (int i = 0; i <= 256; i = i + (256 / 4))
            {
                Pen p = new Pen(Color.FromArgb(122, 122, 122));
                if (i == 256)
                    i = 254;
                g.DrawLine(p, 0,i, 255, i);
            }
            for (int i = 0; i <= 256; i = i + (256 / 4))
            {
                Pen p = new Pen(Color.FromArgb(122, 122, 122));
                if (i == 256)
                    i = 254;
                g.DrawLine(p, i, 0, i, 255);
            }
            //
            for (int i=0;i<256;i++)
            {
                Color color = Color.White;
                if (param == 1)
                    color = Color.Red;
                if (param == 2)
                    color = Color.Lime;
                if (param == 3)
                    color = Color.DodgerBlue;

                SolidBrush brush = new SolidBrush(color);
                int y = 255 - output[i];
                if (y >= 254)
                    y = 253;
                g.FillEllipse(brush, (float)i, (float)y, 3, 3);

            }

            if (param == 1)
            {
                pictureBox1.Image = bmp;
                outputR = output;
            }
            if (param == 2)
            {
                pictureBox2.Image = bmp;
                outputG = output;
            }
            if (param == 3)
            {
                outputB = output;
                pictureBox3.Image = bmp;
            }
            //while (t<50)
            //{

            //    int x = (int)((double)(1 - t) * (1 - t) * p1.X + (double)2 * (1 - t) * t * p2.X + (double)t * t * p3.X);
            //    int y = (int)((double)(1 - t) * (1 - t) * p1.Y + (double)2 * (1 - t) * t * p2.Y + (double)t * t * p3.Y);
            //    if(x>255 ||x<0)
            //    {
            //        t = t + 0.5;
            //        continue;
            //    }
            //    output[x] = 255-y;
            //    bool isEmpty = false;
            //    for (int i = 0; i < 256; i++)
            //        if (output[i] == -1)
            //            isEmpty = true;
            //    if (!isEmpty)
            //        isClear = true;

            //    t = t + 0.0025;

            //}

        }





        FormWait frmWait;
        private void wait()
        {
            frmWait.Show(this);
        }
        private void wait(int value)
        {
            frmWait.setValue(value);
        }
        private void unWait()
        {
            frmWait.Hide();
        }
        public MyImage getImage()
        {
            return img;
        }
        //
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

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void FormCurves_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void FormCurves_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            wait();
            Draw(1, btnR1.Location, btnR2.Location, btnR3.Location);
            Draw(2, btnG1.Location, btnG2.Location, btnG3.Location);
            Draw(3, btnB1.Location, btnB2.Location, btnB3.Location);
            var (w, h) = img.getSize();
            for (int i = 0; i < h; ++i)
            {
                double c = 100 / (double)h;
                frmWait.setValue((int)(c * i));
                wait((int)(c * i));
                for (int j = 0; j < w; ++j)
                {

                    

                    var (r, g,b) = img.getPixel(j, i);
                    r = outputR[r];
                    g = outputG[g];
                    b = outputB[b];

                    img.setPixel(j, i, r, g, b);
                }
            }
            unWait();
        }
        bool isDown;
        private void btnR2_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void btnR2_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                Point pt= this.PointToClient(new Point(Control.MousePosition.X - panel1.Location.X - 5, Control.MousePosition.Y - panel1.Location.Y - 5));
                if(pt.X>=-5 && pt.X<=250 && pt.Y<=250 && pt.Y>=-5 && pt.X>=85 && pt.X<=170)
                c.Location = pt;
            }
        }

        private void btnR2_MouseUp(object sender, MouseEventArgs e)
        {
            Draw(1, btnR1.Location, btnR2.Location, btnR3.Location);
            isDown = false;
        }

        private void btnR1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void btnR1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                Point pt = this.PointToClient(new Point(Control.MousePosition.X - panel1.Location.X - 5, Control.MousePosition.Y - panel1.Location.Y - 5));
                if (pt.X >= -5 && pt.X <= 250 && pt.Y <= 250 && pt.Y >= -5 && pt.X < 85)
                    c.Location = pt;
            }
        }

        private void btnR1_MouseUp(object sender, MouseEventArgs e)
        {
            Draw(1, btnR1.Location, btnR2.Location, btnR3.Location);
            isDown = false;
        }

        private void btnR3_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void btnR3_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                Point pt = this.PointToClient(new Point(Control.MousePosition.X - panel1.Location.X - 5, Control.MousePosition.Y - panel1.Location.Y - 5));
                if (pt.X >= -5 && pt.X <= 250 && pt.Y <= 250 && pt.Y >= -5 && pt.X>170)
                    c.Location = pt;
            }
        }

        private void btnR3_MouseUp(object sender, MouseEventArgs e)
        {
            Draw(1, btnR1.Location, btnR2.Location, btnR3.Location);
            isDown = false;
        }

        private void btnG1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void btnG2_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void btnG3_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void btnG1_MouseUp(object sender, MouseEventArgs e)
        {
            Draw(2, btnG1.Location, btnG2.Location, btnG3.Location);
            isDown = false;
        }

        private void btnG2_MouseUp(object sender, MouseEventArgs e)
        {
            Draw(2, btnG1.Location, btnG2.Location, btnG3.Location);
            isDown = false;
        }

        private void btnG3_MouseUp(object sender, MouseEventArgs e)
        {
            Draw(2, btnG1.Location, btnG2.Location, btnG3.Location);
            isDown = false;
        }

        private void btnG3_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                Point pt = this.PointToClient(new Point(Control.MousePosition.X - panel2.Location.X - 5, Control.MousePosition.Y - panel2.Location.Y - 5));
                if (pt.X >= -5 && pt.X <= 250 && pt.Y <= 250 && pt.Y >= -5 && pt.X > 170)
                    c.Location = pt;
            }
        }

        private void btnG2_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                Point pt = this.PointToClient(new Point(Control.MousePosition.X - panel2.Location.X - 5, Control.MousePosition.Y - panel2.Location.Y - 5));
                if (pt.X >= -5 && pt.X <= 250 && pt.Y <= 250 && pt.Y >= -5 && pt.X >= 85 && pt.X <= 170)
                    c.Location = pt;
            }
        }

        private void btnG1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                Point pt = this.PointToClient(new Point(Control.MousePosition.X - panel2.Location.X - 5, Control.MousePosition.Y - panel2.Location.Y - 5));
                if (pt.X >= -5 && pt.X <= 250 && pt.Y <= 250 && pt.Y >= -5 && pt.X <85)
                    c.Location = pt;
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnR1.Location = new Point(-5, 250);
            btnR2.Location = new Point(123, 123);
            btnR3.Location = new Point(250, -5);
            Draw(1, btnR1.Location, btnR2.Location, btnR3.Location);
        }

        private void btnB1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void btnB2_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void btnB3_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void btnB3_MouseUp(object sender, MouseEventArgs e)
        {
            Draw(3, btnB1.Location, btnB2.Location, btnB3.Location);
            isDown = false;
        }

        private void btnB2_MouseUp(object sender, MouseEventArgs e)
        {
            Draw(3, btnB1.Location, btnB2.Location, btnB3.Location);
            isDown = false;
        }

        private void btnB1_MouseUp(object sender, MouseEventArgs e)
        {
            Draw(3, btnB1.Location, btnB2.Location, btnB3.Location);
            isDown = false;
        }

        private void btnB1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                Point pt = this.PointToClient(new Point(Control.MousePosition.X - panel3.Location.X - 5, Control.MousePosition.Y - panel3.Location.Y - 5));
                if (pt.X >= -5 && pt.X <= 250 && pt.Y <= 250 && pt.Y >= -5 && pt.X < 85)
                    c.Location = pt;
            }
        }

        private void btnB2_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                Point pt = this.PointToClient(new Point(Control.MousePosition.X - panel3.Location.X - 5, Control.MousePosition.Y - panel3.Location.Y - 5));
                if (pt.X >= -5 && pt.X <= 250 && pt.Y <= 250 && pt.Y >= -5 && pt.X >= 85 && pt.X<=170)
                    c.Location = pt;
            }
        }

        private void btnB3_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                Point pt = this.PointToClient(new Point(Control.MousePosition.X - panel3.Location.X - 5, Control.MousePosition.Y - panel3.Location.Y - 5));
                if (pt.X >= -5 && pt.X <= 250 && pt.Y <= 250 && pt.Y >= -5 && pt.X >170)
                    c.Location = pt;
            }
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnG1.Location = new Point(-5, 250);
            btnG2.Location = new Point(123, 123);
            btnG3.Location = new Point(250, -5);
            Draw(2, btnG1.Location, btnG2.Location, btnG3.Location);
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnB1.Location = new Point(-5, 250);
            btnB2.Location = new Point(123, 123);
            btnB3.Location = new Point(250, -5);
            Draw(3, btnB1.Location, btnB2.Location, btnB3.Location);
        }
    }
}
