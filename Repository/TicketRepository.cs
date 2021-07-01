using Repository.ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly IWebApiExecuter webApiExecuter;

        public async Task<IEnumerable<Ticket>> GetAsync()
        {
            return await webApiExecuter.InvokeGet<IEnumerable<Ticket>>("api/tickets");
        }
        public TicketRepository(IWebApiExecuter webApiExecuter)
        {
            this.webApiExecuter = webApiExecuter;
        }

        public async Task<Ticket> GetByIdAsync(int id)
        {
            return await webApiExecuter.InvokeGet<Ticket>($"api/tickets/{id}?api-version=1.0");
        }

        public async Task UpdateAsync(Ticket ticket)
        {
            await webApiExecuter.InvokePut($"api/tickets/{ticket.TicketId}?api-version=1.0", ticket);
        }

    }
}