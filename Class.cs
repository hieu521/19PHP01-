using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helllooo
{
    class Student
    {
        public int Id;
        public string FullName;
        public int Age;
        public string Grade;
        public string ClassName;
        public string Major;

        public Student(int id, string fullname, int age, string major, string className, string grade)
        {
            Id = id;
            FullName = fullname;
            Age = age;
            Major = major;
            ClassName = className;
            Grade = grade;
        }
        public override string ToString()
        {
            string result = $"id: {Id}|| full name :{FullName}||age:{Age}||major:{Major}||class:{ClassName}||grade: {Grade}/n";
            return result;
        }

    }
}
