#pragma checksum "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MovieList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8852622d9550c72477f1a9396195a0f9f969dd74"
// <auto-generated/>
#pragma warning disable 1591
namespace blazormovieswasm.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client.Helpers;

#line default
#line hidden
#nullable disable
    public partial class MovieList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "movies-container");
            __builder.AddMarkupContent(2, "\r\n  ");
            __Blazor.blazormovieswasm.Client.Shared.MovieList.TypeInference.CreateGenericList_0(__builder, 3, 4, 
#nullable restore
#line 4 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MovieList.razor"
                     Movies

#line default
#line hidden
#nullable disable
            , 5, (movie) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n      ");
                __builder2.OpenComponent<blazormovieswasm.Client.Shared.IndividualMovie>(7);
                __builder2.AddAttribute(8, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormovieswasm.Shared.Entities.Movie>(
#nullable restore
#line 6 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MovieList.razor"
                              movie

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MovieList.razor"
         
    [Parameter]
    public List<Movie> Movies { get; set; }

    Movie movieToBeDeleted;
    private async Task DeleteMovie(Movie movie)
    {
      await js.MyFunction("custom message");
      var confirmed = await js.Confirm($"Are you sure you want to delete {movie.Title}?");

      if (confirmed)
      {
        Movies.Remove(movie);
      }
    }
  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.blazormovieswasm.Client.Shared.MovieList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::blazormovieswasm.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "ElementTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591