using ManagementWebApp.Data;
using ManagementWebApp.Data.Services;
using ManagementWebApp.Data.Static;
using ManagementWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManagementWebApp.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //Get : Actors/Details/id
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }

        //Get : Actors/Update/id
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            return View(producerDetails);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, profilePictureURL", "FullName", "Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }

            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));
        }

        //Get : Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("profilePictureURL", "FullName", "Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }

            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //Get : Actors/Delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var poducerDetails = await _service.GetByIdAsync(id);
            if (poducerDetails == null)
            {
                return View("NotFound");
            }
            return View(poducerDetails);
        }

        // If you have two method with the same name and parameter you can use the Action Name
        // The first one to respone in the name Delete is the Delete method above.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poducerDetails = await _service.GetByIdAsync(id);
            if (poducerDetails == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
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
