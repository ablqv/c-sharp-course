using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Xml.Serialization;

namespace ConsoleApplication.Model {
	[Serializable]
	public class Snake : Drawer {
		private static int killer = 4, currentScore = 1;
		private static int level = 1;
		private int dx, dy;

		public int Dx {
			get { return dx; }
			set {
				if (body[0].X + value == body[1].X && body[0].Y + dy == body[1].Y) {
					return;
				}
				dx = value;
			}
		}

		public int Dy {
			get { return dy; }
			set {
				if (body[0].X + dx == body[1].X && body[0].Y + value == body[1].Y) {
					return;
				}
				dy = value;
			}
		}

		public Snake(ConsoleColor color, List<Point> points, char c) : base(color, points, c) {
			generateSnake();
			dx = dy = 0;
		}

		public Snake() {
			dx = dy = 0;
		}

		public void move() {
			while (Game.alive) {
				for (var i = body.Count - 1; i > 0; --i) {
					body[i] = body[i - 1].Clone();
				}
				body[0].X = (body[0].X + dx + 70) % 70;
				body[0].Y = (body[0].Y + dy + 35) % 35;
				if (canEat(Game.food)) {
					Game.food.body = new List<Point> {Food.getRandLocation()};
				}
				else {
					if (intersectsWithWall()) {
						Game.alive = false;
						Console.WriteLine("WHA1");
						Thread.Sleep(5000);
					}
					else {
						if (intersectsWithSelf()) {
							Game.alive = false;
							Console.WriteLine("WHA2");
							Thread.Sleep(5000);
						}
					}
				}
				if (currentScore % killer == 0) {
					currentScore = 1;
					Game.wall.loadLevel(++level);
					Game.panel.Level = level;
				}
				Game.draw();
				Thread.Sleep(300);
			}
		}

		private bool intersectsWithSelf() {
			return dx + dy != 0 && body.Select(e => body.Count(f => f.Equals(e))).Any(cnt => cnt > 1);
		}

		private bool intersectsWithWall() {
			return body.Any(e => Game.wall.body.Contains(e));
		}

		private bool intersectsWithWall(Point pt) {
			return body.Any(e => Game.wall.body.Contains(pt));
		}

		public bool canEat(Food f) {
			if (body[0].Equals(f.body[0])) {
				body.Add(f.body[0]);
				currentScore++;
				Game.panel.Score++;
				return true;
			}
			return false;
		}

		public void draw() {
			base.draw();
			Console.SetCursorPosition(body[0].X, body[0].Y);
			Console.Write(char.ToUpper(sign));
		}

		public void generateSnake() {
			var pt = new Point(new Random().Next(1, 68), new Random().Next(1, 34));
			while (Game.wall != null && !intersectsWithWall(pt) && !intersectsWithWall(new Point(pt.X + 1, pt.Y)))
				pt = new Point(new Random().Next(1, 68), new Random().Next(1, 34));
			body = new List<Point> {pt, new Point(pt.X + 1, pt.Y)};
		}

		public void setDxDy(int ndx, int ndy) {
			if (body[0].X + ndx == body[1].X && body[0].Y + ndy == body[1].Y) {
				return;
			}
			dx = ndx;
			dy = ndy;
		}
	}
}
