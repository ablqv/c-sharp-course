using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Week11
{
    public sealed partial class Form1 : Form
    {
        private AsteroidsGame _game;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _game.DrawObjects(e.Graphics);
        }

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Black;
            timer1.Enabled = true;
            _game = new AsteroidsGame(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _game.MoveObjects();
            Refresh();
        }
    }
}
