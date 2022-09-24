using eTickets.Controllers.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemasController : BaseController<ICinemasService>
    {
        public CinemasController(ICinemasService service): base(service)
        {

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Cinema> allCinemas = await _service.GetAll();

            return View(allCinemas);
        }
    }
}
