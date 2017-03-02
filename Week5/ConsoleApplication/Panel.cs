using System;

namespace ConsoleApplication {
	[Serializable]
	public class Panel : SerializableObject {
		public Panel(int level, int score) {
			Level = level;
			Score = score;
		}

		public Panel() { }

		public int Level { get; set; }

		public int Score { get; set; }

		public void draw() {
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.SetCursorPosition(1, 36);
			Console.WriteLine("Score: {0}", Score);

			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.SetCursorPosition(1, 37);
			Console.WriteLine("Level: {0}", Level);
		}
	}
}