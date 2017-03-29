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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zero_button
            // 
            this.zero_button.Location = new System.Drawing.Point(10, 339);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(100, 40);
            this.zero_button.TabIndex = 0;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            // 
            // one_button
            // 
            this.one_button.Location = new System.Drawing.Point(10, 292);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(45, 40);
            this.one_button.TabIndex = 3;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            // 
            // two_button
            // 
            this.two_button.Location = new System.Drawing.Point(61, 292);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(49, 40);
            this.two_button.TabIndex = 4;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            // 
            // three_button
            // 
            this.three_button.Location = new System.Drawing.Point(116, 292);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(49, 40);
            this.three_button.TabIndex = 5;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            // 
            // coma_button
            // 
            this.coma_button.Location = new System.Drawing.Point(116, 338);
            this.coma_button.Name = "coma_button";
            this.coma_button.Size = new System.Drawing.Size(49, 40);
            this.coma_button.TabIndex = 6;
            this.coma_button.Text = ",";
            this.coma_button.UseVisualStyleBackColor = true;
            this.coma_button.Click += new System.EventHandler(this.onComaClick);
            // 
            // six_button
            // 
            this.six_button.Location = new System.Drawing.Point(116, 246);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(49, 40);
            this.six_button.TabIndex = 9;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            // 
            // five_button
            // 
            this.five_button.Location = new System.Drawing.Point(61, 246);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(49, 40);
            this.five_button.TabIndex = 8;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // four_button
            // 
            this.four_button.Location = new System.Drawing.Point(10, 246);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(45, 40);
            this.four_button.TabIndex = 7;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // nine_button
            // 
            this.nine_button.Location = new System.Drawing.Point(116, 200);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(49, 40);
            this.nine_button.TabIndex = 12;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // eight_button
            // 
            this.eight_button.Location = new System.Drawing.Point(61, 200);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(49, 40);
            this.eight_button.TabIndex = 11;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // seven_button
            // 
            this.seven_button.Location = new System.Drawing.Point(10, 200);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(45, 40);
            this.seven_button.TabIndex = 10;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.onNumberClick);
            // 
            // c_button
            // 
            this.c_button.Location = new System.Drawing.Point(116, 154);
            this.c_button.Name = "c_button";
            this.c_button.Size = new System.Drawing.Size(49, 40);
            this.c_button.TabIndex = 15;
            this.c_button.Text = "C";
            this.c_button.UseVisualStyleBackColor = true;
            this.c_button.Click += new System.EventHandler(this.onClearClick);
            // 
            // ce_button
            // 
            this.ce_button.Location = new System.Drawing.Point(61, 154);
            this.ce_button.Name = "ce_button";
            this.ce_button.Size = new System.Drawing.Size(49, 40);
            this.ce_button.TabIndex = 14;
            this.ce_button.Text = "CE";
            this.ce_button.UseVisualStyleBackColor = true;
            this.ce_button.Click += new System.EventHandler(this.onClearClick);
            // 
            // backspace_button
            // 
            this.backspace_button.Location = new System.Drawing.Point(10, 154);
            this.backspace_button.Name = "backspace_button";
            this.backspace_button.Size = new System.Drawing.Size(45, 40);
            this.backspace_button.TabIndex = 13;
            this.backspace_button.Text = "backspace";
            this.backspace_button.UseVisualStyleBackColor = true;
            this.backspace_button.Click += new System.EventHandler(this.onClearClick);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(171, 338);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(49, 40);
            this.add_button.TabIndex = 16;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // substraction_button
            // 
            this.substraction_button.Location = new System.Drawing.Point(171, 291);
            this.substraction_button.Name = "substraction_button";
            this.substraction_button.Size = new System.Drawing.Size(49, 40);
            this.substraction_button.TabIndex = 17;
            this.substraction_button.Text = "-";
            this.substraction_button.UseVisualStyleBackColor = true;
            this.substraction_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // multiply_button
            // 
            this.multiply_button.Location = new System.Drawing.Point(171, 246);
            this.multiply_button.Name = "multiply_button";
            this.multiply_button.Size = new System.Drawing.Size(49, 40);
            this.multiply_button.TabIndex = 18;
            this.multiply_button.Text = "*";
            this.multiply_button.UseVisualStyleBackColor = true;
            this.multiply_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // divide_button
            // 
            this.divide_button.Location = new System.Drawing.Point(171, 200);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(49, 40);
            this.divide_button.TabIndex = 19;
            this.divide_button.Text = "/";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // plusminus_button
            // 
            this.plusminus_button.Location = new System.Drawing.Point(171, 154);
            this.plusminus_button.Name = "plusminus_button";
            this.plusminus_button.Size = new System.Drawing.Size(49, 40);
            this.plusminus_button.TabIndex = 20;
            this.plusminus_button.Text = "+|-";
            this.plusminus_button.UseVisualStyleBackColor = true;
            this.plusminus_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // sqrt_button
            // 
            this.sqrt_button.Location = new System.Drawing.Point(226, 154);
            this.sqrt_button.Name = "sqrt_button";
            this.sqrt_button.Size = new System.Drawing.Size(49, 40);
            this.sqrt_button.TabIndex = 21;
            this.sqrt_button.Text = "sqrt";
            this.sqrt_button.UseVisualStyleBackColor = true;
            this.sqrt_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // percent_button
            // 
            this.percent_button.Location = new System.Drawing.Point(226, 200);
            this.percent_button.Name = "percent_button";
            this.percent_button.Size = new System.Drawing.Size(49, 40);
            this.percent_button.TabIndex = 22;
            this.percent_button.Text = "x^2";
            this.percent_button.UseVisualStyleBackColor = true;
            this.percent_button.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(226, 246);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(49, 40);
            this.button22.TabIndex = 23;
            this.button22.Text = "1/x";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.onOperationClick);
            // 
            // equal_button
            // 
            this.equal_button.Location = new System.Drawing.Point(226, 291);
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
            this.display.Location = new System.Drawing.Point(10, 12);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(375, 91);
            this.display.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onNumberClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onNumberClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onNumberClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(116, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onNumberClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(116, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.onNumberClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 40);
            this.button6.TabIndex = 13;
            this.button6.Text = "MC";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.onMemoryButtonClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(61, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 40);
            this.button7.TabIndex = 14;
            this.button7.Text = "MR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.onMemoryButtonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(116, 109);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 40);
            this.button8.TabIndex = 15;
            this.button8.Text = "MS";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.onMemoryButtonClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(171, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 40);
            this.button9.TabIndex = 20;
            this.button9.Text = "M+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.onMemoryButtonClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(226, 109);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 40);
            this.button10.TabIndex = 21;
            this.button10.Text = "M-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.onMemoryButtonClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(281, 109);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 40);
            this.button11.TabIndex = 26;
            this.button11.Text = "n!";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(281, 155);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(49, 40);
            this.button12.TabIndex = 27;
            this.button12.Text = "y root x";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(281, 201);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(49, 40);
            this.button13.TabIndex = 28;
            this.button13.Text = "x^y";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(281, 247);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(49, 40);
            this.button14.TabIndex = 28;
            this.button14.Text = "e^x";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.onOperationClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(281, 291);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(49, 40);
            this.button15.TabIndex = 28;
            this.button15.Text = "sin(x)";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.onTregonometricClick);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(281, 337);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(49, 40);
            this.button16.TabIndex = 28;
            this.button16.Text = "cos(x)";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.onTregonometricClick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(336, 109);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(49, 40);
            this.button17.TabIndex = 28;
            this.button17.Text = "%";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.onPercentClick);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(336, 337);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(49, 40);
            this.button18.TabIndex = 28;
            this.button18.Text = "tan(x)";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.onTregonometricClick);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(336, 291);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(49, 40);
            this.button19.TabIndex = 28;
            this.button19.Text = "π";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.onPiButtonClick);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(336, 247);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(49, 40);
            this.button20.TabIndex = 28;
            this.button20.Text = "e";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.onEButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 438);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.display);
            this.Controls.Add(this.equal_button);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.percent_button);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.sqrt_button);
            this.Controls.Add(this.plusminus_button);
            this.Controls.Add(this.divide_button);
            this.Controls.Add(this.multiply_button);
            this.Controls.Add(this.substraction_button);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.c_button);
            this.Controls.Add(this.button6);
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
    }
}

