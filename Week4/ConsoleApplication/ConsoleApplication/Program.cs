using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ConsoleApplication {
	internal class Program {
		public static void Main(string[] args) {
			Console.WriteLine("BinaryFormatter serialization/deserialization\n");
			binaryFormatterExample();
		}

		private static void binaryFormatterExample() {
			// Serialization
			var a = new Complex(12, 256);
			var b = new Complex(70, 87);
			var c = new Complex(8754, 8762);
			var fileStream = new FileStream("data.bf", FileMode.Create);
			var binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(fileStream, a);
			binaryFormatter.Serialize(fileStream, b);
			binaryFormatter.Serialize(fileStream, c);
			fileStream.Close();
			fileStream = new FileStream("data.bf", FileMode.Open, FileAccess.Read);
			// Deserialization
			var newA = binaryFormatter.Deserialize(fileStream) as Complex;
			var newB = binaryFormatter.Deserialize(fileStream) as Complex;
			var newC = binaryFormatter.Deserialize(fileStream) as Complex;
			Console.WriteLine(newA.Equals(a) ? "a is OK" : "a FAILED");
			Console.WriteLine(newB.Equals(b) ? "b is OK" : "b FAILED");
			Console.WriteLine(newC.Equals(c) ? "c is OK" : "c FAILED");
		}
	}
}
