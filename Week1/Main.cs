using System;

class Student {
	private string firstName, lastName;
	private int gpa;
	public Student() {}
	public Student(string firstName, string lastName, int gpa) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.gpa = gpa;
	}

	public string toString() {
		return firstName + " " + lastName + " " + gpa;
	}
}

class Sample {
	static void Main() {
		Student student = new Student("Yerkebulan", "Zhumagali", 4);

		Console.WriteLine(student.toString());
		// Console.WriteLine("Hello, world!");
	}
}
