#pragma checksum "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Pages\DisplayInvoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82b6d4ca7a9fcf20ec1818dd296b510759db23ab"
// <auto-generated/>
#pragma warning disable 1591
namespace InvoiceManagementApp.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/displayinvoice")]
    public partial class DisplayInvoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"d-flex justify-content-center\">\r\n    <img src=\"/images/logo.png\">\r\n</div>\r\n<br>\r\n<br>\r\n\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-light");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">Url</th>\r\n            <th scope=\"col\">Invoice Code</th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 21 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Pages\DisplayInvoice.razor"
     foreach (var item in manager)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "th");
            __builder.AddAttribute(11, "scope", "row");
            __builder.AddContent(12, 
#nullable restore
#line 25 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Pages\DisplayInvoice.razor"
                             item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "th");
            __builder.AddAttribute(15, "scope", "row");
            __builder.AddContent(16, 
#nullable restore
#line 26 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Pages\DisplayInvoice.razor"
                             item.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 29 "C:\Users\Emir\source\repos\InvoiceManagementApp\InvoiceManagementApp\Pages\DisplayInvoice.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Manager manager { get; set; }
    }
}
#pragma warning restore 1591