#pragma checksum "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbaaf618dab3bef5962b4de87e3841baa0224c09"
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
#line 1 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\_ViewImports.cshtml"
using CinemaWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\_ViewImports.cshtml"
using CinemaWork.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\_ViewImports.cshtml"
using CinemaWork.Configurations;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbaaf618dab3bef5962b4de87e3841baa0224c09", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ee50be7243d6c3536bb303f411ca3f7f50d5c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container w-100\">\r\n    <div class=\"container\">\r\n        <div class=\"h3 d-block text-center mt-2 text-info\">Select Hall</div>\r\n    </div>\r\n    <div class=\"container-fluid text-center p-1\">\r\n");
#nullable restore
#line 10 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Index.cshtml"
         foreach (var item in CinemaWork.DBWoker.DBWoker.GetHallsByCinemaID(Globals.SelectedCinema.ID))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card bg-dark d-inline-block m-1 mt-2 p-1\" style=\"width: 19rem\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"card-title text-center h5 bg-primary rounded p-2 text-white w-100\">");
#nullable restore
#line 14 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Index.cshtml"
                                                                                              Write(item.HallName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"card-subtitle text-center text-white p-1 m-1\">Hall Number: ");
#nullable restore
#line 15 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Index.cshtml"
                                                                                      Write(item.HallNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbaaf618dab3bef5962b4de87e3841baa0224c095742", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group m-2 text-center\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 947, "\"", 963, 1);
#nullable restore
#line 18 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Index.cshtml"
WriteAttributeValue("", 955, item.ID, 955, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"hallId\" />\r\n                            <button");
                BeginWriteAttribute("id", " id=\"", 1018, "\"", 1035, 2);
                WriteAttributeValue("", 1023, "btn_", 1023, 4, true);
#nullable restore
#line 19 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Index.cshtml"
WriteAttributeValue("", 1027, item.ID, 1027, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\" class=\"btn btn-primary w-100\">Go To Hall</button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 778, Url.Action("OpenHall", "Home"), 778, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
