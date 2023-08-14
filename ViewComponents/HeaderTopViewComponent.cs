using EduHome.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EduHome.ViewComponents
{
    public class HeaderTopViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public HeaderTopViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var topheader = _dbContext.HeaderTop.Include(x => x.TopNavigations).FirstOrDefault();

            return View(topheader);
        }
    }
}
