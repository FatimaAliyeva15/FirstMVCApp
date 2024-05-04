using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
