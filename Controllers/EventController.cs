using EduHome.DataAccessLayer;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class EventController : Controller
    {
        public readonly AppDbContext _dbContext;
        private readonly int _eventCount;


        public EventController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
            _eventCount = _dbContext.Events.Count();

        }

        public IActionResult Index()
        {
            ViewBag.EventCount = _eventCount;

            var events = _dbContext.Events.Take(3).ToList();

            var eventViewModel = new EventViewModel
            {
                Events = events,
            };

            return View(eventViewModel);
        }

        public IActionResult LoadEvents(int skipEvent)
        {
            var events = _dbContext.Events.Skip(skipEvent).Take(3).ToList();

            return PartialView("_EventPartial", events);
        }
    }
}