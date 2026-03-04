using System;
using System.Collections.Generic;
using System.Text;

namespace Method_overloading
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static Student[] Students = new Student[5];
    }

    class Program
    {
        static void Main()
        {
            // Assigning values
            Student.Students[0] = new Student();
            Student.Students[0].Id = 1;
            Student.Students[0].Name = "Naresh";
            Student.Students[0].Age = 22;

            Student.Students[1] = new Student();
            Student.Students[1].Id = 2;
            Student.Students[1].Name = "Ravi";
            Student.Students[1].Age = 23;

            Student.Students[2] = new Student();
            Student.Students[2].Id = 3;
            Student.Students[2].Name = "Kiran";
            Student.Students[2].Age = 21;

            Student.Students[3] = new Student();
            Student.Students[3].Id = 4;
            Student.Students[3].Name = "Suresh";
            Student.Students[3].Age = 24;

            Student.Students[4] = new Student();
            Student.Students[4].Id = 5;
            Student.Students[4].Name = "Anil";
            Student.Students[4].Age = 22;

            //Calling using for loop
            for (int i = 0; i < Student.Students.Length; i++)
            {
                Console.WriteLine("Id: " + Student.Students[i].Id);
                Console.WriteLine("Name: " + Student.Students[i].Name);
                Console.WriteLine("Age: " + Student.Students[i].Age);
            }

            //Calling using foreach loop
            foreach (Student student in Student.Students)
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Age: " + student.Age);
             
            }
        }
    }

}
