#pragma checksum "D:\ASPNET core\3120217097_levanlinh\Views\Book\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b3cc35cb3d88a40635f97ddfd2b625b9b794bd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Edit), @"mvc.1.0.view", @"/Views/Book/Edit.cshtml")]
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
#line 1 "D:\ASPNET core\3120217097_levanlinh\Views\_ViewImports.cshtml"
using ManagementBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASPNET core\3120217097_levanlinh\Views\_ViewImports.cshtml"
using ManagementBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b3cc35cb3d88a40635f97ddfd2b625b9b794bd1", @"/Views/Book/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01775fa447cc7b941b1eb79391c944b0ac13a08", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/book/SaveBook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ASPNET core\3120217097_levanlinh\Views\Book\Edit.cshtml"
  
    ViewData["Title"] = "Edit Page";
    Book book = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Welcome to Edit Book Page</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3cc35cb3d88a40635f97ddfd2b625b9b794bd14046", async() => {
                WriteLiteral("\r\n<div class=\"form-group\">\r\n        <label for=\"Id\">Id</label>\r\n        <input type=\"number\" class=\"form-control\" id=\"Id\" aria-describedby=\"emailHelp\"\r\n            placeholder=\"Enter Name Book\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 366, "\"", 382, 1);
#nullable restore
#line 11 "D:\ASPNET core\3120217097_levanlinh\Views\Book\Edit.cshtml"
WriteAttributeValue("", 374, book.Id, 374, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Name\">Name</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"Name\" aria-describedby=\"emailHelp\"\r\n            placeholder=\"Enter Name Book\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 609, "\"", 627, 1);
#nullable restore
#line 16 "D:\ASPNET core\3120217097_levanlinh\Views\Book\Edit.cshtml"
WriteAttributeValue("", 617, book.Name, 617, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Description\">Description</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"Description\" placeholder=\"description\" name=\"Description\"");
                BeginWriteAttribute("value", " value=\"", 836, "\"", 861, 1);
#nullable restore
#line 20 "D:\ASPNET core\3120217097_levanlinh\Views\Book\Edit.cshtml"
WriteAttributeValue("", 844, book.Description, 844, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"TotalPage\">Total Page</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"TotalPage\" placeholder=\"total page\" name=\"TotalPage\"");
                BeginWriteAttribute("value", " value=\"", 1062, "\"", 1085, 1);
#nullable restore
#line 24 "D:\ASPNET core\3120217097_levanlinh\Views\Book\Edit.cshtml"
WriteAttributeValue("", 1070, book.TotalPage, 1070, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"ImagePath\">Total Page</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"ImagePath\" placeholder=\"image path\" name=\"ImagePath\"");
                BeginWriteAttribute("value", " value=\"", 1286, "\"", 1309, 1);
#nullable restore
#line 28 "D:\ASPNET core\3120217097_levanlinh\Views\Book\Edit.cshtml"
WriteAttributeValue("", 1294, book.ImagePath, 1294, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Price\">Total Page</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"Price\" placeholder=\"price\" name=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 1493, "\"", 1512, 1);
#nullable restore
#line 32 "D:\ASPNET core\3120217097_levanlinh\Views\Book\Edit.cshtml"
WriteAttributeValue("", 1501, book.Price, 1501, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    \r\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
