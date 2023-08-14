using EduHome.DataAccessLayer;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class AboutController : Controller
    {
        public readonly AppDbContext _dbContext;

        public AboutController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var aboutbanners = _dbContext.AboutBanners.ToList();
            var teachers = _dbContext.Teachers.Take(4).ToList();
            var carusels = _dbContext.Carusels.ToList();
            var videos = _dbContext.Videos.ToList();
            var noticeLeft = _dbContext.NoticeLeft.ToList();

            var aboutViewModel = new AboutViewModel
            {
                AboutBanners = aboutbanners,
                Teachers = teachers,
                Carusels = carusels,
                Videos = videos,
                NoticeLefts = noticeLeft
            };

            return View(aboutViewModel);
        }
    }
}