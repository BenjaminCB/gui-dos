#pragma checksum "/home/bcb/git/gui-dos/gui-dos/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3278e6e0c5ae231ac3a6a8d1e3c33faf7c7a9b56"
// <auto-generated/>
#pragma warning disable 1591
namespace gui_dos
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
using gui_dos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/bcb/git/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Areas.Identity;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 4 "/home/bcb/git/gui-dos/gui-dos/App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "PreferExactMatches", 
#nullable restore
#line 4 "/home/bcb/git/gui-dos/gui-dos/App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 6 "/home/bcb/git/gui-dos/gui-dos/App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "/home/bcb/git/gui-dos/gui-dos/App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(9, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(10);
                    __builder3.AddAttribute(11, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 9 "/home/bcb/git/gui-dos/gui-dos/App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "/home/bcb/git/gui-dos/gui-dos/App.razor"
       
    [Parameter]
    public TokenProvider IntialState { get; set; }

    protected override Task OnInitializedAsync()
    {
        TokenProvider.XsrfToken = IntialState.XsrfToken;

        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TokenProvider TokenProvider { get; set; }
    }
}
#pragma warning restore 1591
