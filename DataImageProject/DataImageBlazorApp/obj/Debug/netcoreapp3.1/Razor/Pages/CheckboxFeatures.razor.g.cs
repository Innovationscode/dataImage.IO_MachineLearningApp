#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CheckboxFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17598daa372fa1ad6b80515e4e49fcc032001848"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CheckboxFeatures.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkbox-features")]
    public partial class CheckboxFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Checkbox</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "control-section");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "checkbox-control");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfCheckBox>(13);
            __builder.AddAttribute(14, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CheckboxFeatures.razor"
                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Label", "CheckBox");
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfCheckBox>(21);
            __builder.AddAttribute(22, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CheckboxFeatures.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CheckboxFeatures.razor"
                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Label", "Checked, Disabled");
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfCheckBox>(30);
            __builder.AddAttribute(31, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CheckboxFeatures.razor"
                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CheckboxFeatures.razor"
                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "Label", "Indeterminate, Disabled");
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n<br>\r\n");
            __builder.AddMarkupContent(39, "<div>\r\n  <h3>Selected Features:</h3>\r\n    <ul class=\"ulstyle\">\r\n      <li class=\"list\"> Default</li>\r\n      <li class=\"list\"> Theme - Bootstrap v4</li>\r\n    </ul>\r\n</div>\r\n<br>\r\n");
            __builder.AddMarkupContent(40, @"<style>
        #ControlRegion {
            margin: 0 auto;
            width: 25%;
            padding: 3%;
        }
    .checkbox-control {
        margin: 12% 0 12% 40%;
    }
    @media only screen and (max-width: 700px) {
        .checkbox-control {
            margin: 20% 0 0 32%;
        }
        .control-section {
            min-height: 200px;
        }
    }
    @media only screen and (max-width: 500px) {
        .control-section {
            min-height: 200px;
        }
        .checkbox-control {
            margin-top: 27%;
            margin-left: 20%;
            margin-bottom: 27%;
        }
    }
    .control-section .row {
        margin: 20px 0;
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
    }
}
#pragma warning restore 1591