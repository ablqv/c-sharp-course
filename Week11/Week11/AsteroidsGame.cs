using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Week11
{
    internal class AsteroidsGame
    {
        const int H = 30, W = 30;

        internal class Star : GameObject
        {
            public GraphicsPath Gp, Gp2;

            public Star(float x, float y) : base()
            {
                this.X = x;
                this.Y = y;
                init();
            }

            public void init()
            {
                Gp = new GraphicsPath();
                Gp2 = new GraphicsPath();
                Gp.AddLine(X + W / 2, Y, X + W, Y + 3 * H / 4);
                Gp.AddLine(X, Y + 3 * H / 4, X + W, Y + 3 * H / 4);
                Gp.AddLine(X, Y + 3 * H / 4, X + W / 2, Y);

                Gp2.AddLine(X + W / 2, Y + H, X + W, Y + W / 4);
                Gp2.AddLine(X, Y + W / 4, X + W, Y + W / 4);
                Gp2.AddLine(X, Y + W / 4, X + W / 2, Y + H);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sb = new SolidBrush(Color.Red);
                e.FillPath(sb, Gp);
                e.FillPath(sb, Gp2);
            }
        }

        internal class Circle : GameObject
        {
            public float R;
            GraphicsPath _gp;

            public Circle(float x, float y, float r = 10) : base()
            {
                this.X = x;
                this.Y = y;
                this.R = r;
                init();
            }

            public void init()
            {
                _gp = new GraphicsPath();
                _gp.AddEllipse(X, Y, 2 * R, 2 * R);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sb = new SolidBrush(Color.White);
                e.FillPath(sb, _gp);
            }
        }

        internal class Bullet : GameObject
        {
            public float D, R;

            GraphicsPath _gp, _gp2;

            public Bullet(float x, float y, float d = 20, float r = 5) : base()
            {
                this.X = x;
                this.Y = y;
                this.D = d;
                this.R = r;
                init();
            }

            public void init()
            {
                _gp = new GraphicsPath();
                _gp2 = new GraphicsPath();
                Point[] pts = { new Point((int)(X + D), (int)(Y)), new Point((int)(X + D + R), (int)(Y + D)), new Point((int)(X + D), (int)(Y + 2 * D)), new Point((int)(X + D - R), (int)(Y + D)) };
                Point[] pts2 = { new Point((int)(X), (int)(Y + D)), new Point((int)(X + D), (int)(Y + D - R)), new Point((int)(X + 2 * D), (int)(Y + D)), new Point((int)(X + D), (int)(Y + D + R)) };
                _gp.AddPolygon(pts);
                _gp2.AddPolygon(pts2);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sb = new SolidBrush(Color.Green);
                e.FillPath(sb, _gp);
                e.FillPath(sb, _gp2);
            }
        }

        internal class Hexagon : GameObject
        {
            public float R;

            GraphicsPath _gp;

            public Hexagon(float x, float y, float r = 50) : base()
            {
                this.X = x;
                this.Y = y;
                this.R = r;
                init();
            }

            public void init()
            {
                Point[] pts = { new Point((int)(X - R / 2), (int)(Y - Math.Sqrt(3) * R / 2)), new Point((int)(X + R / 2), (int)(Y - Math.Sqrt(3) * R / 2)), new Point((int)(X + R), (int)(Y)), new Point((int)(X + R / 2), (int)(Y + Math.Sqrt(3) * R / 2)), new Point((int)(X - R / 2), (int)(Y + Math.Sqrt(3) * R / 2)), new Point((int)(X - R), (int)(Y)) };
                _gp = new GraphicsPath();
                _gp.AddPolygon(pts);
            }

            public void Draw(Graphics e)
            {
                SolidBrush br = new SolidBrush(Color.Yellow);
                e.FillPath(br, _gp);
            }

        }

        internal class Gun : GameObject
        {
            public int X, Y, R, E;
            GraphicsPath _gp;

            public Gun(int x, int y, int r = 15, int e = 5) : base()
            {
                this.X = x;
                this.Y = y;
                this.R = r;
                this.E = e;
                init();
            }

            public void init()
            {

                Point[] pt =
                {
                    new Point(X, Y - R), new Point(X + 2 * E, Y - E),
                    new Point(X + E, Y - E), new Point(X + E, Y + R),
                    new Point(X - E, Y + R), new Point(X - E, Y - E),
                    new Point(X - 2 * E, Y - E)
                };
                _gp = new GraphicsPath();
                _gp.AddPolygon(pt);
            }

            public void Draw(Graphics e)
            {
                SolidBrush br = new SolidBrush(Color.Green);

                e.FillPath(br, _gp);
            }
        }

        public void DrawObjects(Graphics e)
        {
            hexagon.Draw(e);
            gun.Draw(e);
            for (int i = 0; i < num; ++i)
            {
                circles[i].Draw(e);
                stars[i].Draw(e);
                bullets[i].Draw(e);
            }
        }

        public void MoveObjects()
        {
            for (int i = 0; i < num; ++i)
            {
                circles[i].Move(Height, Width);
                stars[i].Move(Height, Width);
                bullets[i].Move(Height, Width);

                circles[i].init();
                stars[i].init();
                bullets[i].init();
            }
            // MessageBox.Show(circles[0].X + " " + circles[0].Y);
        }

        private int num = 150;

        public AsteroidsGame(Form1 form)
        {
            Width = form.Width - 55;
            Height = form.Height - 55;
            circles = new Circle[num + 1];
            stars = new Star[num + 1];
            bullets = new Bullet[num + 1];
            gun = new Gun(Width / 2, Height / 2);
            hexagon = new Hexagon(Width / 2, Height / 2);
            
            var rnd = new Random();

            for (int i = 0; i < num; ++i)
            {
                circles[i] = new Circle(rnd.Next() % Width, rnd.Next() % Height);
                stars[i] = new Star(rnd.Next() % Width, rnd.Next() % Height);
                bullets[i] = new Bullet(rnd.Next() % Width, rnd.Next() % Height);
            }
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public Circle[] circles;
        public Star[] stars;
        public Bullet[] bullets;
        public Gun gun;
        public Hexagon hexagon;
    }

    public class GameObject
    {
        public float X, Y;
        private int dx, dy;
        public int Dx
        {
            get => dx;
            set => dx = value;
        }

        public int Dy
        {
            get => dy;
            set => dy = value;
        }

        public GameObject()
        {
            dx = 10;
            dy = 10;
            if (new Random().Next() % 2 == 0) dx = -dx;
            if (new Random().Next() % 2 == 0) dy = -dy;
        }

        public void Move(int Height, int Width)
        {
            var nX = X + Dx;
            var nY = Y + Dy;
            if (nX > Width || nX < 0) Dx = -Dx;
            if (nY > Height || nY < 0) Dy = -Dy;
            X = X + Dx;
            Y = Y + Dy;
        }
    }
}
