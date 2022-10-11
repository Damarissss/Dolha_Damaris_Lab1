using Microsoft.AspNetCore.Mvc;

namespace Dolha_Damaris_Lab1.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return Content("Bine ati venit!");
        }
        public IActionResult Index2()
        {
            return Content("Greetings!");
        }
        public IActionResult Index3(string x, int n)
        {
            return Content("Valoarea generata pentru x este: " + x + ". Valoarea generata pentru n este: " + n + ".");
        }
    }
}
