namespace Week12_13
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ColorButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(227, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(625, 396);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pencil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Line";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 25);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ellipse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(50, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 25);
            this.button4.TabIndex = 1;
            this.button4.Text = "Rhombus";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 25);
            this.button5.TabIndex = 1;
            this.button5.Text = "Rectangle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.onOperationClick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(50, 256);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(138, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(50, 319);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(138, 109);
            this.ColorButton.TabIndex = 3;
            this.ColorButton.Text = "color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(50, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 25);
            this.button6.TabIndex = 1;
            this.button6.Text = "Triangle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(50, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 25);
            this.button7.TabIndex = 1;
            this.button7.Text = "Fill";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(50, 57);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 25);
            this.button8.TabIndex = 1;
            this.button8.Text = "Erase";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.onOperationClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 472);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

