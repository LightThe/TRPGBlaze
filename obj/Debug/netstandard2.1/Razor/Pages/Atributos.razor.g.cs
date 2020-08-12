#pragma checksum "/Users/light/code/blazor/TRPG/Pages/Atributos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d8d1c7b23f3635007f8abb6bdbdcfdbc12e8eb3"
// <auto-generated/>
#pragma warning disable 1591
namespace TRPG.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/light/code/blazor/TRPG/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/light/code/blazor/TRPG/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/light/code/blazor/TRPG/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/light/code/blazor/TRPG/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/light/code/blazor/TRPG/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/light/code/blazor/TRPG/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/light/code/blazor/TRPG/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/light/code/blazor/TRPG/_Imports.razor"
using TRPG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/light/code/blazor/TRPG/_Imports.razor"
using TRPG.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/atributos")]
    public partial class Atributos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Atributos</h3>\r\n");
            __builder.OpenElement(1, "ul");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 5 "/Users/light/code/blazor/TRPG/Pages/Atributos.razor"
     foreach (var att in atributos){

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "li");
            __builder.AddContent(5, 
#nullable restore
#line 6 "/Users/light/code/blazor/TRPG/Pages/Atributos.razor"
             att.nomeAtr

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, ": ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "/Users/light/code/blazor/TRPG/Pages/Atributos.razor"
                                        att.valorAtr

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => att.valorAtr = __value, att.valorAtr));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(10, " +");
            __builder.AddContent(11, 
#nullable restore
#line 6 "/Users/light/code/blazor/TRPG/Pages/Atributos.razor"
                                                           att.modAtr

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 7 "/Users/light/code/blazor/TRPG/Pages/Atributos.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Users/light/code/blazor/TRPG/Pages/Atributos.razor"
                  BeginAtributos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Teste");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/Users/light/code/blazor/TRPG/Pages/Atributos.razor"
       
    private List<Atributo> atributos = new List<Atributo>();
    Dictionary<int, int> modLookup = new Dictionary<int, int>(){
        {1, -5},
        {2, -4},
        {3, -4},
        {4, -3},
        {5, -3},
        {6, -2},
        {7, -2},
        {8, -1},
        {9, -1},
        {10, 0},
        {11, 0},
        {12, 1},
        {13, 1},
        {14, 2},
        {15, 2},
        {16, 3},
        {17, 3},
        {18, 4},
        {19, 4},
        {20, 5},
        {21, 5},
        {22, 6},
        {23, 6},
        {24, 7},
        {25, 7},
    };
    private void BeginAtributos(){
        atributos.Add(new Atributo{
            nomeAtr = "Força",
            valorAtr = 13,
            modAtr = modLookup.GetValueOrDefault(13)
        });
        atributos.Add(new Atributo{
            nomeAtr = "Destreza",
            valorAtr = 13,
            modAtr = modLookup.GetValueOrDefault(13)
        });
        atributos.Add(new Atributo{
            nomeAtr = "Constituição",
            valorAtr = 13,
            modAtr = modLookup.GetValueOrDefault(13)
        });
        atributos.Add(new Atributo{
            nomeAtr = "Inteligência",
            valorAtr = 13,
            modAtr = modLookup.GetValueOrDefault(13)
        });
        atributos.Add(new Atributo{
            nomeAtr = "Sabedoria",
            valorAtr = 13,
            modAtr = modLookup.GetValueOrDefault(13)
        });
        atributos.Add(new Atributo{
            nomeAtr = "Carisma",
            valorAtr = 13,
            modAtr = modLookup.GetValueOrDefault(13)
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
