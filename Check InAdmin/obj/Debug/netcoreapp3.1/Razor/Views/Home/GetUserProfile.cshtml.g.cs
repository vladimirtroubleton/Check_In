#pragma checksum "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetUserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75886018e09de92b98edd333f89d7f7926d5c5d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetUserProfile), @"mvc.1.0.view", @"/Views/Home/GetUserProfile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\_ViewImports.cshtml"
using Check_InAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\_ViewImports.cshtml"
using Check_InAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75886018e09de92b98edd333f89d7f7926d5c5d4", @"/Views/Home/GetUserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124cfc68647029aefcb47e199fa4e0f8ce1cc7a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetUserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthDataLayer.Models.UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetUserProfile.cshtml"
  
    ViewData["Title"] = "GetUserProfile";
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<hr />
    <div class=""row"">
        <div class=""col-12 mx-auto text-center"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-title"">Логин пользователя</div>
                    <div class=""card-title""><h4>");
#nullable restore
#line 13 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetUserProfile.cshtml"
                                           Write(Model.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                    <div class=\"card-title\">Группа пользователя</div>\r\n                    <div class=\"card-title\"><h4>");
#nullable restore
#line 15 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetUserProfile.cshtml"
                                           Write(ViewBag.Group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                    <div class=\"card-title\">Имя и фамилия</div>\r\n                    <div class=\"card-title\"><h4>");
#nullable restore
#line 17 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetUserProfile.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetUserProfile.cshtml"
                                                       Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                    <div class=\"card-title\">Почта</div>\r\n                    <div class=\"card-title\"><h4>");
#nullable restore
#line 19 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetUserProfile.cshtml"
                                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                    <div class=\"card-title\">Возраст</div>\r\n                    <div class=\"card-title\"><h4>");
#nullable restore
#line 21 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetUserProfile.cshtml"
                                           Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n                   \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthDataLayer.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591