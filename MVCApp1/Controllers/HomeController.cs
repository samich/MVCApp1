using Microsoft.AspNetCore.Mvc;

namespace MVCApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Customers() 
        {

            ViewBag.FirstName = "John";
            ViewBag.LastName = "Doe";
            ViewBag.Age = 41;

            return View();
        }
    }

}
