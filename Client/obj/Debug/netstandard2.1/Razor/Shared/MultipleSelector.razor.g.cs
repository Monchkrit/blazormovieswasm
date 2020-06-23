#pragma checksum "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a066e0695e71ac6eaa18201f29832f9125a5f5"
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
    public partial class MultipleSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row multiple-selector");
            __builder.AddMarkupContent(2, "\r\n  ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "selectable-ul");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 4 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
     foreach (var item in NotSelected)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "      ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
                      () => Select(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, 
#nullable restore
#line 6 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
                                            item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 7 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n  ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "multiple-selector-buttons");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
                                    SelectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, 
#nullable restore
#line 10 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
                                                addAllText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
                                    DeselectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, 
#nullable restore
#line 11 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
                                                  removeAllText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n  ");
            __builder.OpenElement(27, "ul");
            __builder.AddAttribute(28, "class", "selectable-ul");
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 14 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
     foreach (var item in Selected)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "      ");
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
                      () => Deselect(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, 
#nullable restore
#line 16 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
                                              item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 17 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelector.razor"
       
  private string addAllText = ">>";
  private string removeAllText = "<<";
  [Parameter]
  public List<MultipleSelectorModel> NotSelected { get; set; } = new List<MultipleSelectorModel>();
  [Parameter]
  public List<MultipleSelectorModel> Selected { get; set; } = new List<MultipleSelectorModel>();

  private void Select(MultipleSelectorModel item)
  {
    NotSelected.Remove(item);
    Selected.Add(item);
  }

  private void Deselect(MultipleSelectorModel item)
  {
    Selected.Remove(item);
    NotSelected.Add(item);
  }

  private void SelectAll()
  {
    Selected.AddRange(NotSelected);
    NotSelected.Clear();
  }

  private void DeselectAll()
  {
    NotSelected.AddRange(Selected);
    Selected.Clear();
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
