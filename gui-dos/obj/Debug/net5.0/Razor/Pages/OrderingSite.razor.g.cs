#pragma checksum "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d398aa077ba2d80c416251d31026ea2590685a15"
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
#line 1 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using gui_dos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using gui_dos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"
using gui_dos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/gavekurv")]
    public partial class OrderingSite : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"
 if (false)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p b-md6k7013el><em b-md6k7013el>Loading...</em></p>");
#nullable restore
#line 9 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddAttribute(3, "b-md6k7013el");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-xl-6");
            __builder.AddAttribute(6, "b-md6k7013el");
            __builder.AddMarkupContent(7, "<a b-md6k7013el>Pris</a>\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenSlider<IEnumerable<int>>>(8);
            __builder.AddAttribute(9, "Range", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"
                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IEnumerable<int>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IEnumerable<int>>(this, 
#nullable restore
#line 15 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"
                                                                                              args => OnChange(args, "Range Slider")

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<IEnumerable<int>>(
#nullable restore
#line 15 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"
                                                    values

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IEnumerable<int>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IEnumerable<int>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => values = __value, values))));
            __builder.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<IEnumerable<int>>>>(() => values));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n            <br b-md6k7013el> ");
            __builder.AddMarkupContent(15, "<a b-md6k7013el>Her er de valgte vaerdier</a> \r\n                   ");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "b-md6k7013el");
            __builder.AddContent(18, 
#nullable restore
#line 17 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"
                        JoinVal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            <br b-md6k7013el>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, @"<div class=""product-list"" b-md6k7013el><div class=""product"" b-md6k7013el><div class=""product-img"" b-md6k7013el><a href=""https://youtube.com"" b-md6k7013el><img class=""NAVN"" src=""Images/Monkey.jpg"" alt=""Logo"" width=""400"" height=""300"" b-md6k7013el></a></div>
            <div class=""details"" b-md6k7013el><div class=""navn"" b-md6k7013el><a b-md6k7013el>Her er et navn og en pris</a></div>
                <div class=""price"" b-md6k7013el><a b-md6k7013el>200,- kr</a></div></div></div></div>");
#nullable restore
#line 42 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\peter\OneDrive - Aalborg Universitet\3.semester\gui-dos\gui-dos\Pages\OrderingSite.razor"
       
    // https://blazor.radzen.com/slider

    IEnumerable<int> values = new int[] { 14, 78 };
    IEnumerable<int> negativeValues = new int[] { -100, 100 };
    //int value = 67;
    //int negativeValue = 0;
    //int valueWithStep = 30;
    string[] Val;
    string JoinVal = $"Pris mellem {14},- og {78},-";

    void OnChange(dynamic value, string name)
    {
        var str = value is IEnumerable ? string.Join(", ", value) : value;
        Val = str.Split(",");
        JoinVal = $"Pris mellem {Val[0]},- og {Val[1]},-";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
