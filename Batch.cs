using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helllooo
{

    class Batch
    {
        private List<Student> students;
        public string Name;

        private Batch() { }
        public Batch(string name)
        {
            Name = name;
            students = new List<Student>();
        }

        public void AddStudent(int id, string fullname, int age, string major, string classname, string grade)
        {
            Student newStudent = new Student(id, fullname, age, major, classname, grade);
            students.Add(newStudent);
        }
        public string PrintAllStudentInfo()
        {
            string result = "";
            var studentSort = students.OrderBy(P => P.FullName);
            foreach (var item in studentSort)
            {
                result = result + item.ToString();
            }
            return result;

        }
        public bool RemoveStudentByGrade(string grade)
        {
            Student gradeStudent = students.FirstOrDefault(s => s.Grade.Equals(grade));
            Student gradeStudent1 = students.FirstOrDefault(s => s.Grade.Equals("D"));
            Student gradeStudent2 = students.FirstOrDefault(s => s.Grade.Equals("M"));
            Student gradesStudent3 = students.FirstOrDefault(s => s.Grade.Equals("P"));
            if (gradeStudent1 != null && gradeStudent == gradeStudent1)
            {
                students.Remove(gradeStudent);
                students.Remove(gradeStudent2);
                students.Remove(gradesStudent3);
                return true;

            }
            else if (gradeStudent != null && gradeStudent == gradeStudent2)
            {
                students.Remove(gradeStudent);
                students.Remove(gradesStudent3);
            }
            else if (gradeStudent != null && gradeStudent == gradesStudent3)
            {
                students.Remove(gradeStudent);
                return true;
            }
            return false;

        }
        public bool UpdateStudentById(int id, string fullname, int age, string major, string className, string grade)
        {
            Student studentInBatch = students.FirstOrDefault(s => s.Id.Equals(id));
            if (studentInBatch == null) return false;
            studentInBatch.FullName = fullname;
            studentInBatch.Age = age;
            studentInBatch.Major = major;
            studentInBatch.ClassName = className;
            studentInBatch.Grade = grade;
            return true;
        }
    }
}
