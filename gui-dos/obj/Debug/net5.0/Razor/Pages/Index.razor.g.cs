#pragma checksum "/home/bcb/git/gui-dos/gui-dos/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8e2cc8c9979694cab2fc9dfe1dbffb9cd23eff"
// <auto-generated/>
#pragma warning disable 1591
namespace gui_dos.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Areas.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<gui_dos.Shared.LoginDisplay>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "h1");
                __builder2.AddContent(5, "Hello, ");
                __builder2.AddContent(6, 
#nullable restore
#line 7 "/home/bcb/git/gui-dos/gui-dos/Pages/Index.razor"
                    context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<p>You can only see this content if you\'re authorized.</p>");
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "<h1>Authentication Failure!</h1>\r\n        ");
                __builder2.AddMarkupContent(12, "<p>You\'re not signed in.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591