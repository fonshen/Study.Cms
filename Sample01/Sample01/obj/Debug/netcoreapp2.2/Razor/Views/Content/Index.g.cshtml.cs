#pragma checksum "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240a21b636110a32ce6e45f4be832c949b5dba1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Content/Index.cshtml", typeof(AspNetCore.Views_Content_Index))]
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
#line 1 "D:\Fonshen.Study\Sample01\Sample01\Views\_ViewImports.cshtml"
using Sample01;

#line default
#line hidden
#line 2 "D:\Fonshen.Study\Sample01\Sample01\Views\_ViewImports.cshtml"
using Sample01.Models;

#line default
#line hidden
#line 2 "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240a21b636110a32ce6e45f4be832c949b5dba1b", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ae4c732be53154422bdd74665f5c4478a5c6fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml"
  
    ViewData["Title"] = "内容列表";

#line default
#line hidden
            BeginContext(84, 77, true);
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(162, 17, false);
#line 7 "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(179, 310, true);
            WriteLiteral(@"</div>
    <table class=""table table-hover"">
        <thead>
            <tr>
                <td> <input type=""checkbox"" class=""done-checkbox""></td>
                <td>序号</td>
                <td>标题</td>
                <td>内容</td>
                <td>添加时间</td>
            </tr>
        </thead>
");
            EndContext();
#line 18 "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml"
         foreach (var item in Model.Contents)
        {

#line default
#line hidden
            BeginContext(547, 150, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <input type=\"checkbox\" class=\"done-checkbox\">\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(698, 7, false);
#line 24 "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(705, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(733, 10, false);
#line 25 "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(743, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(771, 9, false);
#line 26 "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml"
               Write(item.Body);

#line default
#line hidden
            EndContext();
            BeginContext(780, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(808, 24, false);
#line 27 "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml"
               Write(item.Add_time.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(832, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 30 "D:\Fonshen.Study\Sample01\Sample01\Views\Content\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(871, 20, true);
            WriteLiteral("    </table>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
