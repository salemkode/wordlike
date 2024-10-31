namespace wordpad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            strikeThroughBtn = new PictureBox();
            boldBtn = new PictureBox();
            underlineBtn = new PictureBox();
            italicBtn = new PictureBox();
            alignCenterBtn = new PictureBox();
            alignLeftBtn = new PictureBox();
            alignRightBtn = new PictureBox();
            fontList = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            filePath = new Label();
            fontSizeNumber = new NumericUpDown();
            StrickInLine = new PictureBox();
            italic = new PictureBox();
            underline = new PictureBox();
            moveCenter = new PictureBox();
            moveRight = new PictureBox();
            moveLeft = new PictureBox();
            changeTextSize = new ContextMenuStrip(components);
            titleToolStripMenuItem = new ToolStripMenuItem();
            headerToolStripMenuItem = new ToolStripMenuItem();
            subheaderToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            monToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            customToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            addImageToolStripMenuItem1 = new ToolStripMenuItem();
            changeForceColorToolStripMenuItem = new ToolStripMenuItem();
            changeBToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)strikeThroughBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boldBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)underlineBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)italicBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alignCenterBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alignLeftBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alignRightBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StrickInLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)italic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)underline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moveCenter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moveRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moveLeft).BeginInit();
            changeTextSize.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Location = new Point(0, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(719, 385);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(alignCenterBtn);
            panel2.Controls.Add(alignLeftBtn);
            panel2.Controls.Add(alignRightBtn);
            panel2.Controls.Add(fontList);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(filePath);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 24);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 41);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(strikeThroughBtn);
            panel3.Controls.Add(boldBtn);
            panel3.Controls.Add(underlineBtn);
            panel3.Controls.Add(italicBtn);
            panel3.Location = new Point(314, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(128, 27);
            panel3.TabIndex = 12;
            // 
            // strikeThroughBtn
            // 
            strikeThroughBtn.Anchor = AnchorStyles.None;
            strikeThroughBtn.BackColor = Color.Transparent;
            strikeThroughBtn.ErrorImage = null;
            strikeThroughBtn.Image = Properties.Resources.strikethrough;
            strikeThroughBtn.Location = new Point(97, 1);
            strikeThroughBtn.Name = "strikeThroughBtn";
            strikeThroughBtn.Size = new Size(25, 23);
            strikeThroughBtn.SizeMode = PictureBoxSizeMode.Zoom;
            strikeThroughBtn.TabIndex = 15;
            strikeThroughBtn.TabStop = false;
            // 
            // boldBtn
            // 
            boldBtn.Anchor = AnchorStyles.None;
            boldBtn.BackColor = Color.Transparent;
            boldBtn.ErrorImage = null;
            boldBtn.Image = Properties.Resources.bold__1_;
            boldBtn.Location = new Point(4, 1);
            boldBtn.Name = "boldBtn";
            boldBtn.Size = new Size(25, 23);
            boldBtn.TabIndex = 13;
            boldBtn.TabStop = false;
            // 
            // underlineBtn
            // 
            underlineBtn.Anchor = AnchorStyles.None;
            underlineBtn.BackColor = Color.Transparent;
            underlineBtn.ErrorImage = null;
            underlineBtn.Image = Properties.Resources.underline;
            underlineBtn.Location = new Point(66, 1);
            underlineBtn.Name = "underlineBtn";
            underlineBtn.Size = new Size(25, 23);
            underlineBtn.SizeMode = PictureBoxSizeMode.Zoom;
            underlineBtn.TabIndex = 14;
            underlineBtn.TabStop = false;
            // 
            // italicBtn
            // 
            italicBtn.Anchor = AnchorStyles.None;
            italicBtn.BackColor = Color.Transparent;
            italicBtn.ErrorImage = null;
            italicBtn.Image = Properties.Resources.italic;
            italicBtn.Location = new Point(35, 1);
            italicBtn.Name = "italicBtn";
            italicBtn.Size = new Size(25, 23);
            italicBtn.SizeMode = PictureBoxSizeMode.Zoom;
            italicBtn.TabIndex = 12;
            italicBtn.TabStop = false;
            // 
            // alignCenterBtn
            // 
            alignCenterBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            alignCenterBtn.Image = Properties.Resources.align_center;
            alignCenterBtn.Location = new Point(477, 9);
            alignCenterBtn.Name = "alignCenterBtn";
            alignCenterBtn.Size = new Size(23, 23);
            alignCenterBtn.TabIndex = 7;
            alignCenterBtn.TabStop = false;
            alignCenterBtn.Click += alignCenterBtn_Click;
            // 
            // alignLeftBtn
            // 
            alignLeftBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            alignLeftBtn.Image = Properties.Resources.align_left;
            alignLeftBtn.Location = new Point(448, 9);
            alignLeftBtn.Name = "alignLeftBtn";
            alignLeftBtn.Size = new Size(23, 23);
            alignLeftBtn.TabIndex = 6;
            alignLeftBtn.TabStop = false;
            alignLeftBtn.Click += alignLeftBtn_Click;
            // 
            // alignRightBtn
            // 
            alignRightBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            alignRightBtn.Image = Properties.Resources.symbol;
            alignRightBtn.Location = new Point(506, 9);
            alignRightBtn.Name = "alignRightBtn";
            alignRightBtn.Size = new Size(23, 23);
            alignRightBtn.TabIndex = 4;
            alignRightBtn.TabStop = false;
            alignRightBtn.Click += alignRightBtn_Click;
            // 
            // fontList
            // 
            fontList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fontList.FormattingEnabled = true;
            fontList.Location = new Point(535, 9);
            fontList.Name = "fontList";
            fontList.Size = new Size(121, 23);
            fontList.TabIndex = 5;
            fontList.SelectedIndexChanged += fontList_SelectedIndexChanged;
            fontList.Click += fontList_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Location = new Point(662, 9);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(46, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown1.Click += fontList_Click;
            // 
            // filePath
            // 
            filePath.AutoSize = true;
            filePath.BackColor = Color.White;
            filePath.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filePath.ForeColor = Color.Black;
            filePath.Location = new Point(12, 9);
            filePath.Name = "filePath";
            filePath.Size = new Size(0, 21);
            filePath.TabIndex = 3;
            // 
            // fontSizeNumber
            // 
            fontSizeNumber.BorderStyle = BorderStyle.None;
            fontSizeNumber.Location = new Point(204, 39);
            fontSizeNumber.Name = "fontSizeNumber";
            fontSizeNumber.Size = new Size(49, 19);
            fontSizeNumber.TabIndex = 8;
            // 
            // StrickInLine
            // 
            StrickInLine.BackColor = Color.White;
            StrickInLine.Location = new Point(216, 4);
            StrickInLine.Margin = new Padding(3, 4, 3, 4);
            StrickInLine.Name = "StrickInLine";
            StrickInLine.Size = new Size(24, 24);
            StrickInLine.SizeMode = PictureBoxSizeMode.AutoSize;
            StrickInLine.TabIndex = 6;
            StrickInLine.TabStop = false;
            // 
            // italic
            // 
            italic.BackColor = Color.White;
            italic.Location = new Point(183, 4);
            italic.Margin = new Padding(3, 4, 3, 4);
            italic.Name = "italic";
            italic.Size = new Size(24, 24);
            italic.SizeMode = PictureBoxSizeMode.AutoSize;
            italic.TabIndex = 5;
            italic.TabStop = false;
            // 
            // underline
            // 
            underline.BackColor = Color.White;
            underline.Location = new Point(149, 4);
            underline.Margin = new Padding(3, 4, 3, 4);
            underline.Name = "underline";
            underline.Size = new Size(24, 24);
            underline.SizeMode = PictureBoxSizeMode.AutoSize;
            underline.TabIndex = 4;
            underline.TabStop = false;
            // 
            // moveCenter
            // 
            moveCenter.BackColor = Color.White;
            moveCenter.Location = new Point(46, 4);
            moveCenter.Margin = new Padding(3, 4, 3, 4);
            moveCenter.Name = "moveCenter";
            moveCenter.Size = new Size(24, 24);
            moveCenter.SizeMode = PictureBoxSizeMode.AutoSize;
            moveCenter.TabIndex = 2;
            moveCenter.TabStop = false;
            moveCenter.Click += moveCenter_Click;
            // 
            // moveRight
            // 
            moveRight.BackColor = Color.White;
            moveRight.Location = new Point(80, 4);
            moveRight.Margin = new Padding(3, 4, 3, 4);
            moveRight.Name = "moveRight";
            moveRight.Size = new Size(24, 24);
            moveRight.SizeMode = PictureBoxSizeMode.AutoSize;
            moveRight.TabIndex = 1;
            moveRight.TabStop = false;
            moveRight.Click += moveRight_Click;
            // 
            // moveLeft
            // 
            moveLeft.BackColor = Color.White;
            moveLeft.Location = new Point(11, 4);
            moveLeft.Margin = new Padding(3, 4, 3, 4);
            moveLeft.Name = "moveLeft";
            moveLeft.Size = new Size(24, 24);
            moveLeft.SizeMode = PictureBoxSizeMode.AutoSize;
            moveLeft.TabIndex = 0;
            moveLeft.TabStop = false;
            moveLeft.Click += moveLeft_Click;
            // 
            // changeTextSize
            // 
            changeTextSize.ImageScalingSize = new Size(20, 20);
            changeTextSize.Items.AddRange(new ToolStripItem[] { titleToolStripMenuItem, headerToolStripMenuItem, subheaderToolStripMenuItem, normalToolStripMenuItem, monToolStripMenuItem, toolStripSeparator1, customToolStripMenuItem });
            changeTextSize.Name = "changeTextSize";
            changeTextSize.Size = new Size(137, 142);
            // 
            // titleToolStripMenuItem
            // 
            titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            titleToolStripMenuItem.Size = new Size(136, 22);
            titleToolStripMenuItem.Text = "Title";
            titleToolStripMenuItem.Click += titleToolStripMenuItem_Click;
            // 
            // headerToolStripMenuItem
            // 
            headerToolStripMenuItem.Name = "headerToolStripMenuItem";
            headerToolStripMenuItem.Size = new Size(136, 22);
            headerToolStripMenuItem.Text = "Header";
            headerToolStripMenuItem.Click += headerToolStripMenuItem_Click;
            // 
            // subheaderToolStripMenuItem
            // 
            subheaderToolStripMenuItem.Name = "subheaderToolStripMenuItem";
            subheaderToolStripMenuItem.Size = new Size(136, 22);
            subheaderToolStripMenuItem.Text = "Sub header";
            subheaderToolStripMenuItem.Click += subheaderToolStripMenuItem_Click;
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(136, 22);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // monToolStripMenuItem
            // 
            monToolStripMenuItem.Name = "monToolStripMenuItem";
            monToolStripMenuItem.Size = new Size(136, 22);
            monToolStripMenuItem.Text = "Monospace";
            monToolStripMenuItem.Click += monToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(133, 6);
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.Size = new Size(136, 22);
            customToolStripMenuItem.Text = "Custom";
            customToolStripMenuItem.Click += customToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 24, 0, 0);
            panel1.Size = new Size(719, 450);
            panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, addImageToolStripMenuItem1, changeForceColorToolStripMenuItem, changeBToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(719, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Image = Properties.Resources.folder_open;
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(122, 22);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.disk1;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(122, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveButton_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = Properties.Resources.disk;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(122, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsButton_Click;
            // 
            // addImageToolStripMenuItem1
            // 
            addImageToolStripMenuItem1.Image = Properties.Resources.add_image__1_;
            addImageToolStripMenuItem1.Name = "addImageToolStripMenuItem1";
            addImageToolStripMenuItem1.Size = new Size(93, 20);
            addImageToolStripMenuItem1.Text = "Add image";
            addImageToolStripMenuItem1.Click += addImageBtn_Click;
            // 
            // changeForceColorToolStripMenuItem
            // 
            changeForceColorToolStripMenuItem.Image = Properties.Resources.palette;
            changeForceColorToolStripMenuItem.Name = "changeForceColorToolStripMenuItem";
            changeForceColorToolStripMenuItem.Size = new Size(136, 20);
            changeForceColorToolStripMenuItem.Text = "Change force color";
            changeForceColorToolStripMenuItem.Click += changeForceColorToolStripMenuItem_Click;
            // 
            // changeBToolStripMenuItem
            // 
            changeBToolStripMenuItem.Image = Properties.Resources.highlighter_line;
            changeBToolStripMenuItem.Name = "changeBToolStripMenuItem";
            changeBToolStripMenuItem.Size = new Size(115, 20);
            changeBToolStripMenuItem.Text = "Highlight color";
            changeBToolStripMenuItem.Click += changeBToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)strikeThroughBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)boldBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)underlineBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)italicBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)alignCenterBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)alignLeftBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)alignRightBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fontSizeNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)StrickInLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)italic).EndInit();
            ((System.ComponentModel.ISupportInitialize)underline).EndInit();
            ((System.ComponentModel.ISupportInitialize)moveCenter).EndInit();
            ((System.ComponentModel.ISupportInitialize)moveRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)moveLeft).EndInit();
            changeTextSize.ResumeLayout(false);
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private ContextMenuStrip changeTextSize;
        private ToolStripMenuItem titleToolStripMenuItem;
        private ToolStripMenuItem headerToolStripMenuItem;
        private ToolStripMenuItem subheaderToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem monToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private Label filePath;
        private ToolStripMenuItem customToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private PictureBox moveCenter;
        private PictureBox moveRight;
        private PictureBox moveLeft;
        private PictureBox underline;
        private PictureBox italic;
        private PictureBox StrickInLine;
        private NumericUpDown fontSizeNumber;
        private NumericUpDown numericUpDown1;
        private ComboBox fontList;
        private Panel panel1;
        private PictureBox alignCenterBtn;
        private PictureBox alignLeftBtn;
        private PictureBox alignRightBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem addImageToolStripMenuItem1;
        private Panel panel3;
        private PictureBox strikeThroughBtn;
        private PictureBox boldBtn;
        private PictureBox underlineBtn;
        private PictureBox italicBtn;
        private ToolStripMenuItem changeForceColorToolStripMenuItem;
        private ToolStripMenuItem changeBToolStripMenuItem;
        private ColorDialog colorDialog1;
    }
}
