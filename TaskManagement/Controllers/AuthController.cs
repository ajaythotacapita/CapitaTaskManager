using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
