using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class CinemaService : ICinemasService
    {
        private readonly AppDbContext _context;

        public CinemaService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Cinema cinema)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cinema>> GetAll()
        {
           List<Cinema> result = await _context.Cinemas.ToListAsync();

            return result;
        }

        public Cinema GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Cinema Update(int id, Cinema newCinema)
        {
            throw new NotImplementedException();
        }
    }
}
