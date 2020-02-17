using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using CourseApp.Models;

namespace CourseApp.ViewModels
{
    public class CourseStudentsViewModel
    {
        public Course Course { get; set; }

        public List<Student> Students { get; set; }
    }
}
