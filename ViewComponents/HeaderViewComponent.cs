using EduHome.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var header = _dbContext.Header.Include(x => x.Navigation).FirstOrDefault();

            return View(header);
        }
    }
}
