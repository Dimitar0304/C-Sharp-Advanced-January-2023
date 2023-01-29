using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Student
    {
        //fields
        private string id = "04";

        public Student(string name,int age , double grade,double avrgGrade,List<Course>courses)
        {
            this.Name = "Dimitar";
            this.Age = 18;
            this.Grade = 4.5;
            AvrgGrade = avrgGrade;
            Courses = courses;

        }
        public Student(string name,int age,double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public double Grade { get; set; }
        public double AvrgGrade { get; set; }
        public List<Course> Courses = new List<Course>();

        public void PrintStudentInfo(string name,int age, double grade)
        {
            Console.Write($"The student: {name}");
            Console.Write($" is {age} old");
            Console.Write($"with grade {grade}.");
        }
    }
}
