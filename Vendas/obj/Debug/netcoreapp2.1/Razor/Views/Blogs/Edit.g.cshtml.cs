#pragma checksum "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d843891e1122c2b5b3cd59a01e917634fcc57c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Edit), @"mvc.1.0.view", @"/Views/Blogs/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blogs/Edit.cshtml", typeof(AspNetCore.Views_Blogs_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d843891e1122c2b5b3cd59a01e917634fcc57c5", @"/Views/Blogs/Edit.cshtml")]
    public class Views_Blogs_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EFGetStarted.AspNetCore.NewDb.Models.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(92, 758, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Blog</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""BlogId"" />
            <div class=""form-group"">
                <label asp-for=""Url"" class=""control-label""></label>
                <input asp-for=""Url"" class=""form-control"" />
                <span asp-validation-for=""Url"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(868, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 33 "C:\Users\Kvothe\source\repos\Vendas\Vendas\Views\Blogs\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EFGetStarted.AspNetCore.NewDb.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
