using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private Calculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
            calculator.setTextBox(display);
        }

        private void onNumberClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            calculator.onNumberClick(b.Text);
        }

        private void onOperationClick(object sender, EventArgs e)
        {
            calculator.onOperationClick(((Button)sender).Text);
        }

        private void onClearClick(object sender, EventArgs e)
        {
            calculator.onClearClick(((Button)sender).Text);
        }

        private void onEqualClick(object sender, EventArgs e)
        {
            calculator.onEqualClick();
        }

        private void onComaClick(object sender, EventArgs e)
        {
            calculator.onComaClick();
        }
    }
}
