#pragma checksum "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70e2e5e0cf4d1cef242fd5f740ca26d4374eb156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Index), @"mvc.1.0.view", @"/Views/Blogs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blogs/Index.cshtml", typeof(AspNetCore.Views_Blogs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e2e5e0cf4d1cef242fd5f740ca26d4374eb156", @"/Views/Blogs/Index.cshtml")]
    public class Views_Blogs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EFGetStarted.AspNetCore.NewDb.Models.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(106, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(265, 39, false);
#line 16 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
            EndContext();
            BeginContext(304, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(422, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(471, 38, false);
#line 25 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
            EndContext();
            BeginContext(509, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 584, "\"", 611, 1);
#line 28 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 599, item.BlogId, 599, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(612, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 664, "\"", 691, 1);
#line 29 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 679, item.BlogId, 679, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(692, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 746, "\"", 773, 1);
#line 30 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 761, item.BlogId, 761, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(774, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Index.cshtml"
}

#line default
#line hidden
            BeginContext(824, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EFGetStarted.AspNetCore.NewDb.Models.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
