using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
