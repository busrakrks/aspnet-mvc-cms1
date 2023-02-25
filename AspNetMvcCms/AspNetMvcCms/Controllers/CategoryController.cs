using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCms.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int id, int page)
        {
            return View();
        }
    }
}
