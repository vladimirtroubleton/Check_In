#pragma checksum "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c8b67d90557144f178fe62803e9675dbfceb0bd"
// <auto-generated/>
#pragma warning disable 1591
namespace Check_In.Pages.Account
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
#line 2 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
using AuthDataLayer.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 13 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
         if (currentUser == null || group == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(3, "            ");
                __builder2.AddMarkupContent(4, "<h4>Загружаю ...</h4>\r\n");
#nullable restore
#line 16 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(5, "            ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container");
                __builder2.AddMarkupContent(8, "\r\n                ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.AddMarkupContent(11, "\r\n                    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-sm-6 mx-auto ");
                __builder2.AddMarkupContent(14, "\r\n                        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "card  ");
                __builder2.AddMarkupContent(17, "\r\n\r\n\r\n                            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "card-body");
                __builder2.AddMarkupContent(20, "\r\n                                ");
                __builder2.AddMarkupContent(21, "<p class=\"card-title text-center\">\r\n                                    Профиль пользователя:\r\n                                </p>\r\n                                ");
                __builder2.OpenElement(22, "h4");
                __builder2.AddAttribute(23, "class", "card-title text-center");
                __builder2.AddMarkupContent(24, "\r\n                                    ");
                __builder2.AddContent(25, 
#nullable restore
#line 30 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
                                     currentUser.Login

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n                                ");
                __builder2.AddMarkupContent(28, "<p class=\"card-title text-center\">\r\n                                    Имя и фамилия:\r\n                                </p>\r\n                                ");
                __builder2.OpenElement(29, "h4");
                __builder2.AddAttribute(30, "class", "card-title text-center");
                __builder2.AddMarkupContent(31, "\r\n                                    ");
                __builder2.AddContent(32, 
#nullable restore
#line 37 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
                                     currentUser.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(33, " ");
                __builder2.AddContent(34, 
#nullable restore
#line 37 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
                                                       currentUser.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n                                ");
                __builder2.AddMarkupContent(37, "<p class=\"card-title text-center\">\r\n                                    Возраст:\r\n                                </p>\r\n                                ");
                __builder2.OpenElement(38, "h4");
                __builder2.AddAttribute(39, "class", "card-title text-center");
                __builder2.AddMarkupContent(40, "\r\n                                    ");
                __builder2.AddContent(41, 
#nullable restore
#line 44 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
                                     currentUser.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n                                ");
                __builder2.AddMarkupContent(44, "<p class=\"card-title text-center\">\r\n                                    Почта пользователя:\r\n                                </p>\r\n                                ");
                __builder2.OpenElement(45, "h4");
                __builder2.AddAttribute(46, "class", "card-title text-center");
                __builder2.AddMarkupContent(47, "\r\n                                    ");
                __builder2.AddContent(48, 
#nullable restore
#line 51 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
                                     currentUser.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(49, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                                ");
                __builder2.AddMarkupContent(51, "<p class=\"card-title text-center\">\r\n                                    Название группы:\r\n                                </p>\r\n                                ");
                __builder2.OpenElement(52, "h4");
                __builder2.AddAttribute(53, "class", "card-title text-center");
                __builder2.AddMarkupContent(54, "\r\n                                    ");
                __builder2.AddContent(55, 
#nullable restore
#line 57 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
                                     group.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                                ");
                __builder2.OpenElement(58, "button");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
                                                  LogOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "class", "mx-auto btn btn-outline-danger");
                __builder2.AddMarkupContent(61, "Выйти");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n");
#nullable restore
#line 66 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(68, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Profile.razor"
       
    private UserModel currentUser;

    private GroupModel group;

    private async Task LogOut()
    {
        await authServ.Logout();
        uriHelper.NavigateTo("/");
    }

    protected override async Task OnInitializedAsync()
    {
        var authState = await authProvider.GetAuthenticationStateAsync();
        currentUser = await userServ.GetCurrentUser(authState.User.Identity.Name);
        if(currentUser == null)
        {
            await   authServ.Logout();
            uriHelper.NavigateTo("/loginControl");
            return;
        }
            group = await groupServ.GetGroup(currentUser.GroupId);
        
     


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.Groups.GroupService groupServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.users.UserService userServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.IAuthService authServ { get; set; }
    }
}
#pragma warning restore 1591
