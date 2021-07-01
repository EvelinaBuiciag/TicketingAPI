using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Repository;
using Repository.ApiClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UseCases;

namespace WebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton<IWebApiExecuter>(sp => new WebApiExecuter("https://localhost:44363", new HttpClient()));

            builder.Services.AddTransient<IOwnersScreenUseCases, OwnersScreenUseCases>();
            builder.Services.AddTransient<IOwnerRepository, OwnerRepository>();
            builder.Services.AddTransient<ITicketRepository, TicketRepository>();
            builder.Services.AddTransient<ITicketsScreenUseCases, TicketsScreenUseCases>();
           // builder.Services.AddTransient<ITicketScreenUseCases, TicketScreenUseCases>();

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
