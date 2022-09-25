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
            IEnumerable<Movie> allMovies = await _service.GetAllAsync(n => n.Cinema);

            return View(allMovies);
        }

        public IActionResult Create()
        {
            //var movieDropdownsData = await _service.GetNewMovieDropdownsValues();

            //ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            //ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            //ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            Movie movieDetails = await _service.GetByIdAsync(id);

            if (movieDetails == null)
            {
                return View("NotFound");
            }

            return View(movieDetails);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Movie movieDetails = await _service.GetByIdAsync(id);

            if (movieDetails == null)
            {
                return View("NotFound");
            }

            return View(movieDetails);
        }

        public async Task<IActionResult> Details(int id)
        {
            Movie movieDetails = await _service.GetMovieByIdAsync(id);

            if (movieDetails == null)
            {
                return View("NotFound");
            }

            return View(movieDetails);
        }
    }
}
