using Microsoft.AspNetCore.Mvc;

namespace EduHome.Areas.AdminPanel.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
