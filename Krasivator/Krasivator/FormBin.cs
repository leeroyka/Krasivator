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
    public partial class FormBin : Form
    {

        MyImage img;
        public FormBin(MyImage image)
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.FromArgb(255, 36, 47, 61);
            this.BackColor = Color.FromArgb(255, 23, 33, 43);
            textBox1.BackColor = Color.FromArgb(255, 23, 33, 43);
            textBox2.BackColor = Color.FromArgb(255, 23, 33, 43);
            xToolStripMenuItem.ForeColor = Color.FromArgb(255, 87, 102, 115);
            img = image;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";

            if (textBox2.Text == "")
                textBox2.Text = "0";
            int param1 = Convert.ToInt32(textBox1.Text);
            double param2 = Convert.ToDouble(textBox2.Text);
            if(radioButton1.Checked)
                Binarization.MethodGavr(img);

            if (radioButton2.Checked)
                Binarization.MethodOtsu(img);
            this.Close();
        }
        public MyImage getImage()
        {
            return img;
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

        private void FormBin_MouseMove(object sender, MouseEventArgs e)
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

        private void FormBin_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Text = "15";

            label2.Text = "Чувствительность:";
            textBox2.Text = "-0.2";
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Text = "15";
            label2.Text = "t: ";
            textBox2.Text = "0.15";
        }
    }
}
