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
            IEnumerable<Actor> allActors = await _service.GetAll();

            return View(allActors);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
