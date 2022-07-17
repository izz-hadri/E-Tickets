using eTickets.Controllers.Base;
using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : BaseController
    {
        public ProducersController(AppDbContext context): base(context)
        {

        }

        public async Task<IActionResult> Index()
        {
            List<Producer> allProducers = await _context.Producers.ToListAsync();
            return View();
        }
    }
}
