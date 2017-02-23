using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Threading;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ConsoleApplication.Model {
	[Serializable]
	public class Game {
		public static Snake snake;
		public static Food food;
		public static Wall wall;
		public static bool alive;

		public static void init() {
			Console.CursorVisible = false;
			Console.SetWindowSize(70, 35);

			snake = new Snake(ConsoleColor.Yellow, new List<Point>(), 'o');
			food = new Food(ConsoleColor.Green, new List<Point>{Food.getRandLocation()}, '$');
			wall = new Wall(ConsoleColor.Red, new List<Point>(), '#');
			alive = true;
		}

		public static void draw() {
			Console.Clear();
			snake.draw();
			food.draw();
			wall.draw();
		}

		public static void saveGame() {
			doSerialization();
			alive = false;
		}

		private static void doSerialization() {
			snake.save();
			wall.save();
			food.save();
		}

		public static void loadGame() {
			snake = (Snake) new Snake().load();
			wall = (Wall) new Wall().load();
			food = (Food) new Food().load();
		}
	}
}
