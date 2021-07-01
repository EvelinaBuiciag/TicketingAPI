#pragma checksum "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Pages\TicketsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dcb56ed74bd3680751cae9fe0b858c3e2d56b5b"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets")]
    public partial class TicketsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Tickets</h3>\r\n<br>");
#nullable restore
#line 7 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Pages\TicketsComponent.razor"
 if (tickets != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "ul");
#nullable restore
#line 10 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Pages\TicketsComponent.razor"
     foreach (var ticket in tickets)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 13 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Pages\TicketsComponent.razor"
                         $"/tickets/{ticket.TicketId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(6, 
#nullable restore
#line 14 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Pages\TicketsComponent.razor"
             ticket.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Pages\TicketsComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Pages\TicketsComponent.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Pages\TicketsComponent.razor"
           
        IEnumerable<Ticket> tickets;

protected override async Task OnInitializedAsync()
    {
        tickets = await TicketsScreenUseCases.ViewTicketsAsync();
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITicketsScreenUseCases TicketsScreenUseCases { get; set; }
    }
}
#pragma warning restore 1591
