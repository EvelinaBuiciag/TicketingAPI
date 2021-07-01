#pragma checksum "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Controls\TicketRowComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "329fade9a59c3cc7d2ef393c4723e3ad0bf921f4"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Controls
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
    public partial class TicketRowComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Controls\TicketRowComponent.razor"
 if (this.Ticket != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "tr");
            __builder.OpenElement(1, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(2);
            __builder.AddAttribute(3, "href", 
#nullable restore
#line 7 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Controls\TicketRowComponent.razor"
                         $"ticket/{Ticket.TicketId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, 
#nullable restore
#line 8 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Controls\TicketRowComponent.razor"
             Ticket.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 11 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Controls\TicketRowComponent.razor"
         Ticket.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 12 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Controls\TicketRowComponent.razor"
         Ticket.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Controls\TicketRowComponent.razor"
     }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Lenovo i7\source\repos\TicketingAPI\WebApp\Controls\TicketRowComponent.razor"
        [Parameter]
            public Ticket Ticket { get; set; } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591