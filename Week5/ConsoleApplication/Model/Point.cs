using System;

namespace ConsoleApplication.Model {
	[Serializable]
	public class Point : ICloneable {
		public int X { get; set; }
		public int Y { get; set; }
		public Point(int x, int y) {
			X = x;
			Y = y;
		}

		public Point() { }

		public override bool Equals(object obj) {
			var point = obj as Point;
			return point != null && X == point.X && Y == point.Y;
		}

		public override int GetHashCode() {
			return base.GetHashCode();
		}

		public Point Clone() {
			return (Point) MemberwiseClone();
		}

		object ICloneable.Clone() {
			return Clone();
		}
	}
}