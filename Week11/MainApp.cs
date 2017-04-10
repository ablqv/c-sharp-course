using System;

namespace Week11
{
    public class AsteroidsGame
    {
        const int H = 50, W = 50;

        class Star : IDrawable
        {
            public float x, y;
            public GraphicsPath gp, gp2;

            public Star(float x, float y)
            {
                this.x = x;
                this.y = y;
                gp = new GraphicsPath();
                gp2 = new GraphicsPath();
                gp.AddLine(x + W / 2, y, x + W, y + 3 * H / 4);
                gp.AddLine(x, y + 3 * H / 4, x + W, y + 3 * H / 4);
                gp.AddLine(x, y + 3 * H / 4, x + W / 2, y);

                gp2.AddLine(x + W / 2, y + H, x + W, y + W / 4);
                gp2.AddLine(x, y + W / 4, x + W, y + W / 4);
                gp2.AddLine(x, y + W / 4, x + W / 2, y + H);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sb = new SolidBrush(Color.Red);
                e.FillPath(sb, gp);
                e.FillPath(sb, gp2);
            }
        }

        class Circle : IDrawable
        {
            public float x, y, r;
            GraphicsPath gp;

            public Circle(float x, float y, float r = 15)
            {
                this.x = x;
                this.y = y;
                this.r = r;
                gp = new GraphicsPath();
                gp.AddEllipse(x, y, 2 * r, 2 * r);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sb = new SolidBrush(Color.White);
                e.FillPath(sb, gp);
            }
        }

        class Bullet : IDrawable
        {
            public float x, y, d, r;

            GraphicsPath gp, gp2;

            public Bullet(float x, float y, float d = 30, float r = 10)
            {
                this.x = x;
                this.y = y;
                this.d = d;
                this.r = r;

                gp = new GraphicsPath();
                gp2 = new GraphicsPath();

                Point[] pts =
                {
                    new Point((int) (x + d), (int) (y)),
                    new Point((int) (x + d + r), (int) (y + d)),
                    new Point((int) (x + d), (int) (y + 2 * d)),
                    new Point((int) (x + d - r), (int) (y + d))
                };

                Point[] pts2 =
                {
                    new Point((int) (x), (int) (y + d)),
                    new Point((int) (x + d), (int) (y + d - r)),
                    new Point((int) (x + 2 * d), (int) (y + d)),
                    new Point((int) (x + d), (int) (y + d + r))
                };

                gp.AddPolygon(pts);
                gp2.AddPolygon(pts2);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sb = new SolidBrush(Color.Green);
                e.FillPath(sb, gp);
                e.FillPath(sb, gp2);
                //e.DrawPath(new Pen(Color.Red), gp2);
            }
        }

        class Hexagon : IDrawable
        {
            float x, y, r;

            GraphicsPath gp;

            public Hexagon(float x, float y, float r = 50)
            {
                this.x = x;
                this.y = y;
                this.r = r;
                Point[] pts =
                {
                    new Point((int) (x - r / 2), (int) (y - Math.Sqrt(3) * r / 2)),
                    new Point((int) (x + r / 2), (int) (y - Math.Sqrt(3) * r / 2)),
                    new Point((int) (x + r), (int) (y)),
                    new Point((int) (x + r / 2), (int) (y + Math.Sqrt(3) * r / 2)),
                    new Point((int) (x - r / 2), (int) (y + Math.Sqrt(3) * r / 2)),
                    new Point((int) (x - r), (int) (y))
                };
                gp = new GraphicsPath();
                gp.AddPolygon(pts);
            }

            public void Draw(Graphics e)
            {
                SolidBrush br = new SolidBrush(Color.Yellow);
                e.FillPath(br, gp);
            }

        }

        class Gun : IDrawable
        {
            int x, y, r, e;
            GraphicsPath gp;

            public Gun(int x, int y, int r = 15, int e = 5)
            {
                this.x = x;
                this.y = y;
                this.r = r;
                this.e = e;

                Point[] pt =
                {
                    new Point(x, y - r), new Point(x + 2 * e, y - e),
                    new Point(x + e, y - e), new Point(x + e, y + r),
                    new Point(x - e, y + r), new Point(x - e, y - e),
                    new Point(x - 2 * e, y - e)
                };
                gp = new GraphicsPath();
                gp.AddPolygon(pt);
            }

            public void Draw(Graphics e)
            {
                SolidBrush br = new SolidBrush(Color.Green);

                e.FillPath(br, gp);
            }
        }

        private Circle[] s;


        public AsteroidsGame()
        {
        }
    }
}