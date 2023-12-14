using Microsoft.AspNetCore.Mvc;

namespace sistema_acessidoc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}