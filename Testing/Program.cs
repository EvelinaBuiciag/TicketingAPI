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

    //Console.WriteLine("////////////////////");
    //Console.WriteLine("Create an owner...");
    //var oId = await CreateOwner();
    //await GetOwners();

    //Console.WriteLine("////////////////////");
    //Console.WriteLine("Update an owner...");
    //var owner = await GetOwner(oId);
    //await UpdateOwner(owner);
    //await GetOwners();

    //Console.WriteLine("////////////////////");
    //Console.WriteLine("Delete an owener...");
    //await DeleteOwner(oId);
    //await GetOwners();
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

//async Task<int> CreateOwner()
//{
//    var owner = new Owner { Name = "Another Owner" };
//    OwnerRepository repository = new(apiExectuer);
//    return await repository.CreateAsync(owner);
//}

//async Task UpdateOwner(Owner owner)
//{
//    OwnerRepository repository = new(apiExectuer);
//    owner.Name += " updated";
//    await repository.UpdateAsync(owner);
//}

//async Task DeleteOwner(int id)
//{
//    OwnerRepository repository = new(apiExectuer);
//    await repository.DeleteAsync(id);
//}

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

    //Console.WriteLine("////////////////////");
    //Console.WriteLine("Create a ticket...");
    //var tId = await CreateTicket();
    //await GetTickets();

    Console.WriteLine("////////////////////");
    Console.WriteLine("Update ticket id 1");
    var ticket = await GetTicketById(1);
    await UpdateTicket(ticket);
    await GetTickets();

    //Console.WriteLine("////////////////////");
    //Console.WriteLine("Delete a ticket...");
    //await DeleteTicket(tId);
    //await GetTickets();
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

//async Task<int> CreateTicket()
//{
//    TicketRepository ticketRepository = new(apiExectuer);
//    return await ticketRepository.CreateAsync(new Ticket
//    {
//        OwnerId = 2,
//        Title = "This a very difficult.",
//        Description = "Something is wrong on the server."
//    });
//}

async Task UpdateTicket(Ticket ticket)
{
    TicketRepository ticketRepository = new(apiExectuer);
    ticket.Title += " Updated";
    await ticketRepository.UpdateAsync(ticket);
}

//async Task DeleteTicket(int id)
//{
//    TicketRepository ticketRepository = new(apiExectuer);
//    await ticketRepository.DeleteAsync(id);
//}

#endregion
