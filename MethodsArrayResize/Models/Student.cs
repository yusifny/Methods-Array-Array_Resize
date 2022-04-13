using System;
namespace MethodsArrayResize.Models
{
	public class Student : Person
	{
		private static int _id;
        public int Id { get; }
		public string[] lesson;

        public Student(string name, string surname, byte age) :base(name, surname, age)
		{
			_id++;
			Id = _id;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Id {Id}\n Name: {Name}\n Surname: {Surname}\n Age: {Age}");
		}
	}
}

