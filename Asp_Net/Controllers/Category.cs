using Microsoft.AspNetCore.Mvc;

namespace Asp_Net.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
