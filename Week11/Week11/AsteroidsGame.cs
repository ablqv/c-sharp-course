using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Week11
{
    internal class AsteroidsGame
    {
        private const int H = 30, W = 30;

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

            public Circle(float x, float y, float r = 20) : base()
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
            public int X, Y, R, E, Face;
            GraphicsPath _gp;
            public Point[] pt = new Point[5];

            public Gun(int x, int y, int r = 25, int e = 10, int Face = 0) : base()
            {
                this.X = x;
                this.Y = y;
                this.R = r;
                this.E = e;
                pt = new Point[]{
                    new Point(X, Y - R), new Point(X + 2 * E, Y - E),
                    new Point(X + E, Y - E), new Point(X + E, Y + R),
                    new Point(X - E, Y + R), new Point(X - E, Y - E),
                    new Point(X - 2 * E, Y - E)
                };
                init(Face);
            }

            public void init(int direction)
            {
                ++direction;
                switch (direction)
                {
                    case 1:
                        pt =
                    new Point[]{
                        new Point(X, Y - R), new Point(X + 2 * E, Y - E),
                        new Point(X + E, Y - E), new Point(X + E, Y + R),
                        new Point(X - E, Y + R), new Point(X - E, Y - E),
                        new Point(X - 2 * E, Y - E)
                    };
                        break;
                    case 2:
                        pt =
                            new Point[]{
                                new Point(X + R, Y), new Point(X + E , Y - 2 * E),
                                new Point(X + E, Y - E), new Point(X - R, Y - E),
                                new Point(X - R, Y + E), new Point(X + E, Y + E),
                                new Point(X + E, Y + 2 * E)
                            };
                        break;
                    case 3:
                        pt =
                            new Point[]{
                                new Point(X, Y + R), new Point(X - 2 * E, Y + E),
                                new Point(X - E, Y + E), new Point(X - E, Y - R),
                                new Point(X + E, Y - R), new Point(X + E, Y + E),
                                new Point(X + 2 * E, Y + E)
                            };
                        break;
                    case 4:
                        pt =
                            new Point[]{
                                new Point(X - R, Y), new Point(X - E , Y + 2 * E),
                                new Point(X - E, Y + E), new Point(X + R, Y + E),
                                new Point(X + R, Y - E), new Point(X - E, Y - E),
                                new Point(X - E, Y - 2 * E)
                            };
                        break;
                }
                _gp = new GraphicsPath();
                _gp.AddPolygon(pt);
            }

            public void Draw(Graphics e)
            {
                SolidBrush br = new SolidBrush(Color.Green);

                e.FillPath(br, _gp);
            }

            public void Rotate(int direction)
            {
                init(direction);
            }
        }

        internal class HexaGun : GameObject
        {
            private Gun gun;
            private Hexagon hexagon;
            private readonly int[] DirectionsX = {0, 1, 0, -1};
            private readonly int[] DirectionsY = {-1, 0, 1, 0};

            public Point GetHead()
            {
                return gun.pt[0];
            }

            public int Face { get; set; }

            public HexaGun(int x, int y)
            {
                X = x;
                Y = y;
                init();
                Face = 0;
                Dx = 0;
                Dy = -1;
            }

            public void Draw(Graphics e)
            {
                hexagon.Draw(e);
                gun.Draw(e);
            }

//            public void Move(int Height, int Width)
//            {
//                gun.Move(Height, Width);
//                hexagon.Move(Height, Width);
//            }

            public void Rotate(int direction)
            {
                Dx = DirectionsX[direction];
                Dy = DirectionsY[direction];
                gun.Rotate(direction);
            }

            public void init()
            {
                gun = new Gun((int)X, (int)Y, Face:Face);
                hexagon = new Hexagon(X, Y);
            }
        }

        public void Shoot()
        {
            var nxt = new Bullet(gun.GetHead().X, gun.GetHead().Y)
            {
                Dx = gun.Dx * 3,
                Dy = gun.Dy * 3
            };
            bullets.Add(nxt);
        }

        public void DrawObjects(Graphics e)
        {
            gun.Draw(e);
            foreach (var v in bullets)
                v.Draw(e);

            for (int i = 0; i < num; ++i)
            {
                circles[i].Draw(e);
                stars[i].Draw(e);
                // bullets[i].Draw(e);
            }
        }

        public void MoveObjects()
        {
            gun.Move(Height, Width);
            gun.init();
            for (int i = 0; i < num; ++i)
            {
                circles[i].Move(Height, Width);
                stars[i].Move(Height, Width);

                circles[i].init();
                stars[i].init();
            }
            List<Bullet> nxtBullets = new List<Bullet>();
            foreach (var v in bullets)
            {
                if (!v.Move(Height, Width))
                {
                    nxtBullets.Add(v);
                }
                v.init();
            }
            bullets = nxtBullets;
            // MessageBox.Show(circles[0].X + " " + circles[0].Y);
        }

        private int num = 5;

        public AsteroidsGame(Form1 form)
        {
            Width = form.Width - 55;
            Height = form.Height - 55;
            circles = new Circle[num + 1];
            stars = new Star[num + 1];
            gun = new HexaGun(Width / 2, Height / 2);
            
            var rnd = new Random();

            for (int i = 0; i < num; ++i)
            {
                circles[i] = new Circle(rnd.Next() % Width, rnd.Next() % Height);
                stars[i] = new Star(rnd.Next() % Width, rnd.Next() % Height);
                // bullets[i] = new Bullet(rnd.Next() % Width, rnd.Next() % Height);
            }
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public Circle[] circles;
        public Star[] stars;
        public List<Bullet> bullets = new List<Bullet>();
        public HexaGun gun;

        public void ProcessKeyDown(Keys eKeyCode)
        {
            switch (eKeyCode)
            {
                case Keys.Right:
                    gun.Face++;
                    break;
                case Keys.Left:
                    gun.Face--;
                    break;
                case Keys.Space:
                    Shoot();
                    break;
            }
            gun.Face = (gun.Face + 4) % 4;
            gun.Rotate(gun.Face);
        }
    }

    public class GameObject
    {
        public float X, Y;
        private int dx, dy;
        public Random rnd = new Random();
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
            dx = -(1 + rnd.Next(5));
            dy = 1 + rnd.Next(5);
            if (rnd.Next() % 2 == 0) dx = -dx;
            if (rnd.Next() % 2 == 0) dy = -dy;
        }

        public bool Move(int Height, int Width)
        {
            bool result = false;
            var nX = X + Dx;
            var nY = Y + Dy;
            if (nX > Width || nX < 0)
            {
                Dx = -Dx;
                result = true;
            }

            if (nY > Height || nY < 0)
            {
                Dy = -Dy;
                result = true;
            }
            X = X + Dx;
            Y = Y + Dy;
            return result;
        }
    }
}
