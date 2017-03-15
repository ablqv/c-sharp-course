using System;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    internal class Calculator
    {
        private TextBox textBox;
        private double result, secondOperand;
        enum Operation
        {
            Add, Substract, Divide, Multiply, Empty
        }
        Operation operation;

        public Calculator() {
            Init();
        }

        private void Init()
        {
            operation = Operation.Empty;
            result = secondOperand = 0;
        }

        public void setTextBox(TextBox textBox)
        {
            this.textBox = textBox;
            textBox.Text = "0";
        }
        public TextBox getTextBox()
        {
            return textBox;
        }
        public void onNumberClick(string number)
        {
            if (textBox.Text == "0") textBox.Text = number;
            else
            textBox.Text += number;
        }
        public void onOperationClick(string op)
        {
            if (textBox.Text[textBox.Text.Length - 1] == ',')
                textBox.Text += "0";
            result = double.Parse(textBox.Text);
            switch(op)
            {
                case "+":
                    operation = Operation.Add;
                    textBox.Text = "";
                    break;
                case "-":
                    operation = Operation.Substract;
                    textBox.Text = "";
                    break;
                case "/":
                    operation = Operation.Divide;
                    textBox.Text = "";
                    break;
                case "*":
                    operation = Operation.Multiply;
                    textBox.Text = "";
                    break;
                case "sqrt":
                    result = Math.Sqrt(result);
                    textBox.Text = result.ToString();
                    break;
                case "x^2":
                    result *= (result);
                    textBox.Text = result.ToString();
                    break;
                case "+|-":
                    result = -result;
                    textBox.Text = result.ToString();
                    break;
                case "1/x":
                    result = 1.0 / result;
                    textBox.Text = result.ToString();
                    break;
            }
        }

        internal void onClearClick(string text)
        {
            if (text == "backspace")
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                if (textBox.Text == "")
                    textBox.Text = "0";
            }
            else
            {
                textBox.Text = "0";
                Init();
            }
        }

        internal void onEqualClick()
        {
            if (operation.Equals(Operation.Empty))
            {
                // result = double.Parse(textBox.Text);
                return;
            }
            secondOperand = double.Parse(textBox.Text);
            switch (operation)
            {
                case Operation.Add:
                    result += secondOperand;
                    break;
                case Operation.Substract:
                    result -= secondOperand;
                    break;
                case Operation.Divide:
                    result /= secondOperand;
                    break;
                case Operation.Multiply:
                    result *= secondOperand;
                    break;
            }
            operation = Operation.Empty;
            textBox.Text = result.ToString();
        }

        internal void onComaClick()
        {
            if (!textBox.Text.Contains(","))
            {
                textBox.Text += ",";
            }
        }
    }
}