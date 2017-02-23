using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication.Model {
	public class Food : Drawer {
		public Food(ConsoleColor color, List<Point> points, char c) : base(color, points, c) {}
		public Food() {}
		public static Point getRandLocation() {
			var pt = new Point(new Random().Next(1, 69), new Random().Next(1, 34));
			while (Game.snake != null && Game.snake.body.Contains(pt) ||
			       Game.wall != null && Game.wall.body.Contains(pt))
				pt = new Point(new Random().Next(1, 69), new Random().Next(1, 34));
			return pt;
		}
	}
}
