using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        Dictionary<Color, Color> nxtColor = new Dictionary<Color, Color>();
        
        public Form1()
        {
            InitializeComponent();
            nxtColor[Color.Red] = Color.Yellow;
            nxtColor[Color.Yellow] = Color.Blue;
            nxtColor[Color.Blue] = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = nxtColor[b.BackColor];
        }
    }
}
