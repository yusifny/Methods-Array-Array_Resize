using System;
namespace MethodsArrayResize.Models
{
	public class Teacher : Person
	{
		private int _experience;
		private static int _id;
        public int Id { get; }
        public int Experience
		{
			get => _experience;
            set
            {
				if (value >= 1 && value <= 80)
					_experience = value;
            }
		}

        public Teacher(int experience, string name, string surname, byte age) :base(name, surname, age)
		{
			_id++;
			Id = _id;
			Experience = experience;
		}

        public void ShowInfo()
        {
            Console.WriteLine($"Id {Id}\n Name: {Name}\n Surname: {Surname}\n Age: {Age} Experience: {Experience}");
        }
	}
}

