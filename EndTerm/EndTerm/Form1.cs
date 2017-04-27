using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndTerm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginString = textBox1.Text;
            string passwordString = textBox2.Text;

            if (loginString == "admin" && passwordString == "password123!")
            {
                MessageBox.Show(@"Successful login");
            }
            else
            {
                if (loginString == "" || passwordString == "")
                {
                    MessageBox.Show(@"Validation Error: Fields can not be empty");
                }
                else
                {
                    if (passwordString.Length < 8)
                    {
                        MessageBox.Show(@"Validation Error: Password should not be greater than 8");
                    }
                    else
                    {
                        MessageBox.Show(@"Login Error: Username or Password is wrong");
                    }
                }
            }
        }
    }
}
