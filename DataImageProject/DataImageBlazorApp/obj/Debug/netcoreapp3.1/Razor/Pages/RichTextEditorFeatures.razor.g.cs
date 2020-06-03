#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\RichTextEditorFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b817551c6d5ea23cef43b621c0082b2d8d6dad"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\RichTextEditorFeatures.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\RichTextEditorFeatures.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/richtexteditor-features")]
    public partial class RichTextEditorFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Rich Text Editor</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n  ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "control-section");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "control-wrapper");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "control-section");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.RichTextEditor.SfRichTextEditor>(13);
            __builder.AddAttribute(14, "ShowCharCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\RichTextEditorFeatures.razor"
                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "EnableResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\RichTextEditorFeatures.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\RichTextEditorFeatures.razor"
                                                                                   2000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.AddMarkupContent(19, @"<p>The rich text editor is WYSIWYG ('what you see is what you get') editor useful to create and edit content, and return the valid <a href=""https://ej2.syncfusion.com/aspnetcore/documentation/rich-text-editor/formation/?no-cache=1#markdown-editor"">HTML markup</a> or <a href=""https://ej2.syncfusion.com/aspnetcore/documentation/rich-text-editor/formation/?no-cache=1#html-editor"">markdown</a> of the content</p>");
                __builder2.AddMarkupContent(20, "<b>Toolbar</b>");
                __builder2.AddMarkupContent(21, "<ol><li>Toolbar contains commands to align the text, insert link, insert image, insert list, undo / redo operations, HTML view, etc </li><li>Toolbar is fully customizable </li></ol>");
                __builder2.AddMarkupContent(22, "<b>Links</b>");
                __builder2.AddMarkupContent(23, "<ol><li> You can insert a hyperlink with its corresponding dialog</li><li> Attach a hyperlink to the displayed text. </li><li> Customize the quick toolbar based on the hyperlink </li></ol>");
                __builder2.AddMarkupContent(24, "<b>Image.</b>");
                __builder2.AddMarkupContent(25, @"<ol><li> Allows you to insert images from an online source as well as the local computer</li><li> You can upload an image</li><li> Provides an option to customize quick toolbar for an image </li></ol><img alt=""Logo"" src=""RTEImage-Feather.png"" style=""width: 300px"">
                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.RichTextEditor.RichTextEditorToolbarSettings>(26);
                __builder2.AddAttribute(27, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\RichTextEditorFeatures.razor"
                                                           Tools

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                     ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n<br>\r\n");
            __builder.AddMarkupContent(34, @"<div>
  <h3>Selected Features:</h3>
    <ul class=""ulstyle"">
      <li class=""list""> Rich Text Editor Samples - Overview</li>
      <li class=""list""> Enable Resize</li>
      <li class=""list""> Show Characters Count</li>
      <li class=""list""> Theme - Bootstrap v4</li>
    </ul>
</div>
<br>
");
            __builder.AddMarkupContent(35, @"<style>
    .e-code-mirror::before {
        content: '\e345';
    }
    .e-html-preview::before {
        content: '\e350';
    }
    .CodeMirror-linenumber,
    .CodeMirror-gutters {
        display: none;
    }
    .sb-header {
        z-index: 100;
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
    min-width: 350px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\RichTextEditorFeatures.razor"
       
    public object[] Tools = new object[]{
        "Bold", "Italic", "Underline", "StrikeThrough",
        "FontName", "FontSize", "FontColor", "BackgroundColor",
        "LowerCase", "UpperCase", "|",
        "Formats", "Alignments", "OrderedList", "UnorderedList",
        "Outdent", "Indent", "|",
        "CreateTable", "CreateLink", "Image", "|", "ClearFormat", "Print",
        "SourceCode", "|", "Undo", "Redo"
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
