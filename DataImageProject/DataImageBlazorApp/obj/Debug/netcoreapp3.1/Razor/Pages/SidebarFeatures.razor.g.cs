#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d07b96560464784ecbe6d38ee28652e1395f26"
// <auto-generated/>
#pragma warning disable 1591
namespace DataImageBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using DataImageBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using DataImageBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sidebar-features")]
    public partial class SidebarFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Sidebar</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfSidebar>(4);
            __builder.AddAttribute(5, "Width", "250px");
            __builder.AddAttribute(6, "Target", "#sidebar-content");
            __builder.AddAttribute(7, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.SidebarType>(
#nullable restore
#line 7 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
                                                                               SidebarType.Over

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "style", "text-align: center;");
                __builder2.AddAttribute(12, "class", "text-content");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.AddMarkupContent(14, "<span>Sidebar</span>\r\n                ");
                __builder2.AddMarkupContent(15, "<div class=\"sub-title\">\r\n                    Place your primary content here.\r\n                </div>\r\n                ");
                __builder2.OpenElement(16, "span");
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(18);
                __builder2.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
                                        Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(22, "Close Sidebar");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
            }
            ));
            __builder.AddComponentReferenceCapture(26, (__value) => {
#nullable restore
#line 7 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
                     sidebarObj = (Syncfusion.Blazor.Navigations.SfSidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "id", "sidebar-content");
            __builder.AddAttribute(30, "class", "text-content");
            __builder.AddAttribute(31, "style", "text-align: center;");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, "<div>Main content</div>\r\n        ");
            __builder.AddMarkupContent(34, "<div class=\"sub-title\"> Click the button to open/close the Sidebar.</div>\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(37);
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
                                Toggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "IsToggle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(42, "Toggle Sidebar");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n<br>\r\n");
            __builder.AddMarkupContent(47, "<div>\r\n  <h3>Selected Features:</h3>\r\n    <ul class=\"ulstyle\">\r\n      <li class=\"list\"> Sidebar Samples - Default</li>\r\n      <li class=\"list\"> Theme - Bootstrap v4</li>\r\n    </ul>\r\n</div>\r\n<br>\r\n");
            __builder.AddMarkupContent(48, @"<style>
    .e-sidebar {
        background-color: #f8f8f8;
        color: black;
    }
    .text-content {
        font-size: 1.5rem;
        padding: 3rem;
    }
    #sidebar-content{
        height: 60vh;
    }
    .sub-title {
        text-align: center;
        font-size: 14px;
        padding: 10px;
    }
    .ulstyle {
        margin: 0px;
        padding-left: 20px;
        display: inline-block;
    }
    .list {
    float: left;
    line-height: 20px;
    margin: 10px;
    min-width: 220px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SidebarFeatures.razor"
      
    SfSidebar sidebarObj;
    public void Close()
    {
        this.sidebarObj.Hide();
    }
    public void Toggle()
    {
        this.sidebarObj.Toggle();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591