using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace ConsoleApplication.Model {
	[Serializable]
	public class Game {
		public static Snake snake;
		public static Food food;
		public static Wall wall;
		public static bool alive;
		public static Timer timer;
		public static Thread snakeMover, timerThread;
		public static int totalScore;
		public static Panel panel;

		public static void init() {
			Console.CursorVisible = false;
			Console.SetWindowSize(80, 40);

			alive = true;
			snake = new Snake(ConsoleColor.Yellow, new List<Point>(), 'o');
			food = new Food(ConsoleColor.Green, new List<Point>{Food.getRandLocation()}, '$');
			wall = new Wall(ConsoleColor.Red, new List<Point>(), '#');
			timer = new Timer(2, 0);

			timerThread = new Thread(timer.run);
			timerThread.Start();
			panel = new Panel(1, 2);
			draw();
			snakeMover = new Thread(snake.move);
			snakeMover.Start();
		}

		public static void draw() {
			Console.Clear();
			snake.draw();
			food.draw();
			wall.draw();
			timer.draw();
			panel.draw();
		}

		public static void saveGame() {
			doSerialization();
		}

		private static void doSerialization() {
			snake.save();
			wall.save();
			food.save();
			timer.save();
			panel.save();
		}

		public static void loadGame() {
			snakeMover.Abort();
			snake = (Snake) new Snake().load();
			wall = (Wall) new Wall().load();
			food = (Food) new Food().load();
			Console.Clear();
			Console.WriteLine("Heyyo");
			timer.kill(timerThread);
			timer = (Timer) new Timer().load();
			panel = (Panel) new Panel().load();
			timerThread = new Thread(timer.run);
			timerThread.Start();
			snakeMover = new Thread(snake.move);
			snakeMover.Start();
		}

		public static void onTimerFinished() {
			alive = false;
		}
	}
}
