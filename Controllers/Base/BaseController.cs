using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers.Base
{
    public class BaseController<T> : Controller
    {
        protected readonly T _service;

        public BaseController(T service)
        {
            _service = service;
        }
    }
}
