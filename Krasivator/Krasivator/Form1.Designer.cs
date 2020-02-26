namespace Krasivator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLeftInst = new System.Windows.Forms.Button();
            this.btnLeftEff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRightInst = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRightInst1 = new System.Windows.Forms.Button();
            this.btnRightInst2 = new System.Windows.Forms.Button();
            this.panelRightConfirm = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.debug = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelRightInst.SuspendLayout();
            this.panelRightConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoSize = true;
            this.panelLeft.Controls.Add(this.btnLeftInst);
            this.panelLeft.Controls.Add(this.btnLeftEff);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelLeft.Location = new System.Drawing.Point(0, 24);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(56, 591);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.WrapContents = false;
            // 
            // btnLeftInst
            // 
            this.btnLeftInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeftInst.Location = new System.Drawing.Point(3, 3);
            this.btnLeftInst.Name = "btnLeftInst";
            this.btnLeftInst.Size = new System.Drawing.Size(50, 50);
            this.btnLeftInst.TabIndex = 0;
            this.btnLeftInst.Text = "И";
            this.btnLeftInst.UseVisualStyleBackColor = true;
            this.btnLeftInst.Click += new System.EventHandler(this.btnLeftInst_Click);
            // 
            // btnLeftEff
            // 
            this.btnLeftEff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftEff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnLeftEff.Location = new System.Drawing.Point(3, 59);
            this.btnLeftEff.Name = "btnLeftEff";
            this.btnLeftEff.Size = new System.Drawing.Size(50, 50);
            this.btnLeftEff.TabIndex = 1;
            this.btnLeftEff.Text = "Э";
            this.btnLeftEff.UseVisualStyleBackColor = true;
            this.btnLeftEff.Click += new System.EventHandler(this.btnLeftEff_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.EditToolStripMenuItem.Text = "Редактирование";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 20);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 588);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panelRight
            // 
            this.panelRight.AutoSize = true;
            this.panelRight.Controls.Add(this.panelRightInst);
            this.panelRight.Controls.Add(this.panelRightConfirm);
            this.panelRight.Controls.Add(this.debug);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelRight.Location = new System.Drawing.Point(752, 24);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(206, 591);
            this.panelRight.TabIndex = 3;
            this.panelRight.WrapContents = false;
            // 
            // panelRightInst
            // 
            this.panelRightInst.BackColor = System.Drawing.Color.DimGray;
            this.panelRightInst.Controls.Add(this.btnRightInst1);
            this.panelRightInst.Controls.Add(this.btnRightInst2);
            this.panelRightInst.Location = new System.Drawing.Point(3, 3);
            this.panelRightInst.Name = "panelRightInst";
            this.panelRightInst.Size = new System.Drawing.Size(200, 100);
            this.panelRightInst.TabIndex = 4;
            // 
            // btnRightInst1
            // 
            this.btnRightInst1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRightInst1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightInst1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRightInst1.ForeColor = System.Drawing.Color.White;
            this.btnRightInst1.Location = new System.Drawing.Point(3, 3);
            this.btnRightInst1.Name = "btnRightInst1";
            this.btnRightInst1.Size = new System.Drawing.Size(30, 30);
            this.btnRightInst1.TabIndex = 1;
            this.btnRightInst1.Text = "1";
            this.btnRightInst1.UseVisualStyleBackColor = true;
            // 
            // btnRightInst2
            // 
            this.btnRightInst2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRightInst2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightInst2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRightInst2.ForeColor = System.Drawing.Color.White;
            this.btnRightInst2.Location = new System.Drawing.Point(39, 3);
            this.btnRightInst2.Name = "btnRightInst2";
            this.btnRightInst2.Size = new System.Drawing.Size(30, 30);
            this.btnRightInst2.TabIndex = 2;
            this.btnRightInst2.Text = "2";
            this.btnRightInst2.UseVisualStyleBackColor = true;
            // 
            // panelRightConfirm
            // 
            this.panelRightConfirm.BackColor = System.Drawing.Color.DimGray;
            this.panelRightConfirm.Controls.Add(this.btnConfirm);
            this.panelRightConfirm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelRightConfirm.Location = new System.Drawing.Point(3, 109);
            this.panelRightConfirm.Name = "panelRightConfirm";
            this.panelRightConfirm.Size = new System.Drawing.Size(200, 37);
            this.panelRightConfirm.TabIndex = 5;
            this.panelRightConfirm.WrapContents = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Candara", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(3, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(188, 30);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Подтвердить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(56, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 591);
            this.panel1.TabIndex = 5;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(3, 149);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(35, 13);
            this.debug.TabIndex = 6;
            this.debug.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Krasivator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panelLeft.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelRightInst.ResumeLayout(false);
            this.panelRightConfirm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelLeft;
        private System.Windows.Forms.Button btnLeftInst;
        private System.Windows.Forms.Button btnLeftEff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel panelRight;
        private System.Windows.Forms.FlowLayoutPanel panelRightInst;
        private System.Windows.Forms.Button btnRightInst1;
        private System.Windows.Forms.Button btnRightInst2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelRightConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label debug;
    }
}

