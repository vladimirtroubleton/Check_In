#pragma checksum "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0026b963acd650c8106a92c12567d13196bb5094"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                              userModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                                        Registering

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(16);
                __builder2.AddAttribute(17, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                           userModel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\r\n\r\n\r\n                ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __builder2.AddMarkupContent(22, "<label class=\"control-label\">Введите логин</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 23 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                            checkLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                                                     userModel.Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Login = __value, userModel.Login))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Login));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __Blazor.Check_In.Pages.Account.Register.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 24 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                              () => userModel.Login

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenElement(33, "p");
                __builder2.AddAttribute(34, "style", 
#nullable restore
#line 25 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                               styleData

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(35, 
#nullable restore
#line 25 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                           loginStatus

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.AddMarkupContent(41, "<label class=\"control-label\">Введите имя</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                            userModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Name = __value, userModel.Name))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __Blazor.Check_In.Pages.Account.Register.TypeInference.CreateValidationMessage_1(__builder2, 48, 49, 
#nullable restore
#line 30 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                              () => userModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.AddMarkupContent(55, "<label class=\"control-label\">Введите фамилию</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "class", "form-control");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                            userModel.Surname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Surname = __value, userModel.Surname))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Surname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __Blazor.Check_In.Pages.Account.Register.TypeInference.CreateValidationMessage_2(__builder2, 62, 63, 
#nullable restore
#line 35 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                              () => userModel.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.AddMarkupContent(69, "<label class=\"control-label\">Введите возраст</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "class", "form-control");
                __builder2.AddAttribute(72, "type", "number");
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                            userModel.Age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Age = __value, userModel.Age))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Age));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __Blazor.Check_In.Pages.Account.Register.TypeInference.CreateValidationMessage_3(__builder2, 77, 78, 
#nullable restore
#line 40 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                              () => userModel.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "\r\n                    ");
                __builder2.AddMarkupContent(84, "<label class=\"control-label\">Введите почту</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(85);
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                            userModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Email = __value, userModel.Email))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __Blazor.Check_In.Pages.Account.Register.TypeInference.CreateValidationMessage_4(__builder2, 91, 92, 
#nullable restore
#line 45 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                              () => userModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(93, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group");
                __builder2.AddMarkupContent(97, "\r\n                    ");
                __builder2.AddMarkupContent(98, "<label class=\"control-label\">Введите пароль</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(99);
                __builder2.AddAttribute(100, "class", "form-control");
                __builder2.AddAttribute(101, "type", "password");
                __builder2.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                            userModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Password = __value, userModel.Password))));
                __builder2.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n                    ");
                __Blazor.Check_In.Pages.Account.Register.TypeInference.CreateValidationMessage_5(__builder2, 106, 107, 
#nullable restore
#line 50 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                              () => userModel.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(108, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "form-group");
                __builder2.AddMarkupContent(112, "\r\n");
#nullable restore
#line 53 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                     if (groupView != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(113, "                        ");
                __Blazor.Check_In.Pages.Account.Register.TypeInference.CreateInputSelect_6(__builder2, 114, 115, "form-control", 116, 
#nullable restore
#line 55 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                                  userModel.GroupId

#line default
#line hidden
#nullable disable
                , 117, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.GroupId = __value, userModel.GroupId)), 118, () => userModel.GroupId, 119, (__builder3) => {
                    __builder3.AddMarkupContent(120, "\r\n");
#nullable restore
#line 56 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                             foreach (var item in groupView)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(121, "                                ");
                    __builder3.OpenElement(122, "option");
                    __builder3.AddAttribute(123, "value", 
#nullable restore
#line 58 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                                item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(124, 
#nullable restore
#line 58 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                                          item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\r\n");
#nullable restore
#line 59 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(126, "                            /**/\r\n                        ");
                }
                );
                __builder2.AddMarkupContent(127, "\r\n");
#nullable restore
#line 62 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(128, "                    ");
                __Blazor.Check_In.Pages.Account.Register.TypeInference.CreateValidationMessage_7(__builder2, 129, 130, 
#nullable restore
#line 63 "D:\Projects\OPROSNIK\Check_In\Check In\Pages\Account\Register.razor"
                                              () => userModel.GroupId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(131, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                ");
                __builder2.AddMarkupContent(133, "<button class=\"ml-md-auto btn btn-outline-warning\" type=\"submit\">Зарегестрироваться</button>\r\n\r\n\r\n\r\n\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n       \r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n");
            __builder.CloseElement();
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
namespace __Blazor.Check_In.Pages.Account.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
