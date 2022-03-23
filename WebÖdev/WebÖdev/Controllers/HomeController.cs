using Microsoft.AspNetCore.Mvc;
using WebÖdev.Models;

namespace WebÖdev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Onur";
            ViewBag.Age = 27;
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {

            if (ModelState.IsValid)
            {
                return View("Thanks");
            }
            
            return View();
        }
    }
}
