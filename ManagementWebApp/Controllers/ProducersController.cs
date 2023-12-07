using ManagementWebApp.Data;
using ManagementWebApp.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManagementWebApp.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        // This methos will call the NewPageView file in the View folder
        // If its not indicated in the return it will call the index file
     //   public async Task<IActionResult> Index()
     //   {
     //       var allProducers = await _context.Producers.ToListAsync();
     //       return View("NewPageView", allProducers);
     //   }
    }
}
