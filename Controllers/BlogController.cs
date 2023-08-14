using EduHome.DataAccessLayer;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class BlogController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _blogCount;

        public BlogController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _blogCount = _dbContext.Blogs.Count();
        }


        public IActionResult Index()
        {
            var pageCounts = _dbContext.PageCounts.ToList();

            ViewBag.BlogCount = _blogCount;

            var blogs = _dbContext.Blogs.Take(3).ToList();

            var blogViewModel = new BlogViewModel
            {
                Blogs = blogs,
                PageCounts = pageCounts
            };

            return View(blogViewModel);
        }

        public IActionResult LoadBlogs(int skipBlog)
        {
            var blogs = _dbContext.Blogs.Skip(skipBlog).Take(3).ToList();

            return PartialView("_BlogPartial", blogs);
        }
    }
}
