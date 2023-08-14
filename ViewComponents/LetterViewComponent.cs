using EduHome.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.ViewComponents
{
    public class LetterViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public LetterViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var letter = _dbContext.Letters.Include(x => x.Alerts).FirstOrDefault();

            return View(letter);
        }
    }
}
