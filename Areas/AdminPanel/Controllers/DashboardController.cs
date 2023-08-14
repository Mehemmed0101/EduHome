using Microsoft.AspNetCore.Mvc;

namespace EduHome.Areas.AdminPanel.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
