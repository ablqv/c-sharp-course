using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cur = 0;

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int v = int.Parse(b.Text);
            ++v;
            if (v % 2 == 0)
            {
                ++cur;
                textBox1.Text = cur.ToString();
            }
            b.Text = v.ToString();
        }
    }
}
