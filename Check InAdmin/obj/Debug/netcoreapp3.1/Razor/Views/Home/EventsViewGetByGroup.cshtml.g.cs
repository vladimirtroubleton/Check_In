#pragma checksum "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\EventsViewGetByGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91488b8e6accb1626c23d7882b8b541945e5bad2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EventsViewGetByGroup), @"mvc.1.0.view", @"/Views/Home/EventsViewGetByGroup.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91488b8e6accb1626c23d7882b8b541945e5bad2", @"/Views/Home/EventsViewGetByGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124cfc68647029aefcb47e199fa4e0f8ce1cc7a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EventsViewGetByGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventsDataLayer.Models.EventModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\EventsViewGetByGroup.cshtml"
  
    ViewData["Title"] = "EventsViewGetByGroup";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-6 mx-auto text-center\">\r\n       Группа : ");
#nullable restore
#line 8 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\EventsViewGetByGroup.cshtml"
           Write(ViewBag.GroupThis.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-12 mx-auto text-center\">\r\n");
#nullable restore
#line 14 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\EventsViewGetByGroup.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-text"">
                        Название события
                    </div>
                    <div class=""card-title"">
                        <h4> ");
#nullable restore
#line 22 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\EventsViewGetByGroup.cshtml"
                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                    <div class=\"card-text\">\r\n                        Подпись к событию\r\n                    </div>\r\n                    <div class=\"card-title\">\r\n                        <h4> ");
#nullable restore
#line 28 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\EventsViewGetByGroup.cshtml"
                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 934, "\"", 978, 2);
            WriteAttributeValue("", 941, "/Home/GetEventData?evId=", 941, 24, true);
#nullable restore
#line 30 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\EventsViewGetByGroup.cshtml"
WriteAttributeValue("", 965, item.EventId, 965, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Информация о событии</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "D:\Projects\OPROSNIK\Check_In\Check InAdmin\Views\Home\EventsViewGetByGroup.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventsDataLayer.Models.EventModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
