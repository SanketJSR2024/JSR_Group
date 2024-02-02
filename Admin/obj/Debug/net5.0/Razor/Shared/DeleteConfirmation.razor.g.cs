#pragma checksum "D:\DotNet\JSR\JSR_PROJECT\Admin\Shared\DeleteConfirmation.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0a9eb8f1c0afacb21243a1765ad28bf399cad3115adc4ed64e0bf409f3287c29"
// <auto-generated/>
#pragma warning disable 1591
namespace Admin.Shared
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Admin.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Admin.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DotNet\JSR\JSR_PROJECT\Admin\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class DeleteConfirmation : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade");
            __builder.AddAttribute(2, "data-backdrop", "static");
            __builder.AddAttribute(3, "data-keyboard", "false");
            __builder.AddAttribute(4, "id", "deleteConfirmationModal");
            __builder.AddAttribute(5, "tabindex", "-1");
            __builder.AddAttribute(6, "role", "dialog");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog  modal-dialog-centered");
            __builder.AddAttribute(9, "role", "document");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-header");
            __builder.AddMarkupContent(14, "<h5 class=\"modal-title\" id=\"exampleModalLabel\">Confirm Delete</h5>\r\n                ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "close");
            __builder.AddAttribute(18, "data-dismiss", "modal");
            __builder.AddAttribute(19, "aria-label", "Close");
            __builder.AddAttribute(20, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\DotNet\JSR\JSR_PROJECT\Admin\Shared\DeleteConfirmation.razor"
                                  ()=>OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, "<div class=\"modal-body\">\r\n                Are you sure you want to delete\r\n            </div>\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal-footer");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-secondary");
            __builder.AddAttribute(29, "data-dismiss", "modal");
            __builder.AddAttribute(30, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\DotNet\JSR\JSR_PROJECT\Admin\Shared\DeleteConfirmation.razor"
                                                                                               ()=>OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "\r\n                    Cancel\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 19 "D:\DotNet\JSR\JSR_PROJECT\Admin\Shared\DeleteConfirmation.razor"
                 if (IsProcessStart)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<button type=\"button\" class=\"btn btn-danger\"><i class=\"fa fa-spin fa-spinner\"></i>Processing..</button>");
#nullable restore
#line 22 "D:\DotNet\JSR\JSR_PROJECT\Admin\Shared\DeleteConfirmation.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\DotNet\JSR\JSR_PROJECT\Admin\Shared\DeleteConfirmation.razor"
                                                                           ()=>OnConfirmationChange(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\r\n                        Delete\r\n                    ");
            __builder.CloseElement();
#nullable restore
#line 28 "D:\DotNet\JSR\JSR_PROJECT\Admin\Shared\DeleteConfirmation.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\DotNet\JSR\JSR_PROJECT\Admin\Shared\DeleteConfirmation.razor"
       

    public bool IsProcessStart { get; set; } = false;

    [Parameter]
    public EventCallback<bool> ConfirmationChanged { get; set; }

    [Parameter]
    public bool IsParentComponentProcessing { get; set; }

    protected override void OnParametersSet()
    {
        IsProcessStart = IsParentComponentProcessing;
    }

    protected async Task OnConfirmationChange(bool value)
    {
        if (value)
        {
            IsProcessStart = true;
        }
        await ConfirmationChanged.InvokeAsync(value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
