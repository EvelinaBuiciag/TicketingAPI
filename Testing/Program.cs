using Repository;
using Repository.ApiClient;
using Core.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

HttpClient httpClient = new();
IWebApiExecuter apiExectuer = new WebApiExecuter("https://localhost:44363", httpClient);

await TestOwners();

await TestTickets();

#region Test Owners

async Task TestOwners()
{
    Console.WriteLine("////////////////////");
    Console.WriteLine("Reading owners...");
    await GetOwners();

    Console.WriteLine("////////////////////");
    Console.WriteLine("Reading owner's tickets...");
    await GetOwnerTickets(1);
}

async Task GetOwners()
{
    OwnerRepository repository = new(apiExectuer);
    var owners = await repository.GetAsync();
    foreach (var owner in owners)
    {
        Console.WriteLine($"Owner: {owner.Name}");
    }
}

async Task<Owner> GetOwner(int id)
{
    OwnerRepository repository = new(apiExectuer);
    return await repository.GetByIdAsync(id);
}

async Task GetOwnerTickets(int id)
{
    var Owner = await GetOwner(id);
    Console.WriteLine($"Owner: {Owner.Name}");

    OwnerRepository repository = new(apiExectuer);
    var tickets = await repository.GetOwnerTicketsAsync(id);
    foreach (var ticket in tickets)
    {
        Console.WriteLine($"    Ticket: {ticket.Title}");
    }
}
#endregion

#region Test Tickets
async Task TestTickets()
{
    Console.WriteLine("////////////////////");
    Console.WriteLine("Reading all tickets...");
    await GetTickets();

    Console.WriteLine("////////////////////");
    Console.WriteLine("Reading ticket id 1...");
    var tId = await GetTicketById(1);
    await GetTickets();

    Console.WriteLine("////////////////////");
    Console.WriteLine("Update ticket id 1");
    var ticket = await GetTicketById(1);
    await UpdateTicket(ticket);
    await GetTickets();
}

async Task GetTickets()
{
    TicketRepository ticketRepository = new(apiExectuer);
    var tickets = await ticketRepository.GetAsync();
    foreach (var ticket in tickets)
    {
        Console.WriteLine($"Ticket: {ticket.Title}");
    }
}

async Task<Ticket> GetTicketById(int id)
{
    TicketRepository ticketRepository = new(apiExectuer);
    var ticket = await ticketRepository.GetByIdAsync(id);
    return ticket;
}

async Task UpdateTicket(Ticket ticket)
{
    TicketRepository ticketRepository = new(apiExectuer);
    ticket.Title += " Updated";
    await ticketRepository.UpdateAsync(ticket);
}

#endregion
