using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCms.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Search(string query,int page)
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
