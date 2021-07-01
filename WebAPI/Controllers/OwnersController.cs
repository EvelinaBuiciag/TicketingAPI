using DataStore.EF;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ticketing.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]")]
    public class OwnersController : ControllerBase
    {
        private readonly TicketsContext db;

        public OwnersController(TicketsContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Get() //get all owners
        {
            return Ok(await db.Owners.ToListAsync());
        }

        [HttpGet("{id}")] //Get owner by id
        public async Task<IActionResult> GetById(int id)
        {
            var project = await db.Owners.FindAsync(id);
            if (project == null)
                return NotFound();

            return Ok(project);
        }
        [HttpGet] //Get owners tickets
        [Route("/api/owners/{oid}/tickets")]
        public async Task<IActionResult> GetOwnerTickets(int oid)
        {
            var tickets = await db.Tickets.Where(t => t.OwnerId == oid).ToListAsync();
            if (tickets == null || tickets.Count <= 0)
                return NotFound();

            return Ok(tickets);
        }
        
        }

    }
