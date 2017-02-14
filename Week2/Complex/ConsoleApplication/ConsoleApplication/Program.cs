using System;
using System.Collections.Generic;

namespace ConsoleApplication {
	internal class Program {
		public static void Main(string[] args) {
			Complex a = new Complex(1, 2);
			Complex b = new Complex();
			b.A = 12;
			b.B = 7;
			var c = a + b;
			Console.WriteLine(c.ToString());
			Console.ReadKey();
		}
	}
}
