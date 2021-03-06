#pragma checksum "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d972ce992d8209e0859e14d7d9cf79cc2f56d1ba"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 150 "C:\Users\JVBPo\Desktop\CST_term_4\_DEV\comp4976\docker_assignment\medhApp2\Assignment2BlzrAPI\BlazorClient\Pages\Students.razor"
       
  Student[] students;
  string baseUrl = "https://localhost:6001/";
  private enum MODE { None, Add, Edit, Delete };
  MODE mode = MODE.None;
  Student s;


  protected override async Task OnInitializedAsync() {
	await load();
  }

  protected async Task load() {
	students = await httpClient.GetFromJsonAsync<Student[]>($"{baseUrl}api/students");
  }

  protected void Add() {
    mode = MODE.Add;
        NavigationManager.NavigateTo(uri:"/add/");

  }

  protected async Task ShowEdit(string id) {
    NavigationManager.NavigateTo(uri:"/edit/"+ id);

    mode = MODE.Edit;
}

protected async Task ShowDelete(string id) {
    NavigationManager.NavigateTo(uri:"/delete/"+ id);
    mode = MODE.Delete;
}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
