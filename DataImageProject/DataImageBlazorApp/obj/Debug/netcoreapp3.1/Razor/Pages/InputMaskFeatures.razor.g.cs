#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\InputMaskFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "005969985c711a159695bef5586c2818cce8b83d"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\InputMaskFeatures.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\InputMaskFeatures.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inputmask-features")]
    public partial class InputMaskFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Input Mask</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-lg-12 control-section");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "control_wrapper");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<div class=\"control-label\">\r\n            Mobile Number\r\n        </div>\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfMaskedTextBox>(11);
            __builder.AddAttribute(12, "Mask", "000-000-0000");
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<div class=\"control-label\">\r\n                Country ISO Code\r\n            </div>\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfMaskedTextBox>(15);
            __builder.AddAttribute(16, "Mask", ">LL / LLL");
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.AddMarkupContent(18, "<div class=\"control-label\">\r\n                D.O.B\r\n            </div>\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfMaskedTextBox>(19);
            __builder.AddAttribute(20, "Mask", "00/00/0000");
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<div class=\"control-label\">\r\n                Product Key\r\n            </div>\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfMaskedTextBox>(23);
            __builder.AddAttribute(24, "Mask", ">AAAAA-AAAAA-AAAAA-AAAAA");
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n<br>\r\n");
            __builder.AddMarkupContent(29, "<div>\r\n  <h3>Selected Features:</h3>\r\n    <ul class=\"ulstyle\">\r\n      <li class=\"list\"> Input Mask Samples - Default</li>\r\n      <li class=\"list\"> Theme - Bootstrap v4</li>\r\n    </ul>\r\n</div>\r\n<br>\r\n");
            __builder.AddMarkupContent(30, @"<style>
    .control_wrapper {
        width: 350px;
        margin: 0 auto;
        padding: 3%;
    }
    .control-label {
        padding: 24px 0px 10px 0px;
        font-size: 12px;
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
    min-width: 280px;
    }
</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
