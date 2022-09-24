using eTickets.Controllers.Base;
using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : BaseController<IActorsService>
    {
        public ActorsController(IActorsService service): base(service)
        {

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Actor> allActors = await _service.GetAll();
            return View(allActors);
        }
    }
}
