using eTickets.Data.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MovieService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            Movie movieDetails = await _context.Movies
                .Include(x => x.Cinema)
                .Include(x => x.Producer)
                .Include(x => x.Actors_Movies)
                .ThenInclude(x => x.Actor)
                .FirstOrDefaultAsync(x => x.Id == id);

            return movieDetails;
        }
    }
}
