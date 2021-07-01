using Microsoft.EntityFrameworkCore;
using System;
using Core.Models;

namespace DataStore.EF
{
    public class TicketsContext: DbContext
    {
        public TicketsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>()
                .HasMany(p => p.Tickets)
                .WithOne(t => t.Owner)
                .HasForeignKey(t => t.OwnerId);

            //seeding
            modelBuilder.Entity<Owner>().HasData(
                    new Owner { OwnerId = 1, Name = "Jane Doe" },
                    new Owner { OwnerId = 2, Name = "Jhon Doe" },
                    new Owner { OwnerId = 3, Name = "Kiddo Doe" }
                );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { TicketId = 1, OwnerId = 1, Title = "Opera ticket", Description = "Some opera ticket", Price = 345, BuyerId = 2},
                new Ticket { TicketId = 2, OwnerId = 2, Title = "Theater ticket", Description = "Some theater ticket", Price = 2345, BuyerId =  3},
                new Ticket { TicketId = 3, OwnerId = 2, Title = "Opera ticket", Description = "Some opera ticket", Price = 860, BuyerId = 1 },
                new Ticket { TicketId = 4, OwnerId = 3, Title = "Theater ticket", Description = "Some theater ticket", Price = 123, BuyerId =  1},
                new Ticket { TicketId = 5, OwnerId = 1, Title = "Theater ticket", Description = "Some theater ticket", Price = 678, BuyerId = 2 },
                new Ticket { TicketId = 6, OwnerId = 2, Title = "Gym ticket", Description = "Some gym ticket", Price = 900, BuyerId = 3 },
                new Ticket { TicketId = 7, OwnerId = 2, Title = "Spa ticket", Description = "Some spa ticket", Price = 345, BuyerId = 3 },
                new Ticket { TicketId = 8, OwnerId = 1, Title = "Gym ticket", Description = "Some gym ticket", Price = 780, BuyerId = 2 },
                new Ticket { TicketId = 9, OwnerId = 3, Title = "Opera ticket", Description = "Some opera ticket", Price = 650, BuyerId = 1 },
                new Ticket { TicketId = 10, OwnerId = 1, Title = "Spa ticket", Description = "Some spa ticket", Price = 1100, BuyerId =  2}
                );
        }
    }
}
