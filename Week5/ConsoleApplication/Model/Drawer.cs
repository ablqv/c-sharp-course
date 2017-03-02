using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication.Model {
	[Serializable]
	public class Drawer : SerializableObject {
		public ConsoleColor color { get; set; }

		public List<Point> body { get; set; } = new List<Point>();

		public char sign { get; set; } = 'o';

		public Drawer() {}

		public Drawer(ConsoleColor color, List<Point> body, char sign) {
			this.color = color;
			this.body = body;
			this.sign = sign;
		}

		public void draw() {
			Console.ForegroundColor = color;
			foreach (var p in body) {
				Console.SetCursorPosition(p.X, p.Y);
				Console.Write(sign);
			}
		}
	}
}