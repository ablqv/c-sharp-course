using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication.Model {
	public class Wall : Drawer {
		public Wall(ConsoleColor color, List<Point> points, char c) : base(color, points, c) {
			loadLevel(1);
		}
		public Wall() {}

		public void loadLevel(int level) {
			var fileStream = new FileStream($@"Levels/{level}.dat", FileMode.Open, FileAccess.Read);
			var streamReader = new StreamReader(fileStream);
			var s = streamReader.ReadToEnd().Split('\n');
			for (var i = 0; i < s.Length; ++i) {
				for (var j = 0; j < s[i].Length; ++j) {
					if (s[i][j] == '#') {
						body.Add(new Point(j, i));
					}
				}
			}
			streamReader.Close();
			fileStream.Close();
		}
	}
}