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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLeftInst = new System.Windows.Forms.Button();
            this.btnLeftEff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveagainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRightInst = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRightInst1 = new System.Windows.Forms.Button();
            this.btnRightInst2 = new System.Windows.Forms.Button();
            this.btnRightInst3 = new System.Windows.Forms.Button();
            this.panelRightConfirm = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boxOverlay = new System.Windows.Forms.ComboBox();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barOpacity = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.boxBrushSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelRightEffects = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBright = new System.Windows.Forms.Button();
            this.btnContrast = new System.Windows.Forms.Button();
            this.btnNoise = new System.Windows.Forms.Button();
            this.btnCurves = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCurve2 = new System.Windows.Forms.PictureBox();
            this.btnCurve1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnFreq = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelRightInst.SuspendLayout();
            this.panelRightConfirm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barOpacity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxBrushSize)).BeginInit();
            this.panelRightEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCurve2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCurve1)).BeginInit();
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
            this.saveagainToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // saveagainToolStripMenuItem
            // 
            this.saveagainToolStripMenuItem.Name = "saveagainToolStripMenuItem";
            this.saveagainToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveagainToolStripMenuItem.Text = "Сохранить";
            this.saveagainToolStripMenuItem.Click += new System.EventHandler(this.saveagainToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveToolStripMenuItem.Text = "Сохранить как";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
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
            this.panelRight.Controls.Add(this.panelRightEffects);
            this.panelRight.Controls.Add(this.debug);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelRight.Location = new System.Drawing.Point(746, 24);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(212, 591);
            this.panelRight.TabIndex = 3;
            this.panelRight.WrapContents = false;
            // 
            // panelRightInst
            // 
            this.panelRightInst.BackColor = System.Drawing.Color.DimGray;
            this.panelRightInst.Controls.Add(this.btnRightInst1);
            this.panelRightInst.Controls.Add(this.btnRightInst2);
            this.panelRightInst.Controls.Add(this.btnRightInst3);
            this.panelRightInst.Location = new System.Drawing.Point(3, 3);
            this.panelRightInst.Name = "panelRightInst";
            this.panelRightInst.Size = new System.Drawing.Size(206, 100);
            this.panelRightInst.TabIndex = 4;
            // 
            // btnRightInst1
            // 
            this.btnRightInst1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnRightInst1.Click += new System.EventHandler(this.btnRightInst1_Click);
            // 
            // btnRightInst2
            // 
            this.btnRightInst2.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnRightInst2.Click += new System.EventHandler(this.btnRightInst2_Click);
            // 
            // btnRightInst3
            // 
            this.btnRightInst3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRightInst3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRightInst3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightInst3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRightInst3.ForeColor = System.Drawing.Color.White;
            this.btnRightInst3.Location = new System.Drawing.Point(75, 3);
            this.btnRightInst3.Name = "btnRightInst3";
            this.btnRightInst3.Size = new System.Drawing.Size(30, 30);
            this.btnRightInst3.TabIndex = 2;
            this.btnRightInst3.Text = "3";
            this.btnRightInst3.UseVisualStyleBackColor = true;
            this.btnRightInst3.Click += new System.EventHandler(this.btnRightInst3_Click);
            // 
            // panelRightConfirm
            // 
            this.panelRightConfirm.AutoSize = true;
            this.panelRightConfirm.BackColor = System.Drawing.Color.DimGray;
            this.panelRightConfirm.Controls.Add(this.panel2);
            this.panelRightConfirm.Controls.Add(this.panel3);
            this.panelRightConfirm.Controls.Add(this.btnConfirm);
            this.panelRightConfirm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelRightConfirm.Location = new System.Drawing.Point(3, 109);
            this.panelRightConfirm.Name = "panelRightConfirm";
            this.panelRightConfirm.Size = new System.Drawing.Size(206, 196);
            this.panelRightConfirm.TabIndex = 5;
            this.panelRightConfirm.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.boxOverlay);
            this.panel2.Controls.Add(this.labelOpacity);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.barOpacity);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 101);
            this.panel2.TabIndex = 2;
            // 
            // boxOverlay
            // 
            this.boxOverlay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boxOverlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxOverlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxOverlay.Font = new System.Drawing.Font("Candara", 9F);
            this.boxOverlay.ForeColor = System.Drawing.Color.White;
            this.boxOverlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boxOverlay.Location = new System.Drawing.Point(6, 69);
            this.boxOverlay.Name = "boxOverlay";
            this.boxOverlay.Size = new System.Drawing.Size(156, 22);
            this.boxOverlay.TabIndex = 2;
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.BackColor = System.Drawing.Color.Transparent;
            this.labelOpacity.Font = new System.Drawing.Font("Candara", 9F);
            this.labelOpacity.ForeColor = System.Drawing.Color.White;
            this.labelOpacity.Location = new System.Drawing.Point(161, 18);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(31, 14);
            this.labelOpacity.TabIndex = 1;
            this.labelOpacity.Text = "100%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Режим наложения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Непрозрачность:";
            // 
            // barOpacity
            // 
            this.barOpacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barOpacity.LargeChange = 20;
            this.barOpacity.Location = new System.Drawing.Point(0, 18);
            this.barOpacity.Maximum = 100;
            this.barOpacity.Name = "barOpacity";
            this.barOpacity.Size = new System.Drawing.Size(162, 45);
            this.barOpacity.TabIndex = 0;
            this.barOpacity.TickFrequency = 10;
            this.barOpacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.barOpacity.Value = 100;
            this.barOpacity.Scroll += new System.EventHandler(this.barOpacity_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnColor);
            this.panel3.Controls.Add(this.boxBrushSize);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 47);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(121, 21);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(20, 20);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // boxBrushSize
            // 
            this.boxBrushSize.BackColor = System.Drawing.SystemColors.HotTrack;
            this.boxBrushSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxBrushSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.boxBrushSize.ForeColor = System.Drawing.SystemColors.Menu;
            this.boxBrushSize.Location = new System.Drawing.Point(6, 20);
            this.boxBrushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxBrushSize.Name = "boxBrushSize";
            this.boxBrushSize.Size = new System.Drawing.Size(74, 20);
            this.boxBrushSize.TabIndex = 3;
            this.boxBrushSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Цвет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Размер кисти";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Candara", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(8, 163);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(188, 30);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Подтвердить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panelRightEffects
            // 
            this.panelRightEffects.BackColor = System.Drawing.Color.DimGray;
            this.panelRightEffects.Controls.Add(this.btnBright);
            this.panelRightEffects.Controls.Add(this.btnContrast);
            this.panelRightEffects.Controls.Add(this.btnNoise);
            this.panelRightEffects.Controls.Add(this.btnCurves);
            this.panelRightEffects.Controls.Add(this.btnBin);
            this.panelRightEffects.Controls.Add(this.btnMatrix);
            this.panelRightEffects.Controls.Add(this.btnFreq);
            this.panelRightEffects.Location = new System.Drawing.Point(3, 311);
            this.panelRightEffects.Name = "panelRightEffects";
            this.panelRightEffects.Size = new System.Drawing.Size(206, 255);
            this.panelRightEffects.TabIndex = 4;
            // 
            // btnBright
            // 
            this.btnBright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBright.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBright.Font = new System.Drawing.Font("Candara", 9F);
            this.btnBright.ForeColor = System.Drawing.Color.White;
            this.btnBright.Location = new System.Drawing.Point(8, 3);
            this.btnBright.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnBright.Name = "btnBright";
            this.btnBright.Size = new System.Drawing.Size(188, 30);
            this.btnBright.TabIndex = 1;
            this.btnBright.Text = "Яркость";
            this.btnBright.UseVisualStyleBackColor = true;
            this.btnBright.Click += new System.EventHandler(this.btnBright_Click);
            // 
            // btnContrast
            // 
            this.btnContrast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContrast.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnContrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrast.Font = new System.Drawing.Font("Candara", 9F);
            this.btnContrast.ForeColor = System.Drawing.Color.White;
            this.btnContrast.Location = new System.Drawing.Point(8, 39);
            this.btnContrast.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(188, 30);
            this.btnContrast.TabIndex = 1;
            this.btnContrast.Text = "Контраст";
            this.btnContrast.UseVisualStyleBackColor = true;
            this.btnContrast.Click += new System.EventHandler(this.btnContrast_Click);
            // 
            // btnNoise
            // 
            this.btnNoise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoise.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoise.Font = new System.Drawing.Font("Candara", 9F);
            this.btnNoise.ForeColor = System.Drawing.Color.White;
            this.btnNoise.Location = new System.Drawing.Point(8, 75);
            this.btnNoise.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnNoise.Name = "btnNoise";
            this.btnNoise.Size = new System.Drawing.Size(188, 30);
            this.btnNoise.TabIndex = 1;
            this.btnNoise.Text = "Создать шум";
            this.btnNoise.UseVisualStyleBackColor = true;
            this.btnNoise.Click += new System.EventHandler(this.btnNoise_Click);
            // 
            // btnCurves
            // 
            this.btnCurves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurves.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCurves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurves.Font = new System.Drawing.Font("Candara", 9F);
            this.btnCurves.ForeColor = System.Drawing.Color.White;
            this.btnCurves.Location = new System.Drawing.Point(8, 111);
            this.btnCurves.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnCurves.Name = "btnCurves";
            this.btnCurves.Size = new System.Drawing.Size(188, 30);
            this.btnCurves.TabIndex = 1;
            this.btnCurves.Text = "Кривые";
            this.btnCurves.UseVisualStyleBackColor = true;
            this.btnCurves.Click += new System.EventHandler(this.btnCurves_Click);
            // 
            // btnBin
            // 
            this.btnBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBin.Font = new System.Drawing.Font("Candara", 9F);
            this.btnBin.ForeColor = System.Drawing.Color.White;
            this.btnBin.Location = new System.Drawing.Point(8, 147);
            this.btnBin.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(188, 30);
            this.btnBin.TabIndex = 1;
            this.btnBin.Text = "Бинаризация";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnMatrix
            // 
            this.btnMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatrix.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrix.Font = new System.Drawing.Font("Candara", 9F);
            this.btnMatrix.ForeColor = System.Drawing.Color.White;
            this.btnMatrix.Location = new System.Drawing.Point(8, 183);
            this.btnMatrix.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(188, 30);
            this.btnMatrix.TabIndex = 1;
            this.btnMatrix.Text = "Матричные фильтры";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.ForeColor = System.Drawing.Color.White;
            this.debug.Location = new System.Drawing.Point(3, 569);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(39, 13);
            this.debug.TabIndex = 6;
            this.debug.Text = "Debug";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCurve2);
            this.panel1.Controls.Add(this.btnCurve1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(56, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 591);
            this.panel1.TabIndex = 5;
            // 
            // btnCurve2
            // 
            this.btnCurve2.BackColor = System.Drawing.Color.White;
            this.btnCurve2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCurve2.Location = new System.Drawing.Point(70, 12);
            this.btnCurve2.Name = "btnCurve2";
            this.btnCurve2.Size = new System.Drawing.Size(10, 10);
            this.btnCurve2.TabIndex = 6;
            this.btnCurve2.TabStop = false;
            // 
            // btnCurve1
            // 
            this.btnCurve1.BackColor = System.Drawing.Color.White;
            this.btnCurve1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCurve1.Location = new System.Drawing.Point(54, 12);
            this.btnCurve1.Name = "btnCurve1";
            this.btnCurve1.Size = new System.Drawing.Size(10, 10);
            this.btnCurve1.TabIndex = 6;
            this.btnCurve1.TabStop = false;
            this.btnCurve1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCurve1_MouseDown);
            this.btnCurve1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCurve1_MouseMove);
            this.btnCurve1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCurve1_MouseUp);
            // 
            // btnFreq
            // 
            this.btnFreq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFreq.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnFreq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreq.Font = new System.Drawing.Font("Candara", 9F);
            this.btnFreq.ForeColor = System.Drawing.Color.White;
            this.btnFreq.Location = new System.Drawing.Point(8, 219);
            this.btnFreq.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnFreq.Name = "btnFreq";
            this.btnFreq.Size = new System.Drawing.Size(188, 30);
            this.btnFreq.TabIndex = 1;
            this.btnFreq.Text = "Частотные фильтры";
            this.btnFreq.UseVisualStyleBackColor = true;
            this.btnFreq.Click += new System.EventHandler(this.btnFreq_Click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barOpacity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxBrushSize)).EndInit();
            this.panelRightEffects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCurve2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCurve1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar barOpacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.ComboBox boxOverlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown boxBrushSize;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveagainToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel panelRightEffects;
        private System.Windows.Forms.Button btnBright;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Button btnNoise;
        private System.Windows.Forms.Button btnCurves;
        private System.Windows.Forms.Button btnRightInst3;
        private System.Windows.Forms.PictureBox btnCurve1;
        private System.Windows.Forms.PictureBox btnCurve2;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Button btnFreq;
    }
}

