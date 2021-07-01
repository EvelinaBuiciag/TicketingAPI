using DataStore.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using WebAPI.Filters;

namespace Ticketing.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]")]
    //[APIKeyAuthFilter]
    public class TicketsController : ControllerBase
    {
        private readonly TicketsContext db;

        public TicketsController(TicketsContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Get() //get all tickets
        {
            return Ok(await db.Tickets.ToListAsync());
        }

        [HttpGet("{id}")] //get ticket by id
        public async Task<IActionResult> GetById(int id)
        {
            var ticket = await db .Tickets.FindAsync(id);
            if (ticket == null)
                return NotFound();

            return Ok(ticket);
        }

        [HttpPut("{id}")] //Edit ticket
        public async Task<IActionResult>  Put(int id, [FromBody] Ticket ticket)
        {
            if (id != ticket.TicketId) return BadRequest();

            db.Entry(ticket).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                if (await db.Tickets.FindAsync(id) == null)
                    return NotFound();
                throw;
            }

            return NoContent();
        }
    }
}
