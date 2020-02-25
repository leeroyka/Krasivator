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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setDefaultColors();
        }
        void setDefaultColors()
        {
            menuStrip1.BackColor = Color.FromArgb(255,36, 47, 61);
            Color colorText = Color.FromArgb(255, 87, 102, 115);
            EditToolStripMenuItem.ForeColor = Color.White;
            FileToolStripMenuItem.ForeColor = Color.White;
            xToolStripMenuItem.ForeColor = colorText;
            this.BackColor = Color.FromArgb(255, 14, 22, 33);
            panelLeft.BackColor = Color.FromArgb(255, 22, 33, 43);
            btnLeftInst.BackColor = Color.FromArgb(255, 42, 83, 120);
            btnLeftEff.BackColor = Color.FromArgb(255, 42, 83, 120);
            btnLeftEff.ForeColor = Color.White;
            btnLeftInst.ForeColor = Color.White;
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

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}
