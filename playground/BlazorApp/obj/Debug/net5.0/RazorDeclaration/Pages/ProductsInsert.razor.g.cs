// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
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
#nullable restore
#line 2 "/home/bcb/git/gui-dos/playground/BlazorApp/Pages/ProductsInsert.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/bcb/git/gui-dos/playground/BlazorApp/Pages/ProductsInsert.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/bcb/git/gui-dos/playground/BlazorApp/Pages/ProductsInsert.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/bcb/git/gui-dos/playground/BlazorApp/Pages/ProductsInsert.razor"
using BlazorApp.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/bcb/git/gui-dos/playground/BlazorApp/Pages/ProductsInsert.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/bcb/git/gui-dos/playground/BlazorApp/Pages/ProductsInsert.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products-insert")]
    public partial class ProductsInsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/home/bcb/git/gui-dos/playground/BlazorApp/Pages/ProductsInsert.razor"
       
    private ProductForm productForm = new ProductForm();

    private async Task InsertProduct()
    {
        using (var ctx = DbContextFactory.CreateDbContext())
        {
            ctx.Products.Add(new Product()
                {
                    Title = productForm.Name,
                    Description = productForm.Description,
                    Image = productForm.Image
                });
            await ctx.SaveChangesAsync();
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
