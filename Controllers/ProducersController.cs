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
    }
}
