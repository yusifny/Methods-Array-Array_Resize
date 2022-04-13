using System;
namespace MethodsArrayResize.Models
{
	public class Person
	{
		private byte _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age
		{
			get => _age;
			set
			{
                if (value>0)
                {
					_age = value;
                }
            }
		}

        public Person(string name, string surname, byte age)
		{
			Name = name;
			Surname = surname;
			Age = age;
		}
	}
}

