// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace gui_dos.Pages
{
    #line hidden
    using System;
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
#line 2 "/home/bcb/git/gui-dos/gui-dos/Pages/DummyShow.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/bcb/git/gui-dos/gui-dos/Pages/DummyShow.razor"
using gui_dos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/bcb/git/gui-dos/gui-dos/Pages/DummyShow.razor"
using gui_dos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/bcb/git/gui-dos/gui-dos/Pages/DummyShow.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dummy-show")]
    public partial class DummyShow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/home/bcb/git/gui-dos/gui-dos/Pages/DummyShow.razor"
 
    private List<DummyModel> dummys;

    protected override async Task OnInitializedAsync()
    {
        using (var ctx = DbContextFactory.CreateDbContext())
        {
            dummys = await ctx.Dummys.ToListAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDbContextFactory<IsvaerftetDbContext> DbContextFactory { get; set; }
    }
}
#pragma warning restore 1591
