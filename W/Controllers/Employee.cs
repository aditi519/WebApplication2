using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class Employee : Controller
    {
        public string Email;
        public int Id;
        public string Name;

        public IActionResult Index()
        {
            // Replace this with fetching actual employee data from a database or other data source.
            var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "ABC", Email = "abc@123.com" },
            new Employee { Id = 2, Name = "XYZ", Email = "xyz@789.com" }
        };

            return View(employees);
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
