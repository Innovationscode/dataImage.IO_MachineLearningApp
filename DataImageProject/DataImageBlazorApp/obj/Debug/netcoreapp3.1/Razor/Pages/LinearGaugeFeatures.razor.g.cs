#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d53a20db290a9d513063080513a4211ad4cacdb"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
using Syncfusion.Blazor.LinearGauge;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lineargauge-features")]
    public partial class LinearGaugeFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Linear Gauge</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8 control-section");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content-wrapper");
            __builder.AddMarkupContent(9, "\r\n\t");
            __builder.OpenComponent<Syncfusion.Blazor.LinearGauge.SfLinearGauge>(10);
            __builder.AddAttribute(11, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.LinearGauge.LinearGaugeTheme>(
#nullable restore
#line 8 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                          LinearGaugeTheme.Bootstrap4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Orientation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.LinearGauge.Orientation>(
#nullable restore
#line 8 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                                    Orientation.Horizontal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.LinearGauge.LinearGaugeContainer>(15);
                __builder2.AddAttribute(16, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.LinearGauge.ContainerType>(
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                            ContainerType.Normal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                                         25

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                 ");
                __builder2.OpenComponent<Syncfusion.Blazor.LinearGauge.LinearGaugeTooltipSettings>(19);
                __builder2.AddAttribute(20, "Enable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.LinearGauge.LinearGaugeAxes>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.LinearGauge.LinearGaugeAxis>(25);
                    __builder3.AddAttribute(26, "IsInversed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "OpposedPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(29, "\r\n                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.LinearGauge.LinearGaugeAxisLabelStyle>(30);
                        __builder4.AddAttribute(31, "Offset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 13 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                           0

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\r\n                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.LinearGauge.LinearGaugePointers>(33);
                        __builder4.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(35, "\r\n                            ");
                            __builder5.OpenComponent<Syncfusion.Blazor.LinearGauge.LinearGaugePointer>(36);
                            __builder5.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                       50

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(38, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                                   15

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(39, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                                              15

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(40, "Placement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.LinearGauge.Placement>(
#nullable restore
#line 16 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                                                             Placement.Near

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(41, "Offset", "-0");
                            __builder5.AddAttribute(42, "Color", "#f02828");
                            __builder5.AddAttribute(43, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.LinearGauge.Point>(
#nullable restore
#line 16 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                                                                                                               Point.Bar

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(44, "\r\n                        ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.LinearGauge.LinearGaugeMajorTicks>(46);
                        __builder4.AddAttribute(47, "Interval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 18 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                         10

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 18 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                                     20

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.LinearGauge.LinearGaugeMinorTicks>(50);
                        __builder4.AddAttribute(51, "Interval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 19 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                         2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(52, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 19 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\LinearGaugeFeatures.razor"
                                                                    10

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(53, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n<br>\r\n");
            __builder.AddMarkupContent(60, @"<div>
  <h3>Selected Features:</h3>
    <ul class=""ulstyle"">
      <li class=""list""> Enable Tooltip</li>
      <li class=""list""> Axis Inversed</li>
      <li class=""list""> Orientation - Horizontal</li>
      <li class=""list""> Container Type - Normal</li>
      <li class=""list""> Theme - Bootstrap v4</li>
    </ul>
</div>
<br>
");
            __builder.AddMarkupContent(61, @"<style>
   .control-section{
        margin:0 auto;
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
