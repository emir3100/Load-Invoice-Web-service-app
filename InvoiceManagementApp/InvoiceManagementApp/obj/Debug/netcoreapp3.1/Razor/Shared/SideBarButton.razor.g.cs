#pragma checksum "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Shared\SideBarButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035e0cf3a7d8df8c7e69baa6cea31ff6187a6689"
// <auto-generated/>
#pragma warning disable 1591
namespace InvoiceManagementApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using InvoiceManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using InvoiceManagementApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\_Imports.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    public partial class SideBarButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "href", 
#nullable restore
#line 1 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Shared\SideBarButton.razor"
                Href

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 1 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Shared\SideBarButton.razor"
                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "img");
                __builder2.AddAttribute(7, "src", "/icons/" + (
#nullable restore
#line 2 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Shared\SideBarButton.razor"
                      IconName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "alt", true);
                __builder2.AddAttribute(9, "width", "32");
                __builder2.AddAttribute(10, "height", "32");
                __builder2.AddAttribute(11, "title", "Bootstrap");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n    <span class=\"m-2\" aria-hidden=\"true\"></span> ");
                __builder2.AddContent(13, 
#nullable restore
#line 3 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Shared\SideBarButton.razor"
                                                  Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(14, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Shared\SideBarButton.razor"
       
    [Parameter]
    public string Name { get; set; }

    [Parameter]
    public string IconName { get; set; }

    [Parameter]
    public string Href { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
