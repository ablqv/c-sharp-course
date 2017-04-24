using System;
using System.Drawing;
using System.Windows.Forms;

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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            _game.ProcessKeyDown(e.KeyCode);
        }
    }
}
