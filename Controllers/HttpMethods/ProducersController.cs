using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers.HttpMethods
{
    public partial class ProducersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
