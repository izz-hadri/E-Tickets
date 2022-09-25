using eTickets.Controllers.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers.HttpMethods
{
    public class MoviesController : BaseController<IMoviesService>
    {
        public MoviesController(IMoviesService service) : base(service)
        {

        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description,ImageURL,Price,StartDate,EndDate")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            await _service.AddAsync(movie);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            await _service.UpdateAsync(id, movie);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Movie movieDetails = await _service.GetByIdAsync(id);

            if (movieDetails == null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
