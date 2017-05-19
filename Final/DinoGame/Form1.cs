using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoGame
{
    public partial class Form1 : Form
    {
        class Game
        {
            public class Dino
            {
                public int x, y;
                bool fallDown = false;
                public Dino() {
                    x = 100;
                    y = 100;
                }
                public void Jump()
                {
                    y -= 50;
                    fallDown = true;
                }
                public void Fall()
                {
                    if (fallDown)
                    {
                        y += 5;
                        if (y == 100)
                            fallDown = false;
                    }
                }
                public void Draw(Graphics e)
                {
                    e.FillPolygon(Brushes.Red, 
                        new Point[] { new Point(x - 20, y - 20),
                                      new Point(x - 20, y),
                                      new Point(x, y),
                                      new Point(x, y - 20) });
                }
            }
            class Tree
            {
                public int x, y;
                public Tree(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }
                public bool Move()
                {
                    x -= 5;
                    return x <= 0;
                }
                public void Draw(Graphics e)
                {
                    e.FillPolygon(Brushes.Green, new Point[] { new Point(x - 10, y - 10), new Point(x - 10, y), new Point(x, y), new Point(x, y - 10) });
                }
            }
            Timer t = new Timer();
            public Dino d = new Dino();
            List<Tree> l = new List<Tree>();
            Form context;
            public Game(Form context) {
                this.context = context;
            }
            public void Start()
            {
                t.Interval = 100;
                t.Tick += onTick;
                t.Enabled = true;
                t.Start();
            }

            int cur = 0;

            private void onTick(object sender, EventArgs e)
            {
                d.Fall();
                foreach (var v in l)
                {
                    v.Move();
                    if (Inside(d.x - 20, d.y - 20, d.x, d.y, v.x - 10, v.y - 10) ||
                        Inside(d.x - 20, d.y - 20, d.x, d.y, v.x - 10, v.y) ||
                        Inside(d.x - 20, d.y - 20, d.x, d.y, v.x, v.y - 10) ||
                        Inside(d.x - 20, d.y - 20, d.x, d.y, v.x, v.y))
                    {
                        t.Enabled = false;
                        t.Stop();
                        MessageBox.Show("Game over!\n" + d.x + " " + d.y + " " + v.x + " " + v.y);
                        context.Close();
                    }
                }
                ++cur;
                if (cur % 20 == 0)
                {
                    l.Add(new Tree(500, 100));
                }
                context.Refresh();
            }

            private bool Inside(int x1, int y1, int x2, int y2, int a, int b)
            {
                if (x1 <= a && a <= x2 && y1 <= b && b <= y2) return true;
                return false;
            }

            internal void Draw(Graphics e)
            {
                d.Draw(e);
                foreach (var v in l)
                    v.Draw(e);
            }
        }

        Game g;

        public Form1()
        {
            InitializeComponent();
            g = new Game(this);
            g.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                g.d.Jump();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Draw(e.Graphics);
        }
    }
}
