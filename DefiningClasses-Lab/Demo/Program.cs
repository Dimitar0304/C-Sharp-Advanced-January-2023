using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student mitkoBanchev = new Student("dimitar", 21, 2.4, 5.6, new List<Course>());
            mitkoBanchev.PrintStudentInfo(mitkoBanchev.Name, mitkoBanchev.Age, mitkoBanchev.Grade);

            //Student Dimitar = new Student("Dimitar", 18, 6.00);
            //Console.WriteLine(Dimitar.Name);
            //Console.WriteLine(Dimitar.Age);
            //Console.WriteLine(Dimitar.Grade);


            Course csharp = new Course("csharp", DateTime.Now, "Victor Dakov");
            mitkoBanchev.Courses.Add(csharp);
            Course javaFund = new Course("javaFundamentals", DateTime.Now, "Victor Dakov");
            mitkoBanchev.Courses.Add(javaFund);

            foreach (var course in mitkoBanchev.Courses)
            {
               course.PrintCourseInfo(course.Name,course.StartData,course.Lecturer);
            }

        }
    }
}
