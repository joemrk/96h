#pragma checksum "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd1182c2ed05b3c9ea900ec6a28cdb8f60cf836f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Communications), @"mvc.1.0.view", @"/Views/Home/Communications.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Communications.cshtml", typeof(AspNetCore.Views_Home_Communications))]
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
#line 1 "C:\Users\joe\Desktop\96h\96h\96h\Views\_ViewImports.cshtml"
using _96h;

#line default
#line hidden
#line 2 "C:\Users\joe\Desktop\96h\96h\96h\Views\_ViewImports.cshtml"
using _96h.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1182c2ed05b3c9ea900ec6a28cdb8f60cf836f", @"/Views/Home/Communications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79df0209e696e1ec06f883aa2642d8ce3477a862", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Communications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_96h.Models.Communication>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
  
    ViewData["Title"] = "Communications";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 312, true);
            WriteLiteral(@"
<br />
<br />
<div class=""search-wrap col-12"">
    <input type=""text"" id=""search_text"" maxlength=""8"" placeholder=""ЄДРПОУ"" />
    <input type=""button"" id=""communications_search_btn"" value=""Пошук"" />
</div>
<br />
<br />
<br />

<div class=""communications-wrap col-12"">
    <div class=""col"">
        ");
            EndContext();
            BeginContext(446, 20, false);
#line 20 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
   Write(TempData["homeMess"]);

#line default
#line hidden
            EndContext();
            BeginContext(466, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 22 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
     if (Model != null)
    {
        {
            ViewData["Title"] = @Model.COMPANY.name;
        }

#line default
#line hidden
            BeginContext(588, 12, true);
            WriteLiteral("        <h2>");
            EndContext();
            BeginContext(601, 18, false);
#line 27 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
       Write(Model.COMPANY.name);

#line default
#line hidden
            EndContext();
            BeginContext(619, 208, true);
            WriteLiteral("</h2>\r\n        <hr />\r\n        <div class=\"communications row\">\r\n            <div class=\"director col\">\r\n                <h4>Директор:</h4>\r\n                <div class=\"child el-shadow\">\r\n                    ");
            EndContext();
            BeginContext(828, 19, false);
#line 33 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
               Write(Model.DIRECTOR.name);

#line default
#line hidden
            EndContext();
            BeginContext(847, 30, true);
            WriteLiteral("\r\n                    <hr />\r\n");
            EndContext();
#line 35 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                     foreach (var child in Model.DIRECTOR.children)
                    {

#line default
#line hidden
            BeginContext(969, 61, true);
            WriteLiteral("                        <span class=\"child-linc\" data-edrpou=");
            EndContext();
            BeginContext(1031, 12, false);
#line 37 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                                                        Write(child.edrpou);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1045, 10, false);
#line 37 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                                                                      Write(child.name);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 17, true);
            WriteLiteral(" </span> <br />\r\n");
            EndContext();
#line 38 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                    }

#line default
#line hidden
            BeginContext(1095, 124, true);
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n            <div class=\"founders col\">\r\n                <h4>Засновники:</h4>\r\n");
            EndContext();
#line 44 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                 foreach (var founder in Model.FOUNDERS)
                {

#line default
#line hidden
            BeginContext(1296, 75, true);
            WriteLiteral("                    <div class=\"child el-shadow\">\r\n                        ");
            EndContext();
            BeginContext(1372, 12, false);
#line 47 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                   Write(founder.name);

#line default
#line hidden
            EndContext();
            BeginContext(1384, 34, true);
            WriteLiteral("\r\n                        <hr />\r\n");
            EndContext();
#line 49 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                         foreach (var child in founder.children)
                        {

#line default
#line hidden
            BeginContext(1511, 65, true);
            WriteLiteral("                            <span class=\"child-linc\" data-edrpou=");
            EndContext();
            BeginContext(1577, 12, false);
#line 51 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                                                            Write(child.edrpou);

#line default
#line hidden
            EndContext();
            BeginContext(1589, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1591, 10, false);
#line 51 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                                                                          Write(child.name);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 16, true);
            WriteLiteral(" </span><br />\r\n");
            EndContext();
#line 52 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                        }

#line default
#line hidden
            BeginContext(1644, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 54 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
                }

#line default
#line hidden
            BeginContext(1691, 38, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 58 "C:\Users\joe\Desktop\96h\96h\96h\Views\Home\Communications.cshtml"
    }

#line default
#line hidden
            BeginContext(1736, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(1746, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd1182c2ed05b3c9ea900ec6a28cdb8f60cf836f10218", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1801, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1803, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd1182c2ed05b3c9ea900ec6a28cdb8f60cf836f11398", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1839, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_96h.Models.Communication> Html { get; private set; }
    }
}
#pragma warning restore 1591
