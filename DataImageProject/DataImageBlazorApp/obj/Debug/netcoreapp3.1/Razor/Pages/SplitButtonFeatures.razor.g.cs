#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SplitButtonFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e995e3073701ba3b0fac158c65fa46514884022"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SplitButtonFeatures.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\SplitButtonFeatures.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/splitbutton-features")]
    public partial class SplitButtonFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Split Button</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.SplitButtons.SfSplitButton>(4);
            __builder.AddAttribute(5, "IconCss", "e-btn-icons e-paste");
            __builder.AddAttribute(6, "Content", "Paste");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.SplitButtons.SplitButtonItems>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.SplitButtons.SplitButtonItem>(12);
                    __builder3.AddAttribute(13, "Text", "Paste");
                    __builder3.AddAttribute(14, "IconCss", "e-btn-icons e-paste");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.SplitButtons.SplitButtonItem>(16);
                    __builder3.AddAttribute(17, "Text", "Paste Special");
                    __builder3.AddAttribute(18, "IconCss", "e-btn-icons e-paste-special");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.SplitButtons.SplitButtonItem>(20);
                    __builder3.AddAttribute(21, "Text", "Paste as Formula");
                    __builder3.AddAttribute(22, "IconCss", "e-btn-icons e-paste-formula");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.SplitButtons.SplitButtonItem>(24);
                    __builder3.AddAttribute(25, "Text", "Paste as Hyperlink");
                    __builder3.AddAttribute(26, "IconCss", "e-btn-icons e-paste-hyperlink");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n<br>\r\n");
            __builder.AddMarkupContent(31, "<div>\r\n  <h3>Selected Features:</h3>\r\n    <ul class=\"ulstyle\">\r\n      <li class=\"list\"> Default</li>\r\n      <li class=\"list\"> Theme - Bootstrap v4</li>\r\n    </ul>\r\n</div>\r\n<br>\r\n");
            __builder.AddMarkupContent(32, "<style>\r\n    .ulstyle {\r\n        margin: 0px;\r\n        padding-left: 20px;\r\n        display: inline-block;\r\n    }\r\n    .list {\r\n    float: left;\r\n    line-height: 20px;\r\n    margin: 10px;\r\n    min-width: 200px;\r\n    }\r\n    #ControlRegion {\r\n        margin: 0 auto;\r\n        width: 15%;\r\n        padding: 3%;\r\n    }\r\n    /*Splitbutton*/\r\n    @font-face {\r\n        font-family: \'e-btn-icons\';\r\n        src: url(data:application/x-font-ttf;charset=utf-8;base64,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AwYHCQsMAAAAAAASAN4AAQAAAAAAAAABAAAAAQAAAAAAAQAnAAEAAQAAAAAAAgAHACgAAQAAAAAAAwAnAC8AAQAAAAAABAAnAFYAAQAAAAAABQALAH0AAQAAAAAABgAnAIgAAQAAAAAACgAsAK8AAQAAAAAACwASANsAAwABBAkAAAACAO0AAwABBAkAAQBOAO8AAwABBAkAAgAOAT0AAwABBAkAAwBOAUsAAwABBAkABABOAZkAAwABBAkABQAWAecAAwABBAkABgBOAf0AAwABBAkACgBYAksAAwABBAkACwAkAqMgRUoyIFNwbGl0IGJ1dHRvbiBwYXN0ZSBpY29ucyBmb3IgdGhlbWVzUmVndWxhckVKMiBTcGxpdCBidXR0b24gcGFzdGUgaWNvbnMgZm9yIHRoZW1lc0VKMiBTcGxpdCBidXR0b24gcGFzdGUgaWNvbnMgZm9yIHRoZW1lc1ZlcnNpb24gMS4wRUoyIFNwbGl0IGJ1dHRvbiBwYXN0ZSBpY29ucyBmb3IgdGhlbWVzRm9udCBnZW5lcmF0ZWQgdXNpbmcgU3luY2Z1c2lvbiBNZXRybyBTdHVkaW93d3cuc3luY2Z1c2lvbi5jb20AIABFAEoAMgAgAFMAcABsAGkAdAAgAGIAdQB0AHQAbwBuACAAcABhAHMAdABlACAAaQBjAG8AbgBzACAAZgBvAHIAIAB0AGgAZQBtAGUAcwBSAGUAZwB1AGwAYQByAEUASgAyACAAUwBwAGwAaQB0ACAAYgB1AHQAdABvAG4AIABwAGEAcwB0AGUAIABpAGMAbwBuAHMAIABmAG8AcgAgAHQAaABlAG0AZQBzAEUASgAyACAAUwBwAGwAaQB0ACAAYgB1AHQAdABvAG4AIABwAGEAcwB0AGUAIABpAGMAbwBuAHMAIABmAG8AcgAgAHQAaABlAG0AZQBzAFYAZQByAHMAaQBvAG4AIAAxAC4AMABFAEoAMgAgAFMAcABsAGkAdAAgAGIAdQB0AHQAbwBuACAAcABhAHMAdABlACAAaQBjAG8AbgBzACAAZgBvAHIAIAB0AGgAZQBtAGUAcwBGAG8AbgB0ACAAZwBlAG4AZQByAGEAdABlAGQAIAB1AHMAaQBuAGcAIABTAHkAbgBjAGYAdQBzAGkAbwBuACAATQBlAHQAcgBvACAAUwB0AHUAZABpAG8AdwB3AHcALgBzAHkAbgBjAGYAdQBzAGkAbwBuAC4AYwBvAG0AAAAAAgAAAAAAAAAKAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAALAQIBAwEEAQUBBgEHAQgBCQEKAQsBDAAOUGFzdGVfTWF0ZXJpYWwVUGFzdGVTcGVjaWFsX01hdGVyaWFsFlBhc3RlRm9ybXVsYV9Cb290c3RyYXAYUGFzdGVIeXBlcmxpbmtfQm9vdHN0cmFwFlBhc3RlU3BlY2lhbF9Cb290c3RyYXAVUGFzdGVGb3JtdWxhX01hdGVyaWFsD1Bhc3RlX0Jvb3RzdHJhcBdQYXN0ZUh5cGVybGlua19NYXRlcmlhbBNQYXN0ZU1haW5fQm9vdHN0cmFwElBhc3RlTWFpbl9NYXRlcmlhbAAA) format(\'truetype\');\r\n        font-weight: normal;\r\n        font-style: normal;\r\n    }\r\n    .e-btn-icons {\r\n        font-family: \'e-btn-icons\';\r\n        font-weight: normal;\r\n    }\r\n    .e-paste::before {\r\n        content: \'\\e700\';\r\n    }\r\n    .e-paste-special::before {\r\n        content: \'\\e701\';\r\n    }\r\n    .e-paste-formula::before {\r\n        content: \'\\e705\';\r\n    }\r\n    .e-paste-hyperlink::before {\r\n        content: \'\\e707\';\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
