#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20069dbb444cd488f6ab9e9520b249c22cb6c36"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/smithchart-features")]
    public partial class SmithChartFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Smith Chart</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n\t");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfSmithchart>(4);
            __builder.AddAttribute(5, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 6 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                          1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.SmithchartTheme>(
#nullable restore
#line 6 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                    SmithchartTheme.Bootstrap4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "RenderType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.RenderType>(
#nullable restore
#line 6 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                                            ChartRenderType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.SmithchartHorizontalAxis>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.SmithchartHorizontalMinorGridLines>(13);
                    __builder3.AddAttribute(14, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.SmithchartRadialAxis>(17);
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.SmithchartRadialMinorGridLines>(20);
                    __builder3.AddAttribute(21, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.SmithchartTitle>(24);
                __builder2.AddAttribute(25, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Text", "Impedance Transmission");
                __builder2.AddAttribute(27, "EnableTrim", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "MaximumWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 13 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                                                                  200

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.SmithchartTitleFont>(31);
                    __builder3.AddAttribute(32, "Size", "16px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeriesCollection>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeries>(38);
                    __builder3.AddAttribute(39, "Name", "Transmission1");
                    __builder3.AddAttribute(40, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                           FirstTransmissionData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Resistance", "resistance");
                    __builder3.AddAttribute(42, "Reactance", "reactance");
                    __builder3.AddAttribute(43, "EnableAnimation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                                                                                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "EnableSmartLabels", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                                                                                                                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Fill", "#0F94C4");
                    __builder3.AddAttribute(46, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 17 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                                                                                                                                                                      2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(48, "\r\n            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeriesTooltip>(49);
                        __builder4.AddAttribute(50, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                              true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(51, "\r\n               ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeriesMarker>(52);
                        __builder4.AddAttribute(53, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(54, "Shape", "Rectangle");
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(56, "\r\n                ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeriesDatalabel>(57);
                            __builder5.AddAttribute(58, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                    true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(59, "\r\n                ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeriesMarkerBorder>(60);
                            __builder5.AddAttribute(61, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 21 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                     2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(62, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(63, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeries>(65);
                    __builder3.AddAttribute(66, "Name", "Transmission2");
                    __builder3.AddAttribute(67, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                           SecondTransmissionData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "Resistance", "resistance");
                    __builder3.AddAttribute(69, "Reactance", "reactance");
                    __builder3.AddAttribute(70, "EnableAnimation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                                                                                                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "EnableSmartLabels", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                                                                                                                                           true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "Fill", "#EE0C88");
                    __builder3.AddAttribute(73, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 25 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                                                                                                                                                                       2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(75, "\r\n            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeriesTooltip>(76);
                        __builder4.AddAttribute(77, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                              true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(78, "\r\n               ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeriesMarker>(79);
                        __builder4.AddAttribute(80, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(81, "Shape", "Rectangle");
                        __builder4.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(83, "\r\n                ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeriesDatalabel>(84);
                            __builder5.AddAttribute(85, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                    true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(86, "\r\n                ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Charts.SmithchartSeriesMarkerBorder>(87);
                            __builder5.AddAttribute(88, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 29 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                                     2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(89, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(90, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.SmithchartLegendSettings>(93);
                __builder2.AddAttribute(94, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "Shape", "Circle");
                __builder2.AddAttribute(96, "Position", "Left");
                __builder2.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(98, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.SmithchartBorder>(99);
                    __builder3.AddAttribute(100, "Color", "transparent");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.SmithchartLegendTitle>(102);
                    __builder3.AddAttribute(103, "Text", "");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(104, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n<br>\r\n");
            __builder.AddMarkupContent(108, @"<div>
  <h3>Selected Features:</h3>
    <ul class=""ulstyle"">
      <li class=""list""> Enable Tooltip</li>
      <li class=""list""> Marker</li>
      <li class=""list""> Data Label</li>
      <li class=""list""> Animation</li>
      <li class=""list""> Legend Position - Left</li>
      <li class=""list""> Theme - Bootstrap v4</li>
    </ul>
</div>
<br>
");
            __builder.AddMarkupContent(109, "<style>\r\n    .ulstyle {\r\n        margin: 0px;\r\n        padding-left: 20px;\r\n        display: inline-block;\r\n    }\r\n    .list {\r\n    float: left;\r\n    line-height: 20px;\r\n    margin: 10px;\r\n    min-width: 200px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SmithChartFeatures.razor"
       
    private RenderType ChartRenderType = RenderType.Impedance;
    public class SmithDataSource
    {
        public double? resistance;
        public double? reactance;
    };
    public List<SmithDataSource> FirstTransmissionData = new List<SmithDataSource> {
        new SmithDataSource { resistance= 10, reactance= 25 }, new SmithDataSource { resistance= 8, reactance= 6 },
        new SmithDataSource { resistance= 6, reactance= 4.5 }, new SmithDataSource { resistance= 4.5, reactance= 4 },
        new SmithDataSource { resistance= 3.5, reactance= 3 }, new SmithDataSource { resistance= 2.5, reactance= 2 },
        new SmithDataSource { resistance= 2, reactance= 1.5 }, new SmithDataSource { resistance= 1.5, reactance= 1.25 },
        new SmithDataSource { resistance= 1, reactance= 0.9 }, new SmithDataSource { resistance= 0.5, reactance= 0.6 },
        new SmithDataSource { resistance= 0.3, reactance= 0.4 }, new SmithDataSource { resistance= 0, reactance= 0.15 },
    };
    public List<SmithDataSource> SecondTransmissionData = new List<SmithDataSource> {
        new SmithDataSource { resistance= 20, reactance= -50 }, new SmithDataSource { resistance= 10, reactance= -10 },
        new SmithDataSource { resistance= 9, reactance= -4.5 }, new SmithDataSource { resistance= 8, reactance= -3.5 },
        new SmithDataSource { resistance= 7, reactance= -2.5 }, new SmithDataSource{ resistance= 6, reactance= -1.5 },
        new SmithDataSource { resistance= 5, reactance= -1 }, new SmithDataSource { resistance= 4.5, reactance= -0.8 },
        new SmithDataSource { resistance= 3.5, reactance= -0.8 }, new SmithDataSource { resistance= 2.5, reactance= -0.4 },
        new SmithDataSource { resistance= 2, reactance= -0.2 }, new SmithDataSource { resistance= 1.5, reactance= 0 },
        new SmithDataSource { resistance= 1, reactance= 0.1 }, new SmithDataSource { resistance= 0.5, reactance= 0.2 },
        new SmithDataSource { resistance= 0.3, reactance= 0.15 }, new SmithDataSource { resistance= 0, reactance= 0.05 },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591