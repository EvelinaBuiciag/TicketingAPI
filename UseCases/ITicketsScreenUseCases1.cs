using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases
{
    public interface ITicketsScreenUseCases1
    {
        Task UpdateTicket(Ticket ticket);
        Task<IEnumerable<Ticket>> ViewAllTickets();
        Task<IEnumerable<Ticket>> ViewOwnersTickets(int ownerId, string ownerName);
        Task<Ticket> ViewTicketById(int ticketId);
        Task<IEnumerable<Ticket>> ViewTickets(int ownerId);
    }
}