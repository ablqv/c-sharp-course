using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        class Ball
        {
            Form context;
            public int x, y;
            public Ball(Form context) {
                this.context = context;
            }
            public Ball(int x, int y, Form context)
            {
                this.x = x - 25;
                this.y = y - 25;
                this.context = context;
            }
            public bool Move()
            {
                y += 10;
                if (y - 100 > context.Height)
                {
                    return false;
                }
                return true;
            }
            public void Draw(Graphics e)
            {
                e.FillEllipse(Brushes.Red, x, y, 50, 50);
            }
        }

        class FallingBall
        {
            public Ball b;
            Timer t;
            Form context;
            public FallingBall(Form context, int x, int y)
            {
                this.context = context;
                b = new Ball(x, y, context);
            }
            public void StartFalling()
            {
                t = new Timer();
                t.Tick += onTick;
                t.Interval = 100;
                t.Enabled = true;
                t.Start();
            }

            private void onTick(object sender, EventArgs e)
            {
                if (!b.Move())
                    t.Stop();
                context.Refresh();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        List<FallingBall> lst = new List<FallingBall>();

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var x in lst)
            {
                x.b.Draw(e.Graphics);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            FallingBall fb = new FallingBall(this, e.X, e.Y);
            fb.StartFalling();
            lst.Add(fb);
        }
    }
}
