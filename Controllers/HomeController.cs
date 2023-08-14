using EduHome.DataAccessLayer;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var sliders = _dbContext.Slider.ToList();
            var noticeLefts = _dbContext.NoticeLeft.ToList();
            var noticeRights = _dbContext.NoticeRight.ToList();
            var banners = _dbContext.Banner.ToList();
            var courses = _dbContext.Courses.Take(3).ToList();
            var events = _dbContext.Events.Take(8).ToList();
            var carusels = _dbContext.Carusels.ToList();
            var blogs = _dbContext.Blogs.Take(3).ToList();

            var homeViewModel = new HomeViewModel
            {
                Slider = sliders,
                NoticeLeft = noticeLefts,
                NoticeRight = noticeRights,
                Banner = banners,
                Courses = courses,
                Events = events,
                Carusels = carusels,
                Blogs = blogs
            };

            return View(homeViewModel);
        }
    }
}