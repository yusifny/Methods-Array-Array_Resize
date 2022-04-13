using System;
using MethodsArrayResize.Models;

namespace MethodsArrayResize
{
    class Program
    {
        static void Main(string[] args)
        {
            int experince;
            Console.WriteLine("Enter teacher's name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter teacher's surname");
            string surname = Console.ReadLine();
            byte age;

            do
            {
                Console.WriteLine("Experince");
                experince = Convert.ToInt32(Console.ReadLine());

            } while (experince<1 || experince>80);

            do
            {
                Console.WriteLine("Age");
                age = Convert.ToByte(Console.ReadLine());

            } while (age<0);

            Teacher teacher1 = new Teacher(experince, name, surname, age);

            teacher1.ShowInfo();

            Console.WriteLine("Enter student's name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter student's surname");
            string surname1 = Console.ReadLine();
            byte age1;

            do
            {
                Console.WriteLine("Age");
                age1 = Convert.ToByte(Console.ReadLine());

            } while (age1 < 0);

            Student student1 = new Student(name1, surname1, age1);

            Group group = new Group();
            group.AddStudent(student1);

            foreach (Student item in group.students)
            {
                Console.WriteLine(item.Name, item.Surname, item.Age);
            }

        }
    }
}

