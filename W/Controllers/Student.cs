using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class Student : Controller
    {
        private int Id;
        private string Name;
        private string Email;

        public IActionResult Index()
        {
            
            var students = new List<Student>
        {
            new Student { Id = 1, Name = "A", Email = "A@123.com" },
            new Student { Id = 2, Name = "B", Email = "B@123.com" }
        };

            return View(students);
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }


    }
}
