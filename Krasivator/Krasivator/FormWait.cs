using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Krasivator
{
    public partial class FormWait : Form
    {
        public FormWait()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            this.BackColor = Color.FromArgb(255, 42, 83, 120);


        }
        sbyte progessBarRed = 2;
        private void FormWait_Load(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(progressBar1, progessBarRed);
        }
        public void setValue(int value)
        {
            if (value > 100)
                value = 100;
            progressBar1.Value = value;
        }

        
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
