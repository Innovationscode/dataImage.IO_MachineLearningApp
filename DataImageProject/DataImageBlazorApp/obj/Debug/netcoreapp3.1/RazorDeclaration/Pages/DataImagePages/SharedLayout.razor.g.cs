#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DataImagePages\SharedLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9b992f876a8de27c7b6543efb204a2b7730331b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DataImageBlazorApp.Pages.DataImagePages
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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DataImagePages\SharedLayout.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    public partial class SharedLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DataImagePages\SharedLayout.razor"
       

    SfButton ResourcesBtn;
    SfButton ClusterBtn;
    SfButton ConsoleBtn;
    SfButton SignUpBtn;
    SfButton LogInBtn;

    public string contentSignUp = "SignUp";
    public string contentLogIn = "Log In";

    private void onClickSignUp(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
    {
        if (ResourcesBtn.Content == "SignUp")
        {
            this.contentSignUp = "";
        }
        else
        {
            this.contentSignUp = "Play";
        }
    }
    private void onClickLogIn(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
    {
        if (ResourcesBtn.Content == "SignUp")
        {
            this.contentSignUp = "";
        }
        else
        {
            this.contentSignUp = "Play";
        }
    }
    private void onClickResources(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
    {
        if (ResourcesBtn.Content == "SignUp")
        {
            this.contentSignUp = "";
        }
        else
        {
            this.contentSignUp = "Play";
        }
    }

    private void onClickCluster(Microsoft.AspNetCore.Components.Web.MouseEventArgs args)
    {
        if (ResourcesBtn.Content == "SignUp")
        {
            this.contentSignUp = "";
        }
        else
        {
            this.contentSignUp = "Play";
        }
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
