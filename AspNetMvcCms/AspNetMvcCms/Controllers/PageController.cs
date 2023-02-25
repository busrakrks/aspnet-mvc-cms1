using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCms.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
