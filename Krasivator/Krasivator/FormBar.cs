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
    public partial class FormBar : Form
    {
        public FormBar(string n)
        {
            InitializeComponent();

            labelName.Text = n;
            menuStrip1.BackColor = Color.FromArgb(255, 36, 47, 61);
            Color colorText = Color.FromArgb(255, 87, 102, 115);
            xToolStripMenuItem.ForeColor = colorText;
            this.BackColor = Color.FromArgb(255, 23, 33, 43);
            trackBar1.BackColor = Color.FromArgb(255, 23, 33, 43);
            labelValue.Text = trackBar1.Value.ToString();
            button1.BackColor = Color.FromArgb(255, 39, 105, 153);
            if(n=="Количество шумов")
            {
                trackBar1.Minimum = 0;
            }
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

        private void FormBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void FormBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            labelValue.Text = trackBar1.Value.ToString();
        }
        public int GetValue()
        {
            return trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
