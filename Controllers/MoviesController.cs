using eTickets.Controllers.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : BaseController<IMoviesService>
    {
        public MoviesController(IMoviesService service): base(service)
        {

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Movie> allMovies = await _service.GetAll();

            return View(allMovies);
        }
    }
}
