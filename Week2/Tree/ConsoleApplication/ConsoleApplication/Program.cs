using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication {
	internal class Program {
		public static void printTree(DirectoryInfo dir, int d) {
			Console.WriteLine(new String('\t', d) + dir.Name);
			foreach (var e in dir.GetDirectories())
				printTree(e, d + 1);
			foreach (var e in dir.GetFiles())
				Console.WriteLine(new String('\t', d) + e.Name);
		}

		public static void printTreeStack(DirectoryInfo dir) {
			Stack<DirectoryInfo> st = new Stack<DirectoryInfo>();
			Stack<int> st2 = new Stack<int>();
			st.Push(dir);
			st2.Push(0);
			while (st.Count > 0) {
				int d = st2.Pop();
				DirectoryInfo cur = st.Pop();
				Console.WriteLine(new String('\t', d) + cur.Name);
				foreach (var e in cur.GetDirectories()) {
					st.Push(e);
					st2.Push(d + 1);
				}
				foreach (var e in cur.GetFiles())
					Console.WriteLine(new String('\t', d) + e.Name);
			}
		}

		public static void Main(string[] args) {
			DirectoryInfo directoryInfo = new DirectoryInfo(@"/home/aqali/progTech/input/");
			printTree(directoryInfo, 0);
			Console.WriteLine("/-------------------/");
			printTreeStack(directoryInfo);
		}
	}
}
