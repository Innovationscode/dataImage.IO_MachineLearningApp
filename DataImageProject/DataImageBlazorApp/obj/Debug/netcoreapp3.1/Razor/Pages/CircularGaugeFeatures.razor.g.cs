#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "682745334e1583870fbc32b2aaccbf696aff5445"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
using Syncfusion.Blazor.CircularGauge;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/circulargauge-features")]
    public partial class CircularGaugeFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Circular Gauge</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.CircularGauge.SfCircularGauge>(4);
            __builder.AddAttribute(5, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.CircularGauge.GaugeTheme>(
#nullable restore
#line 6 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                            GaugeTheme.Bootstrap4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "EnablePointerDrag", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n         ");
                __builder2.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeTooltipSettings>(9);
                __builder2.AddAttribute(10, "Enable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAxes>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAxis>(15);
                    __builder3.AddAttribute(16, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.CircularGauge.GaugeDirection>(
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                          GaugeDirection.ClockWise

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                                210

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                                               150

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Minimum", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                                                             0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "Maximum", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                                                                         120

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Radius", "80%");
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(23, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAxisLineStyle>(24);
                        __builder4.AddAttribute(25, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                   10

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "Color", "transparent");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAxisLabelStyle>(28);
                        __builder4.AddAttribute(29, "UseRangeColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(31, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAxisLabelFont>(32);
                            __builder5.AddAttribute(33, "Size", "12px");
                            __builder5.AddAttribute(34, "FontFamily", "Roboto");
                            __builder5.AddAttribute(35, "FontStyle", "Regular");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(36, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAxisMajorTicks>(38);
                        __builder4.AddAttribute(39, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                     15

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "Offset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                 5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "UseRangeColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAxisMinorTicks>(43);
                        __builder4.AddAttribute(44, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 18 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                     10

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(45, "UseRangeColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n                 ");
                        __builder4.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAnnotations>(47);
                        __builder4.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(49, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAnnotation>(50);
                            __builder5.AddAttribute(51, "Radius", "30%");
                            __builder5.AddAttribute(52, "Angle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 21 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                 0

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(53, "ZIndex", "1");
                            __builder5.AddAttribute(54, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(55, "\r\n                            ");
                                __builder6.AddMarkupContent(56, "<div><span style=\"font-size:14px; color:#9E9E9E; font-family:Regular; margin-left: -33px\">Speedometer</span></div>\r\n                        ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(57, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeAnnotation>(58);
                            __builder5.AddAttribute(59, "Radius", "40%");
                            __builder5.AddAttribute(60, "Angle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 26 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                 180

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(61, "ZIndex", "1");
                            __builder5.AddAttribute(62, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(63, "\r\n                            ");
                                __builder6.AddMarkupContent(64, "<div><span style=\"font-size:20px; color:#424242; font-family:Regular; margin-left: -33px\">65 MPH</span></div>\r\n                        ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(65, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeRanges>(67);
                        __builder4.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(69, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeRange>(70);
                            __builder5.AddAttribute(71, "Start", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 33 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                               0

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(72, "End", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 33 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                       40

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(73, "Color", "#30B32D");
                            __builder5.AddAttribute(74, "StartWidth", "10");
                            __builder5.AddAttribute(75, "EndWidth", "10");
                            __builder5.AddAttribute(76, "RoundedCornerRadius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 33 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                                                                              0

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(77, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeRange>(78);
                            __builder5.AddAttribute(79, "Start", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 35 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                               40

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(80, "End", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 35 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                        80

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(81, "Color", "#FFDD00");
                            __builder5.AddAttribute(82, "StartWidth", "10");
                            __builder5.AddAttribute(83, "EndWidth", "10");
                            __builder5.AddAttribute(84, "RoundedCornerRadius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 35 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                                                                               0

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(85, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeRange>(86);
                            __builder5.AddAttribute(87, "Start", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 37 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                               80

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(88, "End", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 37 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                        120

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(89, "Color", "#F03E3E");
                            __builder5.AddAttribute(90, "StartWidth", "10");
                            __builder5.AddAttribute(91, "EndWidth", "10");
                            __builder5.AddAttribute(92, "RoundedCornerRadius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 37 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                                                                                0

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(93, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(94, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugePointers>(95);
                        __builder4.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(97, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugePointer>(98);
                            __builder5.AddAttribute(99, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                 65

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(100, "Radius", "60%");
                            __builder5.AddAttribute(101, "PointerWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                                                7

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(103, "\r\n                        ");
                                __builder6.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeCap>(104);
                                __builder6.AddAttribute(105, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 42 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                  7

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(106, "Color", "#757575");
                                __builder6.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(108, "\r\n                            ");
                                    __builder7.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeCapBorder>(109);
                                    __builder7.AddAttribute(110, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 43 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CircularGaugeFeatures.razor"
                                                           8

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(111, "\r\n                        ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(112, "\r\n                        ");
                                __builder6.OpenComponent<Syncfusion.Blazor.CircularGauge.CircularGaugeNeedleTail>(113);
                                __builder6.AddAttribute(114, "Length", "25%");
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(115, "\r\n                    ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(116, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(117, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(118, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(120, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n<br>\r\n");
            __builder.AddMarkupContent(122, @"<div>
  <h3>Selected Features:</h3>
    <ul class=""ulstyle"">
      <li class=""list""> Enable Tooltip</li>
      <li class=""list""> Enable Drag</li>
      <li class=""list""> Axis Direction - Clockwise</li>
      <li class=""list""> Theme - Bootstrap v4</li>
    </ul>
</div>
<br>
");
            __builder.AddMarkupContent(123, "<style>\r\n    .ulstyle {\r\n        margin: 0px;\r\n        padding-left: 20px;\r\n        display: inline-block;\r\n    }\r\n    .list {\r\n    float: left;\r\n    line-height: 20px;\r\n    margin: 10px;\r\n    min-width: 260px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
