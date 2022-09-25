using eTickets.Controllers.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public partial class ActorsController : BaseController<IActorsService>
    {
        public ActorsController(IActorsService service): base(service)
        {

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Actor> allActors = await _service.GetAllAsync();

            return View(allActors);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            Actor actorDetails = await _service.GetByIdAsync(id);

            if(actorDetails == null)
            {
                return View("NotFound");
            }

            return View(actorDetails);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Actor actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }

            return View(actorDetails);
        }

        public async Task<IActionResult> Details(int id)
        {
            Actor actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }

            return View(actorDetails);
        }
    }
}
