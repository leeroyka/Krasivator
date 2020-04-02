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
    public partial class FormMatrix : Form
    {
        MyImage img;
        public FormMatrix(MyImage image)
        {
            InitializeComponent();
            menuStrip1.BackColor = Color.FromArgb(255, 36, 47, 61);
            this.BackColor = Color.FromArgb(255, 23, 33, 43);
            textBox1.BackColor = Color.FromArgb(255, 23, 33, 43);
            textBox2.BackColor = Color.FromArgb(255, 23, 33, 43);
            textBox3.BackColor = Color.FromArgb(255, 23, 33, 43);
            button1.BackColor = Color.FromArgb(255, 42, 83, 120);
            button2.BackColor = Color.FromArgb(255, 42, 83, 120);
            xToolStripMenuItem.ForeColor = Color.FromArgb(255, 87, 102, 115);
            img = image;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        TimeSpan result;
        public double getTime()
        {

            return result.TotalMilliseconds;
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

        private void FormMatrix_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void FormMatrix_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                textBox1.Text = "5";
                textBox1.Size = new Size(100, 20);
                textBox1.Multiline = false;
                panel1.Visible = false;
                textBox1.ScrollBars = ScrollBars.None;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "";
                textBox1.Size = new Size(370, 146);
                textBox1.Multiline = true;
                textBox1.ScrollBars = ScrollBars.Both;
                panel1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                this.Close();
            if(radioButton1.Checked)
            {
                
                int m = textBox1.Lines.Length;
                int p = textBox1.Text.IndexOf('\r');
                if(textBox1.Text[p-1]==' ')
                {
                    textBox1.Text = textBox1.Text.Remove(p - 1, 1);
                }
                int n = textBox1.Lines[0].Split(' ').Length;
                
                string k = textBox1.Lines[0];
                double[,] arr = new double[m, n];
                for (int i = 0; i < m; i++)
                {
                    string[] s = textBox1.Lines[i].Split(' ');
                    
                    for (int j = 0; j < n; j++)
                    {
                        s[j]=s[j].Replace('.', ',');
                        arr[i, j] = Double.Parse(s[j]);
                    }
                }

                result = MatrixProcessing.timeResult;
                MatrixProcessing.Mask(img,arr,m,n);
            }
            if(radioButton2.Checked)
            {
                int param = Int32.Parse(textBox1.Text);
                if (param % 2 == 0)
                    param++;
                MatrixProcessing.Median(img, param);
                result = MatrixProcessing.timeResult;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBox2.Text);
            double sigma = Convert.ToInt32(textBox3.Text);
            textBox1.Text = "";
            
            for(int i=-r;i<=r;i++)
            {
                for (int j=-r;j<=r;j++)
                {
                    double answ = 1.0 / (2.0 * Math.PI * sigma * sigma)*Math.Exp(-1.0 * (i * i + j * j) / (2.0 * sigma * sigma));
                    string answS = answ.ToString();
                    if (answS[0] != '0')
                        textBox1.Text += "0 ";
                    else
                        textBox1.Text += answS.Remove(7)+" ";
                    
                }
                if(i!=r)
                textBox1.Text += Environment.NewLine;
            }
        }
    }
}
