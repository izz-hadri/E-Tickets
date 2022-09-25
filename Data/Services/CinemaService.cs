using eTickets.Data.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemaService(AppDbContext context) : base(context)
        {

        }
    }
}
