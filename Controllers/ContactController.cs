using EduHome.DataAccessLayer;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class ContactController : Controller
    {
        public readonly AppDbContext _dbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var contacts = _dbContext.Contacts.ToList();

            var contactViewModel = new ContactViewModel
            {
                Contacts = contacts,
            };

            return View(contactViewModel);
        }
    }
}