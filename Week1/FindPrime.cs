using System;

class Sample {
	/**
	 * Sample program for printing all prime numbers given in arguments
	 **/
	
	
	/**
	 * check method checks if the given number is prime
	 */
	static bool check(int x) {
		for (int i = 2; i * i <= x; ++i) {
			if (x % i == 0)
				return false;
		}
		return true;
	}
				
	static void Main(string[] args) {
		/**
		 * Parse arguments
		 */
		for (int i = 0; i < args.Length; ++i) {
			if (check(Int32.Parse(args[i]))) { // Converting string value into
				Console.WriteLine(args[i]); // printing to console if args[i] is prime
			}
		}
	}
}
