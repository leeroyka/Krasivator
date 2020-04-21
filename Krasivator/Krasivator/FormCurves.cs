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
        int[] gistogrammaR;
        int[] gistogrammaG;
        int[] gistogrammaB;
        int[] outputR;
        int[] outputG;
        int[] outputB;
        int[] output;
        MyImage img,circle,binImg;

        int maxR = 0, maxG = 0, maxB = 0;
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
            button2.BackColor = Color.FromArgb(255, 39, 105, 153);
            button3.BackColor = Color.FromArgb(255, 39, 105, 153);
            img = image;
            circle = new MyImage(201, 201);
            var (w, h) = img.getSize();
            binImg = new MyImage(w, h);
            maxR = 0;
            maxG = 0;
            maxB = 0;
            gistogrammaR = new int[256];
            gistogrammaG = new int[256];
            gistogrammaB = new int[256];

            countingGistogramm();
            Draw(1, btnR1.Location, btnR2.Location, btnR3.Location);
            Draw(2, btnG1.Location, btnG2.Location, btnG3.Location);
            Draw(3, btnB1.Location, btnB2.Location, btnB3.Location);
            frmWait = new FormWait();
            this.Size = new Size(827, 374);
        }
        void countingGistogramm()
        {

            var (w, h) = img.getSize();
            for (int i = 0; i < h; ++i)
            {
                for (int j = 0; j < w; ++j)
                {

                    var (r, g, b) = img.getPixel(j, i);
                    gistogrammaR[r]++;
                    gistogrammaG[g]++;
                    gistogrammaB[b]++;

                }
            }
            for(int i=0;i<256;i++)
            {
                if (gistogrammaR[i] >= maxR)
                    maxR = gistogrammaR[i];

                if (gistogrammaG[i] >= maxG)
                    maxG = gistogrammaG[i];

                if (gistogrammaB[i] >= maxB)
                    maxB = gistogrammaB[i];

            }
        }
        void drawGistrogram()
        {
            
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

            Pen p = new Pen(Color.FromArgb(200, 200, 200));
            p.Width = 2;
            for (int i = 0; i < 256; i = i + 2)
            {
                int parY = 0;
                if (param == 1)
                    parY = (int)(255.0 / (double)maxR * (double)gistogrammaR[i]);
                if (param == 2)
                    parY = (int)(255.0 / (double)maxG * (double)gistogrammaG[i]);
                if (param == 3)
                    parY = (int)(255.0 / (double)maxB * (double)gistogrammaB[i]);
                if (parY < 256)
                    g.DrawLine(p, i, 255, i, 255 - parY);
            }
            p.Width = 1;
            p = new Pen(Color.FromArgb(52, 52, 52));
            //Grid
            for (int i = 0; i < 256; i = i + (256 / 16))
            {
               
                if (i == 256)
                    i = 254;
                g.DrawLine(p, i, 0, i, 255);
            }
            for (int i = 0; i < 256; i = i + (256 / 16))
            {
                if (i == 256)
                    i = 254;
                g.DrawLine(p, 0, i, 255, i);
            }
            p = new Pen(Color.FromArgb(122, 122, 122));
            for (int i = 0; i <= 256; i = i + (256 / 4))
            {
                 
                if (i == 256)
                    i = 254;
                g.DrawLine(p, 0,i, 255, i);
            }
            for (int i = 0; i <= 256; i = i + (256 / 4))
            {
                
                if (i == 256)
                    i = 254;
                g.DrawLine(p, i, 0, i, 255);
            }

            //

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
        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }
        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);
            if (value < 0) value = 0;
            if (value > 1) value = 1;
            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
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
        bool[,] matrix;
        private void button1_Click(object sender, EventArgs e)
        {

            wait();
            Draw(1, btnR1.Location, btnR2.Location, btnR3.Location);
            Draw(2, btnG1.Location, btnG2.Location, btnG3.Location);
            Draw(3, btnB1.Location, btnB2.Location, btnB3.Location);
            var (w, h) = img.getSize();

            int d = 2;

            
            for (int i = 0; i < h; ++i)
            {
                double c = 100 / (double)h;
                wait((int)(c * i));
                for (int j = 0; j < w; ++j)
                {

                    

                    var (r, g,b) = img.getPixel(j, i);
                    if (isArea)
                    {
                        if(matrix[j,i])
                        {

                            r = outputR[r];
                            g = outputG[g];
                            b = outputB[b];
                        }
                    }
                    else
                    {
                        r = outputR[r];
                        g = outputG[g];
                        b = outputB[b];
                    }
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
        bool isArea=false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!isArea)
            {
                button2.Text = "Не выбирать";
                isArea = true;
                this.Size = new Size(1326, 374);
                DrawHSV();
            }
            else
            {
                isArea = false;
                button2.Text = "Выбрать область преобразований";
                this.Size = new Size(827, 374);
            }
        }
        double getValue()
        {
            return trackBar1.Value / 100.0;
        }
        bool[,,] matrixColor;
        double ihue, isat, ival;
        void DrawHSV(bool isPipett=false)
        {
            double v = getValue();
            int r1, r2, d1, d2;
            r1 = tR1.Value;
            r2 = tR2.Value;
            d1 = tD1.Value;
            d2 = tD2.Value;
            wait();
            if(isPipett)
            {
                int delta = r2 - r1;
                r1 = Convert.ToInt32(isat*100.0) - (delta / 2);
                r2 = Convert.ToInt32(isat * 100.0) + (delta / 2);
                if (r1 < 0) r1 = 0;
                if (r2 > 100) r2 = 100;
                tR1.Value = r1;
                tR2.Value = r2;
                delta = d2 - d1;
                d1 = Convert.ToInt32(ihue) - (delta / 2);
                d2 = Convert.ToInt32(ihue) + (delta / 2);
                if (d1 < 0) d1 = 0;
                if (d2 > 360) d2 = 360;
                tD1.Value = d1;
                tD2.Value = d2;
            }
            matrixColor = new bool[256, 256, 256];
            double deltaV = 0.15;
            for(int s=100;s>=0;s--)
            {
                for(double hue=0;hue<360;hue=hue+25.0/(s+0.1))
                {
                    if (hue >= 360)
                        break;
                    double angle = Math.PI * hue / 180.0;
                    int x = (int)(Math.Sin(angle) * (double)s)+100;
                    int y = (int)(Math.Cos(angle) * (double)s)+100;
                    Color p;
                    if (s >= r1 && s <= r2 && hue >= d1 && hue <= d2)
                    {

                        p = ColorFromHSV(hue, s / 100.0, v);
                        matrixColor[p.R, p.G, p.B] = true;
                        for (double i=v-deltaV;i<=v+deltaV;i=i+0.01)
                        {
                            Color r =ColorFromHSV(hue, s / 100.0, i);
                            matrixColor[r.R, r.G, r.B] = true;
                        }
                    }
                    else
                        p = ColorFromHSV(hue, s / 100.0, v - 0.8);
                    circle.setPixel(x, y, p.R, p.G, p.B);

                    

                }
            }

            picCircle.Image = circle.bmp;

            var (w, h) = img.getSize();

            int d = 2;
            d = trackBar2.Value;
            int radius = trackBar3.Value;
            int pct = trackBar4.Value;


            matrix = new bool[w, h];

            binImg = new MyImage(w, h);
            for (int i = 0; i < h; ++i)
            {

                double c = 100 / (double)h;
                wait((int)(c * i));
                for (int j = 0; j < w; ++j)
                {
                    var (_r, _g, _b) = img.getPixel(j, i);
                    for (int r = _r - d; r <= _r + d; r++)
                    {
                        for (int g = _g - d; g <= _g + d; g++)
                        {
                            for (int b = _b - d; b <= _b + d; b++)
                            {
                                if (r > 255 || g > 255 || b > 255 || r < 0 || g < 0 || b < 0)
                                    continue;
                                if (matrixColor[r, g, b])
                                {
                                    //matrix[j, i] = true;
                                    //binImg.setPixel(j, i, 255, 255, 255);
                                    int count = 0;
                                    for(int _i=i-radius;_i<=i+radius;_i++)
                                    {
                                        for(int _j=j-radius;_j<=j+radius;_j++)
                                        {
                                            var (__r, __g,__b) = img.getPixel(_j, _i);
                                            if(__r==r && __g ==g && __b ==b)
                                            {
                                                count++;
                                            }
                                        }
                                    }
                                    int area = (radius * 2 + 1) * (radius * 2 + 1);
                                    double precent = 100.0 / (double)area*(double)count;
                                    if(precent>=(double)pct)
                                    {

                                        matrix[j, i] = true;
                                        binImg.setPixel(j, i, 255, 255, 255);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            pictureBox4.Image = binImg.bmp;
            unWait();

        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
              DrawHSV();
        }

        private void tR1_ValueChanged(object sender, EventArgs e)
        {
            if(tR1.Value>=tR2.Value)
            {
                tR1.Value = tR2.Value - 1;
            }
            label9.Text = tR1.Value.ToString();
        }

        private void tR2_ValueChanged(object sender, EventArgs e)
        {
            if (tR1.Value >= tR2.Value)
            {
                tR2.Value = tR2.Value + 1;
            }
            label10.Text = tR2.Value.ToString();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label14.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            label16.Text = trackBar3.Value.ToString();
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            label18.Text = trackBar4.Value.ToString()+"%";
        }

        private void tD1_ValueChanged(object sender, EventArgs e)
        {
            if (tD1.Value >= tD2.Value)
            {
                tD1.Value = tD2.Value - 1;
            }
            label11.Text = tD1.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPipett frm = new FormPipett(img);
            frm.ShowDialog();
            if(frm.DialogResult!=DialogResult.OK)
            {
                var (r, g, b) = frm.getPixel();
                Color p = Color.FromArgb(r, g, b);
                double hue=0, s=0, v=0;
                ColorToHSV(p, out hue, out s, out v);
                trackBar1.Value = Convert.ToInt32(v * 100.0);
                ihue = hue;
                isat = s;
                ival = v;
                DrawHSV(true);

            }
        }

        private void tD2_ValueChanged(object sender, EventArgs e)
        {
            if (tD1.Value >= tD2.Value)
            {
                tD2.Value = tD2.Value + 1;
            }
            label12.Text = tD2.Value.ToString();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();

        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnB1.Location = new Point(-5, 250);
            btnB2.Location = new Point(123, 123);
            btnB3.Location = new Point(250, -5);
            Draw(3, btnB1.Location, btnB2.Location, btnB3.Location);
        }

        private void FormCurves_Load(object sender, EventArgs e)
        {

        }
    }
}
