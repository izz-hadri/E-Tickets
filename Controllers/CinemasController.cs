using eTickets.Controllers.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public partial class CinemasController : BaseController<ICinemasService>
    {
        public CinemasController(ICinemasService service): base(service)
        {

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Cinema> allCinemas = await _service.GetAllAsync();

            return View(allCinemas);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            Cinema cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }

            return View(cinemaDetails);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Cinema cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }

            return View(cinemaDetails);
        }

        public async Task<IActionResult> Details(int id)
        {
            Cinema cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }

            return View(cinemaDetails);
        }
    }
}
