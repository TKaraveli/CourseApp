using System.Collections.Generic;

namespace CourseApp.Models
{
    public static class Repository
    {
        private static List<StudentResponse> _students = new List<StudentResponse>();

        public static List<StudentResponse> Students {
            get
            {
                return _students;
            }
        }

        public static void AddStudent(StudentResponse student){
            _students.Add(student);
        }
    }
}