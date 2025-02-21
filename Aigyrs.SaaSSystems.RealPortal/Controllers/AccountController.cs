using Microsoft.AspNetCore.Mvc;

namespace Aigyrs.SaaSSystems.RealPortal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult UserProfile()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }
    }
}
