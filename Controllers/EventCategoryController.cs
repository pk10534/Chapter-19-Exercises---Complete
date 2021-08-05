using CodingEventsDemo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ch26_Practice_2___Razor_Forms.Models;
using Ch26_Practice_2___Razor_Forms.ViewModels;

namespace Ch26_Practice_2___Razor_Forms.Controllers
{
    public class EventCategoryController : Controller
    {

        private EventDbContext _context;

        public EventCategoryController(EventDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {
            List<EventCategory> eventcategories = _context.EventCategories.ToList();
            return View(eventcategories);
        }
    }
}
