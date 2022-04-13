
using System;
namespace MethodsArrayResize.Models
{
	public class Group
	{
		public Student[] students;
		public int groupNo;

		public Group()
		{
			students = new Student[0];
		}

        public void AddStudent(Student student)
        {
			Array.Resize(ref students, students.Length + 1);
			students[students.Length - 1] = student;
        }

	}
}

