#pragma checksum "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c633d0f7928ea35a782d78875b29b97c774707c5"
// <auto-generated/>
#pragma warning disable 1591
namespace Check_In.Pages.Questions
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
#line 2 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
using AuthDataLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
using QuestionDataLayer.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/questionUser")]
    public partial class QuestionsUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
 if (currentUser == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<div class=\"container\">\r\n        <div class=\"row\">\r\n            <h4>Загрузка</h4>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 16 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
     if (questions != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n\r\n            ");
            __builder.AddMarkupContent(6, "<div class=\"row text-center\">\r\n                <h4>Заполните опросы пожалуйста</h4>\r\n            </div>\r\n");
#nullable restore
#line 26 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
             foreach (var quest in questions)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-12 mx-auto");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card");
            __builder.AddMarkupContent(16, "\r\n                            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-body");
            __builder.AddMarkupContent(19, "\r\n                                ");
            __builder.AddMarkupContent(20, "<div class=\"card-title\">Название опроса</div>\r\n                                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-title");
            __builder.OpenElement(23, "h4");
            __builder.AddContent(24, 
#nullable restore
#line 33 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
                                                             quest.QuestionName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.AddMarkupContent(26, "<div class=\"card-title\">Группа</div>\r\n                                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card-title");
            __builder.AddContent(29, 
#nullable restore
#line 35 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
                                                         quest.GroupName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.AddMarkupContent(31, "<div class=\"card-title\">Вопросы:</div>\r\n");
#nullable restore
#line 37 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
                                 foreach (var miniQ in quest.Questions)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "                                    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "card-text");
            __builder.AddContent(35, 
#nullable restore
#line 39 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
                                                            miniQ

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 40 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "questionResponseAdd/" + (
#nullable restore
#line 42 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
                                                              quest.QuestionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-outline-success");
            __builder.AddMarkupContent(41, "Заполнить");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 47 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 49 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "        ");
            __builder.AddMarkupContent(50, "<div class=\"container\">\r\n            <div class=\"row\">\r\n                <h4>Ну опросов пока нет</h4>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 57 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionsUser.razor"
       

    UserModel currentUser;

    QuestionViewModel[] questions;

    protected override async Task OnInitializedAsync()
    {
        var authState = await authProvider.GetAuthenticationStateAsync();
        currentUser = await userServ.GetCurrentUser(authState.User.Identity.Name);

        questions =await questServ.GetQuestionsByGroupId(currentUser.GroupId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.Question.QuestionService questServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Check_In.Services.users.UserService userServ { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authProvider { get; set; }
    }
}
#pragma warning restore 1591
