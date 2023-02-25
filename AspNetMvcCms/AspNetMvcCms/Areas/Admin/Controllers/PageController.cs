using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
