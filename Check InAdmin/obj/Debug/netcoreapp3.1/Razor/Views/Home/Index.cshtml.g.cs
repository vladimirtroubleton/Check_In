#pragma checksum "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fce6851c8a9e677b6e95f58ec39394714fa9b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fce6851c8a9e677b6e95f58ec39394714fa9b00", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124cfc68647029aefcb47e199fa4e0f8ce1cc7a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Check_InAdmin.Models.AllDataInViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""row"">
           
            <div class=""col-6 text-center"">
                <h4>Пользователи</h4>
            </div>
            
            <div class=""col-6 text-center"">
                <h4>Группы</h4>
            </div>
        </div>
        <div class=""row"">
          
            <div class=""col-6 mx-auto text-center"">


");
#nullable restore
#line 22 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
                 foreach (var item in Model.Users)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"card-title\">\r\n                                ");
#nullable restore
#line 27 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
                                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <a href=\"#\" class=\"btn btn-outline-info\">Перейти</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 32 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-6 mx-auto text-center\">\r\n");
#nullable restore
#line 35 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
                 foreach (var item in Model.Groups)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"card-title\">\r\n                                ");
#nullable restore
#line 40 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            \r\n                               <a");
            BeginWriteAttribute("href", " href=\"", 1361, "\"", 1397, 2);
            WriteAttributeValue("", 1368, "/Home/DeleteGroup?id=", 1368, 21, true);
#nullable restore
#line 43 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1389, item.Id, 1389, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Удалить</a> \r\n                               <a");
            BeginWriteAttribute("href", " href=\"", 1477, "\"", 1522, 2);
            WriteAttributeValue("", 1484, "/Home/EventsViewGetByGroup?id=", 1484, 30, true);
#nullable restore
#line 44 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1514, item.Id, 1514, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">События</a>\r\n                               <a");
            BeginWriteAttribute("href", " href=\"", 1601, "\"", 1648, 2);
            WriteAttributeValue("", 1608, "/Home/QuestionViewGetByGroup?id=", 1608, 32, true);
#nullable restore
#line 45 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1640, item.Id, 1640, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Опросы</a>\r\n                               \r\n                                \r\n                                \r\n                            \r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 52 "D:\Release\OPROSNIK\Check_In\Check InAdmin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Check_InAdmin.Models.AllDataInViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
