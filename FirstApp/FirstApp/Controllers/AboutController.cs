using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
