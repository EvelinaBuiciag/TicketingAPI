using Core.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases
{
    public class TicketsScreenUseCases : ITicketsScreenUseCases
    {
        private readonly IOwnerRepository ownerRepository;
        private readonly ITicketRepository ticketRepository;

        public TicketsScreenUseCases(IOwnerRepository ownerRepository,
            ITicketRepository ticketRepository)
        {
            this.ownerRepository = ownerRepository;
            this.ticketRepository = ticketRepository;
        }
        public async Task<IEnumerable<Ticket>> ViewTicketsAsync()
        {
            return await ticketRepository.GetAsync();
        }
        public async Task<IEnumerable<Ticket>> ViewTickets(int ownerId)
        {
            return await ownerRepository.GetOwnerTicketsAsync(ownerId);
        }
        

        //public async Task<IEnumerable<Ticket>> SearchTickets(string filter)
        //{
        //    if (int.TryParse(filter, out int ticketId))
        //    {
        //        var ticket = await ticketRepository.GetByIdAsync(ticketId);
        //        var tickets = new List<Ticket>();
        //        tickets.Add(ticket);
        //        return tickets;
        //    }

        //    return await ticketRepository.GetAsync(filter);
        //}

        public async Task<IEnumerable<Ticket>> ViewOwnersTickets(int ownerId, string ownerName)
        {
            return await ownerRepository.GetOwnerTicketsAsync(ownerId, ownerName);
        }

        public async Task<Ticket> ViewTicketById(int ticketId)
        {
            return await ticketRepository.GetByIdAsync(ticketId);
        }

        public async Task UpdateTicket(Ticket ticket)
        {
            await ticketRepository.UpdateAsync(ticket);
        }
    }
}