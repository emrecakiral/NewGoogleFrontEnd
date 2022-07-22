using Microsoft.AspNetCore.Mvc;

namespace NewGoogle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
