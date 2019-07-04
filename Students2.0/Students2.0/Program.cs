using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }



    }
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Students> students = new List<Students>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(' ');
                string firstName = commandArgs[0];
                string lastName = commandArgs[1];
                string age = commandArgs[2];
                string hometown = commandArgs[3];
                if (IsStudentExisting(students, firstName, lastName))
                {
                    Students student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = int.Parse(age);
                    student.Hometown = hometown;
                }
                else
                {
                    Students student = new Students()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = int.Parse(age),
                        Hometown = hometown
                    };
                    students.Add(student);
                }

            }
            string selectedCity = Console.ReadLine();
            List<Students> filteredList = students.Where(s => s.Hometown == selectedCity).ToList();
            foreach (var item in filteredList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }

        static bool IsStudentExisting(List<Students> students, string firstName, string lastName)
        {
            foreach (var item in students)
            {
                if (item.FirstName == firstName && item.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Students GetStudent(List<Students> students, string firstName, string lastName)
        {
            Students existingStudent = null;
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
    }
}
