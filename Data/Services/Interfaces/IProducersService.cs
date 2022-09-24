using eTickets.Models;

namespace eTickets.Data.Services.Interfaces
{
    public interface IProducersService
    {
        Task<IEnumerable<Producer>> GetAll();
        Producer GetById(int id);
        void Add(Producer producer);
        Producer Update(int id, Producer newProducer);
        void Delete(int id);
    }
}
