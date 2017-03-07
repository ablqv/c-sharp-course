using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ConsoleApplication {
	public class Problem2 {
		private static string path = @"/home/aqali/progTech/mid";
		public static void solve() {
			var d = new DirectoryInfo(path);
			var fs = new FileStream("result.txt", FileMode.Create, FileAccess.Write);
			var sw = new StreamWriter(fs);

			foreach (var file in d.GetFiles()) {
				var fileStream = new FileStream(path + "/" + file.Name, FileMode.Open);
				var sr = new StreamReader(fileStream);
				var s = sr.ReadToEnd();
				for (var i = 0; i + 3 <= s.Length; ++i)
					if (s.Substring(i, 3) == "yes") {
						sw.WriteLine(file.Name);
						break;
					}
				sr.Close();
				fileStream.Close();
			}
			sw.Close();
			fs.Close();
		}
	}
}