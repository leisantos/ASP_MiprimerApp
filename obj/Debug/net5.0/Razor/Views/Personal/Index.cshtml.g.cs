#pragma checksum "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9ef860a78964769f1188c762a7fa3b25f7c3c09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Index), @"mvc.1.0.view", @"/Views/Personal/Index.cshtml")]
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
#line 1 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\_ViewImports.cshtml"
using ASP_MiprimerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\_ViewImports.cshtml"
using ASP_MiprimerApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9ef860a78964769f1188c762a7fa3b25f7c3c09", @"/Views/Personal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a984560a0cbedacc92497f9949ae68c4ada1b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("margin", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("padding", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("350"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("350"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/enaleidy.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""section about-section gray-bg"" id=""about"">
            <div class=""container"">
                <div class=""row align-items-center flex-row-reverse"">
                    <div class=""col-lg-6"">
                        <div class=""about-text go-to"">
                            <h3 class=""dark-color"">");
#nullable restore
#line 6 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                              Write(Model.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <h6 class=\"theme-color lead\">");
#nullable restore
#line 7 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                                    Write(Model.info);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6><br>
                            <div class=""row about-list"">
                                <div class=""col-md-6"">
                                    <div class=""media"">
                                        <label>Nombre: </label>
                                        <p><br> ");
#nullable restore
#line 12 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                           Write(Model.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"media\">\r\n                                        <label>Sexo: </label>\r\n                                        <p><br> ");
#nullable restore
#line 16 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                           Write(Model.sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"media\">\r\n                                        <label>Direccion: </label>\r\n                                        <p><br> ");
#nullable restore
#line 20 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                           Write(Model.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"media\">\r\n                                        <label>Ciudad: </label>\r\n                                        <p><br> ");
#nullable restore
#line 24 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                           Write(Model.ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""media"">
                                        <label>E-mail:</label>
                                        <p><br> ");
#nullable restore
#line 30 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                           Write(Model.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"media\">\r\n                                        <label>Telefono: </label>\r\n                                        <p><br> ");
#nullable restore
#line 34 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                           Write(Model.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"media\">\r\n                                        <label>Edad: </label>\r\n                                        <p><br> ");
#nullable restore
#line 38 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                           Write(Model.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" a&ntilde;os</p>\r\n                                    </div>\r\n                                    <div class=\"media\">\r\n                                        <label>Carrera: </label>\r\n                                        <p><br> ");
#nullable restore
#line 42 "C:\Users\leidy\source\repos\ASP_MiprimerApp\Views\Personal\Index.cshtml"
                                           Write(Model.carrera);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""about-avatar"" >
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d9ef860a78964769f1188c762a7fa3b25f7c3c0910045", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
