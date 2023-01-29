using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Course
    {
        public Course(string name, DateTime startData,string lecturer)
        {
            Name = name;
            StartData = startData;
            Lecturer = lecturer;
        }
        public string Name { get; set; }

        public DateTime StartData { get; set; }

        public string Lecturer { get; set; }


        public void PrintCourseInfo(string name,DateTime startData,string lecturer)
        {
            Console.WriteLine($"The name of course is {name}");
            Console.WriteLine($"Date of start is {startData}");
            Console.WriteLine($"Lecturer is {lecturer}");
        }
    }
}
