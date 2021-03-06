#pragma checksum "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/RenderMarkdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "958f5e3c3f782f81098f0b7f753bb2fd5c21ac3b"
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
#nullable restore
#line 14 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Shared.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/RenderMarkdown.razor"
using Markdig;

#line default
#line hidden
#nullable disable
    public partial class RenderMarkdown : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/RenderMarkdown.razor"
 if (HTMLContent != null)
{
  

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 5 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/RenderMarkdown.razor"
    (MarkupString)HTMLContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 5 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/RenderMarkdown.razor"
                              
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/RenderMarkdown.razor"
       
  [Parameter]
  public string MarkdownContent { get; set; }
  private string HTMLContent;

  protected override void OnParametersSet()
  {
    if (!string.IsNullOrEmpty(MarkdownContent))
    {
      HTMLContent = Markdown.ToHtml(MarkdownContent);
    }
    else
    {
      HTMLContent = null;
    }
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
