#pragma checksum "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ba77b90c22de2f285a32ed6c557152415d6f9e"
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
#line 2 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
using AuthDataLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
using QuestionDataLayer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
using QuestionDataLayer.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/questionResponseAdd/{Id:int}")]
    public partial class QuestionResponseAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "container");
                __builder2.AddMarkupContent(5, "\r\n");
#nullable restore
#line 12 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
             if (question != null && questionForForm != null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
                __builder2.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                  questionForForm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                  RegisterResponse

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((addQ) => (__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                    __builder3.AddAttribute(15, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                               questionForForm

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n                    ");
                    __builder3.OpenElement(17, "div");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\r\n                        ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-12 mx-auto");
                    __builder3.AddMarkupContent(22, "\r\n                            ");
                    __builder3.OpenElement(23, "div");
                    __builder3.AddAttribute(24, "class", "card");
                    __builder3.AddMarkupContent(25, "\r\n                                ");
                    __builder3.OpenElement(26, "div");
                    __builder3.AddAttribute(27, "class", "card-body");
                    __builder3.AddMarkupContent(28, "\r\n                                    ");
                    __builder3.AddMarkupContent(29, "<div class=\"card-title\">Название опроса</div>\r\n                                    ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "card-title");
                    __builder3.OpenElement(32, "h4");
                    __builder3.AddContent(33, 
#nullable restore
#line 22 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                 questionForForm.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                                    ");
                    __builder3.AddMarkupContent(35, "<div class=\"card-title\">Группа</div>\r\n                                    ");
                    __builder3.OpenElement(36, "div");
                    __builder3.AddAttribute(37, "class", "card-title");
                    __builder3.AddContent(38, 
#nullable restore
#line 24 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                             questionForForm.GroupName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(39, "\r\n                                    ");
                    __builder3.AddMarkupContent(40, "<div class=\"card-title\">Вопросы:</div>\r\n                                    ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "class", "form-group");
                    __builder3.AddAttribute(43, "style", 
#nullable restore
#line 26 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                    questStyle

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(44, "\r\n                                        ");
                    __builder3.OpenElement(45, "p");
                    __builder3.AddAttribute(46, "class", "counter");
                    __builder3.AddMarkupContent(47, "Вопрос : ");
                    __builder3.AddContent(48, 
#nullable restore
#line 27 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                     questionForForm.Question

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                    __builder3.AddAttribute(51, "class", "form-control");
                    __builder3.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                questionForForm.QuestionResponse

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => questionForForm.QuestionResponse = __value, questionForForm.QuestionResponse))));
                    __builder3.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => questionForForm.QuestionResponse));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\r\n                                    ");
                    __builder3.OpenElement(57, "div");
                    __builder3.AddAttribute(58, "class", "form-group");
                    __builder3.AddAttribute(59, "style", 
#nullable restore
#line 30 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                    questStyle1

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(60, "\r\n                                        ");
                    __builder3.OpenElement(61, "p");
                    __builder3.AddAttribute(62, "class", "counter");
                    __builder3.AddMarkupContent(63, "Вопрос : ");
                    __builder3.AddContent(64, 
#nullable restore
#line 31 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                     questionForForm.Question1

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\r\n\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                    __builder3.AddAttribute(67, "class", "form-control");
                    __builder3.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                questionForForm.Question1Response

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => questionForForm.Question1Response = __value, questionForForm.Question1Response))));
                    __builder3.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => questionForForm.Question1Response));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n                                    ");
                    __builder3.OpenElement(73, "div");
                    __builder3.AddAttribute(74, "class", "form-group");
                    __builder3.AddAttribute(75, "style", 
#nullable restore
#line 35 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                    questStyle2

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(76, "\r\n                                        ");
                    __builder3.OpenElement(77, "p");
                    __builder3.AddAttribute(78, "class", "counter");
                    __builder3.AddMarkupContent(79, "Вопрос : ");
                    __builder3.AddContent(80, 
#nullable restore
#line 36 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                     questionForForm.Question2

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(82);
                    __builder3.AddAttribute(83, "class", "form-control");
                    __builder3.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                questionForForm.Question2Response

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => questionForForm.Question2Response = __value, questionForForm.Question2Response))));
                    __builder3.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => questionForForm.Question2Response));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\r\n                                    ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "form-group");
                    __builder3.AddAttribute(91, "style", 
#nullable restore
#line 39 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                    questStyle3

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(92, "\r\n                                        ");
                    __builder3.OpenElement(93, "p");
                    __builder3.AddAttribute(94, "class", "counter");
                    __builder3.AddMarkupContent(95, "Вопрос : ");
                    __builder3.AddContent(96, 
#nullable restore
#line 40 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                     questionForForm.Question3

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(98);
                    __builder3.AddAttribute(99, "class", "form-control");
                    __builder3.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                questionForForm.Question3Response

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => questionForForm.Question3Response = __value, questionForForm.Question3Response))));
                    __builder3.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => questionForForm.Question3Response));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\r\n                                    ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "form-group");
                    __builder3.AddAttribute(107, "style", 
#nullable restore
#line 43 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                    questStyle4

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(108, "\r\n                                        ");
                    __builder3.OpenElement(109, "p");
                    __builder3.AddAttribute(110, "class", "counter");
                    __builder3.AddMarkupContent(111, "Вопрос : ");
                    __builder3.AddContent(112, 
#nullable restore
#line 44 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                     questionForForm.Question4

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n                                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(114);
                    __builder3.AddAttribute(115, "class", "form-control");
                    __builder3.AddAttribute(116, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
                                                                questionForForm.Question4Response

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => questionForForm.Question4Response = __value, questionForForm.Question4Response))));
                    __builder3.AddAttribute(118, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => questionForForm.Question4Response));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\r\n                                ");
                    __builder3.AddMarkupContent(122, "<button class=\"btn btn-outline-success\" type=\"submit\"> Ответить! </button>\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(123, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(124, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\r\n");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(126, "\r\n");
