using ManagementWebApp.Data;
using ManagementWebApp.Data.Services;
using ManagementWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagementWebApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //Get : Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("profilePictureURL", "FullName", "Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }

    }
}
