#pragma checksum "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5456520839664fbbeb726a4af0946602a9d68f5c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\_Imports.razor"
using SchoolLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
