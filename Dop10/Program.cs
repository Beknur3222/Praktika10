using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop10
{
    interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }

        string GetName();
        string GetFullName();
        double GetAvgGrade();
    }

    class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, string fullName, int[] grades)
        {
            Name = name;
            FullName = fullName;
            Grades = grades;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public double GetAvgGrade()
        {
            if (Grades == null || Grades.Length == 0)
            {
                return 0.0;
            }

            int sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }

            return (double)sum / Grades.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            int[] grades = { 90, 85, 92, 88, 95 };
            IStudent student = new Student("Beknur", "Beknur Sattar", grades);

            Console.WriteLine($"Name: {student.GetName()}");
            Console.WriteLine($"Full Name: {student.GetFullName()}");
            Console.WriteLine($"Average Grade: {student.GetAvgGrade()}");
            Console.ReadKey();
        }
    }
}
