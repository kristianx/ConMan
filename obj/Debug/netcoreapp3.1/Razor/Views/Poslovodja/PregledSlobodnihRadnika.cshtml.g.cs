#pragma checksum "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a07e380631a474fc992c7500b473f9fac65734d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Poslovodja_PregledSlobodnihRadnika), @"mvc.1.0.view", @"/Views/Poslovodja/PregledSlobodnihRadnika.cshtml")]
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
#line 1 "C:\Users\krist\Desktop\ConManApp\Views\_ViewImports.cshtml"
using ConManApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\_ViewImports.cshtml"
using ConManApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a07e380631a474fc992c7500b473f9fac65734d1", @"/Views/Poslovodja/PregledSlobodnihRadnika.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61a6947239c377993bfc1166ee1ff5a575f8c6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Poslovodja_PregledSlobodnihRadnika : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConManApp.Models.SlobodniRadniciVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Unesite ime radnika"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
  
    ViewData["Title"] = "PregledSlobodnihRadnika";

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"fa fa-arrow-left\" aria-hidden=\"true\"");
            BeginWriteAttribute("href", " href=\"", 144, "\"", 198, 2);
            WriteAttributeValue("", 151, "/Poslovodja/DetaljiProjekta?id=", 151, 31, true);
#nullable restore
#line 5 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
WriteAttributeValue("", 182, Model.ProjektID, 182, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ></a><br /><br />\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a07e380631a474fc992c7500b473f9fac65734d14818", async() => {
                WriteLiteral("\n    <label>Pretraga</label><br />\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a07e380631a474fc992c7500b473f9fac65734d15113", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 8 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjektID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a07e380631a474fc992c7500b473f9fac65734d16924", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 9 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Filter);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br />\n    <input class=\"btn btn-primary\" type=\"submit\" value=\"Filtriraj\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 232, "/Poslovodja/PregledSlobodnihRadnika?projektid=", 232, 46, true);
#nullable restore
#line 6 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
AddHtmlAttributeValue("", 278, Model.ProjektID, 278, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 294, "&Filter=", 294, 8, true);
#nullable restore
#line 6 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
AddHtmlAttributeValue("", 302, Model.Filter, 302, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<table class=\"table table-bordered\">\n    <tr>\n        <th>Ime</th>\n        <th>Prezime</th>\n        <th>Username</th>\n        <th>Kontakt broj</th>\n        <th>Akcija</th>\n\n    </tr>\n\n");
#nullable restore
#line 23 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
     foreach (var x in Model.rows)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 26 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
           Write(x.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 27 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
           Write(x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 28 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
           Write(x.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 29 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
           Write(x.KontaktBroj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 940, "\"", 1026, 4);
            WriteAttributeValue("", 947, "/Poslovodja/AddRadnikProjekt?projektid=", 947, 39, true);
#nullable restore
#line 30 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
WriteAttributeValue("", 986, Model.ProjektID, 986, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1002, "&radnikid=", 1002, 10, true);
#nullable restore
#line 30 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"
WriteAttributeValue("", 1012, x.UposlenikId, 1012, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Dodaj</a></td>\n        </tr>\n");
#nullable restore
#line 32 "C:\Users\krist\Desktop\ConManApp\Views\Poslovodja\PregledSlobodnihRadnika.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConManApp.Models.SlobodniRadniciVM> Html { get; private set; }
    }
}
#pragma warning restore 1591