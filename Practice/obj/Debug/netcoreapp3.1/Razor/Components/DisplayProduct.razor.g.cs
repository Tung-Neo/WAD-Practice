#pragma checksum "D:\ASP.NET MVC\WAD-Practice\Practice\Components\DisplayProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d6e95500135bb5d9ee0ab668aca58659ebf7c5"
// <auto-generated/>
#pragma warning disable 1591
namespace Practice.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ASP.NET MVC\WAD-Practice\Practice\Components\DisplayProduct.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET MVC\WAD-Practice\Practice\Components\DisplayProduct.razor"
using Practice.service;

#line default
#line hidden
#nullable disable
    public partial class DisplayProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 6 "D:\ASP.NET MVC\WAD-Practice\Practice\Components\DisplayProduct.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 10 "D:\ASP.NET MVC\WAD-Practice\Practice\Components\DisplayProduct.razor"
                           product.img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "style", "width: 250px; height: 250px");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "h5");
            __builder.AddContent(19, 
#nullable restore
#line 13 "D:\ASP.NET MVC\WAD-Practice\Practice\Components\DisplayProduct.razor"
                     product.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "h6");
            __builder.AddContent(22, 
#nullable restore
#line 14 "D:\ASP.NET MVC\WAD-Practice\Practice\Components\DisplayProduct.razor"
                     product.price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 17 "D:\ASP.NET MVC\WAD-Practice\Practice\Components\DisplayProduct.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProduct ProductService { get; set; }
    }
}
#pragma warning restore 1591
