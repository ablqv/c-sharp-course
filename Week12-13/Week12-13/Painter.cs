using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Week12_13
{
    public class Painter
    {
        public enum Operation
        {
            Pencil, Line, Fill, Ellipse, Rhombus, Rectangle, Triangle, Erase
        }

        public Operation CurrentOperation;
        private Pen Pen;
        public Color color;
        public Queue<Point> queue = new Queue<Point>();
        private int[,] usedFill = new int[2000, 2000];
        private int fillTimer = 1;

        public void setColor(Color c)
        {
            color = c;
            Pen = new Pen(c);
        }

        public void setWidth(int width)
        {
            Width = width;
            Pen = new Pen(color, width);
        }

        public int Width;

        public SortedDictionary<string, Operation> Operations = new SortedDictionary<string, Operation>();

        public Graphics G { get; set; }
        public GraphicsPath GP { get; set; }

        public Bitmap bitmap;
        private PictureBox pictureBox;

        private bool Clicked = false;
        private Point prevPoint;

        public Painter(PictureBox pictureBox, Bitmap bmp = null)
        {
            this.pictureBox = pictureBox;

            if (bmp == null)
                bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            else
                bitmap = bmp;
            pictureBox.Image = bitmap;
            setColor(Color.Red);
            G = Graphics.FromImage(bitmap);
            GP = new GraphicsPath();
            CurrentOperation = Operation.Pencil;

            Operations["Pencil"] = Operation.Pencil;
            Operations["Line"] = Operation.Line;
            Operations["Fill"] = Operation.Fill;
            Operations["Ellipse"] = Operation.Ellipse;
            Operations["Rhombus"] = Operation.Rhombus;
            Operations["Rectangle"] = Operation.Rectangle;
            Operations["Triangle"] = Operation.Triangle;
            Operations["Erase"] = Operation.Erase;
        }

        public void MouseDown(MouseEventArgs mouseEventArgs)
        {
            if (CurrentOperation == Operation.Fill)
            {
                Fill(mouseEventArgs.Location.X, mouseEventArgs.Location.Y);
                pictureBox.Refresh();
                return;
            }
            Clicked = true;
            prevPoint = mouseEventArgs.Location;
        }

        private void Fill(int x, int y)
        {
            queue.Enqueue(new Point(x, y));
            Color inBegColor = bitmap.GetPixel(x, y);
            // ++fillTimer;
            // GP.Reset();
            while (queue.Count > 0) // BFS
            {
                Point v = queue.Dequeue();
                Check(v.X-1,v.Y,inBegColor);
                Check(v.X+1, v.Y, inBegColor);
                Check(v.X, v.Y-1, inBegColor);
                Check(v.X, v.Y+1, inBegColor);
            }
            // G.DrawPath(Pen, GP);
            pictureBox.Refresh();
        }

        private void Check(int x, int y, Color getPixel)
        {
            if (x <= 0 || y <= 0 || x >= pictureBox.Width || y >= pictureBox.Height) return;
            if (getPixel != bitmap.GetPixel(x, y)) return;
            bitmap.SetPixel(x, y, color);
            // usedFill[x, y] = fillTimer;
            // GP.AddLine(x, y, x, y);
            queue.Enqueue(new Point(x, y));
        }

        public void MouseUp(MouseEventArgs e)
        {
            Clicked = false;
            if (GP != null)
                G.DrawPath(Pen, GP);
            pictureBox.Refresh();
        }

        public void MouseMove(MouseEventArgs e)
        {
            if (!Clicked) return;
            switch (CurrentOperation)
            {
                case Operation.Pencil:
                    G.DrawLine(Pen, prevPoint, e.Location);
                    prevPoint = e.Location;
                    break;
                case Operation.Erase:
                    G.FillEllipse(Brushes.White, prevPoint.X - Width / 2, prevPoint.Y - Width / 2, Width + 20, Width + 20);
                    prevPoint = e.Location;
                    break;
                case Operation.Triangle:
                    GP.Reset();
                    if (e.Location.X >= prevPoint.X && e.Location.Y >= prevPoint.Y) {
                        GP.AddPolygon(new Point[]
                        {
                            new Point(e.Location.X, e.Location.Y),
                            new Point(prevPoint.X, e.Location.Y),
                            new Point(prevPoint.X, prevPoint.Y)
                        });
                    }
                    else if (e.Location.X <= prevPoint.X && e.Location.Y >= prevPoint.Y)
                    {
                        GP.AddPolygon(new Point[]
                        {
                            new Point(e.Location.X, e.Location.Y),
                            new Point(e.Location.X, prevPoint.Y),
                            new Point(prevPoint.X, e.Location.Y)
                        });
                    }
                    else if (e.Location.Y <= prevPoint.Y && e.Location.X <= prevPoint.X)
                    {
                        GP.AddPolygon(new Point[]
                        {
                            new Point(e.Location.X, e.Location.Y),
                            new Point(e.Location.X, prevPoint.Y),
                            new Point(prevPoint.X, prevPoint.Y)
                        });
                    }
                    else
                    {
                        GP.AddPolygon(new Point[]
                        {
                            new Point(prevPoint.X, e.Location.Y),
                            new Point(e.Location.X, prevPoint.Y),
                            new Point(prevPoint.X, prevPoint.Y)
                        });
                    }
                    break;
                case Operation.Line:
                    GP.Reset();
                    GP.AddLine(prevPoint, e.Location);
                    break;
                case Operation.Ellipse:
                    GP.Reset();
                    GP.AddEllipse(new Rectangle(prevPoint.X, prevPoint.Y, 
                        e.Location.X - prevPoint.X, e.Location.Y - prevPoint.Y));
                    break;
                case Operation.Rhombus:
                    GP.Reset();
                    GP.AddPolygon(new Point[]{
                        e.Location,
                        new Point((e.Location.X - prevPoint.X) / 2 + prevPoint.X, (e.Location.Y - prevPoint.Y) * 2 + prevPoint.Y),
                        new Point(prevPoint.X, e.Location.Y),
                        new Point((e.Location.X - prevPoint.X) / 2 + prevPoint.X, prevPoint.Y)
                    });
                    break;
                case Operation.Rectangle:
                    GP.Reset();
                    GP.AddPolygon(new Point[]{
                        e.Location,
                        new Point(prevPoint.X, e.Location.Y),
                        new Point(prevPoint.X, prevPoint.Y),
                        new Point(e.Location.X, prevPoint.Y)
                    });
                    break;
            }
            pictureBox.Refresh();
        }

        public void pictureBoxPaint(PaintEventArgs paintEventArgs)
        {
            if (GP != null)
                paintEventArgs.Graphics.DrawPath(Pen, GP);
        }
    }
}