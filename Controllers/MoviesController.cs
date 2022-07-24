using eTickets.Controllers.Base;
using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : BaseController
    {
        public MoviesController(AppDbContext context): base(context)
        {

        }

        public async Task<IActionResult> Index()
        {
            List<Movie> allMovies = await _context.Movies
                                                  .Include(x => x.Cinema)
                                                  .OrderBy(x => x.Name)
                                                  .ToListAsync();
            return View(allMovies);
        }
    }
}
