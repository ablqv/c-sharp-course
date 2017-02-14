using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication {
	internal class Program {
		private static bool IsPrime(int e) {
			for (int i = 2; i * i <= e; ++i)
				if (e % i == 0)
					return false;
			return e != 1;
		}
		public static void Main(string[] args) {
			FileStream fileStream = new FileStream(@"/home/aqali/progTech/input/minPrime.txt", FileMode.Open, FileAccess.Read);
			StreamReader streamReader = new StreamReader(fileStream);
			int[] a = Array.ConvertAll(streamReader.ReadLine().Split(), int.Parse);
			int res = -1;
			foreach (var v in a) {
				if (IsPrime(v)) {
					if (res == -1) res = v;
					else {
						res = Math.Min(res, v);
					}
				}
			}
			if (res != -1)
				Console.WriteLine("Minimum prime number is " + res);
			else {
				Console.WriteLine("All numbers are composite");
			}
		}
	}
}
