#pragma checksum "/home/bcb/git/gui-dos/playground/BlazorApp/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dfd6ba34f778c3730480e7c05aa244494f2c570"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/bcb/git/gui-dos/playground/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            __builder.OpenComponent<BlazorApp.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenComponent<BlazorApp.Pages.Products>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenComponent<BlazorApp.Pages.Tree>(6);
            __builder.AddAttribute(7, "number", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "/home/bcb/git/gui-dos/playground/BlazorApp/Pages/Index.razor"
              3

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenComponent<BlazorApp.Pages.Fragment>(9);
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\n    yea boiii!\n    yea boiii!\n    yea boiii!\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
