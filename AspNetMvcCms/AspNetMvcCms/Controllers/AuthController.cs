using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcCms.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login(string redirectUrl)
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
//busra