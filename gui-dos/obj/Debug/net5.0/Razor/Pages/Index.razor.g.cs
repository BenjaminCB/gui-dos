#pragma checksum "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf463ea99d2649d27f80dfa85db008c49bb7a5e3"
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
#line 1 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using gui_dos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using gui_dos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/daniel/Documents/GitHub/gui-dos/gui-dos/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Homepage</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<a>Her skal vaere den oenskede forside</a>\r\n\r\n");
            __builder.AddMarkupContent(2, "<a href=\"./gavekurv\">Gavekurv</a>\r\n    \r\n");
            __builder.OpenComponent<gui_dos.Shared.SurveyPrompt>(3);
            __builder.AddAttribute(4, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
