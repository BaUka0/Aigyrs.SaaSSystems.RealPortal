using Microsoft.AspNetCore.Mvc;

namespace Aigyrs.SaaSSystems.RealPortal.Controllers
{
    public class DashboardsController : Controller
    {
        public IActionResult Analytics()
        {
            return View();
        }
    }
}
