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

namespace Krasivator
{
    public partial class Form1 : Form
    {
        int imageW, imageH;
        FormWait frmWait;
        List<MyImage> images;
        public Form1()
        {
            InitializeComponent();
            setInactiveRight();
            setDefaultColors();

            images = new List<MyImage>();
            openFile();

            frmWait = new FormWait();
            
        }
        void saveImage(MyImage image)
        {
            images.Add(image);
            if(images.Count>8)
            {
                images.RemoveAt(0);
            }
            pictureBox1.Image = image.bmp;
        }
        void controlZ()
        {
            if(images.Count>1)
            {

                images.RemoveAt(images.Count-1);
                pictureBox1.Image = images.ElementAt(images.Count - 1).bmp;
                
                //images.RemoveAt(0);
            }
        }
        void openFile()
        {
            formCreate f = new formCreate();
            f.ShowDialog();
            if (f.dir != "")
                renderImage(f.dir);
            if (f.w != 0 || f.h != 0)
                renderImage(f.w,f.h);
        }
        MyImage img,img_out, secondImage;
        void renderImage(string dir)
        {
            images.Clear();
            img = new MyImage(dir);
            var (w, h) = img.getSize();
            imageW = w;
            imageH = h;
            //pictureBox1.Image = img.bmp;

            panel1.Size = new Size(w, h);
            saveImage(img);
        }
        Bitmap whiteImage;
        void renderImage(int w,int h)
        {
            images.Clear();
            img = new MyImage(w, h);
            imageW = w;
            imageH = h;

            for (int i = 0; i < h; ++i)
            {
                for (int j = 0; j < w; ++j)
                {
                    img.setPixel(j, i, 255, 255, 255);
                }
            }
            panel1.Size = new Size(w, h);
            saveImage(img);

        }
        Color color;
        void setConfirmVisible()
        {
            setInactiveRight();

            setInactiveLeft();
            panelRightConfirm.Visible = true;

            boxOverlay.SelectedIndex = 0;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Visible = true;
            this.BackColor = Color.FromArgb(255, 44, 52, 63);
            panelLeft.BackColor = Color.FromArgb(255, 52, 63, 73);
            panelRight.BackColor = Color.FromArgb(255, 52, 63, 73);
            FileToolStripMenuItem.Enabled = false;
            EditToolStripMenuItem.Enabled = false;
            pictureBox2.Cursor = Cursors.SizeAll;
            if (lastOperation=="draw")
            {
                pictureBox2.Cursor = Cursors.Default;
                panel3.Visible = true;
                colorDialog1.AnyColor = true;
                colorDialog1.FullOpen = true;
                colorDialog1.Color = color;
                btnColor.BackColor = color;

            }
        }
        void renderSecondImage(string dir)
        {
            setConfirmVisible();
            panel2.Visible = true;
            boxOverlay.SelectedIndex = 0;
            secondImage = new MyImage(dir);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Visible = true;
            barOpacity.Value = 100;
            labelOpacity.Text = "100%";
            this.BackColor = Color.FromArgb(255, 44, 52, 63);
            panelLeft.BackColor = Color.FromArgb(255, 52, 63, 73);
            panelRight.BackColor = Color.FromArgb(255, 52, 63, 73);
            FileToolStripMenuItem.Enabled = false;
            EditToolStripMenuItem.Enabled = false;
            pictureBox2.Image = secondImage.bmp;
        }
        void setDefaultColors()
        {
            
            menuStrip1.BackColor = Color.FromArgb(255,36, 47, 61);
            Color colorText = Color.FromArgb(255, 87, 102, 115);
            EditToolStripMenuItem.ForeColor = Color.White;
            FileToolStripMenuItem.ForeColor = Color.White;
            создатьToolStripMenuItem.BackColor = Color.FromArgb(255, 36, 47, 61);
            открытьToolStripMenuItem.BackColor = Color.FromArgb(255, 36, 47, 61);
            saveToolStripMenuItem.BackColor = Color.FromArgb(255, 36, 47, 61);
            saveagainToolStripMenuItem.BackColor = Color.FromArgb(255, 36, 47, 61);
            выйтиToolStripMenuItem.BackColor = Color.FromArgb(255, 36, 47, 61);
            создатьToolStripMenuItem.ForeColor = Color.White;
            открытьToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.ForeColor = Color.White;
            выйтиToolStripMenuItem.ForeColor = Color.White;
            saveagainToolStripMenuItem.ForeColor = Color.White;
            xToolStripMenuItem.ForeColor = colorText;
            this.BackColor = Color.FromArgb(255, 14, 22, 33);
            panelLeft.BackColor = Color.FromArgb(255, 22, 33, 43);
            panelRight.BackColor = Color.FromArgb(255, 22, 33, 43);
            btnLeftInst.BackColor = Color.FromArgb(255, 42, 83, 120);
            btnLeftEff.BackColor = Color.FromArgb(255, 42, 83, 120);
            btnConfirm.BackColor = Color.FromArgb(255, 42, 83, 120);
            btnRightInst1.BackColor = Color.FromArgb(255, 42, 83, 120);
            btnRightInst2.BackColor = Color.FromArgb(255, 42, 83, 120);
            panelRightInst.BackColor = Color.FromArgb(255, 32, 43, 54);
            panelRightConfirm.BackColor = Color.FromArgb(255, 32, 43, 54);
            panelRightEffects.BackColor = Color.FromArgb(255, 32, 43, 54);
            btnLeftEff.ForeColor = Color.White;
            btnLeftInst.ForeColor = Color.White;
            btnContrast.BackColor = Color.FromArgb(255, 42, 83, 120);
            btnBright.BackColor = Color.FromArgb(255, 42, 83, 120);
            btnNoise.BackColor = Color.FromArgb(255, 42, 83, 120);
            btnLeftInst.FlatAppearance.BorderColor = Color.FromArgb(255, 108, 120, 131);
            btnLeftEff.FlatAppearance.BorderColor = Color.FromArgb(255, 108, 120, 131);
            boxOverlay.BackColor = Color.FromArgb(255, 32, 43, 54);
            boxBrushSize.BackColor = Color.FromArgb(255, 32, 43, 54);
            //
            color = Color.Black;
            //
            boxOverlay.Items.Add("Нормальный");
            
            boxOverlay.Items.Add("Вычитание");
            
            boxOverlay.Items.Add("Яркость");
            boxOverlay.Items.Add("Сложение");
            boxOverlay.Items.Add("Затемнение");
            boxOverlay.Items.Add("Светлее");
            boxOverlay.Items.Add("Умножение");
            boxOverlay.Items.Add("Темнее");
            //
            panel2.Visible = false;
            btnLeftInst.Enabled = false;
            panelRightInst.Visible = true;
            saveagainToolStripMenuItem.Enabled = false;
            panelRightEffects.Visible = false;
            //
            ToolTip t = new ToolTip();
            t.SetToolTip(btnRightInst1, "Перемещение");
            t.SetToolTip(btnRightInst2, "Кисть");

        }
        void setInactiveRight()
        {
            panelRightInst.Visible = false;
            panelRightConfirm.Visible = false;
        }
        void setInactiveLeft()
        {
            btnLeftEff.Enabled = false;
            btnLeftInst.Enabled = false;
        }
        void setActiveLeft()
        {
            btnLeftEff.Enabled = true;
            btnLeftInst.Enabled = true;
        }
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Point mouseOffset;
        private bool isMouseDown = false;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y -SystemInformation.FrameBorderSize.Height;
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFile();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool isConfirm = false;
        bool isDown = false;
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            if (isPainting)
                isDown = true;
            if (e.Button == MouseButtons.Left && isConfirm)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPainting && isDown)
            {
                SolidBrush brush = new SolidBrush(color);
                Point mousePos = Control.MousePosition;
                mousePos.Offset(0 - this.Location.X - panel1.Location.X - (int)(boxBrushSize.Value/2), 0 - this.Location.Y - panel1.Location.Y- (int)(boxBrushSize.Value / 2));
                g.FillEllipse(brush, mousePos.X, mousePos.Y, (float)boxBrushSize.Value, (float)boxBrushSize.Value);
                pictureBox2.Refresh();
            }
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X - this.Location.X - panel1.Location.X, mouseOffset.Y - this.Location.Y- panel1.Location.Y);
                pictureBox2.Location = mousePos;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        string lastOperation = "";
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            isConfirm = false;
            isPainting = false;
            setInactiveRight();
            setActiveLeft();
            btnLeftInst.Enabled = false;
            panelRightInst.Visible = true;
            this.BackColor = Color.FromArgb(255, 14, 22, 33);
            panelLeft.BackColor = Color.FromArgb(255, 22, 33, 43);
            panelRight.BackColor = Color.FromArgb(255, 22, 33, 43);
            panel2.Visible = false;
            panel3.Visible = false;
            barOpacity.Value = 100;
            FileToolStripMenuItem.Enabled = true;
            EditToolStripMenuItem.Enabled = true;
            switch(lastOperation)
            {
                case "open":

                    drawPictureBox();
                    break;
                case "move":
                    drawPictureBox();
                    break;
                case "draw":
                    drawPictureBox();
                    break;

            }
        }
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
        private void drawPictureBox()
        {
            
            wait();
            var (w, h) = secondImage.getSize();
            //MyImage newImage = images.Last();
            MyImage newImage = new MyImage(images.Last().bmp.Width, images.Last().bmp.Height);
            newImage.bmp = (Bitmap)images.Last().bmp.Clone();
            if (lastOperation == "move")
            {
                newImage.bmp = (Bitmap)whiteImage.Clone();
            }
            //pictureBox3.Image = images.Last().bmp;
            for (int i = 0; i < h; ++i)
            {
                double c = 100/(double)h;
                frmWait.setValue((int)(c * i));
                wait((int)(c * i));
                for (int j = 0; j < w; ++j)
                {
                    
                    var (r, g, b) = secondImage.getPixel(j, i);
                    int _j = j + pictureBox2.Location.X;
                    int _i = i + pictureBox2.Location.Y;
                    if(_j>=0 && _i>=0 && _j<imageW && _i<imageH)
                    {
                        
                        var (_r, _g, _b) = newImage.getPixel(_j, _i);
                        r = overlay(_r, r);
                        g = overlay(_g, g);
                        b = overlay(_b, b);
                        int newR, newG, newB;
                        newR = Convert.ToInt32(((double)(r - _r) / 100) * barOpacity.Value + _r);
                        newG = Convert.ToInt32(((double)(g - _g) / 100) * barOpacity.Value + _g);
                        newB = Convert.ToInt32(((double)(b - _b) / 100) * barOpacity.Value + _b);

                        newImage.setPixel(_j, _i, newR, newG, newB);
                    }
                }
            }
            unWait();
            //pictureBox1.Image = img.bmp;
            saveImage(newImage);
            pictureBox2.Visible = false;
        }
        private int overlay(int first,int second)
        {
            int c=0;
            if(boxOverlay.Items[boxOverlay.SelectedIndex].ToString() == "Нормальный")
            {
                return second;
            }
            if (boxOverlay.Items[boxOverlay.SelectedIndex].ToString() == "Сложение")
            {
                c = first + second;
                if (c > 255)
                    c = 255;
                return c;
            }
            if (boxOverlay.Items[boxOverlay.SelectedIndex].ToString() == "Вычитание")
            {
                c = second - first;
                if (c < 0)
                    c = 0;
                return c;
            }
            if (boxOverlay.Items[boxOverlay.SelectedIndex].ToString() == "Умножение")
            {
                c = first * second;
                if (c > 255)
                    c = 255;
                return c;
            }
            if (boxOverlay.Items[boxOverlay.SelectedIndex].ToString() == "Яркость")
            {
                if (first >= second)
                    return first;
                else return second;
                
                if (c > 255)
                    c = 255;
                if (c < 0)
                    c = 0;
                return c;
            }
            if (boxOverlay.Items[boxOverlay.SelectedIndex].ToString() == "Затемнение")
            {
                if (first <= second)
                    return first;
                else return second;
                if (c > 255)
                    c = 255;
                if (c < 0)
                    c = 0;
                return c;
            }
            if (boxOverlay.Items[boxOverlay.SelectedIndex].ToString() == "Светлее")
            {
                if (second <= (255 / 2))
                {
                    return second;
                }
                else return first;
            }
            if (boxOverlay.Items[boxOverlay.SelectedIndex].ToString() == "Темнее")
            {
                if (second <= (255 / 2))
                {
                    return second;
                }
                else return first;
            }
            return second;
        }
        private void btnLeftEff_Click(object sender, EventArgs e)
        {
            setInactiveRight();
            setActiveLeft();
            btnLeftEff.Enabled = false;
            panelRightEffects.Visible = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        string saveDir = "";
        int dirIndex;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ($"{ e.KeyCode}" == "Z" && $"{e.Modifiers}" == "Control")
            {
                controlZ();
            }
            if ($"{ e.KeyCode}" == "S" && $"{e.Modifiers}" == "Control")
            {
                if(saveDir!="")
                {
                    switch (dirIndex)
                    {
                        case 1:
                            images.Last().bmp.Save(saveDir,
                              System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            images.Last().bmp.Save(saveDir,
                              System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            images.Last().bmp.Save(saveDir,
                              System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }
                }
            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                saveagainToolStripMenuItem.Enabled = true;
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                saveDir = saveFileDialog1.FileName;

                dirIndex = saveFileDialog1.FilterIndex;
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        images.Last().bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        images.Last().bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        images.Last().bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void barOpacity_Scroll(object sender, EventArgs e)
        {
            labelOpacity.Text = barOpacity.Value.ToString() + "%";
        }
        void setWhitePicture()
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            
            for (int i = 0; i < imageH; ++i)
            {
                for (int j = 0; j < imageW; ++j)
                {
                    b.SetPixel(j, i, Color.White);

                }
            }
            pictureBox1.Image = (Bitmap)b.Clone();
            whiteImage = new Bitmap(b);

            b.Dispose();
        }
        private void btnRightInst1_Click(object sender, EventArgs e)
        {
            lastOperation = "move";

            isConfirm = true;
            secondImage = new MyImage(imageW, imageH);
            secondImage.bmp = (Bitmap)pictureBox1.Image.Clone();
            pictureBox2.Image = secondImage.bmp;
            setWhitePicture();
            setConfirmVisible();
        }
        bool isPainting = false;
        Graphics g;
        private void btnRightInst2_Click(object sender, EventArgs e)
        {
            lastOperation = "draw";
            secondImage = new MyImage(imageW, imageH);
            secondImage.bmp = (Bitmap)pictureBox1.Image.Clone();
            pictureBox2.Image = secondImage.bmp;
            pictureBox2.Location = new Point(0, 0);
            isPainting = true;
            g = Graphics.FromImage(pictureBox2.Image);

            setConfirmVisible();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            color = colorDialog1.Color;
            btnColor.BackColor = color;            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Pen p = new Pen(color,)
            if (isPainting)
            {

               
                
                    SolidBrush brush = new SolidBrush(color);
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset( 0- this.Location.X - panel1.Location.X- (int)(boxBrushSize.Value / 2), 0- this.Location.Y - panel1.Location.Y- (int)(boxBrushSize.Value / 2));
                    g.FillEllipse(brush, mousePos.X, mousePos.Y, (float)boxBrushSize.Value, (float)boxBrushSize.Value);
                pictureBox2.Refresh();
                
            }
        }

        private void saveagainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveDir != "")
            {
                switch (dirIndex)
                {
                    case 1:
                        images.Last().bmp.Save(saveDir,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        images.Last().bmp.Save(saveDir,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        images.Last().bmp.Save(saveDir,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
            }
        }

        private void btnBright_Click(object sender, EventArgs e)
        {
            this.Opacity = .75;
            FormBar frm = new FormBar("Яркость");
            frm.ShowDialog();
            this.Opacity = 1;
            if(frm.DialogResult==DialogResult.OK)
            {
                
                MyImage myImage = new MyImage(imageW, imageH);
                myImage.bmp = (Bitmap)pictureBox1.Image.Clone();
                wait();
                for (int i = 0; i < imageH; ++i)
                {
                    double c = 100 / (double)imageH;
                    frmWait.setValue((int)(c * i));
                    wait((int)(c * i));
                    for (int j = 0; j < imageW; ++j)
                    {
                        var (r, g, b) = myImage.getPixel(j, i);
                        r = r + (int)(255.0 / 100) * frm.GetValue();
                        g = g + (int)(255.0 / 100) * frm.GetValue();
                        b = b + (int)(255.0 / 100) * frm.GetValue();
                        if (r > 255) r = 255;
                        if (r < 0) r = 0;
                        if (g > 255) g = 255;
                        if (g < 0) g = 0;
                        if (b > 255) b = 255;
                        if (b < 0) b = 0;

                        myImage.setPixel(j, i, r, g, b);
                    }
                }
                saveImage(myImage);
                unWait();

            }
        }

        private void btnContrast_Click(object sender, EventArgs e)
        {
            this.Opacity = .75;
            FormBar frm = new FormBar("Контраст");
            frm.ShowDialog();
            this.Opacity = 1;
            if (frm.DialogResult == DialogResult.OK)
            {
                MyImage myImage = new MyImage(imageW, imageH);
                myImage.bmp = (Bitmap)pictureBox1.Image.Clone();
                wait();

                int l = 0;
                for (int i = 0; i < imageH; ++i)
                {
                    for (int j = 0; j < imageW; ++j)
                    {
                        var (r, g, b) = myImage.getPixel(j, i);
                        l += (int)(r * 0.299 + g * 0.587 + b * 0.114);

                    }
                }
                l /= imageH * imageW;
                l /= 3;
                for (int i = 0; i < imageH; ++i)
                {
                    double c = 100 / (double)imageH;
                    frmWait.setValue((int)(c * i));
                    wait((int)(c * i));
                    for (int j = 0; j < imageW; ++j)
                    {
                        var (r, g, b) = myImage.getPixel(j, i);
                        r = frm.GetValue() * (r - l) + l;
                        g = frm.GetValue() * (g - l) + l;
                        b = frm.GetValue() * (b - l) + l;
                        if (r > 255) r = 255;
                        if (r < 0) r = 0;
                        if (g > 255) g = 255;
                        if (g < 0) g = 0;
                        if (b > 255) b = 255;
                        if (b < 0) b = 0;

                        myImage.setPixel(j, i, r, g, b);
                    }
                }
                saveImage(myImage);
                unWait();
            }
        }

        private void btnNoise_Click(object sender, EventArgs e)
        {
            this.Opacity = .75;
            FormBar frm = new FormBar("Количество шумов");
            frm.ShowDialog();
            this.Opacity = 1;
            Random rnd = new Random();
            if (frm.DialogResult == DialogResult.OK)
            {

                MyImage myImage = new MyImage(imageW, imageH);
                myImage.bmp = (Bitmap)pictureBox1.Image.Clone();
                wait();
                for (int i = 0; i < imageH; ++i)
                {
                    double c = 100 / (double)imageH;
                    frmWait.setValue((int)(c * i));
                    wait((int)(c * i));
                    for (int j = 0; j < imageW; ++j)
                    {
                        var (r, g, b) = myImage.getPixel(j, i);
                        
                        int q = rnd.Next(100);
                        if (q <= frm.GetValue())
                        {
                            r *= rnd.Next(7) % 255;
                            g *= rnd.Next(7) % 255;
                            b *= rnd.Next(7) % 255;
                        }
                        if (r > 255) r = 255;
                        if (r < 0) r = 0;
                        if (g > 255) g = 255;
                        if (g < 0) g = 0;
                        if (b > 255) b = 255;
                        if (b < 0) b = 0;

                        myImage.setPixel(j, i, r, g, b);
                    }
                }
                saveImage(myImage);
                unWait();

            }
        }

        private void btnLeftInst_Click(object sender, EventArgs e)
        {
            setInactiveRight();
            panelRightInst.Visible = true;
            setActiveLeft();
            panelRightEffects.Visible = false;
            btnLeftInst.Enabled = false;
            //btnLeftInst.Enabled = true;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Картинки|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string dir = dialog.FileName;
                    lastOperation = "open";
                    setInactiveRight();
                    isConfirm = true;
                    setInactiveLeft();
                    panelRightEffects.Visible = false;
                    panelRightConfirm.Visible = true;
                    renderSecondImage(dir);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}
