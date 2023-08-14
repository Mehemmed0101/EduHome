using EduHome.DataAccessLayer;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class TeacherController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _teacherCount;

        public TeacherController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _teacherCount = _dbContext.Teachers.Count();
        }

        public IActionResult Index()
        {
            ViewBag.TeacherCount = _teacherCount;

            var teachers = _dbContext.Teachers.Take(4).ToList();

            var teacherViewModel = new TeacherViewModel
            {
                Teachers = teachers,
            };

            return View(teacherViewModel);
        }

        public IActionResult LoadTeachers(int skipTeacher)
        {
            var teachers = _dbContext.Teachers.Skip(skipTeacher).Take(4).ToList();

            return PartialView("_TeacherPartial", teachers);
        }
    }
}