﻿using System;
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
            img = new MyImage(dir);
            var (w, h) = img.getSize();
            imageW = w;
            imageH = h;
            //pictureBox1.Image = img.bmp;
            saveImage(img);
        }
        void renderImage(int w,int h)
        {
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
            saveImage(img);

        }
        void renderSecondImage(string dir)
        {
            secondImage = new MyImage(dir);
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Visible = true;
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
            выйтиToolStripMenuItem.BackColor = Color.FromArgb(255, 36, 47, 61);
            создатьToolStripMenuItem.ForeColor = Color.White;
            открытьToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.ForeColor = Color.White;
            выйтиToolStripMenuItem.ForeColor = Color.White;
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
            btnLeftEff.ForeColor = Color.White;
            btnLeftInst.ForeColor = Color.White;
            btnLeftInst.FlatAppearance.BorderColor = Color.FromArgb(255, 108, 120, 131);
            btnLeftEff.FlatAppearance.BorderColor = Color.FromArgb(255, 108, 120, 131);

            btnLeftInst.Enabled = false;
            panelRightInst.Visible = true;
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
            images.Clear();
            openFile();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool isConfirm = false;
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

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
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X - this.Location.X - panel1.Location.X, mouseOffset.Y - this.Location.Y- panel1.Location.Y);
                pictureBox2.Location = mousePos;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            isConfirm = false;
            setInactiveRight();
            setActiveLeft();
            btnLeftInst.Enabled = false;
            panelRightInst.Visible = true;
            this.BackColor = Color.FromArgb(255, 14, 22, 33);
            panelLeft.BackColor = Color.FromArgb(255, 22, 33, 43);
            panelRight.BackColor = Color.FromArgb(255, 22, 33, 43);
            FileToolStripMenuItem.Enabled = true;
            EditToolStripMenuItem.Enabled = true;
            drawPictureBox();
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
                        newImage.setPixel(_j, _i, r, g, b);
                    }
                }
            }
            unWait();
            //pictureBox1.Image = img.bmp;
            saveImage(newImage);
            pictureBox2.Visible = false;
        }
        private void btnLeftEff_Click(object sender, EventArgs e)
        {
            setInactiveRight();
            setActiveLeft();
            btnLeftEff.Enabled = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ($"{ e.KeyCode}" == "Z" && $"{e.Modifiers}" == "Control")
            {
                controlZ();
                debug.Text = "LOL";
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
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
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

        private void btnLeftInst_Click(object sender, EventArgs e)
        {
            setInactiveRight();
            panelRightInst.Visible = true;
            setActiveLeft();

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
                    setInactiveRight();
                    isConfirm = true;
                    setInactiveLeft();
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
