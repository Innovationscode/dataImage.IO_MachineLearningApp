#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b81764031a001f6b15090a2b0663bbdddaf9a2"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dialog-features")]
    public partial class DialogFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Dialog</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n  ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-lg-12 control-section");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "id", "normalbtn");
            __builder.AddAttribute(9, "class", "e-btn open-btn");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
                                                             OnBtnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Open");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(13);
            __builder.AddAttribute(14, "Width", "500px");
            __builder.AddAttribute(15, "AllowDragging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "EnableResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
                                                                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(21);
                __builder2.AddAttribute(22, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, " About SYNCFUSION succinctly series ");
                }
                ));
                __builder2.AddAttribute(24, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(25, " ");
                    __builder3.AddMarkupContent(26, @"<p>In the Succinctly series, Syncfusion created a robust, free library of more than 130 technical e - books formatted for PDF, Kindle, and EPUB.<br> <br>The Succinctly series was born in 2012 out of a desire to provide concise technical e-books for software developers.Each title in the Succinctly series is written by a carefully chosen expert and provides essential content in about 100 pages.</p> ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(28);
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(31);
                    __builder3.AddAttribute(32, "ButtonModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
                                        DialogBtn

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(35, (__value) => {
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
                    DialogObj = (Syncfusion.Blazor.Popups.SfDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n<br>\r\n");
            __builder.AddMarkupContent(39, @"<div>
  <h3>Selected Features:</h3>
    <ul class=""ulstyle"">
      <li class=""list""> Dialog Samples - Default</li>
      <li class=""list""> Resizable</li>
      <li class=""list""> Modal</li>
      <li class=""list""> Draggable</li>
      <li class=""list""> Theme - Bootstrap v4</li>
    </ul>
</div>
<br>
");
            __builder.AddMarkupContent(40, @"<style>
	 .open-btn {
        position: relative;
        left: 50%;
        top: 50%;
    }
    html,body,app{
        width:100%;
        height:100%;
    }
    a, a:hover, .highcontrast #dialog a, .highcontrast #dialog a:hover {
        color: inherit;
        text-decoration: none;
    }
    .fabric #target .e-dialog {
        height: 306px;
    }
    .material #target .e-dialog {
        height: 270px;
    }
    .bootstrap4 #target .e-dialog {
        height: 305px;
    }
    .e-dialog {
        height: 270px;
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
    min-width: 200px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DialogFeatures.razor"
       
    SfDialog DialogObj;
    private void OnBtnClick()
    {
        this.DialogObj.Show();
    }
    public ButtonModel DialogBtn = new ButtonModel { Content = "<a id='newTab' href='https://www.syncfusion.com/company/about-us' target='_blank'>Learn More</a>", IsPrimary = true };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591