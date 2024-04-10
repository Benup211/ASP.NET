using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab6.Models;

namespace lab6.Controllers
{
    public class Controller1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new Model1Model
            {
                FullName = "John Doe",
                Email = "johndoe@gmail.com",
                Salary = 1000
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Model1Model user)
        {
            if (ModelState.IsValid)
            {
                return Content("Success");
            }
            return View(user);
        }
    }

}
