using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SpellNameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HelloUser(User user)
        {
            return View("Hello", user);
        }
    }
}
