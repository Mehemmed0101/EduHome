using EduHome.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var footer = _dbContext.Footer.Include(x => x.GetInTouch).Include(x => x.Information).Include(x => x.SocialMedia).Include(x => x.UsefulLinks).FirstOrDefault();

            return View(footer);
        }
    }
}