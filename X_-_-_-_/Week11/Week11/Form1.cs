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
        private Graphics g;
        private static GraphicsPath gp;
        private static int x = 100;
        private static int y = 100;
        private static int[] dx = {1, 2, 2, 4, 4, 8, 16, 16, 32, 32};
        private static int[] dy = {1, 2, 2, 4, 4, 8, 16, 16, 32, 32};
        private int i = 0, t = 1, r = 1;
        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(Handle);
            gp = new GraphicsPath();
            gp.AddEllipse(x, y, 50, 50);
            timer1.Enabled = true;
            Refresh();
        }

        private int curx, cury;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            gp.AddLine(curx, cury, e.X, e.Y);
            curx = e.X;
            cury = e.Y;
            Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            curx = e.X;
            cury = e.Y;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color[] ar = {Color.Red, Color.Blue, Color.BlueViolet, Color.Crimson, Color.Yellow, Color.Green};
            SolidBrush sb = new SolidBrush(ar[new Random().Next(ar.Length)]);
            e.Graphics.FillPath(sb, gp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
//            x += dx[i] * t;
//            y += dy[i] * r;
//            ++i;
//            if (i == 10) i = 0;
//            if (x <= 0 || x >= 200) t = -t;
//            if (y <= 0 || y >= 200) r = -r;
            // gp = new GraphicsPath();
            // gp.ClearMarkers();
            // Week11.Form1.gp.AddEllipse(x, y, 50, 50);
            // Thread.Sleep(1000);
            Refresh();
            // Thread.Sleep(100);
        }
    }
}
