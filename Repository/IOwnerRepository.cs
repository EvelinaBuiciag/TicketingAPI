using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOwnerRepository
    {
        Task<IEnumerable<Owner>> GetAsync();
        Task<Owner> GetByIdAsync(int id);
        Task<IEnumerable<Ticket>> GetOwnerTicketsAsync(int ownerId, string filter = null);
    }
}