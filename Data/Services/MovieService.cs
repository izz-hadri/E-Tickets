using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class MovieService : IMoviesService
    {
        private readonly AppDbContext _context;

        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            List<Movie> result = await _context.Movies
                .Include(x => x.Cinema)
                .OrderBy(x => x.Name)
                .ToListAsync();

            return result;
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Movie Update(int id, Movie newMovie)
        {
            throw new NotImplementedException();
        }
    }
}
