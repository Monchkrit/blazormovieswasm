#pragma checksum "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/Confirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e522f983b26ec885b6f11adeaf0a5907065f2aeb"
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
    public partial class Confirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/Confirmation.razor"
 if (DisplayConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "  <div class=\"modal-backdrop show\"></div>\r\n  ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddAttribute(8, "style", "display: block;");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-dialog");
            __builder.AddAttribute(12, "role", "document");
            __builder.AddMarkupContent(13, "\r\n      ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-content");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "modal-header");
            __builder.AddMarkupContent(19, "\r\n          ");
            __builder.OpenElement(20, "h5");
            __builder.AddAttribute(21, "class", "moal-title");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddContent(23, 
#nullable restore
#line 11 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/Confirmation.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n          ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/Confirmation.razor"
                            onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "close");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.AddMarkupContent(31, "<span aria-hidden=\"true\">&times;</span>\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-body");
            __builder.AddMarkupContent(36, "\r\n          ");
            __builder.AddContent(37, 
#nullable restore
#line 18 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/Confirmation.razor"
           ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "modal-footer");
            __builder.AddMarkupContent(42, "\r\n          ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/Confirmation.razor"
                            onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-secondary");
            __builder.AddContent(47, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n          ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/Confirmation.razor"
                            onConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddContent(53, "Confirm");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "  \r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 27 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/Confirmation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/Confirmation.razor"
       
  private bool DisplayConfirmation = false;
  [Parameter] public string Title { get; set; } = "Confirm";
  [Parameter] public RenderFragment ChildContent { get; set; }
  [Parameter] public EventCallback onConfirm { get; set; }
  [Parameter] public EventCallback onCancel { get; set; }
  public void Show() => DisplayConfirmation = true;
  public void Hide() => DisplayConfirmation = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
