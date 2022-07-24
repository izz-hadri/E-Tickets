using eTickets.Controllers.Base;
using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : BaseController
    {
        public CinemasController(AppDbContext context): base(context)
        {

        }

        public async Task<IActionResult> Index()
        {
            List<Cinema> allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
