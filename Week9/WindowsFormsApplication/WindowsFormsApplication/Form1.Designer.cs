namespace WindowsFormsApplication
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
            this.zero_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.coma_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.c_button = new System.Windows.Forms.Button();
            this.ce_button = new System.Windows.Forms.Button();
            this.backspace_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.substraction_button = new System.Windows.Forms.Button();
            this.multiply_button = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.plusminus_button = new System.Windows.Forms.Button();
            this.sqrt_button = new System.Windows.Forms.Button();
            this.percent_button = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zero_button
            // 
            this.zero_button.Location = new System.Drawing.Point(8, 282);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(100, 40);
            this.zero_button.TabIndex = 0;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            // 
            // one_button
            // 
            this.one_button.Location = new System.Drawing.Point(8, 235);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(45, 40);
            this.one_button.TabIndex = 3;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            // 
            // two_button
            // 
            this.two_button.Location = new System.Drawing.Point(59, 235);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(49, 40);
            this.two_button.TabIndex = 4;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            // 
            // three_button
            // 
            this.three_button.Location = new System.Drawing.Point(114, 235);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(49, 40);
            this.three_button.TabIndex = 5;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            // 
            // coma_button
            // 
            this.coma_button.Location = new System.Drawing.Point(114, 281);
            this.coma_button.Name = "coma_button";
            this.coma_button.Size = new System.Drawing.Size(49, 40);
            this.coma_button.TabIndex = 6;
            this.coma_button.Text = ",";
            this.coma_button.UseVisualStyleBackColor = true;
            this.coma_button.Click += new System.EventHandler(this.onComaClick);
            // 
            // six_button
            // 
            this.six_button.Location = new System.Drawing.Point(114, 189);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(49, 40);
            this.six_button.TabIndex = 9;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            // 
            // five_button
            // 
            this.five_button.Location = new System.Drawing.Point(59, 189);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(49, 40);
            this.five_button.TabIndex = 8;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // four_button
            // 
            this.four_button.Location = new System.Drawing.Point(8, 189);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(45, 40);
            this.four_button.TabIndex = 7;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // nine_button
            // 
            this.nine_button.Location = new System.Drawing.Point(114, 143);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(49, 40);
            this.nine_button.TabIndex = 12;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // eight_button
            // 
            this.eight_button.Location = new System.Drawing.Point(59, 143);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(49, 40);
            this.eight_button.TabIndex = 11;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // seven_button
            // 
            this.seven_button.Location = new System.Drawing.Point(8, 143);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(45, 40);
            this.seven_button.TabIndex = 10;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // c_button
            // 
            this.c_button.Location = new System.Drawing.Point(114, 97);
            this.c_button.Name = "c_button";
            this.c_button.Size = new System.Drawing.Size(49, 40);
            this.c_button.TabIndex = 15;
            this.c_button.Text = "C";
            this.c_button.UseVisualStyleBackColor = true;
            this.c_button.Click += new System.EventHandler(this.onClearClick);
            // 
            // ce_button
            // 
            this.ce_button.Location = new System.Drawing.Point(59, 97);
            this.ce_button.Name = "ce_button";
            this.ce_button.Size = new System.Drawing.Size(49, 40);
            this.ce_button.TabIndex = 14;
            this.ce_button.Text = "CE";
            this.ce_button.UseVisualStyleBackColor = true;
            this.ce_button.Click += new System.EventHandler(this.onClearClick);
            // 
            // backspace_button
            // 
            this.backspace_button.Location = new System.Drawing.Point(8, 97);
            this.backspace_button.Name = "backspace_button";
            this.backspace_button.Size = new System.Drawing.Size(45, 40);
            this.backspace_button.TabIndex = 13;
            this.backspace_button.Text = "backspace";
            this.backspace_button.UseVisualStyleBackColor = true;
            this.backspace_button.Click += new System.EventHandler(this.onClearClick);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(169, 281);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(49, 40);
            this.add_button.TabIndex = 16;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // substraction_button
            // 
            this.substraction_button.Location = new System.Drawing.Point(169, 234);
            this.substraction_button.Name = "substraction_button";
            this.substraction_button.Size = new System.Drawing.Size(49, 40);
            this.substraction_button.TabIndex = 17;
            this.substraction_button.Text = "-";
            this.substraction_button.UseVisualStyleBackColor = true;
            this.substraction_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // multiply_button
            // 
            this.multiply_button.Location = new System.Drawing.Point(169, 189);
            this.multiply_button.Name = "multiply_button";
            this.multiply_button.Size = new System.Drawing.Size(49, 40);
            this.multiply_button.TabIndex = 18;
            this.multiply_button.Text = "*";
            this.multiply_button.UseVisualStyleBackColor = true;
            this.multiply_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // divide_button
            // 
            this.divide_button.Location = new System.Drawing.Point(169, 143);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(49, 40);
            this.divide_button.TabIndex = 19;
            this.divide_button.Text = "/";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // plusminus_button
            // 
            this.plusminus_button.Location = new System.Drawing.Point(169, 97);
            this.plusminus_button.Name = "plusminus_button";
            this.plusminus_button.Size = new System.Drawing.Size(49, 40);
            this.plusminus_button.TabIndex = 20;
            this.plusminus_button.Text = "+|-";
            this.plusminus_button.UseVisualStyleBackColor = true;
            this.plusminus_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // sqrt_button
            // 
            this.sqrt_button.Location = new System.Drawing.Point(224, 97);
            this.sqrt_button.Name = "sqrt_button";
            this.sqrt_button.Size = new System.Drawing.Size(49, 40);
            this.sqrt_button.TabIndex = 21;
            this.sqrt_button.Text = "sqrt";
            this.sqrt_button.UseVisualStyleBackColor = true;
            this.sqrt_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // percent_button
            // 
            this.percent_button.Location = new System.Drawing.Point(224, 143);
            this.percent_button.Name = "percent_button";
            this.percent_button.Size = new System.Drawing.Size(49, 40);
            this.percent_button.TabIndex = 22;
            this.percent_button.Text = "x^2";
            this.percent_button.UseVisualStyleBackColor = true;
            this.percent_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(224, 189);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(49, 40);
            this.button22.TabIndex = 23;
            this.button22.Text = "1/x";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.onOperationClick);
            // 
            // equal_button
            // 
            this.equal_button.Location = new System.Drawing.Point(224, 234);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(49, 87);
            this.equal_button.TabIndex = 24;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = true;
            this.equal_button.Click += new System.EventHandler(this.onEqualClick);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.Location = new System.Drawing.Point(8, 12);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(265, 80);
            this.display.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onNumberClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onNumberClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onNumberClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onNumberClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(114, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.onNumberClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.display);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.percent_button);
            this.Controls.Add(this.sqrt_button);
            this.Controls.Add(this.plusminus_button);
            this.Controls.Add(this.divide_button);
            this.Controls.Add(this.multiply_button);
            this.Controls.Add(this.substraction_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.c_button);
            this.Controls.Add(this.ce_button);
            this.Controls.Add(this.backspace_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.coma_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "☺Calculator☻";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button coma_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button c_button;
        private System.Windows.Forms.Button ce_button;
        private System.Windows.Forms.Button backspace_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button substraction_button;
        private System.Windows.Forms.Button multiply_button;
        private System.Windows.Forms.Button divide_button;
        private System.Windows.Forms.Button plusminus_button;
        private System.Windows.Forms.Button sqrt_button;
        private System.Windows.Forms.Button percent_button;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button equal_button;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

