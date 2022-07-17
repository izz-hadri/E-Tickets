using eTickets.Controllers.Base;
using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : BaseController
    {
        public ActorsController(AppDbContext context): base(context)
        {

        }

        public IActionResult Index()
        {
            List<Actor> allActors = _context.Actors.ToList();
            return View();
        }
    }
}
