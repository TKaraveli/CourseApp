using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            //int saat = DateTime.Now.Hour;

            //ViewBag.Greeting = saat > 12 ? "Günaydın" : "İyi günler";
            //ViewBag.UserName = "Tayfun"; 

            //return View();
            //return Content("Hello World.");
            //return NotFound();
            //return new EmptyResult();
            return RedirectToAction("List", "Home", new { id = 5, sortBy = "name" });

        }

        public IActionResult About(){
            return View(); 
        }

        public IActionResult List()
        {
            return View();
        }
    }
}