#nullable restore
#line 53 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(127, "                ");
                __builder2.AddMarkupContent(128, "<h4>Загрузка.....</h4>\r\n");
#nullable restore
#line 57 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(129, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Questions\QuestionResponseAdd.razor"
       
    [Parameter]
    public int Id { get; set; }

    UserModel currentUser;

    QuestionViewModel question;

    QuestionResponseModel questionForForm;

    string questStyle = "display:none";
    string questStyle1= "display:none";
    string questStyle2= "display:none";
    string questStyle3= "display:none";
    string questStyle4= "display:none";

    int questCount;

    protected override async Task OnInitializedAsync()
    {
        var authState = await authProvider.GetAuthenticationStateAsync();
        currentUser = await userServ.GetCurrentUser(authState.User.Identity.Name);
        question = await questServ.GetQuestionsById(Id);
        questCount = question.Questions.Count();


        questionForForm =await questServ.GetResponseModel(question, questCount , currentUser.Login);

        await FormedForm();
    }

    private async Task RegisterResponse()
    {
        await questServ.CreateResponse(questionForForm);
        uriHelper.NavigateTo("/questionUser");
    }

    private Task FormedForm()
    {
        switch (questCount)
        {
            case 1:
                {
                    questStyle =  "display:block";
                    break;
                }
            case 2:
                {
                    questStyle = "";
                    questStyle1 = "";
                    break;
                }
            case 3:
                {
                    questStyle = "";
                    questStyle1 = "";
                    questStyle2 = "";
                    break;
                }
            case 4:
                {
                    questStyle = "";
                    questStyle1 = "";
                    questStyle2 = "";
                    questStyle3 = "";
                    break;
                }
            case 5:
                {
                    questStyle = "";
                    questStyle1 = "";
                    questStyle2 = "";
                    questStyle3 = "";
                    questStyle4 = "";
                    break;
                }
        }
        return Task.CompletedTask;
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
