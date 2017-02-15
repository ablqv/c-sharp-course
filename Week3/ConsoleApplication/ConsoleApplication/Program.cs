using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace ConsoleApplication {
	internal class Program {
		private static DirectoryInfo directoryInfo;
		private static int cursor;
		private static ConsoleColor ConsoleBackgroundColor = ConsoleColor.Black;
		private static Stack<int> cursorStack;
		private static string additionalMessage;

		public static void Main(string[] args) {
			cursor = 0;
			directoryInfo = new DirectoryInfo(@"/home/aqali/progTech/input/");
			Console.BackgroundColor = ConsoleBackgroundColor;
			cursorStack = new Stack<int>();
			cursorStack.Push(cursor);
			additionalMessage = "To exit press F10";
			printWorkingDirectory();
			while (onKeyPressed(Console.ReadKey()));
		}

		private static bool onKeyPressed(ConsoleKeyInfo consoleKeyInfo) {
			additionalMessage = "To exit press F10";
			if (consoleKeyInfo.Key.Equals(ConsoleKey.F10)) {
				return false;
			}
			switch (consoleKeyInfo.Key) {
				case ConsoleKey.UpArrow:
					switchUp();
					break;
				case ConsoleKey.DownArrow:
					switchDown();
					break;
				case ConsoleKey.Enter:
					enter();
					break;
				case ConsoleKey.Escape:
					escape();
					break;
			}
			printWorkingDirectory();
			return true;
		}

		private static void printWorkingDirectory() {
			Console.Clear();
			int i = 0;
			if (cursor == i) {
				Console.BackgroundColor = ConsoleBackgroundColor;
				Console.ForegroundColor = ConsoleColor.Green;
			}
			Console.WriteLine("/..");
			++i;
			Console.BackgroundColor = ConsoleBackgroundColor;
			Console.ForegroundColor = ConsoleColor.White;
			foreach (var d in directoryInfo.GetDirectories()) {
				if (cursor == i) {
					Console.BackgroundColor = ConsoleBackgroundColor;
					Console.ForegroundColor = ConsoleColor.Green;
				}
				Console.WriteLine("/" + d.Name);
				Console.BackgroundColor = ConsoleBackgroundColor;
				Console.ForegroundColor = ConsoleColor.White;
				++i;
			}
			foreach (var f in directoryInfo.GetFiles()) {
				if (cursor == i) {
					Console.BackgroundColor = ConsoleBackgroundColor;
					Console.ForegroundColor = ConsoleColor.Green;
				}
				Console.WriteLine(f.Name);
				Console.BackgroundColor = ConsoleBackgroundColor;
				Console.ForegroundColor = ConsoleColor.White;
				++i;
			}
			Console.WriteLine("\n\n\n\n\n/------------/");
			Console.WriteLine("Hint: " + additionalMessage);
		}

		private static void escape() {
			if (cursorStack.Count <= 1) {
				additionalMessage = "Don't get out of sandbox";
				return;
			}
			directoryInfo = directoryInfo.Parent;
			cursorStack.Pop();
			cursor = cursorStack.Peek();
		}

		private static void enter() {
			if (cursor == 0) {
				escape();
				return;
			}
			if (cursor <= directoryInfo.GetDirectories().Length) {
				cursorStack.Push(cursor);
				directoryInfo = directoryInfo.GetDirectories()[cursor - 1];
				cursor = 0;
			} else {
				Console.Clear();
				var fileStream = new FileStream(directoryInfo.GetFiles()[cursor - directoryInfo.GetDirectories().Length - 1].FullName, FileMode.Open, FileAccess.Read);
				var streamReader = new StreamReader(fileStream);
				Console.WriteLine(streamReader.ReadToEnd());
				while (!Console.ReadKey(true).Key.Equals(ConsoleKey.Escape));
				fileStream.Close();
				streamReader.Close();
			}
		}

		private static void switchDown() {
			cursor = Math.Min(cursor + 1, (1 + directoryInfo.GetFiles().Length + directoryInfo.GetDirectories().Length) - 1);
		}

		private static void switchUp() {
			cursor = Math.Max(cursor - 1, 0);
		}
	}
}
