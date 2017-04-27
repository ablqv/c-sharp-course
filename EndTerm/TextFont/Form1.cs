using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Font = new Font("Arial", 2);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int val = trackBar1.Value;
            val = Math.Max(1, val);
            label2.Font = new Font("Arial", val * 2);
        }
    }
}
