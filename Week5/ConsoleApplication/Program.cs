using System;
using ConsoleApplication.Model;

namespace ConsoleApplication {
	internal class Program {
		public static void Main(string[] args) {
			Game.init();
			while (Game.alive) {
				Game.draw();
				var button = Console.ReadKey();
				switch (button.Key) {
					case ConsoleKey.UpArrow:
						Game.snake.move(0, -1);
						break;
					case ConsoleKey.DownArrow:
						Game.snake.move(0, 1);
						break;
					case ConsoleKey.RightArrow:
						Game.snake.move(1, 0);
						break;
					case ConsoleKey.LeftArrow:
						Game.snake.move(-1, 0);
						break;
					case ConsoleKey.Escape:
						Game.alive = false;
						break;
					case ConsoleKey.F2:
						Game.saveGame();
						break;
					case ConsoleKey.F3:
						Game.loadGame();
						break;
				}
			}
		}
	}
}
