using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetAsync();
        Task<Ticket> GetByIdAsync(int id);
        Task UpdateAsync(Ticket ticket);
    }
}