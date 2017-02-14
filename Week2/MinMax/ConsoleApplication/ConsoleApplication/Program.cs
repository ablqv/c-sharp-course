using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication {
	internal class Program {
		public static void Main(string[] args) {
			FileStream fileStream = new FileStream(@"/home/aqali/progTech/input/minMax.txt", FileMode.Open, FileAccess.Read);
			StreamReader streamReader = new StreamReader(fileStream);
			int[] a = Array.ConvertAll(streamReader.ReadLine().Split(), int.Parse);
			Console.WriteLine("Minumum is " + a.Min());
			Console.WriteLine("Maximum is " + a.Max());
		}
	}
}
