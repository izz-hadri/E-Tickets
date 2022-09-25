using eTickets.Controllers.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public partial class ProducersController : BaseController<IProducersService>
    {
        public ProducersController(IProducersService service): base(service)
        {

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Producer> allProducers = await _service.GetAllAsync();

            return View(allProducers);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            Producer producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Producer producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }

        public async Task<IActionResult> Details(int id)
        {
            Producer producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }
    }
}
