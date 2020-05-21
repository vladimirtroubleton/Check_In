#pragma checksum "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0026b963acd650c8106a92c12567d13196bb5094"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Check_In.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 2 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
using AuthDataLayer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
using AuthDataLayer.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
       
    UserViewModel userModel = new UserViewModel();

    GroupModel[] groupView;

    string loginStatus;

    string styleData;

    bool resultCheckLogin;

    private async Task Registering()
    {

        if (!resultCheckLogin)
        {
            var result = await authServ.Register(userModel);

            if (result.Successful)
            {
                UriHelper.NavigateTo("/loginControl");
            }
        }
    }

    private Task checkLogin()
    {
        resultCheckLogin = userServ.CheckLogin(userModel.Login);
        if (!resultCheckLogin)
        {
            styleData = "color:green";
            loginStatus = "Логин свободен";
        }
        else
        {
            styleData = "color:red";
            loginStatus = "Логин занят";
        }
        return Task.CompletedTask;
    }

    protected override async Task OnInitializedAsync()
    {
        groupView = await groupServ.GetGroups();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.IAuthService authServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.Groups.GroupService groupServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.users.UserService userServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
