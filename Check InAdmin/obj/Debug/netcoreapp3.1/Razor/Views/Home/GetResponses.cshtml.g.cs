#pragma checksum "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b700bf492bf5e4b6f89e76fc5286d349fe32544c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetResponses), @"mvc.1.0.view", @"/Views/Home/GetResponses.cshtml")]
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
#line 1 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\_ViewImports.cshtml"
using Check_InAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\_ViewImports.cshtml"
using Check_InAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b700bf492bf5e4b6f89e76fc5286d349fe32544c", @"/Views/Home/GetResponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124cfc68647029aefcb47e199fa4e0f8ce1cc7a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetResponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuestionDataLayer.Models.QuestionResponseModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
  
    ViewData["Title"] = "GetResponses";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 7 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
 if (Model.FirstOrDefault() != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-6 mx-auto\">\r\n\r\n        <h4>Название опроса</h4>\r\n        <p>");
#nullable restore
#line 13 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
      Write(Model.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h4>Название группы</h4>\r\n        <p>");
#nullable restore
#line 15 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
      Write(Model.FirstOrDefault().GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h4>Вопросы:</h4>\r\n        <p>");
#nullable restore
#line 17 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
      Write(Model.FirstOrDefault().Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 18 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
      Write(Model.FirstOrDefault().Question1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 19 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
      Write(Model.FirstOrDefault().Question2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 20 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
      Write(Model.FirstOrDefault().Question3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 21 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
      Write(Model.FirstOrDefault().Question4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-6 mx-auto text-center\">\r\n        <h4>Ответы</h4>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 31 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
     foreach (var response in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-6 mx-auto\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">Ответы пользователя: ");
#nullable restore
#line 36 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
                                                           Write(response.UserLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>");
#nullable restore
#line 37 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
                  Write(response.QuestionResponse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 38 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
                  Write(response.Question1Response);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 39 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
                  Write(response.Question2Response);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 40 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
                  Write(response.Question3Response);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 41 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
                  Write(response.Question4Response);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n           \r\n\r\n           \r\n        </div>\r\n");
#nullable restore
#line 48 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 50 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-6 mx-auto text-center\">\r\n            <p class=\"display-4\">Ответов нет</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 58 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\GetResponses.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuestionDataLayer.Models.QuestionResponseModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
