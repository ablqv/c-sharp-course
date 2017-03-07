using System;

namespace ConsoleApplication {
	public class Problem1 {
		public static void solve() {
			var s = Console.ReadLine();
			foreach (var i in s)
				if (int.Parse(i.ToString()) % 2 == 0)
					Console.Write(i + " ");
		}
	}
}