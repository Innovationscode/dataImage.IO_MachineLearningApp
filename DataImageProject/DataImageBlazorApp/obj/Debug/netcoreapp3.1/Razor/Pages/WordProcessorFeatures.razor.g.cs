#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb31046e5e71a618d9682f9e21579690f3d3f452"
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
using Syncfusion.Blazor.DocumentEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
using DataImageBlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/wordprocessor-features")]
    public partial class WordProcessorFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Word Processor</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "ControlRegion");
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "control-section");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "id", "control-container");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "id", "documenteditor_titlebar");
            __builder.AddAttribute(12, "class", "e-de-ctn-title");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "single-line");
            __builder.AddAttribute(16, "id", "documenteditor_title_contentEditor");
            __builder.AddAttribute(17, "style", "border: 1px solid transparent;");
            __builder.AddAttribute(18, "title", "Document Name.");
            __builder.AddAttribute(19, "contenteditable", "false");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "label");
            __builder.AddAttribute(22, "id", "documenteditor_title_name");
            __builder.AddAttribute(23, "class", "doc-edit-title");
            __builder.AddContent(24, " ");
            __builder.AddContent(25, 
#nullable restore
#line 12 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
                                                                               DocumentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "style", "float: right");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(31);
            __builder.AddAttribute(32, "IconCss", "e-de-ctn-title-print");
            __builder.AddAttribute(33, "CssClass", "title-bar-btn");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
                                                                                            Print

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(36, "Print");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "float: right");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(42);
            __builder.AddAttribute(43, "IconCss", "e-de-ctn-title-download");
            __builder.AddAttribute(44, "CssClass", "title-bar-btn");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
                                                                                               OnExport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(47, "Download");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "id", "control-container");
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.DocumentEditor.SfDocumentEditorContainer>(54);
            __builder.AddAttribute(55, "Height", "550px");
            __builder.AddAttribute(56, "Width", "1000px");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.DocumentEditor.DocumentEditorContainerEvents>(59);
                __builder2.AddAttribute(60, "Created", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 23 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
                                                        OnCreated

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(61, "DocumentChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DocumentEditor.ContainerDocumentChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DocumentEditor.ContainerDocumentChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
                                                                                    OnDocumentChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n            ");
            }
            ));
            __builder.AddComponentReferenceCapture(63, (__value) => {
#nullable restore
#line 22 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
                                             container = (Syncfusion.Blazor.DocumentEditor.SfDocumentEditorContainer)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n<br>\r\n");
            __builder.AddMarkupContent(69, "<div>\r\n  <h3>Selected Features:</h3>\r\n    <ul class=\"ulstyle\">\r\n      <li class=\"list\"> Default</li>\r\n      <li class=\"list\"> Theme - Bootstrap v4</li>\r\n    </ul>\r\n</div>\r\n<br>\r\n");
            __builder.AddMarkupContent(70, "<style>\r\n    .ulstyle {\r\n        margin: 0px;\r\n        padding-left: 20px;\r\n        display: inline-block;\r\n    }\r\n    .list {\r\n    float: left;\r\n    line-height: 20px;\r\n    margin: 10px;\r\n    min-width: 200px;\r\n    }\r\n    #control-container {\r\n        width: 1000px;\r\n        margin: 0 auto;\r\n    }\r\n    #edit_container {\r\n        width: 950px;\r\n    }\r\n    .title-bar-btn, .title-bar-btn:hover, .title-bar-btn:focus {\r\n        background: transparent;\r\n        box-shadow: none;\r\n        font-family: inherit;\r\n        border-color: transparent;\r\n        border-radius: 2px;\r\n        color: inherit;\r\n        font-size: 12px;\r\n        text-transform: capitalize;\r\n        height: 28px;\r\n        font-weight: 400;\r\n        margin-top: 2px;\r\n    }\r\n    #documenteditor_titlebar {       \r\n        height: 36px;\r\n        line-height: 26px;\r\n        width: 1000px;\r\n        font-size: 12px;\r\n        padding-left: 15px;\r\n        padding-right: 10px;\r\n        font-family: inherit;\r\n        margin: 0 auto;\r\n    }\r\n    #documenteditor_title_contentEditor {\r\n        height: 26px;\r\n        max-width: 85%;\r\n        width: auto;\r\n        overflow: hidden;\r\n        display: inline-block;\r\n        padding-left: 4px;\r\n        padding-right: 4px;\r\n        margin: 5px;\r\n    }\r\n    .doc-edit-title {\r\n        text-transform: capitalize;\r\n        font-weight: 400;\r\n        font-family: inherit;\r\n        text-overflow: ellipsis;\r\n        outline: none;\r\n        white-space: pre;\r\n        overflow: hidden;\r\n        user-select: none;\r\n        cursor: text\r\n    }\r\n    .print-ctnr {\r\n        cursor: pointer;\r\n        margin-top: 6px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\WordProcessorFeatures.razor"
       
    internal string DocumentName { get; set; }
    SfDocumentEditorContainer container;
    public void OnExport(object args)
    {
        DocumentEditorModule documentEditor = container.GetDocumentEditor();
        documentEditor.Save(DocumentName, FormatType.Docx);
    }
    public void Print(object args)
    {
        DocumentEditorModule documentEditor = container.GetDocumentEditor();
        documentEditor.Print();
    }
    public void OnCreated(object args)
    {
        DocumentEditorModule documentEditor = container.GetDocumentEditor();
        documentEditor.Open(Data.DefaultDocument);
        DocumentName = "Getting Started";
    }
    public void OnDocumentChange()
    {
        string name = container.GetDocumentEditor().DocumentName;
        if (name != "")
        {
            DocumentName = name;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
