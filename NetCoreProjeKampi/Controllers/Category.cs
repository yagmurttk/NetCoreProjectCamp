using Microsoft.AspNetCore.Mvc;

namespace NetCoreProjeKampi.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
