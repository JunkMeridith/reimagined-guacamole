#pragma checksum "/Users/meridith.a.junk/Desktop/sprints/sprintone/WebApplication1/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aad93c80f2d3447f911ca8aae5fa8adb36fc4b0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/meridith.a.junk/Desktop/sprints/sprintone/WebApplication1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/meridith.a.junk/Desktop/sprints/sprintone/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/meridith.a.junk/Desktop/sprints/sprintone/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/meridith.a.junk/Desktop/sprints/sprintone/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/Users/meridith.a.junk/Desktop/sprints/sprintone/WebApplication1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/meridith.a.junk/Desktop/sprints/sprintone/WebApplication1/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#line 7 "/Users/meridith.a.junk/Desktop/sprints/sprintone/WebApplication1/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 40 "/Users/meridith.a.junk/Desktop/sprints/sprintone/WebApplication1/Pages/FetchData.razor"
       

    randomGenerator randomFact;


    protected override async Task OnInitializedAsync()
    {
        randomFact = await Http.GetJsonAsync<randomGenerator>("https://uselessfacts.jsph.pl/random.json?language=en");  
        await JsRuntime.InvokeAsync<object>("GetMap", new object[0]);
    }

    public class randomGenerator
    {
        public string id { get; set; }

        public string text { get; set; }

        public string source { get; set; }

        public string source_url { get; set; }

        public string language { get; set; }

        public string permalink { get; set; }
        
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
