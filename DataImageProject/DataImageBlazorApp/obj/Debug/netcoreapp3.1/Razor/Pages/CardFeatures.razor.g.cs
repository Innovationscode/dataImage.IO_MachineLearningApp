#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CardFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0740d1da34bbcc1b3710258a48155a49c7d2741b"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CardFeatures.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\CardFeatures.razor"
using Syncfusion.Blazor.Cards;

#line default
#line hidden
#nullable disable
    public partial class CardFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(0);
            __builder.AddAttribute(1, "ID", "BasicCard");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardHeader>(4);
                __builder2.AddAttribute(5, "Title", "Debunking Five Data Science Myths");
                __builder2.AddAttribute(6, "SubTitle", "By John Doe | Jan 20, 2018");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(8);
                __builder2.AddAttribute(9, "Content", @"Tech evangelists are currently pounding their pulpits about all things AI, machine learning, analytics anything that sounds like the future and probably involves lots of numbers. Many of these topics can be grouped under the intimidating term data science.");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardFooter>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Cards.CardFooterContent>(14);
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(16, "\r\n            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(17);
                        __builder4.AddAttribute(18, "CssClass", "e-btn e-outline e-primary");
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(20, "Read More");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, "\r\n\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(25, @"<style>
      #BasicCard, #NewIconCard {
        height: 300px;
         width: 400px;
        margin: 16px auto;
    }
    .newIcon {
        background: #2CC000;
        border-radius: 12px;
        border-radius: 12px;
        font-family: HelveticaNeue-Medium, 'Segoe UI';
        font-weight: 500;
        color: #ffffff;
        margin-left: 16px;
        font-size: 14px;
        width: 58px;
        height: 24px;
        display: flex;
        justify-content: center;
        align-items: center;
        letter-spacing: 0.4px;
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
