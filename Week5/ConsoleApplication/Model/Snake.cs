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
		private static int killer = 4;
		private static int level = 1;

		public Snake(ConsoleColor color, List<Point> points, char c) : base(color, points, c) {
			generateSnake();
		}

		public Snake() {}

		public void move(int dx, int dy) {
			if (body[0].X + dx == body[1].X && body[0].Y + dy == body[1].Y) {
				return;
			}
			for (var i = body.Count - 1; i > 0; --i) {
				body[i] = body[i - 1].Clone();
			}
			body[0].X = (body[0].X + dx + 70) % 70;
			body[0].Y = (body[0].Y + dy + 35) % 35;
			if (canEat(Game.food)) {
				Game.food.body = new List<Point>{Food.getRandLocation()};
			}
			else {
				if (intersectsWithWall() || intersectsWithSelf()) {
					Game.alive = false;
				}
			}
			if (Game.snake.body.Count % killer == 0) {
				killer += killer;
				Game.wall.loadLevel(++level);
			}
		}

		private bool intersectsWithSelf() {
			return body.Select(e => body.Count(f => f.Equals(e))).Any(cnt => cnt > 1);
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
	}
}
