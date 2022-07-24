using eTickets.Controllers.Base;
using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : BaseController
    {
        public ActorsController(AppDbContext context): base(context)
        {

        }

        public async Task<IActionResult> Index()
        {
            List<Actor> allActors = await _context.Actors.ToListAsync();
            return View(allActors);
        }
    }
}
