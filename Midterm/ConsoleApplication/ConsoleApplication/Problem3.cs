using System;
using System.Threading;

namespace ConsoleApplication {
	internal class Point {
		public int X { get; set; }
		public int Y { get; set; }
		public Point(int x, int y) {
			X = x;
			Y = y;
		}

		public void Draw(char c) {
			Console.SetCursorPosition(X, Y);
			Console.Write(c);
		}

		public Point GetNext(int dx, int dy) {
			var res = MemberwiseClone() as Point;
			res.X += dx;
			res.Y += dy;
			return res;
		}
	}
	public class Problem3 {
		private const int Height = 35;
		private const int Width = 70;
		private static Point pt;

		public static void solve() {
			Console.SetWindowSize(Height + 1, Width + 1);
			Console.CursorVisible = false;
			Console.Clear();
			for (int i = 0; i < Height; ++i) {
				Console.SetCursorPosition(0, i);
				Console.Write('#');

				Console.SetCursorPosition(Width - 1, i);
				Console.Write('#');
			}

			for (int i = 0; i < Width; ++i) {
				Console.SetCursorPosition(i, 0);
				Console.Write('#');

				Console.SetCursorPosition(i, Height - 1);
				Console.Write('#');
			}
			Console.WriteLine();

			var thread = new Thread(Move);
			thread.Start();
		}

		private static void Move() {
			int dx = -1, dy = -1;
			pt = new Point(5, 7);

			while (true) {
				pt.Draw(' ');
				var nxt = pt.GetNext(dx, dy);
				if (nxt.X > 0 && nxt.X < Width - 1 && nxt.Y > 0 && nxt.Y < Height - 1) {
					pt = nxt;
				}
				else {
					if (nxt.X == Width - 1 || nxt.X == 0) {
						dx = -dx;
					}
					else {
						dy = -dy;
					}
				}
				pt.Draw('o');
				Thread.Sleep(50);
			}
		}
	}
}