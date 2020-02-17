using System.Collections.Generic;
using System.Linq;
using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult ByReleased(int year, int month)
        {
            return Content("year :" + year + "month :" + month);
        }

        //Course/Details/2 : route
        //Course/Details?id=2&sortby=name
        public ActionResult Details(int id, string sortBy)
        {
            return Content("id =" + id + "sort by :" + sortBy);
        }

        public ActionResult CourseList(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)            
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content("pageIndex =" + pageIndex + "sort by :" + sortBy);
        }

        public IActionResult Index()
        {
            var kurs = new Course()
            {
                Id = 1,
                Name = "Örnek"
            };

            ViewData["course"] = kurs;
            ViewBag.course = kurs;
            ViewBag.count = 10;

            //return View(kurs);

            var ogrenciler = new List<Student>()
            {
                new Student() {Name = "Tayfun"},
                new Student() {Name = "Tayfun2"},
                new Student() {Name = "Tayfun3"}
            };


            var viewModel = new CourseStudentsViewModel();

            viewModel.Course = kurs;
            viewModel.Students = ogrenciler;
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Apply()
        {
          
          
          return View();
        }

        [HttpPost]
        public IActionResult Apply(StudentResponse student)
        {
            if(ModelState.IsValid){
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else{
                return View(student);
            }           
        }

        //public IActionResult Details(){
        //    // return View("MyView"); MyView adında bir cshtml getirmeye çalışır.
            
        //    var course = new Course();
        //    course.Name = "Core Mvc Kursu";
        //    course.Description = "Güzel kurs";
        //    course.isPublished = true;

        //    return View(course);
        //}
 
        public IActionResult List(){
            var students = Repository.Students.Where(i => i.Confirm == true);

            return View(students);
        }
    }
}