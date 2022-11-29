using Microsoft.AspNetCore.Mvc;

namespace firstTask.wwwroot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
