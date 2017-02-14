namespace ConsoleApplication {
	public class Complex {
		private int a, b;
		public Complex() { }

		public Complex(int a, int b) {
			this.a = a;
			this.b = b;
		}

		public int A {
			get { return a; }
			set { a = value; }
		}

		public int B {
			get { return b; }
			set { b = value; }
		}

		public static Complex operator +(Complex c1, Complex c2) {
			return new Complex(c1.A + c2.A, c1.B + c2.B);
		}

		public override string ToString() {
			return a + "+" + b + "i";
		}
	}
}