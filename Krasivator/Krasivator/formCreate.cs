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
    public partial class formCreate : Form
    {
        public formCreate()
        {
            InitializeComponent();
        }
        private void formCreate_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.FromArgb(255, 36, 47, 61);
            Color colorText = Color.FromArgb(255, 87, 102, 115);
            xToolStripMenuItem.ForeColor = colorText;
            this.BackColor = Color.FromArgb(255, 14, 22, 33);
            textBox1.BackColor = Color.FromArgb(255, 23, 33, 43);
            textBox2.BackColor = Color.FromArgb(255, 23, 33, 43);
            button1.BackColor = Color.FromArgb(255, 39, 105, 153);
            button2.BackColor = Color.FromArgb(255, 39, 105, 153);
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

        private void formCreate_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void formCreate_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
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
        public string dir = "";
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Картинки|*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dir = dialog.FileName;
                    this.Close();
                }
            }
        }
        public int w = 0, h = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            w = Convert.ToInt32(textBox1.Text);
            h = Convert.ToInt32(textBox2.Text);
            this.Close();
        }
    }
}
