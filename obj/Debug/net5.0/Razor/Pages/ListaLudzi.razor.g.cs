#pragma checksum "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a27dcf33824fc68b739431f1e0c72d8a6b6fb9"
// <auto-generated/>
#pragma warning disable 1591
namespace Startowa.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using Startowa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\work\blazor\Lab1\Startowa\_Imports.razor"
using Startowa.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"
using Startowa.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listaludzi")]
    public partial class ListaLudzi : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Lista osób w mojej firmie</h1>");
#nullable restore
#line 13 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"
 if (listaOsob == null)

{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "< p>< em> Loading...</></>");
#nullable restore
#line 18 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"

}

else

{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-hover");
            __builder.AddMarkupContent(4, @"<thead><tr><th scope=""col"">#</th>

            <th scope=""col"">Imię</th>

            <th scope=""col"">Nazwisko</th>

            <th scope=""col"">Wiek</th>

            <th scope=""col"">Czy poprawny</th>

            <th scope=""col"">Sparowane - Nazwisko</th></tr></thead>

    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 49 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"
         foreach (var item in listaOsob)

        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<td>1</td>\r\n\r\n    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 57 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"
         item.Imie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 59 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"
         item.Nazwisko

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 61 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"
         item.Wiek

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 63 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"
         item.CzyPoprawnie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 65 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"
         item.Wylosowany

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"

}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "​​");
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "d:\work\blazor\Lab1\Startowa\Pages\ListaLudzi.razor"
       

        private List<Osoba> listaOsob;



            protected override async Task OnInitializedAsync()

            {

            listaOsob = await OsobaService.GetListaLudzi();

            }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OsobaService OsobyDane { get; set; }
    }
}
#pragma warning restore 1591
