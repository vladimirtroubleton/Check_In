#pragma checksum "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a41c7fb027474da423337536adec756d52d162"
// <auto-generated/>
#pragma warning disable 1591
namespace Check_In.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using Check_In;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using Check_In.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\OPROSNIK\Check_In\Check In\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Index.razor"
using AuthDataLayer.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container\">\r\n    <div class=\"row\">\r\n        \r\n            <h4 style=\"color:coral\" class=\"display-4\"> Привет выбери интересующий пункт в меню </h4>\r\n        \r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Index.razor"
      
    UserModel currentUser;
    protected override async Task OnInitializedAsync()
    {

        var authState = await authProvider.GetAuthenticationStateAsync();
        currentUser = await userServ.GetCurrentUser(authState.User.Identity.Name);
        if (currentUser == null && authState.User.Identity.Name != null) { await authServ.Logout(); uriHelper.NavigateTo("/loginControl"); return; }
        if (currentUser == null) {uriHelper.NavigateTo("/loginControl"); }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.users.UserService userServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.IAuthService authServ { get; set; }
    }
}
#pragma warning restore 1591
