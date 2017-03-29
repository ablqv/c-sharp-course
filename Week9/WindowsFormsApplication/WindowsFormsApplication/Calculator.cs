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
            Add, Substract, Divide, Multiply, Percent, Root, Power, Empty
        }
        Operation operation;
        private double E = Math.E;
        private double Pi = Math.PI;

        public double inMemory { get; private set; }

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
                case "n!":
                    double p = double.Parse(textBox.Text);
                    if (Math.Abs(p - Math.Floor(p)) < 1e-9)
                    {
                        double res = 1;
                        for (int i = 1; i <= p; ++i)
                            res = res * i;
                        textBox.Text = res.ToString();
                    }
                    break;
                case "y root x":
                    operation = Operation.Root;
                    textBox.Text = "";
                    break;
                case "x^y":
                    operation = Operation.Power;
                    textBox.Text = "";
                    break;
                case "e^x":
                    textBox.Text = Math.Pow(E, double.Parse(textBox.Text)).ToString();
                    break;
            }
        }

        internal void onPercentClick()
        {
            textBox.Text = (result * double.Parse(textBox.Text) / 100.0).ToString();
            onEqualClick();
        }

        internal void onTregonometricClick(object sender, EventArgs e)
        {
            String f = ((Button)sender).Text;
            switch (f[0])
            {
                case 's':
                    textBox.Text = Math.Sin(double.Parse(textBox.Text)).ToString();
                    break;
                case 'c':
                    textBox.Text = Math.Cos(double.Parse(textBox.Text)).ToString();
                    break;
                case 't':
                    textBox.Text = Math.Tan(double.Parse(textBox.Text)).ToString();
                    break;
            }
        }

        internal void onEButtonClick()
        {
            textBox.Text = E.ToString();
        }

        internal void onMemoryButtonClick(object sender, EventArgs e)
        {
            String text = ((Button)sender).Text.ToString();
            switch (text)
            {
                case "MC":
                    inMemory = 0;
                    break;
                case "MR":
                    textBox.Text = inMemory.ToString();
                    break;
                case "M+":
                    inMemory += double.Parse(textBox.Text.ToString());
                    break;
                case "M-":
                    inMemory -= double.Parse(textBox.Text.ToString());
                    break;
                case "MS":
                    inMemory = double.Parse(textBox.Text.ToString());
                    break;
            }
        }

        internal void onPiButtonClick()
        {
            textBox.Text = Pi.ToString();
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
                if (text == "C")
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
                case Operation.Root:
                    if (secondOperand != 0)
                        result = Math.Pow(result, 1.0 / secondOperand);
                    break;
                case Operation.Power:
                    result = Math.Pow(result, secondOperand);
                    break;
                case Operation.Percent:
                    secondOperand /= 100;
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