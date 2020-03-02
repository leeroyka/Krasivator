namespace Krasivator
{
    partial class FormCurves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnR1 = new System.Windows.Forms.Button();
            this.btnR2 = new System.Windows.Forms.Button();
            this.btnR3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnG3 = new System.Windows.Forms.Button();
            this.btnG2 = new System.Windows.Forms.Button();
            this.btnG1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnR3);
            this.panel1.Controls.Add(this.btnR2);
            this.panel1.Controls.Add(this.btnR1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 265);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 255);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 20);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Красный канал:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Зеленый канал:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Синий канал:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnR1
            // 
            this.btnR1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR1.Location = new System.Drawing.Point(-5, 250);
            this.btnR1.Name = "btnR1";
            this.btnR1.Size = new System.Drawing.Size(10, 10);
            this.btnR1.TabIndex = 1;
            this.btnR1.UseVisualStyleBackColor = false;
            this.btnR1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnR1_MouseDown);
            this.btnR1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnR1_MouseMove);
            this.btnR1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnR1_MouseUp);
            // 
            // btnR2
            // 
            this.btnR2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR2.Location = new System.Drawing.Point(123, 123);
            this.btnR2.Name = "btnR2";
            this.btnR2.Size = new System.Drawing.Size(10, 10);
            this.btnR2.TabIndex = 1;
            this.btnR2.UseVisualStyleBackColor = false;
            this.btnR2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnR2_MouseDown);
            this.btnR2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnR2_MouseMove);
            this.btnR2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnR2_MouseUp);
            // 
            // btnR3
            // 
            this.btnR3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnR3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR3.Location = new System.Drawing.Point(250, -5);
            this.btnR3.Name = "btnR3";
            this.btnR3.Size = new System.Drawing.Size(10, 10);
            this.btnR3.TabIndex = 1;
            this.btnR3.UseVisualStyleBackColor = false;
            this.btnR3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnR3_MouseDown);
            this.btnR3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnR3_MouseMove);
            this.btnR3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnR3_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnG3);
            this.panel2.Controls.Add(this.btnG2);
            this.panel2.Controls.Add(this.btnG1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(278, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 265);
            this.panel2.TabIndex = 0;
            // 
            // btnG3
            // 
            this.btnG3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnG3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG3.Location = new System.Drawing.Point(250, -5);
            this.btnG3.Name = "btnG3";
            this.btnG3.Size = new System.Drawing.Size(10, 10);
            this.btnG3.TabIndex = 1;
            this.btnG3.UseVisualStyleBackColor = false;
            this.btnG3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnG3_MouseDown);
            this.btnG3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnG3_MouseMove);
            this.btnG3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnG3_MouseUp);
            // 
            // btnG2
            // 
            this.btnG2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnG2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG2.Location = new System.Drawing.Point(123, 123);
            this.btnG2.Name = "btnG2";
            this.btnG2.Size = new System.Drawing.Size(10, 10);
            this.btnG2.TabIndex = 1;
            this.btnG2.UseVisualStyleBackColor = false;
            this.btnG2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnG2_MouseDown);
            this.btnG2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnG2_MouseMove);
            this.btnG2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnG2_MouseUp);
            // 
            // btnG1
            // 
            this.btnG1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG1.Location = new System.Drawing.Point(-5, 250);
            this.btnG1.Name = "btnG1";
            this.btnG1.Size = new System.Drawing.Size(10, 10);
            this.btnG1.TabIndex = 1;
            this.btnG1.UseVisualStyleBackColor = false;
            this.btnG1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnG1_MouseDown);
            this.btnG1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnG1_MouseMove);
            this.btnG1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnG1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 255);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDoubleClick);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnB3);
            this.panel3.Controls.Add(this.btnB2);
            this.panel3.Controls.Add(this.btnB1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(544, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 265);
            this.panel3.TabIndex = 0;
            // 
            // btnB3
            // 
            this.btnB3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB3.Location = new System.Drawing.Point(250, -5);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(10, 10);
            this.btnB3.TabIndex = 1;
            this.btnB3.UseVisualStyleBackColor = false;
            this.btnB3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnB3_MouseDown);
            this.btnB3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnB3_MouseMove);
            this.btnB3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnB3_MouseUp);
            // 
            // btnB2
            // 
            this.btnB2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB2.Location = new System.Drawing.Point(123, 123);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(10, 10);
            this.btnB2.TabIndex = 1;
            this.btnB2.UseVisualStyleBackColor = false;
            this.btnB2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnB2_MouseDown);
            this.btnB2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnB2_MouseMove);
            this.btnB2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnB2_MouseUp);
            // 
            // btnB1
            // 
            this.btnB1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB1.Location = new System.Drawing.Point(-5, 250);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(10, 10);
            this.btnB1.TabIndex = 1;
            this.btnB1.UseVisualStyleBackColor = false;
            this.btnB1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnB1_MouseDown);
            this.btnB1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnB1_MouseMove);
            this.btnB1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnB1_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(255, 255);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDoubleClick);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // FormCurves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Candara", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCurves";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCurves";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormCurves_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormCurves_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnR3;
        private System.Windows.Forms.Button btnR2;
        private System.Windows.Forms.Button btnR1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnG3;
        private System.Windows.Forms.Button btnG2;
        private System.Windows.Forms.Button btnG1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}