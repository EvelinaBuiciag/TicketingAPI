using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases
{
    public interface ITicketsScreenUseCases
    {
        Task UpdateTicket(Ticket ticket);
        Task<IEnumerable<Ticket>> ViewOwnersTickets(int ownerId, string ownerName);
        Task<Ticket> ViewTicketById(int ticketId);
        Task<IEnumerable<Ticket>> ViewTickets(int ownerId);
        Task<IEnumerable<Ticket>> ViewTicketsAsync();
    }
}