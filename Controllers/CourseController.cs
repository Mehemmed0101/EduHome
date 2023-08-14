using EduHome.DataAccessLayer;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class CourseController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _courseCount;

        public CourseController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _courseCount = _dbContext.Courses.Count();
        }

        public IActionResult Index()
        {
            ViewBag.CourseCount = _courseCount;

            var courses = _dbContext.Courses.Take(3).ToList();

            var courseViewModel = new CourseViewModel
            {
                Courses = courses,
            };

            return View(courseViewModel);
        }

        public IActionResult LoadCourses(int skipCourse)
        {
            var courses = _dbContext.Courses.Skip(skipCourse).Take(3).ToList();

            return PartialView("_CoursePartial", courses);
        }
    }
}
