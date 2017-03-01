using System;
using System.Threading;
using System.Xml.Serialization;
using ConsoleApplication.Model;

namespace ConsoleApplication {
	[Serializable]
	public class Timer : SerializableObject {
		private Thread thread;

		public Thread Thread {
			get { return thread; }
			set { thread = value; }
		}

		public int Minute { get; set; }
		public int Second { get; set; }
		public bool Alive { get; set; }

		public Timer(int minute, int second) {
			Minute = minute;
			Second = second;
			thread = new Thread(run);
			Alive = true;
		}

		public Timer() { }

		public void kill() {
			Alive = false;
			thread.Abort();
		}

		private void run(object obj) {
			while (Alive) {
				--Second;
				if (Second < 0) {
					--Minute;
					Second = 59;
				}
				draw();
				Thread.Sleep(1000);
				if (Minute + Second == 0) {
					Alive = false;
					Game.onTimerFinished();
				}
			}
		}

		public void draw() {
			Console.SetCursorPosition(1, 35);
			Console.WriteLine("Remaining time: {0}:{1}", Minute, Second);
		}

		public void Start() {
			thread = new Thread(run);
			thread.Start();
		}
	}
}
