#pragma checksum "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a6396006d5ccfa451d2d7551f3d3f742f9a1eb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hall), @"mvc.1.0.view", @"/Views/Home/Hall.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6396006d5ccfa451d2d7551f3d3f742f9a1eb4", @"/Views/Home/Hall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ee50be7243d6c3536bb303f411ca3f7f50d5c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Hall : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<CinemaWork.ModelsDB.CinemaHall, List<CinemaWork.ModelsDB.CinemaSession>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml"
   
    var hall = Model.Item1;
    var sessions = Model.Item2;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container text-center m-3 h-75 h3\">\r\n    <div class=\"modal-title\">Sessions in <b>");
#nullable restore
#line 7 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml"
                                       Write(hall.HallName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </div>\r\n</div>\r\n<div class=\"container text-left\">\r\n");
#nullable restore
#line 10 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml"
     foreach (var session in sessions)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-white bg-dark d-block mt-1 mb-2 p-2 rounded\" style=\"border-width:2px; border-color:gainsboro\">\r\n            <div class=\"card-title d-inline p-1\">Session IN:</div>\r\n            <div class=\"text-left d-inline p-1\">DATE: ");
#nullable restore
#line 14 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml"
                                                 Write(session.Date.ToString("MM-dd-yytt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"text-left d-inline p-1\">TIME: ");
#nullable restore
#line 15 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml"
                                                  Write(session.Time.Hours.ToString() + ":" + @session.Time.Minutes.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a6396006d5ccfa451d2d7551f3d3f742f9a1eb45927", async() => {
                WriteLiteral("\r\n                <div class=\"form-group m-2 text-center d-inline\">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1009, "\"", 1028, 1);
#nullable restore
#line 18 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml"
WriteAttributeValue("", 1017, session.ID, 1017, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"sessionID\" />\r\n                    <button");
                BeginWriteAttribute("id", " id=\"", 1078, "\"", 1098, 2);
                WriteAttributeValue("", 1083, "btn_", 1083, 4, true);
#nullable restore
#line 19 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml"
WriteAttributeValue("", 1087, session.ID, 1087, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\" class=\"btn btn-primary\">Go To Session</button>\r\n                </div>\r\n            ");
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
#line 16 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml"
AddHtmlAttributeValue("", 835, Url.Action("OpenSession", "Home"), 835, 34, false);

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
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\FoxMelt\source\repos\CinemaWork\CinemaWork\Views\Home\Hall.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<CinemaWork.ModelsDB.CinemaHall, List<CinemaWork.ModelsDB.CinemaSession>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
