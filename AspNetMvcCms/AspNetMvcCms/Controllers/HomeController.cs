using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
