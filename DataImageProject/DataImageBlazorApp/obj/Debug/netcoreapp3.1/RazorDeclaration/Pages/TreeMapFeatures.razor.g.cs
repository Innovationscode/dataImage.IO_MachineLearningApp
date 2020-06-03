#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\TreeMapFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f34d0690d6f38596dcb23959b4c02dcc33d32b9e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\TreeMapFeatures.razor"
using Syncfusion.Blazor.TreeMap;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/treemap-features")]
    public partial class TreeMapFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\TreeMapFeatures.razor"
       
    public class Data
    {
        public string State;
        public double Trump;
        public double Clinton;
        public double WinPercentage;
        public string Winner;
        public double Population;
    }
    public List<Data> dataSource = new List<Data> {
        new Data { State =  "Alabama", Trump = 62.9, Clinton = 34.6, WinPercentage = 62.9, Winner = "Trump", Population = 4780127 },
        new Data { State =  "Alaska", Trump = 52.9, Clinton = 37.7, WinPercentage = 52.9, Winner = "Trump", Population = 710249 },
        new Data { State =  "Arkansas", Trump = 60.6, Clinton = 33.7, WinPercentage = 60.6, Winner = "Trump", Population = 2915958 },
        new Data { State =  "Arizona", Trump = 49.5, Clinton = 45.4, WinPercentage = 49.5, Winner = "Trump", Population = 6392307 },
        new Data { State =  "California", Trump = 32.8, Clinton = 61.6, WinPercentage = 61.6, Winner = "Clinton", Population = 37252895 },
        new Data { State =  "Colorado", Trump = 47.3, Clinton = 44.4, WinPercentage = 47.3, Winner = "Trump", Population = 5029324 },
        new Data { State =  "Connecticut", Trump = 41.2, Clinton = 54.5, WinPercentage = 54.5, Winner = "Clinton", Population = 3574118 },
        new Data { State =  "Delaware", Trump = 53.4, Clinton = 41.9, WinPercentage = 53.4, Winner = "Trump", Population = 897936 },
        new Data { State =  "District of Columbia", Trump = 4.1, Clinton = 92.8, WinPercentage = 92.8, Winner = "Clinton", Population = 693972 },
        new Data { State =  "Florida", Trump = 49.1, Clinton = 47.8, WinPercentage = 49.1, Winner = "Trump", Population = 18804623 },
        new Data { State =  "Georgia", Trump = 51.3, Clinton = 45.6, WinPercentage = 51.3, Winner = "Trump", Population = 9688681 },
        new Data { State =  "Hawaii", Trump = 62.2, Clinton = 30, WinPercentage = 62.2, Winner = "Trump", Population = 1360301 },
        new Data { State =  "Idaho", Trump = 59.2, Clinton = 27.6, WinPercentage = 59.2, Winner = "Trump", Population = 1567652 },
        new Data { State =  "Illinois", Trump = 55.4, Clinton = 39.4, WinPercentage = 55.4, Winner = "Trump", Population = 12831549 },
        new Data { State =  "Indiana", Trump = 57.2, Clinton = 37.9, WinPercentage = 57.2, Winner = "Trump", Population = 6484229 },
        new Data { State =  "Iowa", Trump = 51.8, Clinton = 42.2, WinPercentage = 51.8, Winner = "Trump", Population = 3046869 },
        new Data { State =  "Kansas", Trump = 57.2, Clinton = 36.2, WinPercentage = 57.2, Winner = "Trump", Population = 2853132, },
        new Data { State =  "Kentucky", Trump = 62.5, Clinton = 32.7, WinPercentage = 62.5, Winner = "Trump", Population = 4339349 },
        new Data { State =  "Louisiana", Trump = 58.1, Clinton = 38.4, WinPercentage = 58.1, Winner = "Trump", Population = 4533479 },
        new Data { State =  "Maine", Trump = 45.2, Clinton = 47.9, WinPercentage = 47.9, Winner = "Clinton", Population = 1328361 },
        new Data { State =  "Maryland", Trump = 35.3, Clinton = 60.5, WinPercentage = 60.5, Winner = "Clinton", Population = 5773785 },
        new Data { State =  "Massachusetts", Trump = 33.5, Clinton = 60.8, WinPercentage = 60.8, Winner = "Clinton", Population = 6547817 },
        new Data { State =  "Michigan", Trump = 47.6, Clinton = 47.3, WinPercentage = 47.6, Winner = "Trump", Population = 9884129 },
        new Data { State =  "Minnesota", Trump = 45.4, Clinton = 46.9, WinPercentage = 46.9, Winner = "Trump", Population = 5303925 },
        new Data { State =  "Mississippi", Trump = 58.3, Clinton = 39.7, WinPercentage = 58.3, Winner = "Trump", Population = 2968103 },
        new Data { State =  "Missouri", Trump = 57.1, Clinton = 38.0, WinPercentage = 57.1, Winner = "Trump", Population = 5988927 },
        new Data { State =  "Montana", Trump = 56.5, Clinton = 36.0, WinPercentage = 56.5, Winner = "Trump", Population = 989417 },
        new Data { State =  "Nebraska", Trump = 60.3, Clinton = 34.0, WinPercentage = 60.3, Winner = "Trump", Population = 1826341 },
        new Data { State =  "Nevada", Trump = 45.5, Clinton = 47.9, WinPercentage = 47.9, Winner = "Clinton", Population = 2700691 },
        new Data { State =  "New Hampshire", Trump = 47.2, Clinton = 47.6, WinPercentage = 47.6, Winner = "Clinton", Population = 1316466 },
        new Data { State =  "New Jersey", Trump = 41.8, Clinton = 55.0, WinPercentage = 55, Winner = "Clinton", Population = 8791936 },
        new Data { State =  "New Mexico", Trump = 40.0, Clinton = 48.3, WinPercentage = 48.3, Winner = "Clinton", Population = 2059192 },
        new Data { State =  "New York", Trump = 37.5, Clinton = 58.8, WinPercentage = 58.8, Winner = "Clinton", Population = 19378087 },
        new Data { State =  "North Carolina", Trump = 50.5, Clinton = 46.7, WinPercentage = 50.5, Winner = "Trump", Population = 9535692 },
        new Data { State =  "North Dakota", Trump = 64.1, Clinton = 27.8, WinPercentage = 64.1, Winner = "Trump", Population = 672591 },
        new Data { State =  "Ohio", Trump = 52.1, Clinton = 43.5, WinPercentage = 52.5, Winner = "Trump", Population = 11536725 },
        new Data { State =  "Oklahoma", Trump = 65.3, Clinton = 28.9, WinPercentage = 65.3, Winner = "Trump", Population = 3751616 },
        new Data { State =  "Oregon", Trump = 41.1, Clinton = 51.7, WinPercentage = 51.7, Winner = "Clinton", Population = 3831073 },
        new Data { State =  "Pennsylvania", Trump = 48.8, Clinton = 47.6, WinPercentage = 48.8, Winner = "Trump", Population = 12702887 },
        new Data { State =  "Rhode Island", Trump = 39.8, Clinton = 55.4, WinPercentage = 55.4, Winner = "Clinton", Population = 1052931 },
        new Data { State =  "South Carolina", Trump = 54.9, Clinton = 40.8, WinPercentage = 54.9, Winner = "Trump", Population = 4625401 },
        new Data { State =  "South Dakota", Trump = 61.5, Clinton = 31.7, WinPercentage = 61.5, Winner = "Trump", Population = 814191 },
        new Data { State =  "Tennessee", Trump = 61.1, Clinton = 34.9, WinPercentage = 61.1, Winner = "Trump", Population = 6346275 },
        new Data { State =  "Texas", Trump = 52.6, Clinton = 43.4, WinPercentage = 52.6, Winner = "Trump", Population = 25146105 },
        new Data { State =  "Utah", Trump = 45.9, Clinton = 27.8, WinPercentage = 45.9, Winner = "Trump", Population = 2763888, },
        new Data { State =  "Vermont", Trump = 39.7, Clinton = 61.1, WinPercentage = 61.1, Winner = "Clinton", Population = 625745 },
        new Data { State =  "Virginia", Trump = 45.0, Clinton = 49.9, WinPercentage = 49.9, Winner = "Clinton", Population = 8001045 },
        new Data { State =  "Washington", Trump = 4.1, Clinton = 92.8, WinPercentage = 92.8, Winner = "Clinton", Population = 6724543 },
        new Data { State =  "Wisconsin", Trump = 68.7, Clinton = 26.5, WinPercentage = 68.7, Winner = "Trump", Population = 5687289 },
        new Data { State =  "West Virginia", Trump = 47.9, Clinton = 46.9, WinPercentage = 47.9, Winner = "Clinton", Population = 1853011 },
        new Data { State =  "Wyoming", Trump = 70.1, Clinton = 22.5, WinPercentage = 70.1, Winner = "Trump", Population = 583767 }
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
