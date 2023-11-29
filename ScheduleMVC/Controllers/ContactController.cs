using Microsoft.AspNetCore.Mvc;
using ScheduleMVC.Context;
using ScheduleMVC.Models.Services;

namespace ScheduleMVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactService _contactService;

        public ContactController(ContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var list = _contactService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
