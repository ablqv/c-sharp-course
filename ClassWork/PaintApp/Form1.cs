using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        private GraphicsPath gp;

        Button[][] btn;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            btn = new Button[10][];
            int row = 50, col, cnt = 0;
            for (int i = 0; i < 5; ++i)
            {
                btn[i] = new Button[10];
                col = 50;
                for (int j = 0; j < 5; ++j)
                {
                    btn[i][j] = new Button();
//                    btn[i][j].Text = (++cnt).ToString();
                    btn[i][j].Click += onButtonClick;
                    btn[i][j].Name = i + ":" + j;
                    btn[i][j].Location = new Point(col, row);
                    btn[i][j].Size = new Size(40, 40);
                    btn[i][j].BackColor = Color.Black;

//                    Controls.Add(btn[i][j]);
                    col += 60;
                }
                row += 60;
            }
        }

        private int lx = -1, ly = -1;

        public void onButtonClick(object sender, EventArgs e)
        {
            Button cur = sender as Button;
            int x = int.Parse(cur.Name.Split(':')[0]);
            int y = int.Parse(cur.Name.Split(':')[1]);
            if (lx != -1)
                onPush(lx, ly);
            onPush(x, y);
            lx = x;
            ly = y;
        }

        private void onPush(int x, int y)
        {
            if (btn[x][y].BackColor == Color.Black)
                btn[x][y].BackColor = Color.Red;
            else
                btn[x][y].BackColor = Color.Black;
            for (int i = 0; i < 5; ++i)
            {
                if (y != i)
                {
                    if (btn[x][i].BackColor == Color.Black)
                        btn[x][i].BackColor = Color.Red;
                    else
                        btn[x][i].BackColor = Color.Black;
                }
                if (i != x)
                {
                    if (btn[i][y].BackColor == Color.Black)
                        btn[i][y].BackColor = Color.Red;
                    else
                        btn[i][y].BackColor = Color.Black;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            gp = new GraphicsPath();
            gp.AddEllipse(e.Location.X - 50, e.Location.Y - 50, 100, 100);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gp != null)
                e.Graphics.DrawPath(new Pen(Color.Red), gp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private int angle = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle++;
            angle %= 360;
            if (angle == 0)
                angle = 360;

//            MessageBox.Show(angle + "");
            gp = new GraphicsPath();
            double rad = angle * 360 / Math.PI;
            double xn = 200 + 60 * Math.Cos(rad);
            double yn = 200 + 60 * Math.Sin(rad);

            gp.AddLine((int) xn, (int) yn, 200, 200);
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
