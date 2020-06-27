#pragma checksum "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/Movies/CreateMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096af70d1ebfd8598642463fc801ef46247ad755"
// <auto-generated/>
#pragma warning disable 1591
namespace blazormovieswasm.Client.Pages.Movies
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
using blazormovieswasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client.Repository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/create")]
    public partial class CreateMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Movie</h3>\r\n\r\n");
            __builder.OpenComponent<blazormovieswasm.Client.Pages.Movies.MovieForm>(1);
            __builder.AddAttribute(2, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<blazormovieswasm.Shared.Entities.Movie>(
#nullable restore
#line 7 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/Movies/CreateMovie.razor"
                  Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/Movies/CreateMovie.razor"
                                        AddMovie

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "NotSelectedGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<blazormovieswasm.Shared.Entities.Genre>>(
#nullable restore
#line 7 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/Movies/CreateMovie.razor"
                                                                     NotSelectedGenres

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/Movies/CreateMovie.razor"
       
  [Parameter]
  public EventCallback OnValidSubmit { get; set; }
  
  private Movie Movie = new Movie();

  private List<Genre> NotSelectedGenres = new List<Genre>()
  {
    new Genre() { Id = 1, Name = "Action" },
    new Genre() { Id = 2, Name = "Comedy" },
    new Genre() { Id = 3, Name = "Drama " }
  };

  private async Task AddMovie() 
  {
    try
    {
      var movieId = await movieRepository.CreateMovie(Movie);
      navManager.NavigateTo($"movie/{movieId}/{Movie.Title.Replace(" ", "-")}");
    }
    catch (Exception ex)
    {

    }
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMovieRepository movieRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
#pragma warning restore 1591
